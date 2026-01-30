using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ADO_Example
{
    public partial class FrmMain : Form
    {
        // --- KHAI BÁO BIẾN ---
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        // --- BẢNG MÀU CHUẨN ---
        private struct ThemeColor
        {
            public static Color Primary = Color.FromArgb(24, 30, 54);
            public static Color Darker = Color.FromArgb(15, 20, 40);
            public static Color ActiveBg = Color.FromArgb(40, 45, 70);
            public static Color TextInactive = Color.DarkGray;

            public static Color Color1 = Color.FromArgb(172, 126, 241);
            public static Color Color2 = Color.FromArgb(249, 118, 176);
            public static Color Color3 = Color.FromArgb(253, 138, 114);
            public static Color Color4 = Color.FromArgb(95, 77, 221);
            public static Color Color5 = Color.FromArgb(24, 161, 251);
            public static Color Color6 = Color.FromArgb(230, 126, 34);
        }

        // --- DLL KÉO THẢ FORM ---
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FrmMain()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 55);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        // --- SỰ KIỆN CLICK NÚT CHATBOT (MỚI) ---
        private void btnChatbot_Click(object sender, EventArgs e)
        {
            // Mở form chatbot dạng popup, không phải form con lồng vào panel
            FrmChatbot chatbot = new FrmChatbot();
            chatbot.Show();
        }

        // --- HIỆU ỨNG MENU ---
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = ThemeColor.ActiveBg;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

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

        // --- SỰ KIỆN MENU ---
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
            lblTitle.Text = "QUẢN LÝ TÒA KTX";
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeColor.Color3);
            OpenChildForm(new FrmRoom());
            lblTitle.Text = "QUẢN LÝ PHÒNG Ở";
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeColor.Color4);
            OpenChildForm(new FrmCustomer());
            lblTitle.Text = "HỒ SƠ SINH VIÊN";
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeColor.Color5);
            OpenChildForm(new FrmContract());
            lblTitle.Text = "HỢP ĐỒNG THUÊ KTX";
        }

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
            OpenChildForm(new FrmSystem());
            lblTitle.Text = "CẤU HÌNH HỆ THỐNG";
        }

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
                this.Close();
            }
        }
    }
}