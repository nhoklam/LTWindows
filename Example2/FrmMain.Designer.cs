using System.Windows.Forms;

namespace ADO_Example
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // [STYLE CONFIG]
            System.Drawing.Color colorSidebar = System.Drawing.Color.FromArgb(24, 30, 54); // Màu nền Menu
            System.Drawing.Color colorActiveBtn = System.Drawing.Color.FromArgb(46, 51, 73); // Màu khi chọn
            System.Drawing.Color colorBg = System.Drawing.Color.FromArgb(244, 247, 254);    // Màu nền Desktop

            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnContract = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnBuilding = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblSubLogo = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();

            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnChatbot = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new System.Windows.Forms.Panel(); // Giả lập icon tiêu đề
            this.panelDesktop = new System.Windows.Forms.Panel();

            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelMenu (Sidebar)
            // 
            this.panelMenu.BackColor = colorSidebar;
            this.panelMenu.Controls.Add(this.btnLogout);   // Bottom

            // Add Buttons (Thứ tự ngược vì Dock=Top)
            this.panelMenu.Controls.Add(this.btnSystem);
            this.panelMenu.Controls.Add(this.btnStaff);
            this.panelMenu.Controls.Add(this.btnService);
            this.panelMenu.Controls.Add(this.btnContract);
            this.panelMenu.Controls.Add(this.btnCustomer);
            this.panelMenu.Controls.Add(this.btnRoom);
            this.panelMenu.Controls.Add(this.btnBuilding);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);

            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Size = new System.Drawing.Size(260, 750);
            this.panelMenu.TabIndex = 0;

            // 
            // SETUP MENU BUTTONS (Dùng Helper cho gọn)
            // 
            SetupMenuButton(btnLogout, "Đăng Xuất", 0, DockStyle.Bottom);
            btnLogout.ForeColor = System.Drawing.Color.IndianRed; // Riêng nút Logout màu đỏ nhạt

            SetupMenuButton(btnSystem, "Cấu Hình Hệ Thống", 8, DockStyle.Top);
            SetupMenuButton(btnStaff, "Nhân Sự & Phân Quyền", 7, DockStyle.Top);
            SetupMenuButton(btnService, "Dịch Vụ & Tiện Ích", 6, DockStyle.Top);
            SetupMenuButton(btnContract, "Quản Lý Hợp Đồng", 5, DockStyle.Top);
            SetupMenuButton(btnCustomer, "Hồ Sơ Sinh Viên", 4, DockStyle.Top);
            SetupMenuButton(btnRoom, "Quản Lý Phòng KTX", 3, DockStyle.Top);
            SetupMenuButton(btnBuilding, "Quản Lý Tòa Nhà", 2, DockStyle.Top);
            SetupMenuButton(btnDashboard, "Tổng Quan (Dashboard)", 1, DockStyle.Top);

            // Events Click
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            this.btnBuilding.Click += new System.EventHandler(this.btnBuilding_Click);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);

            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(15, 20, 40); // Đậm hơn nền menu chút
            this.panelLogo.Controls.Add(this.lblSubLogo);
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Size = new System.Drawing.Size(260, 140);
            this.panelLogo.TabIndex = 0;

            // lblLogo
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(45, 40);
            this.lblLogo.Text = "KTX MANAGER";

            // lblSubLogo (Text nhỏ dưới logo)
            this.lblSubLogo.AutoSize = true;
            this.lblSubLogo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubLogo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubLogo.Location = new System.Drawing.Point(75, 80);
            this.lblSubLogo.Text = "Ver 2.0.1";
            this.panelLogo.Controls.Add(this.lblSubLogo);

            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.btnChatbot);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(260, 0);
            this.panelTitleBar.Size = new System.Drawing.Size(940, 70); // Cao 70px
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);

            // 
            // btnChatbot (AI BUTTON)
            // 
            this.btnChatbot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChatbot.BackColor = System.Drawing.Color.FromArgb(255, 128, 0); // Màu Cam nổi bật
            this.btnChatbot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChatbot.FlatAppearance.BorderSize = 0;
            this.btnChatbot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChatbot.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnChatbot.ForeColor = System.Drawing.Color.White;
            this.btnChatbot.Location = new System.Drawing.Point(630, 15);
            this.btnChatbot.Size = new System.Drawing.Size(120, 40);
            this.btnChatbot.Text = "🤖 Trợ Lý AI";
            this.btnChatbot.UseVisualStyleBackColor = false;
            this.btnChatbot.Click += new System.EventHandler(this.btnChatbot_Click);

            // Window Controls (Exit/Max/Min)
            SetupWindowControl(btnExit, "✕", 895, System.Drawing.Color.IndianRed);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            SetupWindowControl(btnMaximize, "▢", 850, System.Drawing.Color.DimGray);
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);

            SetupWindowControl(btnMinimize, "—", 805, System.Drawing.Color.DimGray);
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);

            // Title
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblTitle.Location = new System.Drawing.Point(70, 22);
            this.lblTitle.Text = "TỔNG QUAN";

            // Icon Placeholder (Màu tím làm điểm nhấn)
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(25, 20);
            this.iconCurrentChildForm.Size = new System.Drawing.Size(30, 30);

            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = colorBg; // Màu nền xám xanh nhạt
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(260, 70);
            this.panelDesktop.Size = new System.Drawing.Size(940, 680);

            // Form Main
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTX Management System";

            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
        }

        // --- HELPER METHODS CHO GỌN CODE ---

        private void SetupMenuButton(System.Windows.Forms.Button btn, string text, int index, System.Windows.Forms.DockStyle dock)
        {
            btn.Dock = dock;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            btn.ForeColor = System.Drawing.Color.Gainsboro; // Màu chữ xám trắng
            btn.Location = new System.Drawing.Point(0, 0);
            btn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0); // Padding để chừa chỗ cho Icon nếu có
            btn.Size = new System.Drawing.Size(260, 55);
            btn.TabIndex = index;
            btn.Text = text;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.UseVisualStyleBackColor = true;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void SetupWindowControl(System.Windows.Forms.Button btn, string text, int x, System.Drawing.Color hoverColor)
        {
            btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.Gray;
            btn.Location = new System.Drawing.Point(x, 0);
            btn.Size = new System.Drawing.Size(45, 30);
            btn.Text = text;
            btn.UseVisualStyleBackColor = true;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnDashboard, btnBuilding, btnRoom, btnCustomer, btnContract, btnService, btnStaff, btnSystem, btnLogout;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogo, lblSubLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel iconCurrentChildForm;
        private System.Windows.Forms.Button btnExit, btnMaximize, btnMinimize, btnChatbot;
        private System.Windows.Forms.Panel panelDesktop;
    }
}