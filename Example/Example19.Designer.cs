namespace Example
{
    partial class Example19
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
            this.lblId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(30, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(72, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Mã nhân viên";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(120, 27);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(150, 20);
            this.tbId.TabIndex = 1;
            this.tbId.Text = "03152482001";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tên nhân viên";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(120, 67);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(250, 20);
            this.tbName.TabIndex = 3;
            this.tbName.Text = "Nguyễn Văn Hùng";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(30, 110);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(46, 13);
            this.lblImage.TabIndex = 4;
            this.lblImage.Text = "Ảnh 3x4";
            // 
            // pbImage (Slide 128)
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; // Tạo viền để dễ nhìn
            this.pbImage.Location = new System.Drawing.Point(120, 110);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(120, 160); // Kích thước tỷ lệ 3x4
            this.pbImage.TabIndex = 5;
            this.pbImage.TabStop = false;
            // 
            // btFile (Slide 128)
            // 
            this.btFile.Location = new System.Drawing.Point(260, 110);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(110, 30);
            this.btFile.TabIndex = 6;
            this.btFile.Text = "Chọn ảnh ...";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // Example19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lblId);
            this.Name = "Example19";
            this.Text = "Quản lý nhân sự";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btFile;
    }
}