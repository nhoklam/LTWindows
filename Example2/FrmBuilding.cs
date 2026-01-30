using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ADO_Example
{
    public partial class FrmBuilding : Form
    {
        public FrmBuilding()
        {
            InitializeComponent();
            LoadStaffCombobox(); // Load danh sách nhân viên trước
            LoadData();
        }

        // MỚI: Load danh sách nhân viên vào ComboBox
        private void LoadStaffCombobox()
        {
            try
            {
                // Chỉ lấy những nhân viên đang hoạt động
                string query = "SELECT Username, FullName FROM Staffs WHERE IsActive = 1";
                DataTable dt = DatabaseHelper.GetData(query);

                cbbManager.DataSource = dt;
                cbbManager.DisplayMember = "FullName"; // Hiển thị tên đầy đủ
                cbbManager.ValueMember = "Username";   // Giá trị ngầm là Username (để lưu vào DB)
                cbbManager.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách nhân viên: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                // JOIN bảng Staffs để lấy tên đầy đủ của Trưởng nhà
                // Cột b.Manager lưu Username -> Join với s.Username -> Lấy s.FullName để hiển thị
                string query = @"SELECT b.Id, b.Name, b.LocationDesc, b.TotalFloors, b.GenderType, 
                                        b.Manager, s.FullName AS ManagerName 
                                 FROM Buildings b 
                                 LEFT JOIN Staffs s ON b.Manager = s.Username";

                DataTable dt = DatabaseHelper.GetData(query);
                dgvBuilding.DataSource = dt;
                SetupGridColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void SetupGridColumns()
        {
            if (dgvBuilding.Columns.Count > 0)
            {
                dgvBuilding.Columns["Id"].HeaderText = "MÃ";
                dgvBuilding.Columns["Id"].Width = 60;

                dgvBuilding.Columns["Name"].HeaderText = "TÊN TÒA KTX";
                dgvBuilding.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                if (dgvBuilding.Columns.Contains("LocationDesc"))
                {
                    dgvBuilding.Columns["LocationDesc"].HeaderText = "VỊ TRÍ";
                    dgvBuilding.Columns["LocationDesc"].Width = 200;
                }
                else if (dgvBuilding.Columns.Contains("Address"))
                {
                    dgvBuilding.Columns["Address"].HeaderText = "VỊ TRÍ";
                    dgvBuilding.Columns["Address"].Width = 200;
                }

                // Hiển thị tên đầy đủ của quản lý (lấy từ bảng Staffs)
                if (dgvBuilding.Columns.Contains("ManagerName"))
                {
                    dgvBuilding.Columns["ManagerName"].HeaderText = "TRƯỞNG NHÀ";
                    dgvBuilding.Columns["ManagerName"].Width = 180;
                }

                // Ẩn cột Manager gốc (chứa username) cho đẹp
                if (dgvBuilding.Columns.Contains("Manager"))
                    dgvBuilding.Columns["Manager"].Visible = false;

                if (dgvBuilding.Columns.Contains("TotalFloors"))
                {
                    dgvBuilding.Columns["TotalFloors"].HeaderText = "SỐ TẦNG";
                    dgvBuilding.Columns["TotalFloors"].Width = 100;
                }

                if (dgvBuilding.Columns.Contains("GenderType"))
                {
                    dgvBuilding.Columns["GenderType"].HeaderText = "LOẠI HÌNH";
                    dgvBuilding.Columns["GenderType"].Width = 100;
                }

                if (dgvBuilding.Columns.Contains("Price"))
                    dgvBuilding.Columns["Price"].Visible = false;
            }
        }

        private void dgvBuilding_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBuilding.Columns[e.ColumnIndex].Name == "GenderType" && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int val))
                {
                    e.Value = (val == 1) ? "Nam" : "Nữ";
                    e.FormattingApplied = true;
                }
            }
        }

        // --- CRUD ---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tòa!");
                return;
            }
            if (cbbManager.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Trưởng nhà!");
                return;
            }

            try
            {
                string floors = string.IsNullOrEmpty(txtFloors.Text) ? "0" : txtFloors.Text;
                int gender = (cbbGender.SelectedIndex == 1) ? 1 : 0;

                // Lấy Username từ ComboBox
                string managerUsername = cbbManager.SelectedValue.ToString();

                string query = $"INSERT INTO Buildings (Name, LocationDesc, Manager, GenderType, TotalFloors) " +
                               $"VALUES (N'{txtName.Text}', N'{txtLocation.Text}', '{managerUsername}', {gender}, {floors})";

                DatabaseHelper.ExecuteQuery(query);
                LoadData(); ClearInput();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "AUTO") return;
            if (cbbManager.SelectedValue == null) return;

            try
            {
                string floors = string.IsNullOrEmpty(txtFloors.Text) ? "0" : txtFloors.Text;
                int gender = (cbbGender.SelectedIndex == 1) ? 1 : 0;
                string managerUsername = cbbManager.SelectedValue.ToString();

                string query = $"UPDATE Buildings SET Name = N'{txtName.Text}', LocationDesc = N'{txtLocation.Text}', " +
                               $"Manager = '{managerUsername}', GenderType = {gender}, TotalFloors = {floors} " +
                               $"WHERE Id = {txtID.Text}";

                DatabaseHelper.ExecuteQuery(query);
                MessageBox.Show("Cập nhật thành công!");
                LoadData(); ClearInput();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "AUTO") return;
            if (MessageBox.Show("Xóa tòa nhà này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DatabaseHelper.ExecuteQuery($"DELETE FROM Buildings WHERE Id = {txtID.Text}");
                    LoadData(); ClearInput();
                }
                catch { MessageBox.Show("Không thể xóa (Dữ liệu đang được sử dụng)."); }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearInput();

        private void dgvBuilding_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvBuilding.Rows[e.RowIndex];
                txtID.Text = r.Cells["Id"].Value.ToString();
                txtName.Text = r.Cells["Name"].Value.ToString();

                if (dgvBuilding.Columns.Contains("LocationDesc") && r.Cells["LocationDesc"].Value != DBNull.Value)
                    txtLocation.Text = r.Cells["LocationDesc"].Value.ToString();
                else if (dgvBuilding.Columns.Contains("Address") && r.Cells["Address"].Value != DBNull.Value)
                    txtLocation.Text = r.Cells["Address"].Value.ToString();

                // Gán giá trị cho ComboBox Manager
                if (r.Cells["Manager"].Value != DBNull.Value)
                {
                    cbbManager.SelectedValue = r.Cells["Manager"].Value.ToString();
                }

                if (dgvBuilding.Columns.Contains("TotalFloors") && r.Cells["TotalFloors"].Value != DBNull.Value)
                    txtFloors.Text = r.Cells["TotalFloors"].Value.ToString();
                else
                    txtFloors.Text = "0";

                if (dgvBuilding.Columns.Contains("GenderType") && r.Cells["GenderType"].Value != DBNull.Value)
                {
                    int val = Convert.ToInt32(r.Cells["GenderType"].Value);
                    cbbGender.SelectedIndex = (val == 1) ? 1 : 0;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string kw = txtSearch.Text.Trim();
                // Search cũng cần JOIN để tìm theo tên Quản lý (FullName)
                string query = $@"SELECT b.Id, b.Name, b.LocationDesc, b.TotalFloors, b.GenderType, 
                                         b.Manager, s.FullName AS ManagerName 
                                  FROM Buildings b 
                                  LEFT JOIN Staffs s ON b.Manager = s.Username
                                  WHERE b.Name LIKE N'%{kw}%' OR s.FullName LIKE N'%{kw}%'";

                dgvBuilding.DataSource = DatabaseHelper.GetData(query);
            }
            catch { }
        }

        private void ClearInput()
        {
            txtID.Text = "AUTO";
            txtName.Clear(); txtLocation.Clear(); txtFloors.Clear();
            cbbManager.SelectedIndex = -1;
            cbbGender.SelectedIndex = -1;
            txtName.Focus();
        }
    }
}