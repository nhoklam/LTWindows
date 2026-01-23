using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ADO_Example
{
    public partial class FrmMain : Form
    {
        // --- 1. KHAI BÁO BIẾN ---
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        // --- 2. BẢNG MÀU CHUẨN (Theme Steinway: Sang trọng & Hiện đại) ---
        private struct ThemeColor
        {
            public static Color Primary = Color.FromArgb(24, 30, 54); // Nền Menu
            public static Color Darker = Color.FromArgb(15, 20, 40);  // Nền Logo
            public static Color ActiveBg = Color.FromArgb(40, 45, 70); // Nền nút khi chọn
            public static Color TextInactive = Color.DarkGray;

            // Màu highlight cho từng mục (Pastel Neon)
            public static Color Color1 = Color.FromArgb(172, 126, 241); // Dashboard
            public static Color Color2 = Color.FromArgb(249, 118, 176); // Building
            public static Color Color3 = Color.FromArgb(253, 138, 114); // Room
            public static Color Color4 = Color.FromArgb(95, 77, 221);  // Customer
            public static Color Color5 = Color.FromArgb(24, 161, 251); // Contract
            public static Color Color6 = Color.FromArgb(230, 126, 34); // Service (Màu Cam mới)
        }

        // --- 3. DLL KÉO THẢ FORM ---
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FrmMain()
        {
            InitializeComponent();

            // Khởi tạo thanh highlight bên trái
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 55);
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
                currentBtn.BackColor = ThemeColor.ActiveBg;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);

                // Di chuyển thanh màu
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Đổi icon/panel trên TitleBar
                iconCurrentChildForm.BackColor = color;
                lblTitle.ForeColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = ThemeColor.Primary;
                currentBtn.ForeColor = ThemeColor.TextInactive;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            }
        }

        // --- 5. MỞ FORM CON ---
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
            lblTitle.Text = "QUẢN LÝ CĂN HỘ"; // Đổi tên cho sang
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeColor.Color4);
            OpenChildForm(new FrmCustomer());
            lblTitle.Text = "THÔNG TIN CƯ DÂN"; // Đổi tên cho sang
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeColor.Color5);
            OpenChildForm(new FrmContract());
            lblTitle.Text = "HỢP ĐỒNG THUÊ";
        }

        // NÚT MỚI: DỊCH VỤ
        private void btnService_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeColor.Color6);
            OpenChildForm(new FrmService());
            lblTitle.Text = "DỊCH VỤ & TIỆN ÍCH";
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeColor.Color2);
            OpenChildForm(new FrmStaff());
            lblTitle.Text = "NHÂN SỰ & PHÂN QUYỀN";
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gray);
            OpenChildForm(new FrmSystem()); // Nếu chưa có form này thì comment lại
            lblTitle.Text = "CẤU HÌNH HỆ THỐNG";
        }

        // --- 7. CÁC NÚT ĐIỀU HƯỚNG CỬA SỔ ---
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
            lblTitle.Text = "SẢNH CHÍNH (LOBBY)";
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
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close(); // Hoặc mở lại form Login
            }
        }
    }
}