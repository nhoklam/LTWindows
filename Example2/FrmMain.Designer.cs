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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            // Nút mới
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            // Thứ tự Add rất quan trọng khi dùng Dock.Top (Add sau cùng sẽ nằm trên cùng)
            this.panelMenu.Controls.Add(this.btnLogout);   // Bottom

            // Nhóm Menu Chính (Dock Top - Add ngược từ dưới lên)
            this.panelMenu.Controls.Add(this.btnSystem);
            this.panelMenu.Controls.Add(this.btnStaff);
            this.panelMenu.Controls.Add(this.btnService);  // <--- Nút Dịch Vụ Mới
            this.panelMenu.Controls.Add(this.btnContract);
            this.panelMenu.Controls.Add(this.btnCustomer);
            this.panelMenu.Controls.Add(this.btnRoom);
            this.panelMenu.Controls.Add(this.btnBuilding);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);

            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(260, 750);
            this.panelMenu.TabIndex = 0;

            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLogout.Location = new System.Drawing.Point(0, 690);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(260, 60);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // 
            // btnSystem
            // 
            this.btnSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystem.FlatAppearance.BorderSize = 0;
            this.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystem.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnSystem.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSystem.Location = new System.Drawing.Point(0, 540);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSystem.Size = new System.Drawing.Size(260, 55);
            this.btnSystem.TabIndex = 8;
            this.btnSystem.Text = "Cấu Hình Hệ Thống";
            this.btnSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystem.UseVisualStyleBackColor = true;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);

            // 
            // btnStaff
            // 
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnStaff.ForeColor = System.Drawing.Color.DarkGray;
            this.btnStaff.Location = new System.Drawing.Point(0, 485);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnStaff.Size = new System.Drawing.Size(260, 55);
            this.btnStaff.TabIndex = 7;
            this.btnStaff.Text = "Nhân Sự & Phân Quyền";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);

            // 
            // btnService (NÚT MỚI)
            // 
            this.btnService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnService.FlatAppearance.BorderSize = 0;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnService.ForeColor = System.Drawing.Color.DarkGray;
            this.btnService.Location = new System.Drawing.Point(0, 430);
            this.btnService.Name = "btnService";
            this.btnService.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnService.Size = new System.Drawing.Size(260, 55);
            this.btnService.TabIndex = 6;
            this.btnService.Text = "Dịch Vụ & Tiện Ích";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);

            // 
            // btnContract
            // 
            this.btnContract.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContract.FlatAppearance.BorderSize = 0;
            this.btnContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContract.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnContract.ForeColor = System.Drawing.Color.DarkGray;
            this.btnContract.Location = new System.Drawing.Point(0, 375);
            this.btnContract.Name = "btnContract";
            this.btnContract.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnContract.Size = new System.Drawing.Size(260, 55);
            this.btnContract.TabIndex = 5;
            this.btnContract.Text = "Hợp Đồng";
            this.btnContract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContract.UseVisualStyleBackColor = true;
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);

            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnCustomer.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.Location = new System.Drawing.Point(0, 320);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(260, 55);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.Text = "Thông Tin Cư Dân";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);

            // 
            // btnRoom
            // 
            this.btnRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnRoom.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRoom.Location = new System.Drawing.Point(0, 265);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnRoom.Size = new System.Drawing.Size(260, 55);
            this.btnRoom.TabIndex = 3;
            this.btnRoom.Text = "Căn Hộ & Penthouse";
            this.btnRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);

            // 
            // btnBuilding
            // 
            this.btnBuilding.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuilding.FlatAppearance.BorderSize = 0;
            this.btnBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuilding.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnBuilding.ForeColor = System.Drawing.Color.DarkGray;
            this.btnBuilding.Location = new System.Drawing.Point(0, 210);
            this.btnBuilding.Name = "btnBuilding";
            this.btnBuilding.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBuilding.Size = new System.Drawing.Size(260, 55);
            this.btnBuilding.TabIndex = 2;
            this.btnBuilding.Text = "Quản Lý Tòa Tháp";
            this.btnBuilding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuilding.UseVisualStyleBackColor = true;
            this.btnBuilding.Click += new System.EventHandler(this.btnBuilding_Click);

            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnDashboard.ForeColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.Location = new System.Drawing.Point(0, 155);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(260, 55);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Tổng Quan";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);

            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.panelLogo.Controls.Add(this.lblSubLogo);
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(260, 155);
            this.panelLogo.TabIndex = 0;
            // 
            // lblSubLogo
            // 
       
            // 
            // lblLogo (Đã đổi tên)
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(40, 45);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(160, 38);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "QUẢN LÝ TÒA NHÀ";
            this.lblLogo.Click += new System.EventHandler(this.btnHome_Click);

            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(260, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(940, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);

            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.DimGray;
            this.btnExit.Location = new System.Drawing.Point(895, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "✕";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaximize.ForeColor = System.Drawing.Color.DimGray;
            this.btnMaximize.Location = new System.Drawing.Point(850, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 30);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Text = "▢";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);

            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.DimGray;
            this.btnMinimize.Location = new System.Drawing.Point(805, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 30);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "—";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(75, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(152, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "TRANG CHỦ";

            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(25, 25);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(35, 35);
            this.iconCurrentChildForm.TabIndex = 0;

            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(260, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(940, 670);
            this.panelDesktop.TabIndex = 2;

            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ TÒA NHÀ";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBuilding;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.Button btnService; // Nút mới
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnSystem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblSubLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel iconCurrentChildForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel panelDesktop;
    }
}