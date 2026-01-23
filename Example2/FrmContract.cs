using System;
using System.Data;
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
        }

        // --- 1. TẢI DỮ LIỆU & ĐỊNH DẠNG ---
        private void LoadData()
        {
            try
            {
                // Join 3 bảng để lấy tên hiển thị
                string query = @"SELECT ct.Id, ct.ContractCode, c.Name AS CustomerName, r.Name AS RoomName, 
                                        ct.StartDate, ct.EndDate, ct.Price, ct.Deposit, ct.Status,
                                        ct.CustomerId, ct.RoomId
                                 FROM Contracts ct
                                 JOIN Customers c ON ct.CustomerId = c.Id
                                 JOIN Rooms r ON ct.RoomId = r.Id";

                dgvContract.DataSource = DatabaseHelper.GetData(query);
                FormatGrid(); // Gọi hàm định dạng sau khi gán nguồn dữ liệu
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
        }

        // Hàm định dạng hiển thị Grid (Cho đồng bộ với các form khác)
        private void FormatGrid()
        {
            if (dgvContract.Columns.Count > 0)
            {
                // Ẩn các cột ID
                if (dgvContract.Columns.Contains("Id")) dgvContract.Columns["Id"].Visible = false;
                if (dgvContract.Columns.Contains("CustomerId")) dgvContract.Columns["CustomerId"].Visible = false;
                if (dgvContract.Columns.Contains("RoomId")) dgvContract.Columns["RoomId"].Visible = false;

                // Đặt tên cột tiếng Việt & Kích thước
                dgvContract.Columns["ContractCode"].HeaderText = "SỐ HĐ";
                dgvContract.Columns["ContractCode"].Width = 100;

                dgvContract.Columns["CustomerName"].HeaderText = "KHÁCH HÀNG";
                dgvContract.Columns["CustomerName"].Width = 180;

                dgvContract.Columns["RoomName"].HeaderText = "PHÒNG";
                dgvContract.Columns["RoomName"].Width = 80;

                dgvContract.Columns["StartDate"].HeaderText = "BẮT ĐẦU";
                dgvContract.Columns["StartDate"].Width = 100;

                dgvContract.Columns["EndDate"].HeaderText = "KẾT THÚC";
                dgvContract.Columns["EndDate"].Width = 100;

                dgvContract.Columns["Price"].HeaderText = "GIÁ THUÊ";
                dgvContract.Columns["Price"].DefaultCellStyle.Format = "N0"; // Format 15,000,000
                dgvContract.Columns["Price"].Width = 120;

                dgvContract.Columns["Deposit"].HeaderText = "TIỀN CỌC";
                dgvContract.Columns["Deposit"].DefaultCellStyle.Format = "N0";
                dgvContract.Columns["Deposit"].Width = 120;

                dgvContract.Columns["Status"].HeaderText = "TRẠNG THÁI";
                dgvContract.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void LoadComboboxes()
        {
            try
            {
                // Load danh sách Khách
                cbbCustomer.DataSource = DatabaseHelper.GetData("SELECT Id, Name FROM Customers");
                cbbCustomer.DisplayMember = "Name";
                cbbCustomer.ValueMember = "Id";
                cbbCustomer.SelectedIndex = -1;

                // Load danh sách Phòng
                cbbRoom.DataSource = DatabaseHelper.GetData("SELECT Id, Name FROM Rooms");
                cbbRoom.DisplayMember = "Name";
                cbbRoom.ValueMember = "Id";
                cbbRoom.SelectedIndex = -1;
            }
            catch { }
        }

        // --- 2. SỰ KIỆN CLICK GRID ---
        private void dgvContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var r = dgvContract.Rows[e.RowIndex];
                txtID.Text = r.Cells["Id"].Value.ToString();
                txtCode.Text = r.Cells["ContractCode"].Value.ToString();

                // Gán giá trị cho ComboBox
                if (r.Cells["CustomerId"].Value != DBNull.Value)
                    cbbCustomer.SelectedValue = r.Cells["CustomerId"].Value;

                if (r.Cells["RoomId"].Value != DBNull.Value)
                    cbbRoom.SelectedValue = r.Cells["RoomId"].Value;

                dtpStart.Value = Convert.ToDateTime(r.Cells["StartDate"].Value);
                dtpEnd.Value = Convert.ToDateTime(r.Cells["EndDate"].Value);

                // Format lại text tiền tệ bỏ dấu phẩy để hiển thị trên textbox
                txtPrice.Text = string.Format("{0:0}", r.Cells["Price"].Value);
                txtDeposit.Text = string.Format("{0:0}", r.Cells["Deposit"].Value);
            }
        }

        // --- 3. CRUD (THÊM / SỬA / XÓA) ---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbCustomer.SelectedValue == null || cbbRoom.SelectedValue == null || txtCode.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã HĐ, chọn Khách và Phòng!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Insert Hợp đồng
                string query = $"INSERT INTO Contracts (ContractCode, CustomerId, RoomId, StartDate, EndDate, Price, Deposit, Status) VALUES " +
                               $"('{txtCode.Text}', {cbbCustomer.SelectedValue}, {cbbRoom.SelectedValue}, " +
                               $"'{dtpStart.Value:yyyy-MM-dd}', '{dtpEnd.Value:yyyy-MM-dd}', " +
                               $"{txtPrice.Text.Replace(",", "")}, {txtDeposit.Text.Replace(",", "")}, N'Hiệu lực')";

                DatabaseHelper.ExecuteQuery(query);

                // Cập nhật trạng thái phòng -> Đã thuê
                DatabaseHelper.ExecuteQuery($"UPDATE Rooms SET Status = N'Đã thuê' WHERE Id = {cbbRoom.SelectedValue}");

                MessageBox.Show("Lập hợp đồng thành công!");
                LoadData();
                ClearInput();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;
            try
            {
                string query = $"UPDATE Contracts SET ContractCode='{txtCode.Text}', " +
                               $"CustomerId={cbbCustomer.SelectedValue}, RoomId={cbbRoom.SelectedValue}, " +
                               $"StartDate='{dtpStart.Value:yyyy-MM-dd}', EndDate='{dtpEnd.Value:yyyy-MM-dd}', " +
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

            if (MessageBox.Show("Bạn muốn Thanh lý và Xóa hợp đồng này?\n(Trạng thái phòng sẽ trở về 'Còn trống')", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Lấy ID phòng trước khi xóa HĐ để update lại trạng thái
                    int roomId = (int)cbbRoom.SelectedValue;

                    // Trả lại trạng thái phòng -> Còn trống
                    DatabaseHelper.ExecuteQuery($"UPDATE Rooms SET Status = N'Còn trống' WHERE Id = {roomId}");

                    // Xóa HĐ
                    DatabaseHelper.ExecuteQuery($"DELETE FROM Contracts WHERE Id={txtID.Text}");

                    LoadData();
                    ClearInput();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearInput();

        // --- 4. TÌM KIẾM ---
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string kw = txtSearch.Text.Trim();
                string query = $@"SELECT ct.Id, ct.ContractCode, c.Name AS CustomerName, r.Name AS RoomName, 
                                         ct.StartDate, ct.EndDate, ct.Price, ct.Deposit, ct.Status,
                                         ct.CustomerId, ct.RoomId
                                  FROM Contracts ct
                                  JOIN Customers c ON ct.CustomerId = c.Id
                                  JOIN Rooms r ON ct.RoomId = r.Id
                                  WHERE ct.ContractCode LIKE '%{kw}%' 
                                     OR c.Name LIKE N'%{kw}%' 
                                     OR r.Name LIKE '%{kw}%'";

                dgvContract.DataSource = DatabaseHelper.GetData(query);
                FormatGrid(); // Quan trọng: Phải gọi lại format sau khi search
            }
            catch { }
        }

        private void ClearInput()
        {
            txtID.Text = ""; txtCode.Text = "";
            cbbCustomer.SelectedIndex = -1; cbbRoom.SelectedIndex = -1;
            txtPrice.Text = "0"; txtDeposit.Text = "0";
            dtpStart.Value = DateTime.Now; dtpEnd.Value = DateTime.Now.AddYears(1);
            txtCode.Focus();
        }
    }
}