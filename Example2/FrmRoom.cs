using System;
using System.Data;
using System.Windows.Forms;

namespace ADO_Example
{
    public partial class FrmRoom : Form
    {
        public FrmRoom()
        {
            InitializeComponent();
            LoadData();
            LoadBuildingCombobox(); // Load danh sách tòa nhà vào ComboBox
        }

        // 1. Load Data Grid
        private void LoadData()
        {
            try
            {
                // Join bảng Rooms và Buildings để lấy Tên Tòa Nhà thay vì ID
                string query = @"SELECT r.Id, b.Name AS BuildingName, r.Name, r.Floor, r.Area, r.Price, r.Status, r.BuildingId 
                                 FROM Rooms r 
                                 LEFT JOIN Buildings b ON r.BuildingId = b.Id";

                dgvRoom.DataSource = DatabaseHelper.GetData(query);

                if (dgvRoom.Columns.Count > 0)
                {
                    dgvRoom.Columns["Id"].HeaderText = "Mã";
                    dgvRoom.Columns["Id"].Width = 60;
                    dgvRoom.Columns["BuildingName"].HeaderText = "Tòa Nhà";
                    dgvRoom.Columns["BuildingName"].Width = 200;
                    dgvRoom.Columns["Name"].HeaderText = "Số Phòng";
                    dgvRoom.Columns["Floor"].HeaderText = "Tầng";
                    dgvRoom.Columns["Area"].HeaderText = "Diện Tích";
                    dgvRoom.Columns["Price"].HeaderText = "Giá Thuê";
                    dgvRoom.Columns["Price"].DefaultCellStyle.Format = "N0";
                    dgvRoom.Columns["Status"].HeaderText = "Trạng Thái";

                    // Ẩn cột BuildingId (chỉ dùng để xử lý logic)
                    if (dgvRoom.Columns.Contains("BuildingId")) dgvRoom.Columns["BuildingId"].Visible = false;
                }
            }
            catch { }
        }

        // 2. Load ComboBox Tòa Nhà
        private void LoadBuildingCombobox()
        {
            try
            {
                DataTable dt = DatabaseHelper.GetData("SELECT Id, Name FROM Buildings");
                cbbBuilding.DataSource = dt;
                cbbBuilding.DisplayMember = "Name"; // Hiển thị tên
                cbbBuilding.ValueMember = "Id";     // Giá trị ngầm là ID
                cbbBuilding.SelectedIndex = -1;     // Không chọn gì cả
            }
            catch { }
        }

        // 3. Sự kiện Click Grid
        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvRoom.Rows[e.RowIndex];
                txtID.Text = r.Cells["Id"].Value.ToString();
                txtName.Text = r.Cells["Name"].Value.ToString();
                txtFloor.Text = r.Cells["Floor"].Value.ToString();
                txtArea.Text = r.Cells["Area"].Value.ToString();
                txtPrice.Text = r.Cells["Price"].Value.ToString();
                cbbStatus.Text = r.Cells["Status"].Value.ToString();

                // Gán giá trị cho ComboBox Tòa nhà
                if (r.Cells["BuildingId"].Value != DBNull.Value)
                {
                    cbbBuilding.SelectedValue = r.Cells["BuildingId"].Value;
                }
            }
        }

        // 4. CRUD Operations
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbBuilding.SelectedValue == null || txtName.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tòa nhà và nhập số phòng!"); return;
            }

            try
            {
                int bId = (int)cbbBuilding.SelectedValue;
                string query = $"INSERT INTO Rooms (BuildingId, Name, Floor, Area, Price, Status) " +
                               $"VALUES ({bId}, N'{txtName.Text}', N'{txtFloor.Text}', {txtArea.Text}, {txtPrice.Text}, N'{cbbStatus.Text}')";

                DatabaseHelper.ExecuteQuery(query);
                LoadData(); ClearInput();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "AUTO") return;
            try
            {
                int bId = (int)cbbBuilding.SelectedValue;
                string query = $"UPDATE Rooms SET BuildingId={bId}, Name=N'{txtName.Text}', Floor=N'{txtFloor.Text}', " +
                               $"Area={txtArea.Text}, Price={txtPrice.Text}, Status=N'{cbbStatus.Text}' WHERE Id={txtID.Text}";

                DatabaseHelper.ExecuteQuery(query);
                MessageBox.Show("Đã cập nhật!");
                LoadData(); ClearInput();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "AUTO") return;
            if (MessageBox.Show("Xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DatabaseHelper.ExecuteQuery($"DELETE FROM Rooms WHERE Id = {txtID.Text}");
                    LoadData(); ClearInput();
                }
                catch { }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearInput();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string kw = txtSearch.Text.Trim();
            string query = $"SELECT r.Id, b.Name AS BuildingName, r.Name, r.Floor, r.Area, r.Price, r.Status, r.BuildingId " +
                           $"FROM Rooms r LEFT JOIN Buildings b ON r.BuildingId = b.Id " +
                           $"WHERE r.Name LIKE '%{kw}%' OR b.Name LIKE N'%{kw}%'";
            dgvRoom.DataSource = DatabaseHelper.GetData(query);
        }

        private void ClearInput()
        {
            txtID.Text = "AUTO"; cbbBuilding.SelectedIndex = -1; txtName.Clear();
            txtFloor.Clear(); txtArea.Clear(); txtPrice.Clear(); cbbStatus.SelectedIndex = -1;
        }
    }
}