using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ADO_Example // Đảm bảo namespace đúng
{
    public partial class FrmMain : Form
    {
        // --- 1. KHAI BÁO BIẾN ---
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        // --- 2. BẢNG MÀU CHUẨN (Modern Palette) ---
        private struct ThemeColor
        {
            public static Color Primary = Color.FromArgb(24, 30, 54); // Màu nền Menu (Dark Navy)
            public static Color Darker = Color.FromArgb(15, 20, 40);  // Màu nền Logo (Đậm hơn)
            public static Color ActiveBg = Color.FromArgb(40, 45, 70); // Màu nền nút khi chọn
            public static Color TextActive = Color.White;
            public static Color TextInactive = Color.DarkGray;

            // Màu highlight cho từng mục (Pastel Neon)
            public static Color Color1 = Color.FromArgb(172, 126, 241);
            public static Color Color2 = Color.FromArgb(249, 118, 176);
            public static Color Color3 = Color.FromArgb(253, 138, 114);
            public static Color Color4 = Color.FromArgb(95, 77, 221);
            public static Color Color5 = Color.FromArgb(24, 161, 251);
        }

        // --- 3. DLL KÉO THẢ FORM ---
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FrmMain()
        {
            InitializeComponent();

            // Khởi tạo thanh highlight
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 55); // Thanh mảnh, tinh tế hơn
            panelMenu.Controls.Add(leftBorderBtn);

            // Cấu hình Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        // --- 4. HIỆU ỨNG NÚT MENU ---
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton(); // Reset nút cũ

                // Style nút mới
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = ThemeColor.ActiveBg; // Nền sáng hơn một chút
                currentBtn.ForeColor = color; // Chữ theo màu highlight
                currentBtn.TextAlign = ContentAlignment.MiddleCenter; // Chữ ra giữa
                currentBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold); // Chữ đậm hơn

                // Di chuyển thanh màu
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Đổi icon/panel trên TitleBar
                iconCurrentChildForm.BackColor = color;
                lblTitle.ForeColor = color; // Tiêu đề cùng màu highlight
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = ThemeColor.Primary; // Về màu gốc
                currentBtn.ForeColor = ThemeColor.TextInactive;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            }
        }

        // --- 5. MỞ FORM CON (SPA) ---
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null) currentChildForm.Close();

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // --- 6. SỰ KIỆN CLICK MENU ---
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeColor.Color1);
            OpenChildForm(new FrmDashboard());
            lblTitle.Text = "TỔNG QUAN HỆ THỐNG";
        }

        private void btnBuilding_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeColor.Color2);
            OpenChildForm(new FrmBuilding());
            lblTitle.Text = "QUẢN LÝ TÒA NHÀ";
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeColor.Color3);
            OpenChildForm(new FrmRoom());
            lblTitle.Text = "QUẢN LÝ MẶT BẰNG";
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeColor.Color4);
            OpenChildForm(new FrmCustomer());
            lblTitle.Text = "QUẢN LÝ KHÁCH HÀNG";
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeColor.Color5);
            OpenChildForm(new FrmContract());
            lblTitle.Text = "HỢP ĐỒNG & GIAO DỊCH";
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeColor.Color2); // Tái sử dụng màu
            OpenChildForm(new FrmStaff());
            lblTitle.Text = "NHÂN SỰ & PHÂN QUYỀN";
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gray);
            OpenChildForm(new FrmSystem());
            lblTitle.Text = "CẤU HÌNH HỆ THỐNG";
        }

        // --- 7. CÁC NÚT ĐIỀU HƯỚNG ---
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null) currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.BackColor = Color.MediumPurple;
            lblTitle.Text = "TRANG CHỦ";
            lblTitle.ForeColor = Color.Gainsboro;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e) { Application.Exit(); }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            //new FrmLogin().ShowDialog(); // Uncomment dòng này nếu muốn mở lại form login
            this.Close();
        }
    }
}