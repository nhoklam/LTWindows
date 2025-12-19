namespace Example
{
    partial class Example09
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
            btThoat = new Button();
            btNhan = new Button();
            btCong = new Button();
            tbSoY = new TextBox();
            tbKetQua = new TextBox();
            tbSoX = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btLuu = new Button();
            SuspendLayout();
            // 
            // btThoat
            // 
            btThoat.Location = new Point(231, 196);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(50, 23);
            btThoat.TabIndex = 17;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(175, 196);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(50, 23);
            btNhan.TabIndex = 16;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btCong
            // 
            btCong.Location = new Point(119, 196);
            btCong.Name = "btCong";
            btCong.Size = new Size(50, 23);
            btCong.TabIndex = 15;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // tbSoY
            // 
            tbSoY.Location = new Point(83, 67);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(198, 23);
            tbSoY.TabIndex = 14;
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(83, 98);
            tbKetQua.Multiline = true;
            tbKetQua.Name = "tbKetQua";
            tbKetQua.Size = new Size(198, 92);
            tbKetQua.TabIndex = 13;
            // 
            // tbSoX
            // 
            tbSoX.Location = new Point(83, 33);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(198, 23);
            tbSoX.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 102);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 11;
            label3.Text = "Kết quả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 71);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 10;
            label2.Text = "Số y";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 36);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 9;
            label1.Text = "Số x";
            // 
            // btLuu
            // 
            btLuu.Location = new Point(35, 196);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(50, 23);
            btLuu.TabIndex = 18;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = true;
            btLuu.Click += btLuu_Click;
            // 
            // Example09
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 256);
            Controls.Add(btLuu);
            Controls.Add(btThoat);
            Controls.Add(btNhan);
            Controls.Add(btCong);
            Controls.Add(tbSoY);
            Controls.Add(tbKetQua);
            Controls.Add(tbSoX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Example09";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btThoat;
        private Button btNhan;
        private Button btCong;
        private TextBox tbSoY;
        private TextBox tbKetQua;
        private TextBox tbSoX;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btLuu;
    }
}