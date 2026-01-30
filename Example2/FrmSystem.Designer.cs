namespace ADO_Example
{
    partial class FrmSystem
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // [STYLE CONFIG] - Bộ màu đồng nhất
            System.Drawing.Color colorPrimary = System.Drawing.Color.FromArgb(58, 110, 242);
            System.Drawing.Color colorBg = System.Drawing.Color.FromArgb(244, 247, 254);
            System.Drawing.Color colorText = System.Drawing.Color.FromArgb(64, 70, 85);
            System.Drawing.Color colorGray = System.Drawing.Color.FromArgb(160, 165, 185);

            // Grid Styles
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle altRowStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpInput = new System.Windows.Forms.Panel();
            this.lblTitleInput = new System.Windows.Forms.Label();

            // Inputs
            this.lblKey = new System.Windows.Forms.Label(); this.txtKey = new System.Windows.Forms.TextBox(); this.lineKey = new System.Windows.Forms.Panel();
            this.lblValue = new System.Windows.Forms.Label(); this.txtValue = new System.Windows.Forms.TextBox(); this.lineValue = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label(); this.txtDesc = new System.Windows.Forms.TextBox(); this.lineDesc = new System.Windows.Forms.Panel();

            // Buttons
            this.btnEdit = new System.Windows.Forms.Button();

            // List Panel
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

            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.BackColor = colorBg;
            this.pnlMain.Padding = new System.Windows.Forms.Padding(25);
            this.pnlMain.Controls.Add(this.grpList);
            this.pnlMain.Controls.Add(this.grpInput);

            // 
            // --- CARD 1: CONFIG INPUT ---
            // 
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInput.Height = 240; // Chiều cao vừa đủ
            this.grpInput.BackColor = System.Drawing.Color.White;
            this.grpInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);

            this.lblTitleInput.Text = "THIẾT LẬP THAM SỐ";
            this.lblTitleInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleInput.ForeColor = colorPrimary;
            this.lblTitleInput.Location = new System.Drawing.Point(30, 25);
            this.lblTitleInput.AutoSize = true;
            this.grpInput.Controls.Add(this.lblTitleInput);

            // Row 1: Key & Description (READ ONLY AREA)
            // Key
            SetupInput(this.grpInput, lblKey, txtKey, lineKey, "MÃ THAM SỐ (KEY)", 35, 70, 250);
            this.txtKey.ReadOnly = true;
            this.txtKey.BackColor = System.Drawing.Color.White;
            this.txtKey.ForeColor = System.Drawing.Color.DimGray; // Màu đậm hơn chút để dễ đọc dù là ReadOnly

            // Description
            SetupInput(this.grpInput, lblDesc, txtDesc, lineDesc, "MÔ TẢ Ý NGHĨA", 320, 70, 450);
            this.txtDesc.ReadOnly = true;
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.ForeColor = System.Drawing.Color.DimGray;

            // Row 2: Value & Action (EDIT AREA)
            // Value - Đây là nhân vật chính, cần làm nổi bật
            SetupInput(this.grpInput, lblValue, txtValue, lineValue, "GIÁ TRỊ CẤU HÌNH (VALUE)", 35, 150, 535);
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); // Chữ to, đậm
            this.txtValue.ForeColor = colorPrimary; // Màu xanh để nhấn mạnh đây là cái cần sửa
            this.lineValue.BackColor = colorPrimary; // Gạch chân màu xanh luôn

            // Button Save - Đặt ngay cạnh ô Value để tiện tay bấm
            SetupButton(this.grpInput, btnEdit, "Lưu Thay Đổi", colorPrimary, 600, 145);

            // Event
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // 
            // --- CARD 2: LIST ---
            // 
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.BackColor = System.Drawing.Color.White;
            this.grpList.Padding = new System.Windows.Forms.Padding(25);
            this.grpList.BringToFront();

            this.lblListTitle.Text = "Danh Sách Cấu Hình";
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = colorText;
            this.lblListTitle.Location = new System.Drawing.Point(20, 20);
            this.lblListTitle.AutoSize = true;
            this.grpList.Controls.Add(this.lblListTitle);

            // Grid Wrapper
            this.pnlGridWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridWrapper.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.grpList.Controls.Add(this.pnlGridWrapper);

            // Grid Style (Copy từ FrmStaff sang cho đồng bộ)
            this.dgvConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConfig.BackgroundColor = System.Drawing.Color.White;
            this.dgvConfig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConfig.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvConfig.RowHeadersVisible = false;
            this.dgvConfig.EnableHeadersVisualStyles = false;
            this.dgvConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConfig.AllowUserToAddRows = false;
            this.dgvConfig.ReadOnly = true;

            // Header
            headerStyle.BackColor = System.Drawing.Color.White;
            headerStyle.ForeColor = colorGray;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            headerStyle.SelectionBackColor = System.Drawing.Color.White;
            headerStyle.SelectionForeColor = colorGray;
            this.dgvConfig.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvConfig.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConfig.ColumnHeadersHeight = 50;
            this.dgvConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Row
            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.ForeColor = colorText;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(235, 240, 255);
            rowStyle.SelectionForeColor = colorPrimary;
            rowStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvConfig.DefaultCellStyle = rowStyle;

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(250, 250, 252);
            this.dgvConfig.AlternatingRowsDefaultCellStyle = altRowStyle;

            this.dgvConfig.RowTemplate.Height = 50;
            this.dgvConfig.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.dgvConfig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConfig_CellClick);

            this.pnlGridWrapper.Controls.Add(this.dgvConfig);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSystem";
            this.Text = "System Configuration";
            this.pnlMain.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpList.ResumeLayout(false);
            this.grpList.PerformLayout();
            this.pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).EndInit();
            this.ResumeLayout(false);
        }

        // Helpers (Đã tối ưu UI/UX)
        private void SetupInput(System.Windows.Forms.Panel p, System.Windows.Forms.Label l, System.Windows.Forms.TextBox t, System.Windows.Forms.Panel line, string text, int x, int y, int w)
        {
            l.Text = text.ToUpper(); // Label in hoa nhỏ
            l.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            l.ForeColor = System.Drawing.Color.FromArgb(160, 165, 185); // Màu xám nhạt
            l.AutoSize = true; l.Location = new System.Drawing.Point(x, y); p.Controls.Add(l);

            t.BorderStyle = System.Windows.Forms.BorderStyle.None;
            t.Font = new System.Drawing.Font("Segoe UI", 11F);
            t.ForeColor = System.Drawing.Color.FromArgb(64, 70, 85);
            t.Location = new System.Drawing.Point(x, y + 25); t.Size = new System.Drawing.Size(w, 25); p.Controls.Add(t);

            line.BackColor = System.Drawing.Color.FromArgb(230, 230, 235);
            line.Location = new System.Drawing.Point(x, y + 50); line.Size = new System.Drawing.Size(w, 2); p.Controls.Add(line);
        }

        private void SetupButton(System.Windows.Forms.Panel p, System.Windows.Forms.Button b, string text, System.Drawing.Color c, int x, int y)
        {
            b.Text = text; b.BackColor = c; b.ForeColor = System.Drawing.Color.White;
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0; b.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            b.Size = new System.Drawing.Size(140, 40); // Nút to vừa phải
            b.Location = new System.Drawing.Point(x, y); b.Cursor = System.Windows.Forms.Cursors.Hand; p.Controls.Add(b);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain, grpInput, grpList, pnlGridWrapper;
        private System.Windows.Forms.Label lblTitleInput, lblListTitle;
        private System.Windows.Forms.DataGridView dgvConfig;
        private System.Windows.Forms.Label lblKey, lblValue, lblDesc;
        private System.Windows.Forms.TextBox txtKey, txtValue, txtDesc;
        private System.Windows.Forms.Panel lineKey, lineValue, lineDesc;
        private System.Windows.Forms.Button btnEdit;
    }
}