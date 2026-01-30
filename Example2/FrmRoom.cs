using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ADO_Example
{
    public partial class FrmRoom : Form
    {
        public FrmRoom()
        {
            InitializeComponent();
            LoadBuildingCombobox();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = @"SELECT r.Id, b.Name AS BuildingName, r.Name, r.Floor, r.Price, r.Area, r.Status 
                                 FROM Rooms r 
                                 JOIN Buildings b ON r.BuildingId = b.Id
                                 ORDER BY b.Name, r.Floor, r.Name";
                dgvRoom.DataSource = DatabaseHelper.GetData(query);
                SetupGrid();
            }
            catch { }
        }

        private void SetupGrid()
        {
            dgvRoom.AutoGenerateColumns = false;
            dgvRoom.Columns.Clear();

            // 1. Checkbox Column
            DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn();
            chkCol.Name = "colSelect";
            chkCol.HeaderText = "";
            chkCol.Width = 40;
            chkCol.ReadOnly = false; // QUAN TRỌNG: Phải cho phép sửa
            dgvRoom.Columns.Add(chkCol);

            // 2. Data Columns
            AddTextColumn("Id", "ID", 0);
            AddTextColumn("BuildingName", "TÒA NHÀ", 150);
            AddTextColumn("Name", "SỐ PHÒNG", 100);
            AddTextColumn("Floor", "TẦNG", 80);
            AddTextColumn("Price", "GIÁ THUÊ", 120);
            AddTextColumn("Area", "DIỆN TÍCH", 100);
            AddTextColumn("Status", "TRẠNG THÁI", 150);

            dgvRoom.Columns["Price"].DefaultCellStyle.Format = "N0";
            dgvRoom.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // QUAN TRỌNG: Chỉ set ReadOnly cho các cột DỮ LIỆU, chừa cột Checkbox ra
            foreach (DataGridViewColumn col in dgvRoom.Columns)
            {
                if (col.Name != "colSelect")
                {
                    col.ReadOnly = true;
                }
            }
        }

        private void AddTextColumn(string dataPropertyName, string headerText, int width)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = dataPropertyName;
            col.HeaderText = headerText;
            col.Width = width;
            col.Name = dataPropertyName;
            if (width == 0) col.Visible = false;
            dgvRoom.Columns.Add(col);
        }

        private void LoadBuildingCombobox()
        {
            try
            {
                string query = "SELECT Id, Name, TotalFloors FROM Buildings";
                DataTable dt = DatabaseHelper.GetData(query);
                cbbBuilding.DataSource = dt;
                cbbBuilding.DisplayMember = "Name";
                cbbBuilding.ValueMember = "Id";
                cbbBuilding.SelectedIndex = -1;
            }
            catch { }
        }

        // --- XUẤT EXCEL (CSV) ---
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvRoom.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.csv)|*.csv";
            sfd.FileName = "DanhSachPhong_KTX.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        sw.Write('\uFEFF');

                        // Header
                        for (int i = 0; i < dgvRoom.Columns.Count; i++)
                        {
                            if (dgvRoom.Columns[i].Visible && dgvRoom.Columns[i].Name != "colSelect")
                            {
                                sw.Write(dgvRoom.Columns[i].HeaderText);
                                if (i < dgvRoom.Columns.Count - 1) sw.Write(",");
                            }
                        }
                        sw.WriteLine();

                        // Data
                        foreach (DataGridViewRow row in dgvRoom.Rows)
                        {
                            for (int i = 0; i < dgvRoom.Columns.Count; i++)
                            {
                                if (dgvRoom.Columns[i].Visible && dgvRoom.Columns[i].Name != "colSelect")
                                {
                                    string val = row.Cells[i].Value?.ToString() ?? "";
                                    if (val.Contains(",")) val = "\"" + val + "\"";
                                    sw.Write(val);
                                    if (i < dgvRoom.Columns.Count - 1) sw.Write(",");
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cbbBuilding.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Tòa nhà!", "Thiếu thông tin");
                return;
            }
            if (string.IsNullOrEmpty(txtRoomsPerFloor.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập số phòng/tầng và giá tiền!", "Thiếu thông tin");
                return;
            }

            try
            {
                int buildingId = (int)cbbBuilding.SelectedValue;
                int roomsPerFloor = int.Parse(txtRoomsPerFloor.Text);
                string price = txtPrice.Text.Replace(",", "").Replace(".", "");
                string area = string.IsNullOrEmpty(txtArea.Text) ? "0" : txtArea.Text;

                DataTable dtB = DatabaseHelper.GetData($"SELECT TotalFloors FROM Buildings WHERE Id = {buildingId}");
                int totalFloors = 0;
                if (dtB.Rows.Count > 0 && dtB.Rows[0]["TotalFloors"] != DBNull.Value)
                {
                    totalFloors = Convert.ToInt32(dtB.Rows[0]["TotalFloors"]);
                }

                if (totalFloors <= 0)
                {
                    MessageBox.Show("Tòa nhà này chưa thiết lập 'Số Tầng'. Vui lòng qua mục Quản Lý Tòa Tháp để cập nhật số tầng trước.", "Lỗi Logic");
                    return;
                }

                int countSuccess = 0;
                for (int f = 1; f <= totalFloors; f++)
                {
                    for (int r = 1; r <= roomsPerFloor; r++)
                    {
                        string roomName = $"{f}{r:00}";
                        string checkQuery = $"SELECT COUNT(*) FROM Rooms WHERE BuildingId={buildingId} AND Name='{roomName}'";
                        DataTable dtCheck = DatabaseHelper.GetData(checkQuery);

                        if (dtCheck.Rows[0][0].ToString() == "0")
                        {
                            string insertQuery = $"INSERT INTO Rooms (BuildingId, Name, Floor, Area, Price, Status) " +
                                                 $"VALUES ({buildingId}, '{roomName}', {f}, {area}, {price}, N'Còn trống')";
                            DatabaseHelper.ExecuteQuery(insertQuery);
                            countSuccess++;
                        }
                    }
                }

                MessageBox.Show($"Đã tạo thành công {countSuccess} phòng mới cho tòa nhà này!", "Thành công");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn một phòng từ danh sách để sửa!");
                return;
            }

            try
            {
                string price = txtPrice.Text.Replace(",", "").Replace(".", "");
                string area = txtArea.Text.Replace(",", ".");

                if (string.IsNullOrEmpty(price)) price = "0";
                if (string.IsNullOrEmpty(area)) area = "0";

                string query = $"UPDATE Rooms SET Price = {price}, Area = {area} WHERE Id = {txtID.Text}";
                DatabaseHelper.ExecuteQuery(query);

                MessageBox.Show("Cập nhật thông tin phòng thành công!", "Thông báo");
                LoadData();
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<string> listIDs = new List<string>();
            dgvRoom.EndEdit();

            foreach (DataGridViewRow row in dgvRoom.Rows)
            {
                // Fix lỗi Null Reference khi check
                object val = row.Cells["colSelect"].Value;
                bool isSelected = (val != null && (bool)val == true);

                if (isSelected)
                {
                    listIDs.Add(row.Cells["Id"].Value.ToString());
                }
            }

            if (listIDs.Count == 0)
            {
                if (!string.IsNullOrEmpty(txtID.Text)) listIDs.Add(txtID.Text);
                else
                {
                    MessageBox.Show("Vui lòng tích chọn các phòng cần xóa!");
                    return;
                }
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa {listIDs.Count} phòng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string ids = string.Join(",", listIDs);
                    string query = $"DELETE FROM Rooms WHERE Id IN ({ids})";
                    DatabaseHelper.ExecuteQuery(query);
                    MessageBox.Show("Đã xóa thành công!");
                    LoadData();
                    ClearInput();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa (Có thể phòng đang có sinh viên ở hoặc lỗi hệ thống).");
                }
            }
        }

        // --- SỬA LỖI CHECKBOX KHÔNG ĂN ---
        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Nếu click vào cột checkbox (index 0) thì KHÔNG làm gì cả (để mặc định nó toggle check)
            // Hoặc kiểm tra tên cột
            if (dgvRoom.Columns[e.ColumnIndex].Name == "colSelect") return;

            try
            {
                DataGridViewRow r = dgvRoom.Rows[e.RowIndex];
                txtID.Text = r.Cells["Id"].Value.ToString();

                if (r.Cells["Price"].Value != DBNull.Value)
                {
                    double priceVal = Convert.ToDouble(r.Cells["Price"].Value);
                    txtPrice.Text = string.Format("{0:N0}", priceVal);
                }

                if (r.Cells["Area"].Value != DBNull.Value)
                    txtArea.Text = r.Cells["Area"].Value.ToString();

                string buildingName = r.Cells["BuildingName"].Value.ToString();
                int index = cbbBuilding.FindStringExact(buildingName);
                if (index != -1) cbbBuilding.SelectedIndex = index;
            }
            catch { }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearInput();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string kw = txtSearch.Text.Trim();
            string query = $"SELECT r.Id, b.Name AS BuildingName, r.Name, r.Floor, r.Price, r.Area, r.Status " +
                           $"FROM Rooms r JOIN Buildings b ON r.BuildingId = b.Id " +
                           $"WHERE r.Name LIKE '%{kw}%' OR b.Name LIKE N'%{kw}%' " +
                           $"ORDER BY b.Name, r.Floor, r.Name";
            dgvRoom.DataSource = DatabaseHelper.GetData(query);
            // SetupGrid(); // Không cần gọi lại SetupGrid để tránh mất trạng thái
        }

        private void ClearInput()
        {
            cbbBuilding.SelectedIndex = -1;
            txtRoomsPerFloor.Text = "3";
            txtPrice.Clear();
            txtArea.Clear();
            txtID.Clear();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text)) return;
            try
            {
                string rawValue = txtPrice.Text.Replace(",", "").Replace(".", "");
                long value = long.Parse(rawValue);
                txtPrice.TextChanged -= txtPrice_TextChanged;
                txtPrice.Text = string.Format("{0:N0}", value);
                txtPrice.SelectionStart = txtPrice.Text.Length;
                txtPrice.TextChanged += txtPrice_TextChanged;
            }
            catch { }
        }
    }
}