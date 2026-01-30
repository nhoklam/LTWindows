namespace ADO_Example
{
    partial class FrmContract
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // [STYLE CONFIG]
            System.Drawing.Color colorPrimary = System.Drawing.Color.FromArgb(58, 110, 242);
            System.Drawing.Color colorSuccess = System.Drawing.Color.FromArgb(32, 160, 56);
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

            // --- INPUT CONTROLS ---
            this.lblCode = new System.Windows.Forms.Label(); this.txtCode = new System.Windows.Forms.TextBox(); this.lineCode = new System.Windows.Forms.Panel();
            this.lblCustomer = new System.Windows.Forms.Label(); this.cbbCustomer = new System.Windows.Forms.ComboBox();

            // Bộ lọc Phòng (3 Cấp)
            this.lblFilterBuilding = new System.Windows.Forms.Label(); this.cbbFilterBuilding = new System.Windows.Forms.ComboBox();
            this.lblFilterFloor = new System.Windows.Forms.Label(); this.cbbFilterFloor = new System.Windows.Forms.ComboBox();
            this.lblRoom = new System.Windows.Forms.Label(); this.cbbRoom = new System.Windows.Forms.ComboBox();

            // Thời gian, Tiền
            this.lblStart = new System.Windows.Forms.Label(); this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label(); this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblPrice = new System.Windows.Forms.Label(); this.txtPrice = new System.Windows.Forms.TextBox(); this.linePrice = new System.Windows.Forms.Panel();
            this.lblDeposit = new System.Windows.Forms.Label(); this.txtDeposit = new System.Windows.Forms.TextBox(); this.lineDeposit = new System.Windows.Forms.Panel();

            // Buttons
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();

            // List Panel
            this.grpList = new System.Windows.Forms.Panel();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lineSearch = new System.Windows.Forms.Panel();
            this.pnlGridWrapper = new System.Windows.Forms.Panel();
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();

            this.pnlMain.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpList.SuspendLayout();
            this.pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
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
            // --- INPUT PANEL ---
            // 
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInput.Height = 350; // Tăng chiều cao để chứa 3 hàng input thoải mái
            this.grpInput.BackColor = System.Drawing.Color.White;
            this.grpInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);

            this.lblTitleInput.Text = "QUẢN LÝ HỢP ĐỒNG";
            this.lblTitleInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleInput.ForeColor = colorPrimary;
            this.lblTitleInput.Location = new System.Drawing.Point(30, 25);
            this.lblTitleInput.AutoSize = true;
            this.grpInput.Controls.Add(this.lblTitleInput);

            // DÒNG 1: THÔNG TIN CƠ BẢN (Mã HĐ + Sinh Viên)
            SetupInput(this.grpInput, lblCode, txtCode, lineCode, "SỐ HỢP ĐỒNG (AUTO)", 35, 70, 150);
            this.txtCode.Enabled = false; this.txtCode.BackColor = System.Drawing.Color.White;

            // Combo Sinh Viên (Custom Style)
            this.lblCustomer.Text = "SINH VIÊN / KHÁCH THUÊ";
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCustomer.ForeColor = colorGray;
            this.lblCustomer.Location = new System.Drawing.Point(220, 70);
            this.lblCustomer.AutoSize = true;
            this.grpInput.Controls.Add(this.lblCustomer);

            this.cbbCustomer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbCustomer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCustomer.Location = new System.Drawing.Point(220, 95);
            this.cbbCustomer.Size = new System.Drawing.Size(350, 30);
            this.grpInput.Controls.Add(this.cbbCustomer);

            // DÒNG 2: CHỌN PHÒNG (LOGIC 3 BƯỚC)
            // Bước 1: Tòa
            this.lblFilterBuilding.Text = "1. CHỌN TÒA";
            this.lblFilterBuilding.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFilterBuilding.ForeColor = colorGray;
            this.lblFilterBuilding.Location = new System.Drawing.Point(35, 145);
            this.lblFilterBuilding.AutoSize = true;
            this.grpInput.Controls.Add(this.lblFilterBuilding);

            this.cbbFilterBuilding.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbFilterBuilding.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbFilterBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbFilterBuilding.Location = new System.Drawing.Point(35, 170);
            this.cbbFilterBuilding.Size = new System.Drawing.Size(150, 30);
            this.grpInput.Controls.Add(this.cbbFilterBuilding);
            this.cbbFilterBuilding.SelectedIndexChanged += new System.EventHandler(this.cbbFilterBuilding_SelectedIndexChanged);

            // Bước 2: Tầng
            this.lblFilterFloor.Text = "2. CHỌN TẦNG";
            this.lblFilterFloor.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFilterFloor.ForeColor = colorGray;
            this.lblFilterFloor.Location = new System.Drawing.Point(220, 145);
            this.lblFilterFloor.AutoSize = true;
            this.grpInput.Controls.Add(this.lblFilterFloor);

            this.cbbFilterFloor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbFilterFloor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbFilterFloor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbFilterFloor.Location = new System.Drawing.Point(220, 170);
            this.cbbFilterFloor.Size = new System.Drawing.Size(120, 30);
            this.grpInput.Controls.Add(this.cbbFilterFloor);
            this.cbbFilterFloor.SelectedIndexChanged += new System.EventHandler(this.cbbFilterFloor_SelectedIndexChanged);

            // Bước 3: Phòng (Target)
            this.lblRoom.Text = "3. CHỌN PHÒNG (TRỐNG)";
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblRoom.ForeColor = colorPrimary; // Màu xanh nhấn mạnh
            this.lblRoom.Location = new System.Drawing.Point(370, 145);
            this.lblRoom.AutoSize = true;
            this.grpInput.Controls.Add(this.lblRoom);

            this.cbbRoom.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbRoom.BackColor = System.Drawing.Color.White; // Nền trắng nổi bật
            this.cbbRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbRoom.Location = new System.Drawing.Point(370, 170);
            this.cbbRoom.Size = new System.Drawing.Size(200, 30);
            this.grpInput.Controls.Add(this.cbbRoom);
            this.cbbRoom.SelectedIndexChanged += new System.EventHandler(this.cbbRoom_SelectedIndexChanged);

            // DÒNG 3: THỜI GIAN & TIỀN BẠC
            // DatePickers
            this.lblStart.Text = "NGÀY BẮT ĐẦU";
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblStart.ForeColor = colorGray;
            this.lblStart.Location = new System.Drawing.Point(35, 220);
            this.lblStart.AutoSize = true;
            this.grpInput.Controls.Add(this.lblStart);

            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpStart.Location = new System.Drawing.Point(35, 245);
            this.dtpStart.Size = new System.Drawing.Size(150, 30);
            this.grpInput.Controls.Add(this.dtpStart);

            this.lblEnd.Text = "NGÀY KẾT THÚC";
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEnd.ForeColor = colorGray;
            this.lblEnd.Location = new System.Drawing.Point(220, 220);
            this.lblEnd.AutoSize = true;
            this.grpInput.Controls.Add(this.lblEnd);

            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpEnd.Location = new System.Drawing.Point(220, 245);
            this.dtpEnd.Size = new System.Drawing.Size(150, 30);
            this.grpInput.Controls.Add(this.dtpEnd);

            // Price & Deposit
            SetupInput(this.grpInput, lblPrice, txtPrice, linePrice, "GIÁ THUÊ (AUTO)", 400, 220, 180);
            SetupInput(this.grpInput, lblDeposit, txtDeposit, lineDeposit, "TIỀN CỌC", 610, 220, 180);

            // BUTTONS
            int btnY = 285;
            SetupButton(this.grpInput, btnAdd, "Lập Hợp Đồng", colorPrimary, 35, btnY, 140);
            SetupButton(this.grpInput, btnEdit, "Cập Nhật", System.Drawing.Color.FromArgb(255, 175, 29), 190, btnY, 120);
            SetupButton(this.grpInput, btnDelete, "Thanh Lý", System.Drawing.Color.FromArgb(255, 82, 82), 325, btnY, 120);
            SetupButton(this.grpInput, btnExcel, "Xuất Excel", colorSuccess, 460, btnY, 120);
            SetupButton(this.grpInput, btnClear, "Làm Mới", System.Drawing.Color.WhiteSmoke, 595, btnY, 100);
            this.btnClear.ForeColor = System.Drawing.Color.DimGray;

            // Events
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);

            // 
            // --- LIST PANEL ---
            // 
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.BackColor = System.Drawing.Color.White;
            this.grpList.Padding = new System.Windows.Forms.Padding(25);
            this.grpList.BringToFront();

            this.lblListTitle.Text = "Danh Sách Hợp Đồng";
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

            SetupPlaceholder(this.txtSearch, "Tìm số HĐ, tên SV...");

            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.grpList.Controls.Add(this.txtSearch);

            this.lineSearch.BackColor = colorPrimary;
            this.lineSearch.Location = new System.Drawing.Point(705, 48);
            this.lineSearch.Size = new System.Drawing.Size(235, 2);
            this.grpList.Controls.Add(this.lineSearch);

            // Grid
            this.pnlGridWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridWrapper.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.grpList.Controls.Add(this.pnlGridWrapper);

            // DataGridView Style
            this.dgvContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContract.BackgroundColor = System.Drawing.Color.White;
            this.dgvContract.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContract.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvContract.RowHeadersVisible = false;
            this.dgvContract.EnableHeadersVisualStyles = false;
            this.dgvContract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContract.AllowUserToAddRows = false;
            this.dgvContract.ReadOnly = true;

            // Header
            headerStyle.BackColor = System.Drawing.Color.White;
            headerStyle.ForeColor = colorGray;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            headerStyle.SelectionBackColor = System.Drawing.Color.White;
            headerStyle.SelectionForeColor = colorGray;
            this.dgvContract.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvContract.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvContract.ColumnHeadersHeight = 50;
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Row
            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.ForeColor = colorText;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(235, 240, 255);
            rowStyle.SelectionForeColor = colorPrimary;
            rowStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvContract.DefaultCellStyle = rowStyle;

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(250, 250, 252);
            this.dgvContract.AlternatingRowsDefaultCellStyle = altRowStyle;

            this.dgvContract.RowTemplate.Height = 50;
            this.dgvContract.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.dgvContract.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContract_CellClick);
            this.pnlGridWrapper.Controls.Add(this.dgvContract);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmContract";
            this.Text = "Contract Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.pnlMain.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpList.ResumeLayout(false);
            this.grpList.PerformLayout();
            this.pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
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

        private void SetupButton(System.Windows.Forms.Panel p, System.Windows.Forms.Button b, string text, System.Drawing.Color c, int x, int y, int w)
        {
            b.Text = text; b.BackColor = c; b.ForeColor = System.Drawing.Color.White;
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0; b.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            b.Size = new System.Drawing.Size(w, 40); b.Location = new System.Drawing.Point(x, y);
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
        private System.Windows.Forms.TextBox txtSearch, txtID;
        private System.Windows.Forms.Panel lineSearch;
        private System.Windows.Forms.DataGridView dgvContract;

        private System.Windows.Forms.Label lblCode, lblCustomer, lblStart, lblEnd, lblPrice, lblDeposit;
        private System.Windows.Forms.TextBox txtCode, txtPrice, txtDeposit;
        private System.Windows.Forms.ComboBox cbbCustomer;

        private System.Windows.Forms.ComboBox cbbFilterBuilding, cbbFilterFloor, cbbRoom;
        private System.Windows.Forms.Label lblFilterBuilding, lblFilterFloor, lblRoom;

        private System.Windows.Forms.DateTimePicker dtpStart, dtpEnd;
        private System.Windows.Forms.Panel lineCode, linePrice, lineDeposit;

        private System.Windows.Forms.Button btnAdd, btnEdit, btnDelete, btnClear, btnExcel;
    }
}