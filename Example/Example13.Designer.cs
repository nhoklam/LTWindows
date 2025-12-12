namespace Example
{
    partial class Example13
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
            this.cb_Faculty = new System.Windows.Forms.ComboBox();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Faculty
            // 
            this.cb_Faculty.FormattingEnabled = true;
            this.cb_Faculty.Location = new System.Drawing.Point(30, 30);
            this.cb_Faculty.Name = "cb_Faculty";
            this.cb_Faculty.Size = new System.Drawing.Size(250, 21);
            this.cb_Faculty.TabIndex = 0;
            this.cb_Faculty.SelectedIndexChanged += new System.EventHandler(this.cb_Faculty_SelectedValueChanged);
            // Lưu ý: Slide 101 dùng sự kiện SelectedValueChanged
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(30, 70);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(250, 100);
            this.tbDisplay.TabIndex = 1;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(205, 190);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(120, 190);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // Example13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 240);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.cb_Faculty);
            this.Name = "Example13";
            this.Text = "ComboBox Article 13";
            this.Load += new System.EventHandler(this.Example13_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Faculty;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btClear;
    }
}