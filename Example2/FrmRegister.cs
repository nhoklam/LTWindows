using System;
using System.Data;
using System.Windows.Forms;

namespace ADO_Example
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        // --- NÚT ĐĂNG KÝ ---
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string fullName = txtName.Text.Trim();
            string password = txtPass.Text.Trim();
            string confirmPass = txtConfirmPass.Text.Trim();

            // 1. Kiểm tra nhập liệu
            if (username == "" || fullName == "" || password == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPass)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 2. Kiểm tra tài khoản đã tồn tại chưa
                string checkQuery = $"SELECT COUNT(*) FROM Staffs WHERE Username = '{username}'";
                DataTable dt = DatabaseHelper.GetData(checkQuery);
                if (dt.Rows[0][0].ToString() != "0")
                {
                    MessageBox.Show("Tài khoản này đã tồn tại! Vui lòng chọn tên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Insert vào Database
                // Mặc định Role là 'Sale', IsActive là 1 (True)
                string insertQuery = $"INSERT INTO Staffs (Username, Password, FullName, Role, IsActive) " +
                                     $"VALUES ('{username}', '{password}', N'{fullName}', 'Sale', 1)";

                DatabaseHelper.ExecuteQuery(insertQuery);

                MessageBox.Show("Đăng ký thành công! Hãy đăng nhập ngay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Chuyển về màn hình đăng nhập
                BackToLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng ký: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- NÚT THOÁT ---
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // --- CLICK LINK "ĐĂNG NHẬP NGAY" ---
        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BackToLogin();
        }

        // Hàm chung để quay về Login
        private void BackToLogin()
        {
            this.Hide();
            // Vì FrmLogin là form khởi đầu, nó có thể đang ẩn (Hide) chứ chưa đóng
            // Cách an toàn là mở lại 1 instance mới hoặc hiện form cũ
            FrmLogin login = new FrmLogin();
            login.Show();
            // Form hiện tại (Register) sẽ đóng lại nhưng không tắt app vì login đã hiện
            // Lưu ý: Nếu muốn quản lý bộ nhớ tốt hơn có thể dùng ShowDialog ở Program.cs
        }
    }
}