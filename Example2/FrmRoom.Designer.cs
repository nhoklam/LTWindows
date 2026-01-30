namespace ADO_Example
{
    partial class FrmRoom
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

            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle altRowStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpInput = new System.Windows.Forms.Panel();
            this.lblTitleInput = new System.Windows.Forms.Label();

            this.lblBuilding = new System.Windows.Forms.Label(); this.cbbBuilding = new System.Windows.Forms.ComboBox();
            this.lblRoomsPerFloor = new System.Windows.Forms.Label(); this.txtRoomsPerFloor = new System.Windows.Forms.TextBox(); this.lineRoomsPerFloor = new System.Windows.Forms.Panel();
            this.lblArea = new System.Windows.Forms.Label(); this.txtArea = new System.Windows.Forms.TextBox(); this.lineArea = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label(); this.txtPrice = new System.Windows.Forms.TextBox(); this.linePrice = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();

            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();

            this.grpList = new System.Windows.Forms.Panel();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lineSearch = new System.Windows.Forms.Panel();
            this.pnlGridWrapper = new System.Windows.Forms.Panel();
            this.dgvRoom = new System.Windows.Forms.DataGridView();

            this.pnlMain.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpList.SuspendLayout();
            this.pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.SuspendLayout();

            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.BackColor = colorBg;
            this.pnlMain.Padding = new System.Windows.Forms.Padding(25);
            this.pnlMain.Controls.Add(this.grpList);
            this.pnlMain.Controls.Add(this.grpInput);

            this.grpInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInput.Height = 270;
            this.grpInput.BackColor = System.Drawing.Color.White;
            this.grpInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);

            this.lblTitleInput.Text = "QUẢN LÝ PHÒNG KTX";
            this.lblTitleInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleInput.ForeColor = colorPrimary;
            this.lblTitleInput.Location = new System.Drawing.Point(30, 25);
            this.lblTitleInput.AutoSize = true;
            this.grpInput.Controls.Add(this.lblTitleInput);

            this.lblBuilding.Text = "CHỌN TÒA NHÀ";
            this.lblBuilding.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblBuilding.ForeColor = colorGray;
            this.lblBuilding.Location = new System.Drawing.Point(35, 70);
            this.lblBuilding.AutoSize = true;
            this.grpInput.Controls.Add(this.lblBuilding);

            this.cbbBuilding.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbBuilding.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbBuilding.Location = new System.Drawing.Point(35, 95);
            this.cbbBuilding.Size = new System.Drawing.Size(220, 30);
            this.grpInput.Controls.Add(this.cbbBuilding);

            SetupInput(this.grpInput, lblRoomsPerFloor, txtRoomsPerFloor, lineRoomsPerFloor, "SỐ PHÒNG/TẦNG (AUTO)", 290, 70, 200);
            this.txtRoomsPerFloor.Text = "3";

            SetupInput(this.grpInput, lblArea, txtArea, lineArea, "DIỆN TÍCH (M2)", 35, 145, 220);
            SetupInput(this.grpInput, lblPrice, txtPrice, linePrice, "ĐƠN GIÁ PHÒNG", 290, 145, 200);

            this.txtID.Visible = false;
            this.grpInput.Controls.Add(this.txtID);

            int btnY = 210;
            SetupButton(this.grpInput, btnGenerate, "Phát Sinh", colorPrimary, 545, 80);
            this.btnGenerate.Location = new System.Drawing.Point(545, 90);
            this.btnGenerate.Size = new System.Drawing.Size(120, 38);

            SetupButton(this.grpInput, btnEdit, "Cập Nhật", System.Drawing.Color.FromArgb(255, 175, 29), 545, btnY);
            SetupButton(this.grpInput, btnDelete, "Xóa", System.Drawing.Color.FromArgb(255, 82, 82), 655, btnY);
            SetupButton(this.grpInput, btnExcel, "Xuất Excel", colorSuccess, 765, btnY);
            SetupButton(this.grpInput, btnClear, "Làm Mới", System.Drawing.Color.WhiteSmoke, 875, btnY);
            this.btnClear.ForeColor = System.Drawing.Color.DimGray;

            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);

            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.BackColor = System.Drawing.Color.White;
            this.grpList.Padding = new System.Windows.Forms.Padding(25);
            this.grpList.BringToFront();

            this.lblListTitle.Text = "Danh Sách Phòng";
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = colorText;
            this.lblListTitle.Location = new System.Drawing.Point(20, 20);
            this.lblListTitle.AutoSize = true;
            this.grpList.Controls.Add(this.lblListTitle);

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
            SetupPlaceholder(this.txtSearch, "Tìm phòng...");
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.grpList.Controls.Add(this.txtSearch);

            this.lineSearch.BackColor = colorPrimary;
            this.lineSearch.Location = new System.Drawing.Point(705, 48);
            this.lineSearch.Size = new System.Drawing.Size(235, 2);
            this.grpList.Controls.Add(this.lineSearch);

            this.pnlGridWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridWrapper.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.grpList.Controls.Add(this.pnlGridWrapper);

            this.dgvRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoom.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRoom.RowHeadersVisible = false;
            this.dgvRoom.EnableHeadersVisualStyles = false;
            this.dgvRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoom.AllowUserToAddRows = false;

            // QUAN TRỌNG: Để ReadOnly = false để người dùng có thể tích vào checkbox
            this.dgvRoom.ReadOnly = false;

            headerStyle.BackColor = System.Drawing.Color.White;
            headerStyle.ForeColor = colorGray;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            headerStyle.SelectionBackColor = System.Drawing.Color.White;
            headerStyle.SelectionForeColor = colorGray;
            this.dgvRoom.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvRoom.ColumnHeadersHeight = 50;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.ForeColor = colorText;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(235, 240, 255);
            rowStyle.SelectionForeColor = colorPrimary;
            rowStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvRoom.DefaultCellStyle = rowStyle;

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(250, 250, 252);
            this.dgvRoom.AlternatingRowsDefaultCellStyle = altRowStyle;

            this.dgvRoom.RowTemplate.Height = 50;
            this.dgvRoom.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.dgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellClick);
            this.pnlGridWrapper.Controls.Add(this.dgvRoom);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRoom";
            this.Text = "Room Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.pnlMain.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpList.ResumeLayout(false);
            this.grpList.PerformLayout();
            this.pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.ResumeLayout(false);
        }

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
        private System.Windows.Forms.DataGridView dgvRoom;

        private System.Windows.Forms.Label lblBuilding, lblRoomsPerFloor, lblArea, lblPrice;
        private System.Windows.Forms.TextBox txtRoomsPerFloor, txtArea, txtPrice, txtID;
        private System.Windows.Forms.ComboBox cbbBuilding;
        private System.Windows.Forms.Panel lineRoomsPerFloor, lineArea, linePrice;

        private System.Windows.Forms.Button btnGenerate, btnDelete, btnClear, btnEdit, btnExcel;
    }
}