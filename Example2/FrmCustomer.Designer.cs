namespace ADO_Example
{
    partial class FrmCustomer
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpInput = new System.Windows.Forms.Panel();
            this.lblTitleInput = new System.Windows.Forms.Label();

            // Inputs
            this.lblID = new System.Windows.Forms.Label(); this.txtID = new System.Windows.Forms.TextBox(); this.lineID = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label(); this.txtName = new System.Windows.Forms.TextBox(); this.lineName = new System.Windows.Forms.Panel();
            this.lblPhone = new System.Windows.Forms.Label(); this.txtPhone = new System.Windows.Forms.TextBox(); this.linePhone = new System.Windows.Forms.Panel();
            this.lblCompany = new System.Windows.Forms.Label(); this.txtCompany = new System.Windows.Forms.TextBox(); this.lineCompany = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label(); this.txtEmail = new System.Windows.Forms.TextBox(); this.lineEmail = new System.Windows.Forms.Panel();

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
            this.grpList.SuspendLayout();
            this.pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(242, 245, 250); // Màu nền chuẩn xám nhạt
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMain.Controls.Add(this.grpList);
            this.pnlMain.Controls.Add(this.grpInput);

            // 
            // --- CARD 1: INPUT ---
            // 
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInput.Height = 260; // Chiều cao chuẩn 260px giống FrmBuilding
            this.grpInput.BackColor = System.Drawing.Color.White;
            this.grpInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);

            this.lblTitleInput.Text = "THÔNG TIN KHÁCH HÀNG"; // Đồng bộ ngữ nghĩa
            this.lblTitleInput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleInput.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblTitleInput.Location = new System.Drawing.Point(25, 20);
            this.lblTitleInput.AutoSize = true;
            this.grpInput.Controls.Add(this.lblTitleInput);

            // Row 1: ID, Tên, SĐT (Căn chỉnh tọa độ y=70 giống Building)
            SetupInput(this.grpInput, lblID, txtID, lineID, "Mã KH (Auto)", 30, 70, 100);
            this.txtID.Enabled = false; this.txtID.BackColor = System.Drawing.Color.White;

            SetupInput(this.grpInput, lblName, txtName, lineName, "Họ và Tên", 170, 70, 350);
            SetupInput(this.grpInput, lblPhone, txtPhone, linePhone, "Số Điện Thoại", 560, 70, 250);

            // Row 2: Công ty, Email (Căn chỉnh tọa độ y=140 giống Building)
            SetupInput(this.grpInput, lblCompany, txtCompany, lineCompany, "Công Ty / Đơn Vị", 30, 140, 490);
            SetupInput(this.grpInput, lblEmail, txtEmail, lineEmail, "Email Liên Hệ", 560, 140, 250);

            // Buttons (Tọa độ y=200 giống Building)
            int btnY = 200;
            SetupButton(this.grpInput, btnAdd, "THÊM", System.Drawing.Color.FromArgb(0, 122, 204), 30, btnY);
            SetupButton(this.grpInput, btnEdit, "CẬP NHẬT", System.Drawing.Color.FromArgb(255, 193, 7), 160, btnY);
            SetupButton(this.grpInput, btnDelete, "XÓA", System.Drawing.Color.FromArgb(220, 53, 69), 290, btnY);
            SetupButton(this.grpInput, btnClear, "LÀM MỚI", System.Drawing.Color.Gray, 420, btnY);

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
            this.grpList.Padding = new System.Windows.Forms.Padding(20);
            this.grpList.BringToFront();

            this.lblListTitle.Text = "DANH SÁCH KHÁCH HÀNG";
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblListTitle.Location = new System.Drawing.Point(20, 15);
            this.lblListTitle.AutoSize = true;
            this.grpList.Controls.Add(this.lblListTitle);

            // Search Bar (Đã sửa lỗi hiển thị chữ)
            this.lblSearch.Text = "🔍 Tìm kiếm:";
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblSearch.Location = new System.Drawing.Point(550, 15);
            this.grpList.Controls.Add(this.lblSearch);

            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(720, 15); // Dời sang phải để không bị che
            this.txtSearch.Size = new System.Drawing.Size(210, 20);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.grpList.Controls.Add(this.txtSearch);

            this.lineSearch.BackColor = System.Drawing.Color.LightGray;
            this.lineSearch.Location = new System.Drawing.Point(720, 38);
            this.lineSearch.Size = new System.Drawing.Size(210, 2);
            this.grpList.Controls.Add(this.lineSearch);

            // Grid Wrapper
            this.pnlGridWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridWrapper.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.grpList.Controls.Add(this.pnlGridWrapper);

            // DataGridView Style (Đã sửa lỗi màu sắc khó nhìn)
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.ReadOnly = true;

            // Header Style
            headerStyle.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvCustomer.ColumnHeadersHeight = 50;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Row Style
            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            // Màu khi chọn: Xanh dương sáng, Chữ Trắng (Dễ đọc)
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(24, 161, 251);
            rowStyle.SelectionForeColor = System.Drawing.Color.White;
            rowStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvCustomer.DefaultCellStyle = rowStyle;
            this.dgvCustomer.RowTemplate.Height = 45;
            this.dgvCustomer.GridColor = System.Drawing.Color.WhiteSmoke;

            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            this.pnlGridWrapper.Controls.Add(this.dgvCustomer);

            // Form Main
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
            this.pnlMain.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpList.ResumeLayout(false);
            this.grpList.PerformLayout();
            this.pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
        }

        // Helper: Setup Input (Material Design)
        private void SetupInput(System.Windows.Forms.Panel p, System.Windows.Forms.Label l, System.Windows.Forms.TextBox t, System.Windows.Forms.Panel line, string text, int x, int y, int w)
        {
            l.Text = text;
            l.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            l.ForeColor = System.Drawing.Color.Gray;
            l.AutoSize = true;
            l.Location = new System.Drawing.Point(x, y);
            p.Controls.Add(l);

            t.BorderStyle = System.Windows.Forms.BorderStyle.None;
            t.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            t.Location = new System.Drawing.Point(x, y + 22);
            t.Size = new System.Drawing.Size(w, 25);
            p.Controls.Add(t);

            line.BackColor = System.Drawing.Color.Silver;
            line.Location = new System.Drawing.Point(x, y + 48);
            line.Size = new System.Drawing.Size(w, 2);
            p.Controls.Add(line);
        }

        // Helper: Setup Button
        private void SetupButton(System.Windows.Forms.Panel p, System.Windows.Forms.Button b, string text, System.Drawing.Color c, int x, int y)
        {
            b.Text = text;
            b.BackColor = c;
            b.ForeColor = System.Drawing.Color.White;
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            b.Size = new System.Drawing.Size(120, 40);
            b.Location = new System.Drawing.Point(x, y);
            b.Cursor = System.Windows.Forms.Cursors.Hand;
            p.Controls.Add(b);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain, grpInput, grpList, pnlGridWrapper;
        private System.Windows.Forms.Label lblTitleInput, lblListTitle, lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel lineSearch;
        private System.Windows.Forms.DataGridView dgvCustomer;

        // Input Controls
        private System.Windows.Forms.Label lblID, lblName, lblPhone, lblCompany, lblEmail;
        private System.Windows.Forms.TextBox txtID, txtName, txtPhone, txtCompany, txtEmail;
        private System.Windows.Forms.Panel lineID, lineName, linePhone, lineCompany, lineEmail;

        // Buttons
        private System.Windows.Forms.Button btnAdd, btnEdit, btnDelete, btnClear;
    }
}