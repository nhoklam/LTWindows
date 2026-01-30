namespace ADO_Example
{
    partial class FrmChatbot
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            // [STYLE CONFIG]
            System.Drawing.Color colorPrimary = System.Drawing.Color.FromArgb(58, 110, 242); // Xanh chủ đạo
            System.Drawing.Color colorBg = System.Drawing.Color.FromArgb(244, 247, 254);    // Nền tổng thể
            System.Drawing.Color colorWhite = System.Drawing.Color.White;

            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlChatArea = new System.Windows.Forms.Panel();
            this.rtbHistory = new System.Windows.Forms.RichTextBox();

            this.pnlBottom = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lineInput = new System.Windows.Forms.Panel();

            this.pnlMain.SuspendLayout();
            this.pnlChatArea.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlMain (Container chính)
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.BackColor = colorBg;
            this.pnlMain.Controls.Add(this.pnlChatArea);
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(500, 600);
            this.pnlMain.TabIndex = 0;

            // 
            // pnlChatArea (Chứa nội dung chat)
            // 
            this.pnlChatArea.Controls.Add(this.rtbHistory);
            this.pnlChatArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChatArea.Padding = new System.Windows.Forms.Padding(15);
            this.pnlChatArea.Location = new System.Drawing.Point(0, 0);
            this.pnlChatArea.Name = "pnlChatArea";
            this.pnlChatArea.Size = new System.Drawing.Size(500, 530); // Chừa chỗ cho Bottom
            this.pnlChatArea.TabIndex = 1;

            // 
            // rtbHistory (Khung hiển thị tin nhắn)
            // 
            this.rtbHistory.BackColor = colorBg; // Cùng màu nền để tạo cảm giác trong suốt
            this.rtbHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbHistory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.rtbHistory.Location = new System.Drawing.Point(15, 15);
            this.rtbHistory.Name = "rtbHistory";
            this.rtbHistory.ReadOnly = true;
            this.rtbHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbHistory.Size = new System.Drawing.Size(470, 500);
            this.rtbHistory.TabIndex = 0;
            this.rtbHistory.Text = "";

            // 
            // pnlBottom (Khu vực nhập liệu)
            // 
            this.pnlBottom.BackColor = colorWhite;
            this.pnlBottom.Controls.Add(this.btnSend);
            this.pnlBottom.Controls.Add(this.lineInput);
            this.pnlBottom.Controls.Add(this.txtMessage);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 530);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(15);
            this.pnlBottom.Size = new System.Drawing.Size(500, 70);
            this.pnlBottom.TabIndex = 0;

            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMessage.Location = new System.Drawing.Point(20, 22);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(380, 27);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);

            // Placeholder Helper (Tự động thêm placeholder)
            SetupPlaceholder(this.txtMessage, "Nhập tin nhắn...");

            // 
            // lineInput (Đường kẻ dưới textbox cho đẹp)
            // 
            this.lineInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lineInput.Location = new System.Drawing.Point(20, 52);
            this.lineInput.Name = "lineInput";
            this.lineInput.Size = new System.Drawing.Size(380, 2);
            this.lineInput.TabIndex = 2;

            // 
            // btnSend
            // 
            this.btnSend.BackColor = colorPrimary;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(415, 15);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(70, 40);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // 
            // FrmChatbot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmChatbot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AI Assistant - Hỗ Trợ KTX";
            this.pnlMain.ResumeLayout(false);
            this.pnlChatArea.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);
        }

        // Helper Placeholder (Copy lại từ các form trước để dùng)
        private void SetupPlaceholder(System.Windows.Forms.TextBox txt, string placeholderText)
        {
            txt.Text = placeholderText;
            txt.ForeColor = System.Drawing.Color.Gray;
            txt.Tag = placeholderText;

            txt.Enter += (s, e) => {
                System.Windows.Forms.TextBox t = (System.Windows.Forms.TextBox)s;
                if (t.Text == (string)t.Tag)
                {
                    t.Text = "";
                    t.ForeColor = System.Drawing.Color.Black;
                }
            };

            txt.Leave += (s, e) => {
                System.Windows.Forms.TextBox t = (System.Windows.Forms.TextBox)s;
                if (string.IsNullOrWhiteSpace(t.Text))
                {
                    t.Text = (string)t.Tag;
                    t.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlChatArea;
        private System.Windows.Forms.RichTextBox rtbHistory;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel lineInput;
    }
}