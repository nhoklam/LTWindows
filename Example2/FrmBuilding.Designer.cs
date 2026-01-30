namespace ADO_Example
{
    partial class FrmBuilding
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
            this.lblFloors = new System.Windows.Forms.Label(); this.txtFloors = new System.Windows.Forms.TextBox(); this.lineFloors = new System.Windows.Forms.Panel();
            this.lblLocation = new System.Windows.Forms.Label(); this.txtLocation = new System.Windows.Forms.TextBox(); this.lineLocation = new System.Windows.Forms.Panel();

            // ComboBoxes
            this.lblGender = new System.Windows.Forms.Label(); this.cbbGender = new System.Windows.Forms.ComboBox();
            this.lblManager = new System.Windows.Forms.Label(); this.cbbManager = new System.Windows.Forms.ComboBox();

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
            this.dgvBuilding = new System.Windows.Forms.DataGridView();

            this.pnlMain.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpList.SuspendLayout();
            this.pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilding)).BeginInit();
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

            this.lblTitleInput.Text = "QUẢN LÝ TÒA NHÀ (KTX)";
            this.lblTitleInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleInput.ForeColor = colorPrimary;
            this.lblTitleInput.Location = new System.Drawing.Point(30, 25);
            this.lblTitleInput.AutoSize = true;
            this.grpInput.Controls.Add(this.lblTitleInput);

            // ROW 1: ID, Name, Gender, Floor
            SetupInput(this.grpInput, lblID, txtID, lineID, "MÃ TÒA", 35, 70, 80);
            this.txtID.Enabled = false; this.txtID.BackColor = System.Drawing.Color.White;

            SetupInput(this.grpInput, lblName, txtName, lineName, "TÊN TÒA (VD: B1)", 150, 70, 200);

            // Combo Gender
            this.lblGender.Text = "LOẠI TÒA";
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblGender.ForeColor = colorGray;
            this.lblGender.Location = new System.Drawing.Point(390, 70);
            this.lblGender.AutoSize = true;
            this.grpInput.Controls.Add(this.lblGender);

            this.cbbGender.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbGender.Location = new System.Drawing.Point(390, 95);
            this.cbbGender.Size = new System.Drawing.Size(180, 30);
            this.cbbGender.Items.AddRange(new object[] { "Khu Nam", "Khu Nữ" });
            this.grpInput.Controls.Add(this.cbbGender);

            SetupInput(this.grpInput, lblFloors, txtFloors, lineFloors, "SỐ TẦNG", 610, 70, 100);

            // ROW 2: Manager & Location
            // Combo Manager
            this.lblManager.Text = "TRƯỞNG NHÀ (QUẢN LÝ)";
            this.lblManager.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblManager.ForeColor = colorGray;
            this.lblManager.Location = new System.Drawing.Point(35, 145);
            this.lblManager.AutoSize = true;
            this.grpInput.Controls.Add(this.lblManager);

            this.cbbManager.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbManager.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbManager.Location = new System.Drawing.Point(35, 170);
            this.cbbManager.Size = new System.Drawing.Size(315, 30);
            this.grpInput.Controls.Add(this.cbbManager);

            SetupInput(this.grpInput, lblLocation, txtLocation, lineLocation, "VỊ TRÍ / MÔ TẢ", 390, 145, 320);

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

            this.lblListTitle.Text = "Danh Sách Tòa Nhà";
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
            this.txtSearch.Size = new System.Drawing.Size(235, 20);

            SetupPlaceholder(this.txtSearch, "Tìm kiếm tòa nhà...");

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

            // Grid Style
            this.dgvBuilding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBuilding.BackgroundColor = System.Drawing.Color.White;
            this.dgvBuilding.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBuilding.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBuilding.RowHeadersVisible = false;
            this.dgvBuilding.EnableHeadersVisualStyles = false;
            this.dgvBuilding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuilding.AllowUserToAddRows = false;
            this.dgvBuilding.ReadOnly = true;

            // Header
            headerStyle.BackColor = System.Drawing.Color.White;
            headerStyle.ForeColor = colorGray;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            headerStyle.SelectionBackColor = System.Drawing.Color.White;
            headerStyle.SelectionForeColor = colorGray;
            this.dgvBuilding.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvBuilding.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBuilding.ColumnHeadersHeight = 50;
            this.dgvBuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Row
            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.ForeColor = colorText;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(235, 240, 255);
            rowStyle.SelectionForeColor = colorPrimary;
            rowStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvBuilding.DefaultCellStyle = rowStyle;

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(250, 250, 252);
            this.dgvBuilding.AlternatingRowsDefaultCellStyle = altRowStyle;

            this.dgvBuilding.RowTemplate.Height = 50;
            this.dgvBuilding.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.dgvBuilding.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuilding_CellClick);
            this.dgvBuilding.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBuilding_CellFormatting);

            this.pnlGridWrapper.Controls.Add(this.dgvBuilding);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuilding";
            this.Text = "Building Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.pnlMain.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpList.ResumeLayout(false);
            this.grpList.PerformLayout();
            this.pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilding)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvBuilding;

        private System.Windows.Forms.Label lblID, lblName, lblFloors, lblLocation, lblGender, lblManager;
        private System.Windows.Forms.TextBox txtID, txtName, txtFloors, txtLocation;
        private System.Windows.Forms.Panel lineID, lineName, lineFloors, lineLocation;

        private System.Windows.Forms.ComboBox cbbGender, cbbManager;
        private System.Windows.Forms.Button btnAdd, btnEdit, btnDelete, btnClear;
    }
}