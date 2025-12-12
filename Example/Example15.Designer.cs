namespace Example
{
    partial class Example15
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
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(30, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy"; // Định dạng hiển thị ngày/tháng/năm
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(70, 32);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(195, 70);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // Example15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 120);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Name = "Example15";
            this.Text = "DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btOK;
    }
}