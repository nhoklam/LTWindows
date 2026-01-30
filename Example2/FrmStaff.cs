using System;
using System.Data;
using System.Drawing; // Thêm thư viện này để dùng Color
using System.Windows.Forms;

namespace ADO_Example
{
    public partial class FrmStaff : Form
    {
        public FrmStaff()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Không lấy cột Password để bảo mật
                string query = "SELECT Username, Password, FullName, Role, IsActive FROM Staffs";
                dgvStaff.DataSource = DatabaseHelper.GetData(query);
                FormatGrid();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void FormatGrid()
        {
            if (dgvStaff.Columns.Count > 0)
            {
                dgvStaff.Columns["Username"].HeaderText = "TÀI KHOẢN";
                dgvStaff.Columns["Username"].Width = 150;

                // Ẩn cột Password trên Grid
                if (dgvStaff.Columns.Contains("Password")) dgvStaff.Columns["Password"].Visible = false;

                dgvStaff.Columns["FullName"].HeaderText = "HỌ VÀ TÊN";
                dgvStaff.Columns["FullName"].Width = 200;

                dgvStaff.Columns["Role"].HeaderText = "QUYỀN HẠN";
                dgvStaff.Columns["Role"].Width = 120;

                dgvStaff.Columns["IsActive"].HeaderText = "TRẠNG THÁI";
                dgvStaff.Columns["IsActive"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        // --- SỰ KIỆN CLICK GRID ---
        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvStaff.Rows[e.RowIndex];
                txtUser.Text = r.Cells["Username"].Value.ToString();
                txtUser.Enabled = false; // Không cho sửa Username

                txtPass.Text = r.Cells["Password"].Value.ToString();
                txtName.Text = r.Cells["FullName"].Value.ToString();
                cbbRole.Text = r.Cells["Role"].Value.ToString();

                bool isActive = Convert.ToBoolean(r.Cells["IsActive"].Value);
                cbbStatus.Text = isActive ? "Active" : "Locked"; // Sửa lại cho khớp với Items trong Designer
            }
        }

        // --- CRUD ---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tài khoản và Mật khẩu!"); return;
            }

            try
            {
                int status = (cbbStatus.Text == "Active") ? 1 : 0;
                string query = $"INSERT INTO Staffs (Username, Password, FullName, Role, IsActive) " +
                               $"VALUES ('{txtUser.Text}', '{txtPass.Text}', N'{txtName.Text}', '{cbbRole.Text}', {status})";

                DatabaseHelper.ExecuteQuery(query);
                LoadData(); ClearInput();
            }
            catch { MessageBox.Show("Lỗi: Tài khoản đã tồn tại hoặc dữ liệu không hợp lệ!"); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtUser.Enabled) return; // Nếu đang ở chế độ thêm mới thì ko sửa
            try
            {
                int status = (cbbStatus.Text == "Active") ? 1 : 0;
                string query = $"UPDATE Staffs SET Password='{txtPass.Text}', FullName=N'{txtName.Text}', " +
                               $"Role='{cbbRole.Text}', IsActive={status} WHERE Username='{txtUser.Text}'";

                DatabaseHelper.ExecuteQuery(query);
                MessageBox.Show("Cập nhật thành công!");
                LoadData(); ClearInput();
            }
            catch { MessageBox.Show("Lỗi cập nhật!"); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "") return;

            // Không cho xóa chính mình (Admin đang đăng nhập) - Logic nâng cao có thể check thêm
            if (txtUser.Text.ToLower() == "admin")
            {
                MessageBox.Show("Không thể xóa tài khoản Super Admin!");
                return;
            }

            if (MessageBox.Show("Xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DatabaseHelper.ExecuteQuery($"DELETE FROM Staffs WHERE Username='{txtUser.Text}'");
                    LoadData(); ClearInput();
                }
                catch { MessageBox.Show("Lỗi xóa!"); }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearInput();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // SỬA LỖI: Nếu text đang là placeholder thì không tìm kiếm
            if (txtSearch.Text == "Tìm kiếm theo tên..." || txtSearch.ForeColor == Color.Gray) return;

            string kw = txtSearch.Text.Trim();
            string query = $"SELECT Username, Password, FullName, Role, IsActive FROM Staffs " +
                           $"WHERE Username LIKE '%{kw}%' OR FullName LIKE N'%{kw}%' OR Role LIKE '%{kw}%'";
            dgvStaff.DataSource = DatabaseHelper.GetData(query);
            FormatGrid(); // Gọi lại format vì source thay đổi
        }

        private void ClearInput()
        {
            txtUser.Enabled = true; // Cho phép nhập lại Username
            txtUser.Clear(); txtPass.Clear(); txtName.Clear();
            cbbRole.SelectedIndex = -1;
            cbbStatus.SelectedIndex = 0; // Mặc định Active
            txtUser.Focus();
        }
    }
}