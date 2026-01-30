using System;
using System.Data;
using System.IO; // Thư viện ghi file
using System.Text; // Thư viện mã hóa
using System.Windows.Forms;

namespace ADO_Example
{
    public partial class FrmContract : Form
    {
        public FrmContract()
        {
            InitializeComponent();
            LoadData();
            LoadComboboxes();
            GenerateContractCode(); // <--- MỚI: Tự sinh mã khi mở form
        }

        // --- HÀM MỚI: TỰ ĐỘNG SINH MÃ HỢP ĐỒNG ---
        private void GenerateContractCode()
        {
            try
            {
                // Lấy ID lớn nhất hiện tại trong bảng Contracts
                string query = "SELECT MAX(Id) FROM Contracts";
                DataTable dt = DatabaseHelper.GetData(query);

                int nextId = 1; // Mặc định là 1 nếu chưa có dữ liệu

                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    nextId = Convert.ToInt32(dt.Rows[0][0]) + 1;
                }

                // Tạo mã định dạng: HĐ-0001, HĐ-0002...
                txtCode.Text = "HĐ-" + nextId.ToString("0000");
                txtCode.Enabled = false; // Khóa không cho sửa để tránh trùng
            }
            catch
            {
                txtCode.Text = "HĐ-0001";
            }
        }

