namespace Example
{
    partial class Example16
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.cbFaculty = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ và tên";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(120, 22);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(30, 60);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(56, 13);
            this.lblDob.TabIndex = 2;
            this.lblDob.Text = "Ngày Sinh";
            // 
            // dtpDob
            // 
            this.dtpDob.CustomFormat = "dd/MM/yyyy";
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDob.Location = new System.Drawing.Point(120, 57);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(200, 20);
            this.dtpDob.TabIndex = 3;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rbFemale);
            this.grpGender.Controls.Add(this.rbMale);
            this.grpGender.Location = new System.Drawing.Point(120, 90);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(200, 50);
            this.grpGender.TabIndex = 4;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Giới tính";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(110, 20);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(39, 17);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(30, 20);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(47, 17);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(30, 160);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(32, 13);
            this.lblFaculty.TabIndex = 5;
            this.lblFaculty.Text = "Khoa";
            // 
            // cbFaculty
            // 
            this.cbFaculty.FormattingEnabled = true;
            this.cbFaculty.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Quản trị kinh doanh",
            "Kế toán",
            "Cơ khí"});
            this.cbFaculty.Location = new System.Drawing.Point(120, 157);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(200, 21);
            this.cbFaculty.TabIndex = 6;
            this.cbFaculty.SelectedIndex = 0; // Chọn mặc định cái đầu tiên
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(30, 200);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Trạng thái";
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(120, 200);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDisplay.Size = new System.Drawing.Size(240, 120);
            this.tbDisplay.TabIndex = 8;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(150, 340);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(240, 340);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 10;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Example16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 380);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbFaculty);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Name = "Example16";
            this.Text = "Quản lý sinh viên";
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btExit;
    }
}