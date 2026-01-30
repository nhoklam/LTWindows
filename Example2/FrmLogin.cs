using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices; // Thư viện để kéo thả form
using System.Windows.Forms;

namespace ADO_Example
{
    // QUAN TRỌNG: Phải có ": Form" để sửa lỗi AutoScaleDimensions, ClientSize...
    public partial class FrmLogin : Form
    {
        // --- Code để di chuyển Form không viền (Borderless) ---
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // --- SỰ KIỆN NÚT ĐĂNG NHẬP ---
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- KẾT NỐI SQL SERVER ---
            try
            {
                // Gọi hàm lấy dữ liệu từ DatabaseHelper
                // Đảm bảo bạn đã có bảng Staffs và DatabaseHelper như hướng dẫn trước
                string query = $"SELECT * FROM Staffs WHERE Username = '{username}' AND Password = '{password}' AND IsActive = 1";
                DataTable dt = DatabaseHelper.GetData(query);

                if (dt.Rows.Count > 0)
                {
                    // Đăng nhập thành công
                    string role = dt.Rows[0]["Role"].ToString();
                    string fullName = dt.Rows[0]["FullName"].ToString();

                    MessageBox.Show($"Xin chào {fullName}!", "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    if (role == "Admin" || role == "Sale")
                    {
                        // Mở form Admin
                        FrmMain frmAdmin = new FrmMain();
                        frmAdmin.ShowDialog();
                    }
                    else
                    {
                        // Mở form Cư dân (Demo) hoặc Nhân viên khác
                        FrmPortal frmUser = new FrmPortal(fullName);
                        frmUser.ShowDialog();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản, mật khẩu hoặc tài khoản đã bị khóa!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Trường hợp chưa cấu hình xong Database thì cho đăng nhập test bằng nick admin/123
                if (username == "admin" && password == "123")
                {
                    this.Hide();
                    new FrmMain().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message + "\n(Tạm thời dùng admin/123 để test giao diện)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- SỰ KIỆN NÚT THOÁT (X) ---
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // --- SỰ KIỆN KÉO FORM ---
        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}