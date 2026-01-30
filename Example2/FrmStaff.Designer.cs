namespace ADO_Example
{
    partial class FrmStaff
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

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
            this.lblUser = new System.Windows.Forms.Label(); this.txtUser = new System.Windows.Forms.TextBox(); this.lineUser = new System.Windows.Forms.Panel();
            this.lblPass = new System.Windows.Forms.Label(); this.txtPass = new System.Windows.Forms.TextBox(); this.linePass = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label(); this.txtName = new System.Windows.Forms.TextBox(); this.lineName = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label(); this.cbbRole = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label(); this.cbbStatus = new System.Windows.Forms.ComboBox();

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
            this.dgvStaff = new System.Windows.Forms.DataGridView();

            this.pnlMain.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpList.SuspendLayout();
            this.pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
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
            this.grpInput.Height = 280;
            this.grpInput.BackColor = System.Drawing.Color.White;
            this.grpInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);

            // Title Input
            this.lblTitleInput.Text = "THÔNG TIN NHÂN SỰ";
            this.lblTitleInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleInput.ForeColor = colorPrimary;
            this.lblTitleInput.Location = new System.Drawing.Point(30, 25);
            this.lblTitleInput.AutoSize = true;
            this.grpInput.Controls.Add(this.lblTitleInput);

            // Column 1: User & Role
            SetupInput(this.grpInput, lblUser, txtUser, lineUser, "USERNAME", 35, 70, 220);

            this.lblRole.Text = "CHỨC VỤ";
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblRole.ForeColor = colorGray;
            this.lblRole.Location = new System.Drawing.Point(35, 140);
            this.lblRole.AutoSize = true;
            this.grpInput.Controls.Add(this.lblRole);

            this.cbbRole.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbRole.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbRole.Location = new System.Drawing.Point(35, 165);
            this.cbbRole.Size = new System.Drawing.Size(220, 30);
            this.cbbRole.Items.AddRange(new object[] { "Admin", "Sale", "KeToan", "BaoVe" });
            this.grpInput.Controls.Add(this.cbbRole);

            // Column 2: Pass & Status
            SetupInput(this.grpInput, lblPass, txtPass, linePass, "PASSWORD", 290, 70, 220);

            this.lblStatus.Text = "TRẠNG THÁI";
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = colorGray;
            this.lblStatus.Location = new System.Drawing.Point(290, 140);
            this.lblStatus.AutoSize = true;
            this.grpInput.Controls.Add(this.lblStatus);

            this.cbbStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbStatus.Location = new System.Drawing.Point(290, 165);
            this.cbbStatus.Size = new System.Drawing.Size(220, 30);
            this.cbbStatus.Items.AddRange(new object[] { "Active", "Locked" });
            this.grpInput.Controls.Add(this.cbbStatus);

            // Column 3: Fullname
            SetupInput(this.grpInput, lblName, txtName, lineName, "HỌ VÀ TÊN", 545, 70, 350);

            // Buttons
            int btnY = 220;
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

            this.lblListTitle.Text = "Danh Sách Nhân Viên";
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = colorText;
            this.lblListTitle.Location = new System.Drawing.Point(20, 20);
            this.lblListTitle.AutoSize = true;
            this.grpList.Controls.Add(this.lblListTitle);

            // Search Bar
            this.lblSearch.Text = "🔍";
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSearch.ForeColor = colorGray;
            this.lblSearch.Location = new System.Drawing.Point(660, 20);
            this.grpList.Controls.Add(this.lblSearch);

            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(705, 23);
            this.txtSearch.Size = new System.Drawing.Size(250, 20);

            // --- SỬA LỖI PLACEHOLDER ---
            SetupPlaceholder(this.txtSearch, "Tìm kiếm theo tên...");
            // ---------------------------

            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.grpList.Controls.Add(this.txtSearch);

            this.lineSearch.BackColor = colorPrimary;
            this.lineSearch.Location = new System.Drawing.Point(705, 48);
            this.lineSearch.Size = new System.Drawing.Size(250, 2);
            this.grpList.Controls.Add(this.lineSearch);

            // Grid Wrapper
            this.pnlGridWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridWrapper.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.grpList.Controls.Add(this.pnlGridWrapper);

            // DataGridView Styling
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.EnableHeadersVisualStyles = false;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.ReadOnly = true;

            // Grid Header
            headerStyle.BackColor = System.Drawing.Color.White;
            headerStyle.ForeColor = colorGray;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            headerStyle.SelectionBackColor = System.Drawing.Color.White;
            headerStyle.SelectionForeColor = colorGray;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStaff.ColumnHeadersHeight = 50;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Grid Row
            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.ForeColor = colorText;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(235, 240, 255);
            rowStyle.SelectionForeColor = colorPrimary;
            rowStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvStaff.DefaultCellStyle = rowStyle;

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(250, 250, 252);
            this.dgvStaff.AlternatingRowsDefaultCellStyle = altRowStyle;

            this.dgvStaff.RowTemplate.Height = 50;
            this.dgvStaff.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            this.pnlGridWrapper.Controls.Add(this.dgvStaff);

            // Form Main
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStaff";
            this.Text = "Human Resources";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.pnlMain.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpList.ResumeLayout(false);
            this.grpList.PerformLayout();
            this.pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
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
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat; b.FlatAppearance.BorderSize = 0;
            b.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            b.Size = new System.Drawing.Size(100, 38); b.Location = new System.Drawing.Point(x, y);
            b.Cursor = System.Windows.Forms.Cursors.Hand; p.Controls.Add(b);
        }

        // HÀM SỬA LỖI PLACEHOLDERTEXT
        private void SetupPlaceholder(System.Windows.Forms.TextBox txt, string placeholderText)
        {
            txt.Text = placeholderText;
            txt.ForeColor = System.Drawing.Color.Gray;
            txt.Tag = placeholderText; // Lưu giá trị gốc

            txt.Enter += (s, e) => {
                System.Windows.Forms.TextBox t = (System.Windows.Forms.TextBox)s;
                if (t.Text == (string)t.Tag)
                {
                    t.Text = "";
                    t.ForeColor = System.Drawing.Color.FromArgb(64, 70, 85); // Màu đen khi nhập
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
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Label lblUser, lblPass, lblName, lblRole, lblStatus;
        private System.Windows.Forms.TextBox txtUser, txtPass, txtName;
        private System.Windows.Forms.ComboBox cbbRole, cbbStatus;
        private System.Windows.Forms.Panel lineUser, linePass, lineName;
        private System.Windows.Forms.Button btnAdd, btnEdit, btnDelete, btnClear;
    }
}