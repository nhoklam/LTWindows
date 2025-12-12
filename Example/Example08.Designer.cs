namespace Example
{
    partial class Example08
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbSoX = new TextBox();
            tbKetQua = new TextBox();
            tbSoY = new TextBox();
            btCong = new Button();
            btNhan = new Button();
            btThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 80);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Số x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 115);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Số y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 146);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Kết quả";
            // 
            // tbSoX
            // 
            tbSoX.Location = new Point(129, 77);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(198, 23);
            tbSoX.TabIndex = 3;
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(129, 142);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.Size = new Size(198, 23);
            tbKetQua.TabIndex = 4;
            // 
            // tbSoY
            // 
            tbSoY.Location = new Point(129, 111);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(198, 23);
            tbSoY.TabIndex = 5;
            // 
            // btCong
            // 
            btCong.Location = new Point(84, 183);
            btCong.Name = "btCong";
            btCong.Size = new Size(75, 23);
            btCong.TabIndex = 6;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(165, 183);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(75, 23);
            btNhan.TabIndex = 7;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(246, 183);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(75, 23);
            btThoat.TabIndex = 8;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // Example08
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btThoat);
            Controls.Add(btNhan);
            Controls.Add(btCong);
            Controls.Add(tbSoY);
            Controls.Add(tbKetQua);
            Controls.Add(tbSoX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Example08";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbSoX;
        private TextBox tbKetQua;
        private TextBox tbSoY;
        private Button btCong;
        private Button btNhan;
        private Button btThoat;
    }
}