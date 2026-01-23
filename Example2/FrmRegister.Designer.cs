namespace ADO_Example
{
    partial class FrmRegister
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lnkLogin = new System.Windows.Forms.LinkLabel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();

            // --- Các ô nhập liệu ---
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lineUser = new System.Windows.Forms.Panel();

            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lineName = new System.Windows.Forms.Panel();

            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.linePass = new System.Windows.Forms.Panel();

            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lineConfirm = new System.Windows.Forms.Panel();

            this.btnExit = new System.Windows.Forms.Button();

            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelLeft (Chứa ảnh)
            // 
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(400, 650);
            this.panelLeft.TabIndex = 0;

            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            // Đảm bảo bạn đã thêm ảnh vào Resources và đúng namespace ADO_Example
            this.pictureBox1.Image = global::Example2.Properties.Resources.Login;
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 650);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            // 
            // panelRight (Chứa form đăng ký)
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.btnExit);
            this.panelRight.Controls.Add(this.lnkLogin);
            this.panelRight.Controls.Add(this.labelLogin);
            this.panelRight.Controls.Add(this.btnRegister);
            this.panelRight.Controls.Add(this.lblTitle);

            // Add Controls: User
            this.panelRight.Controls.Add(this.lblUser);
            this.panelRight.Controls.Add(this.txtUser);
            this.panelRight.Controls.Add(this.lineUser);
            // Add Controls: Name
            this.panelRight.Controls.Add(this.lblName);
            this.panelRight.Controls.Add(this.txtName);
            this.panelRight.Controls.Add(this.lineName);
            // Add Controls: Pass
            this.panelRight.Controls.Add(this.lblPass);
            this.panelRight.Controls.Add(this.txtPass);
            this.panelRight.Controls.Add(this.linePass);
            // Add Controls: Confirm
            this.panelRight.Controls.Add(this.lblConfirm);
            this.panelRight.Controls.Add(this.txtConfirmPass);
            this.panelRight.Controls.Add(this.lineConfirm);

            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(400, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(450, 650);
            this.panelRight.TabIndex = 1;

            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(410, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // --- GROUP 1: TÀI KHOẢN ---
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblUser.Location = new System.Drawing.Point(50, 110);
            this.lblUser.Text = "Tên đăng nhập (Username)";

            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUser.Location = new System.Drawing.Point(55, 135);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(340, 20);

            this.lineUser.BackColor = System.Drawing.Color.Silver;
            this.lineUser.Location = new System.Drawing.Point(50, 160);
            this.lineUser.Size = new System.Drawing.Size(350, 2);

            // --- GROUP 2: HỌ TÊN ---
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblName.Location = new System.Drawing.Point(50, 180);
            this.lblName.Text = "Họ và Tên (Full Name)";

            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtName.Location = new System.Drawing.Point(55, 205);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 20);

            this.lineName.BackColor = System.Drawing.Color.Silver;
            this.lineName.Location = new System.Drawing.Point(50, 230);
            this.lineName.Size = new System.Drawing.Size(350, 2);

            // --- GROUP 3: MẬT KHẨU ---
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPass.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPass.Location = new System.Drawing.Point(50, 250);
            this.lblPass.Text = "Mật khẩu";

            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPass.Location = new System.Drawing.Point(55, 275);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(340, 20);
            this.txtPass.UseSystemPasswordChar = true;

            this.linePass.BackColor = System.Drawing.Color.Silver;
            this.linePass.Location = new System.Drawing.Point(50, 300);
            this.linePass.Size = new System.Drawing.Size(350, 2);

            // --- GROUP 4: NHẬP LẠI MẬT KHẨU ---
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblConfirm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblConfirm.Location = new System.Drawing.Point(50, 320);
            this.lblConfirm.Text = "Nhập lại mật khẩu";

            this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirmPass.Location = new System.Drawing.Point(55, 345);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(340, 20);
            this.txtConfirmPass.UseSystemPasswordChar = true;

            this.lineConfirm.BackColor = System.Drawing.Color.Silver;
            this.lineConfirm.Location = new System.Drawing.Point(50, 370);
            this.lineConfirm.Size = new System.Drawing.Size(350, 2);

            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(75, 410);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(300, 50);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "ĐĂNG KÝ";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // 
            // labelLogin (Text: Đã có tài khoản?)
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelLogin.ForeColor = System.Drawing.Color.Gray;
            this.labelLogin.Location = new System.Drawing.Point(110, 480);
            this.labelLogin.Text = "Đã có tài khoản?";

            // 
            // lnkLogin (Text: Đăng nhập ngay)
            // 
            this.lnkLogin.AutoSize = true;
            this.lnkLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkLogin.LinkColor = System.Drawing.Color.MidnightBlue;
            this.lnkLogin.Location = new System.Drawing.Point(230, 480);
            this.lnkLogin.Text = "Đăng nhập ngay";
            this.lnkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogin_LinkClicked);

            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký";
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel lineUser;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel lineName;

        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel linePass;

        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Panel lineConfirm;

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.LinkLabel lnkLogin;
    }
}