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
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM Buildings";
                DataTable dt = DatabaseHelper.GetData(query);
                dgvBuilding.DataSource = dt;
                SetupGridColumns(); // Gọi hàm định dạng cột
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

                dgvBuilding.Columns["Name"].HeaderText = "TÊN TÒA NHÀ";
                dgvBuilding.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Tự giãn

                dgvBuilding.Columns["Address"].HeaderText = "ĐỊA CHỈ";
                dgvBuilding.Columns["Address"].Width = 250;

                dgvBuilding.Columns["Manager"].HeaderText = "QUẢN LÝ";
                dgvBuilding.Columns["Manager"].Width = 150;

                dgvBuilding.Columns["Price"].HeaderText = "GIÁ SÀN";
                dgvBuilding.Columns["Price"].Width = 120;
                dgvBuilding.Columns["Price"].DefaultCellStyle.Format = "N0"; // 5,000
            }
        }

        // --- CÁC SỰ KIỆN NÚT BẤM (CRUD) ---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "") return;
            try
            {
                string price = string.IsNullOrEmpty(txtPrice.Text) ? "0" : txtPrice.Text;
                string query = $"INSERT INTO Buildings (Name, Address, Manager, Price) VALUES (N'{txtName.Text}', N'{txtAddress.Text}', N'{txtManager.Text}', {price})";
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
                string price = string.IsNullOrEmpty(txtPrice.Text) ? "0" : txtPrice.Text;
                string query = $"UPDATE Buildings SET Name = N'{txtName.Text}', Address = N'{txtAddress.Text}', Manager = N'{txtManager.Text}', Price = {price} WHERE Id = {txtID.Text}";
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
                txtAddress.Text = r.Cells["Address"].Value.ToString();
                txtManager.Text = r.Cells["Manager"].Value.ToString();
                txtPrice.Text = r.Cells["Price"].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string kw = txtSearch.Text.Trim();
                string query = $"SELECT * FROM Buildings WHERE Name LIKE N'%{kw}%' OR Manager LIKE N'%{kw}%'";
                dgvBuilding.DataSource = DatabaseHelper.GetData(query);
            }
            catch { }
        }

        private void ClearInput()
        {
            txtID.Text = "AUTO";
            txtName.Clear(); txtAddress.Clear(); txtManager.Clear(); txtPrice.Clear();
            txtName.Focus();
        }
    }
}