namespace ADO_Example
{
    partial class FrmCustomer
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // [STYLE CONFIG]
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
            this.lblID = new System.Windows.Forms.Label(); this.txtID = new System.Windows.Forms.TextBox(); this.lineID = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label(); this.txtName = new System.Windows.Forms.TextBox(); this.lineName = new System.Windows.Forms.Panel();
            this.lblPhone = new System.Windows.Forms.Label(); this.txtPhone = new System.Windows.Forms.TextBox(); this.linePhone = new System.Windows.Forms.Panel();
            this.lblCompany = new System.Windows.Forms.Label(); this.txtCompany = new System.Windows.Forms.TextBox(); this.lineCompany = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label(); this.txtEmail = new System.Windows.Forms.TextBox(); this.lineEmail = new System.Windows.Forms.Panel();

            // Avatar Controls
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();

            // Buttons
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            // List Panel
            this.grpList = new System.Windows.Forms.Panel();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lineSearch = new System.Windows.Forms.Panel();
            this.pnlGridWrapper = new System.Windows.Forms.Panel();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();

            this.pnlMain.SuspendLayout();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.grpList.SuspendLayout();
            this.pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
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
            // --- CARD 1: INPUT ---
            // 
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInput.Height = 320; // Chiều cao lý tưởng cho form có ảnh
            this.grpInput.BackColor = System.Drawing.Color.White;
            this.grpInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);

            this.lblTitleInput.Text = "HỒ SƠ SINH VIÊN";
            this.lblTitleInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleInput.ForeColor = colorPrimary;
            this.lblTitleInput.Location = new System.Drawing.Point(30, 25);
            this.lblTitleInput.AutoSize = true;
            this.grpInput.Controls.Add(this.lblTitleInput);

            // --- CỘT TRÁI (TEXT INPUTS) ---
            // Row 1: ID & Name
            SetupInput(this.grpInput, lblID, txtID, lineID, "MÃ SV (AUTO)", 35, 70, 150);
            this.txtID.Enabled = false; this.txtID.BackColor = System.Drawing.Color.White;

            SetupInput(this.grpInput, lblName, txtName, lineName, "HỌ VÀ TÊN", 220, 70, 350);

            // Row 2: Phone & Email
            SetupInput(this.grpInput, lblPhone, txtPhone, linePhone, "SỐ ĐIỆN THOẠI", 35, 145, 250);
            SetupInput(this.grpInput, lblEmail, txtEmail, lineEmail, "EMAIL LIÊN HỆ", 320, 145, 250);

            // Row 3: School/Address
            SetupInput(this.grpInput, lblCompany, txtCompany, lineCompany, "TRƯỜNG / QUÊ QUÁN", 35, 220, 535);

            // --- CỘT PHẢI (AVATAR AREA) ---
            // Avatar Box
            this.picAvatar.Location = new System.Drawing.Point(650, 70);
            this.picAvatar.Size = new System.Drawing.Size(140, 140);
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; // Viền đơn giản
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpInput.Controls.Add(this.picAvatar);

            // Upload Button
            this.btnUpload.Text = "Chọn Ảnh...";
            this.btnUpload.BackColor = System.Drawing.Color.White;
            this.btnUpload.ForeColor = colorGray;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnUpload.FlatAppearance.BorderSize = 1;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpload.Location = new System.Drawing.Point(650, 220); // Thẳng hàng với picAvatar
            this.btnUpload.Size = new System.Drawing.Size(140, 30);
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            this.grpInput.Controls.Add(this.btnUpload);

            // Buttons Actions
            int btnY = 270; // Dời nút xuống dưới cùng
            SetupButton(this.grpInput, btnAdd, "Thêm Mới", colorPrimary, 545, btnY);
            SetupButton(this.grpInput, btnEdit, "Cập Nhật", System.Drawing.Color.FromArgb(255, 175, 29), 655, btnY);
            SetupButton(this.grpInput, btnDelete, "Xóa", System.Drawing.Color.FromArgb(255, 82, 82), 765, btnY);
            SetupButton(this.grpInput, btnClear, "Làm Mới", System.Drawing.Color.WhiteSmoke, 875, btnY);
            this.btnClear.ForeColor = System.Drawing.Color.DimGray;

            // Events
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // --- CARD 2: LIST ---
            // 
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.BackColor = System.Drawing.Color.White;
            this.grpList.Padding = new System.Windows.Forms.Padding(25);
            this.grpList.BringToFront();

            this.lblListTitle.Text = "Danh Sách Sinh Viên";
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = colorText;
            this.lblListTitle.Location = new System.Drawing.Point(20, 20);
            this.lblListTitle.AutoSize = true;
            this.grpList.Controls.Add(this.lblListTitle);

            // Search Bar (Đã fix lỗi che chữ)
            this.lblSearch.Text = "🔍";
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSearch.ForeColor = colorGray;
            this.lblSearch.Location = new System.Drawing.Point(660, 20);
            this.grpList.Controls.Add(this.lblSearch);

            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(705, 23); // Cách icon 45px
            this.txtSearch.Size = new System.Drawing.Size(235, 20);

            SetupPlaceholder(this.txtSearch, "Tìm kiếm sinh viên...");

            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.grpList.Controls.Add(this.txtSearch);

            this.lineSearch.BackColor = colorPrimary;
            this.lineSearch.Location = new System.Drawing.Point(705, 48);
            this.lineSearch.Size = new System.Drawing.Size(235, 2);
            this.grpList.Controls.Add(this.lineSearch);

            // Grid Wrapper
            this.pnlGridWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridWrapper.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.grpList.Controls.Add(this.pnlGridWrapper);

            // DataGridView Styling
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.ReadOnly = true;

            // Header Style
            headerStyle.BackColor = System.Drawing.Color.White;
            headerStyle.ForeColor = colorGray;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            headerStyle.SelectionBackColor = System.Drawing.Color.White;
            headerStyle.SelectionForeColor = colorGray;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomer.ColumnHeadersHeight = 50;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Row Style
            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.ForeColor = colorText;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(235, 240, 255);
            rowStyle.SelectionForeColor = colorPrimary;
            rowStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvCustomer.DefaultCellStyle = rowStyle;

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(250, 250, 252);
            this.dgvCustomer.AlternatingRowsDefaultCellStyle = altRowStyle;

            this.dgvCustomer.RowTemplate.Height = 50;
            this.dgvCustomer.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            this.pnlGridWrapper.Controls.Add(this.dgvCustomer);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCustomer";
            this.Text = "Student Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.pnlMain.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.grpList.ResumeLayout(false);
            this.grpList.PerformLayout();
            this.pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
        }

        // Helpers
        private void SetupInput(System.Windows.Forms.Panel p, System.Windows.Forms.Label l, System.Windows.Forms.TextBox t, System.Windows.Forms.Panel line, string text, int x, int y, int w)
        {
            l.Text = text.ToUpper();
            l.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            l.ForeColor = System.Drawing.Color.FromArgb(160, 165, 185);
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
            b.Size = new System.Drawing.Size(100, 38); b.Location = new System.Drawing.Point(x, y);
            b.Cursor = System.Windows.Forms.Cursors.Hand; p.Controls.Add(b);
        }

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
                    t.ForeColor = System.Drawing.Color.FromArgb(64, 70, 85);
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

        #endregion

        private System.Windows.Forms.Panel pnlMain, grpInput, grpList, pnlGridWrapper;
        private System.Windows.Forms.Label lblTitleInput, lblListTitle, lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel lineSearch;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Label lblID, lblName, lblPhone, lblCompany, lblEmail;
        private System.Windows.Forms.TextBox txtID, txtName, txtPhone, txtCompany, txtEmail;
        private System.Windows.Forms.Panel lineID, lineName, linePhone, lineCompany, lineEmail;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnAdd, btnEdit, btnDelete, btnClear;
    }
}