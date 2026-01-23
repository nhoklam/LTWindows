namespace ADO_Example
{
    partial class FrmSystem
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpInput = new System.Windows.Forms.Panel();
            this.lblTitleInput = new System.Windows.Forms.Label();

            // Inputs
            this.lblKey = new System.Windows.Forms.Label(); this.txtKey = new System.Windows.Forms.TextBox(); this.lineKey = new System.Windows.Forms.Panel();
            this.lblValue = new System.Windows.Forms.Label(); this.txtValue = new System.Windows.Forms.TextBox(); this.lineValue = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label(); this.txtDesc = new System.Windows.Forms.TextBox(); this.lineDesc = new System.Windows.Forms.Panel();

            // Buttons
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            // List
            this.grpList = new System.Windows.Forms.Panel();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.pnlGridWrapper = new System.Windows.Forms.Panel();
            this.dgvConfig = new System.Windows.Forms.DataGridView();

            this.pnlMain.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpList.SuspendLayout();
            this.pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).BeginInit();
            this.SuspendLayout();

            // PnlMain
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMain.Controls.Add(this.grpList);
            this.pnlMain.Controls.Add(this.grpInput);

            // --- CARD 1: INPUT ---
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInput.Height = 220; // Thấp hơn chút vì ít nút
            this.grpInput.BackColor = System.Drawing.Color.White;
            this.grpInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);

            this.lblTitleInput.Text = "THIẾT LẬP THÔNG SỐ";
            this.lblTitleInput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleInput.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblTitleInput.Location = new System.Drawing.Point(25, 20);
            this.lblTitleInput.AutoSize = true;
            this.grpInput.Controls.Add(this.lblTitleInput);

            // Row 1
            SetupInput(this.grpInput, lblKey, txtKey, lineKey, "Mã Tham Số (Không sửa)", 30, 70, 200);
            this.txtKey.Enabled = false; this.txtKey.BackColor = System.Drawing.Color.White;

            SetupInput(this.grpInput, lblDesc, txtDesc, lineDesc, "Mô Tả Ý Nghĩa", 260, 70, 400);
            this.txtDesc.Enabled = false; this.txtDesc.BackColor = System.Drawing.Color.White; // Chỉ đọc

            // Row 2 (Quan trọng nhất)
            SetupInput(this.grpInput, lblValue, txtValue, lineValue, "GIÁ TRỊ THIẾT LẬP (Sửa tại đây)", 30, 140, 630);
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold); // Đậm lên cho dễ nhìn

            // Buttons
            int btnY = 160;
            // Chỉ cần nút Cập nhật và Làm mới (Không cho xóa/thêm tham số tùy tiện)
            SetupButton(this.grpInput, btnEdit, "LƯU CẤU HÌNH", System.Drawing.Color.FromArgb(255, 193, 7), 700, 130);

            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // --- CARD 2: LIST ---
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.BackColor = System.Drawing.Color.White;
            this.grpList.Padding = new System.Windows.Forms.Padding(20);
            this.grpList.BringToFront();

            this.lblListTitle.Text = "DANH SÁCH THAM SỐ HỆ THỐNG";
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblListTitle.Location = new System.Drawing.Point(20, 15);
            this.lblListTitle.AutoSize = true;
            this.grpList.Controls.Add(this.lblListTitle);

            // Grid Wrapper
            this.pnlGridWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridWrapper.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.grpList.Controls.Add(this.pnlGridWrapper);

            // Grid Style
            this.dgvConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConfig.BackgroundColor = System.Drawing.Color.White;
            this.dgvConfig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConfig.RowHeadersVisible = false;
            this.dgvConfig.EnableHeadersVisualStyles = false;
            this.dgvConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConfig.AllowUserToAddRows = false;
            this.dgvConfig.ReadOnly = true;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvConfig.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvConfig.ColumnHeadersHeight = 50;
            this.dgvConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(24, 161, 251);
            rowStyle.SelectionForeColor = System.Drawing.Color.White;
            rowStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvConfig.DefaultCellStyle = rowStyle;
            this.dgvConfig.RowTemplate.Height = 45;
            this.dgvConfig.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvConfig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConfig_CellClick);

            this.pnlGridWrapper.Controls.Add(this.dgvConfig);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSystem";
            this.Text = "FrmSystem";
            this.pnlMain.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpList.ResumeLayout(false);
            this.grpList.PerformLayout();
            this.pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).EndInit();
            this.ResumeLayout(false);
        }

        private void SetupInput(System.Windows.Forms.Panel p, System.Windows.Forms.Label l, System.Windows.Forms.TextBox t, System.Windows.Forms.Panel line, string text, int x, int y, int w)
        {
            l.Text = text; l.Font = new System.Drawing.Font("Segoe UI", 9F); l.ForeColor = System.Drawing.Color.Gray;
            l.AutoSize = true; l.Location = new System.Drawing.Point(x, y); p.Controls.Add(l);
            t.BorderStyle = System.Windows.Forms.BorderStyle.None; t.Font = new System.Drawing.Font("Segoe UI", 11F);
            t.Location = new System.Drawing.Point(x, y + 22); t.Size = new System.Drawing.Size(w, 25); p.Controls.Add(t);
            line.BackColor = System.Drawing.Color.Silver; line.Location = new System.Drawing.Point(x, y + 48); line.Size = new System.Drawing.Size(w, 2); p.Controls.Add(line);
        }
        private void SetupButton(System.Windows.Forms.Panel p, System.Windows.Forms.Button b, string text, System.Drawing.Color c, int x, int y)
        {
            b.Text = text; b.BackColor = c; b.ForeColor = System.Drawing.Color.White; b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0; b.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            b.Size = new System.Drawing.Size(160, 45); // Nút to hơn chút cho quan trọng
            b.Location = new System.Drawing.Point(x, y); b.Cursor = System.Windows.Forms.Cursors.Hand; p.Controls.Add(b);
        }

        private System.Windows.Forms.Panel pnlMain, grpInput, grpList, pnlGridWrapper;
        private System.Windows.Forms.Label lblTitleInput, lblListTitle;
        private System.Windows.Forms.DataGridView dgvConfig;
        private System.Windows.Forms.Label lblKey, lblValue, lblDesc;
        private System.Windows.Forms.TextBox txtKey, txtValue, txtDesc;
        private System.Windows.Forms.Panel lineKey, lineValue, lineDesc;
        private System.Windows.Forms.Button btnEdit, btnClear;
    }
}