        private void LoadData()
        {
            try
            {
                string query = @"SELECT ct.Id, ct.ContractCode, c.Name AS CustomerName, 
                                        b.Name + ' - ' + r.Name AS RoomInfo, 
                                        ct.StartDate, ct.EndDate, ct.Price, ct.Deposit, ct.Status,
                                        ct.CustomerId, ct.RoomId
                                 FROM Contracts ct
                                 JOIN Customers c ON ct.CustomerId = c.Id
                                 JOIN Rooms r ON ct.RoomId = r.Id
                                 JOIN Buildings b ON r.BuildingId = b.Id";

                dgvContract.DataSource = DatabaseHelper.GetData(query);
                FormatGrid();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
        }

        private void FormatGrid()
        {
            if (dgvContract.Columns.Count > 0)
            {
                if (dgvContract.Columns.Contains("Id")) dgvContract.Columns["Id"].Visible = false;
                if (dgvContract.Columns.Contains("CustomerId")) dgvContract.Columns["CustomerId"].Visible = false;
                if (dgvContract.Columns.Contains("RoomId")) dgvContract.Columns["RoomId"].Visible = false;

                dgvContract.Columns["ContractCode"].HeaderText = "SỐ HĐ";
                dgvContract.Columns["ContractCode"].Width = 100;

                dgvContract.Columns["CustomerName"].HeaderText = "SINH VIÊN";
                dgvContract.Columns["CustomerName"].Width = 180;

                dgvContract.Columns["RoomInfo"].HeaderText = "PHÒNG";
                dgvContract.Columns["RoomInfo"].Width = 120;

                dgvContract.Columns["StartDate"].HeaderText = "BẮT ĐẦU";
                dgvContract.Columns["EndDate"].HeaderText = "KẾT THÚC";

                dgvContract.Columns["Price"].HeaderText = "GIÁ THUÊ";
                dgvContract.Columns["Price"].DefaultCellStyle.Format = "N0";

                dgvContract.Columns["Deposit"].HeaderText = "TIỀN CỌC";
                dgvContract.Columns["Deposit"].DefaultCellStyle.Format = "N0";

                dgvContract.Columns["Status"].HeaderText = "TRẠNG THÁI";
                dgvContract.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void LoadComboboxes()
        {
            try
            {
                // Chỉ load sinh viên chưa có hợp đồng hiệu lực
                string queryCustomer = @"SELECT Id, Name FROM Customers 
                                         WHERE Id NOT IN (SELECT CustomerId FROM Contracts WHERE Status = N'Hiệu lực')";

                cbbCustomer.DataSource = DatabaseHelper.GetData(queryCustomer);
                cbbCustomer.DisplayMember = "Name";
                cbbCustomer.ValueMember = "Id";
                cbbCustomer.SelectedIndex = -1;

                cbbFilterBuilding.DataSource = DatabaseHelper.GetData("SELECT Id, Name, TotalFloors FROM Buildings");
                cbbFilterBuilding.DisplayMember = "Name";
                cbbFilterBuilding.ValueMember = "Id";
                cbbFilterBuilding.SelectedIndex = -1;
            }
            catch { }
        }

        // --- XUẤT EXCEL (CSV) ---
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvContract.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.csv)|*.csv";
            sfd.FileName = "DanhSachHopDong_KTX.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        sw.Write('\uFEFF'); // BOM for UTF8

                        // Header
                        for (int i = 0; i < dgvContract.Columns.Count; i++)
                        {
                            if (dgvContract.Columns[i].Visible)
                            {
                                sw.Write(dgvContract.Columns[i].HeaderText);
                                if (i < dgvContract.Columns.Count - 1) sw.Write(",");
                            }
                        }
                        sw.WriteLine();

                        // Data
                        foreach (DataGridViewRow row in dgvContract.Rows)
                        {
                            for (int i = 0; i < dgvContract.Columns.Count; i++)
                            {
                                if (dgvContract.Columns[i].Visible)
                                {
                                    string val = row.Cells[i].Value?.ToString() ?? "";
                                    if (val.Contains(",")) val = "\"" + val + "\"";

                                    if (dgvContract.Columns[i].Name.Contains("Date") && DateTime.TryParse(val, out DateTime dt))
                                    {
                                        val = dt.ToString("dd/MM/yyyy");
                                    }

                                    sw.Write(val);
                                    if (i < dgvContract.Columns.Count - 1) sw.Write(",");
                                }
                            }
                            sw.WriteLine();
                        }
                    }
                    MessageBox.Show("Xuất file Excel thành công!\nĐường dẫn: " + sfd.FileName, "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi");
                }
            }
        }

        // --- FILTER LOGIC ---
        private void cbbFilterBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFilterBuilding.SelectedIndex == -1) return;
            try
            {
                int buildingId = (int)cbbFilterBuilding.SelectedValue;
                DataTable dt = DatabaseHelper.GetData($"SELECT TotalFloors FROM Buildings WHERE Id = {buildingId}");

                cbbFilterFloor.Items.Clear();
                if (dt.Rows.Count > 0)
                {
                    int floors = Convert.ToInt32(dt.Rows[0]["TotalFloors"]);
                    for (int i = 1; i <= floors; i++)
                    {
                        cbbFilterFloor.Items.Add(i.ToString());
                    }
                }
                cbbFilterFloor.SelectedIndex = -1;
                cbbRoom.DataSource = null;
            }
            catch { }
        }

        private void cbbFilterFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFilterBuilding.SelectedValue == null || cbbFilterFloor.SelectedIndex == -1) return;
            try
            {
                int buildingId = (int)cbbFilterBuilding.SelectedValue;
                string floor = cbbFilterFloor.SelectedItem.ToString();
                string query = $"SELECT Id, Name, Price FROM Rooms WHERE BuildingId = {buildingId} AND Floor = '{floor}' AND Status = N'Còn trống'";
                DataTable dt = DatabaseHelper.GetData(query);

                cbbRoom.DataSource = dt;
                cbbRoom.DisplayMember = "Name";
                cbbRoom.ValueMember = "Id";
                cbbRoom.SelectedIndex = -1;
            }
            catch { }
        }

        private void cbbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbRoom.SelectedIndex == -1)
            {
                txtPrice.Text = "0"; return;
            }
            try
            {
                DataRowView drv = (DataRowView)cbbRoom.SelectedItem;
                decimal price = Convert.ToDecimal(drv["Price"]);
                txtPrice.Text = price.ToString("N0");
                txtDeposit.Text = price.ToString("N0");
            }
            catch { }
        }

        // --- CRUD ---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbCustomer.SelectedValue == null || cbbRoom.SelectedValue == null || txtCode.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin (Số HĐ, Sinh viên, Phòng)!");
                return;
            }
            try
            {
                string checkQuery = $"SELECT COUNT(*) FROM Contracts WHERE CustomerId={cbbCustomer.SelectedValue} AND Status=N'Hiệu lực'";
                DataTable dtCheck = DatabaseHelper.GetData(checkQuery);
                if (dtCheck.Rows[0][0].ToString() != "0")
                {
                    MessageBox.Show("Sinh viên này vừa được tạo hợp đồng ở máy khác. Vui lòng chọn sinh viên khác.");
                    LoadComboboxes();
                    return;
                }

                string query = $"INSERT INTO Contracts (ContractCode, CustomerId, RoomId, StartDate, EndDate, Price, Deposit, Status) VALUES " +
                               $"('{txtCode.Text}', {cbbCustomer.SelectedValue}, {cbbRoom.SelectedValue}, " +
                               $"'{dtpStart.Value:yyyy-MM-dd}', '{dtpEnd.Value:yyyy-MM-dd}', " +
                               $"{txtPrice.Text.Replace(",", "")}, {txtDeposit.Text.Replace(",", "")}, N'Hiệu lực')";

                DatabaseHelper.ExecuteQuery(query);
                DatabaseHelper.ExecuteQuery($"UPDATE Rooms SET Status = N'Đã thuê' WHERE Id = {cbbRoom.SelectedValue}");

                MessageBox.Show("Lập hợp đồng thành công!");
                LoadData();
                ClearInput(); // Sẽ gọi lại GenerateContractCode để tăng số
                LoadComboboxes();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;
            try
            {
                string query = $"UPDATE Contracts SET StartDate='{dtpStart.Value:yyyy-MM-dd}', EndDate='{dtpEnd.Value:yyyy-MM-dd}', " +
                               $"Price={txtPrice.Text.Replace(",", "")}, Deposit={txtDeposit.Text.Replace(",", "")} " +
                               $"WHERE Id={txtID.Text}";

                DatabaseHelper.ExecuteQuery(query);
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
                ClearInput();
            }
            catch { MessageBox.Show("Lỗi cập nhật!"); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;
            if (MessageBox.Show("Thanh lý hợp đồng này? Phòng sẽ được trả về trạng thái 'Còn trống'.", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DataTable dt = DatabaseHelper.GetData($"SELECT RoomId FROM Contracts WHERE Id={txtID.Text}");
                    if (dt.Rows.Count > 0)
                    {
                        string roomId = dt.Rows[0][0].ToString();
                        DatabaseHelper.ExecuteQuery($"UPDATE Rooms SET Status = N'Còn trống' WHERE Id = {roomId}");
                    }
                    DatabaseHelper.ExecuteQuery($"DELETE FROM Contracts WHERE Id={txtID.Text}");
                    LoadData();
                    ClearInput();
                    LoadComboboxes();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearInput();

        private void dgvContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var r = dgvContract.Rows[e.RowIndex];
                txtID.Text = r.Cells["Id"].Value.ToString();
                txtCode.Text = r.Cells["ContractCode"].Value.ToString();

                // Khi sửa, ta không đổi sinh viên nên không cần gán lại combobox nếu nó không có trong list
                // Chỉ hiển thị ngày và giá
                dtpStart.Value = Convert.ToDateTime(r.Cells["StartDate"].Value);
                dtpEnd.Value = Convert.ToDateTime(r.Cells["EndDate"].Value);
                txtPrice.Text = string.Format("{0:N0}", r.Cells["Price"].Value);
                txtDeposit.Text = string.Format("{0:N0}", r.Cells["Deposit"].Value);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string kw = txtSearch.Text.Trim();
                string query = $@"SELECT ct.Id, ct.ContractCode, c.Name AS CustomerName, 
                                         b.Name + ' - ' + r.Name AS RoomInfo,
                                         ct.StartDate, ct.EndDate, ct.Price, ct.Deposit, ct.Status,
                                         ct.CustomerId, ct.RoomId
                                  FROM Contracts ct
                                  JOIN Customers c ON ct.CustomerId = c.Id
                                  JOIN Rooms r ON ct.RoomId = r.Id
                                  JOIN Buildings b ON r.BuildingId = b.Id
                                  WHERE ct.ContractCode LIKE '%{kw}%' 
                                     OR c.Name LIKE N'%{kw}%' 
                                     OR r.Name LIKE '%{kw}%'";

                dgvContract.DataSource = DatabaseHelper.GetData(query);
                FormatGrid();
            }
            catch { }
        }

        private void ClearInput()
        {
            txtID.Text = "";
            GenerateContractCode(); // <--- GỌI LẠI HÀM NÀY ĐỂ TĂNG SỐ TỰ ĐỘNG

            cbbCustomer.SelectedIndex = -1;
            cbbFilterBuilding.SelectedIndex = -1;
            cbbFilterFloor.Items.Clear();
            cbbRoom.DataSource = null;
            txtPrice.Text = "0"; txtDeposit.Text = "0";
            dtpStart.Value = DateTime.Now; dtpEnd.Value = DateTime.Now.AddYears(1);
        }
    }
}