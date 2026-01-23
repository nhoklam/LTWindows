namespace ADO_Example
{
    partial class FrmStaff
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
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(242, 245, 250); // Màu nền chuẩn
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMain.Controls.Add(this.grpList);
            this.pnlMain.Controls.Add(this.grpInput);

            // 
            // --- CARD 1: INPUT ---
            // 
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInput.Height = 260; // Chiều cao chuẩn 260px
            this.grpInput.BackColor = System.Drawing.Color.White;
            this.grpInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);

            this.lblTitleInput.Text = "QUẢN LÝ NHÂN SỰ";
            this.lblTitleInput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleInput.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblTitleInput.Location = new System.Drawing.Point(25, 20);
            this.lblTitleInput.AutoSize = true;
            this.grpInput.Controls.Add(this.lblTitleInput);

            // Row 1: User, Pass, Name
            SetupInput(this.grpInput, lblUser, txtUser, lineUser, "Tài Khoản (Username)", 30, 70, 200);
            SetupInput(this.grpInput, lblPass, txtPass, linePass, "Mật Khẩu", 260, 70, 200);
            // txtPass.UseSystemPasswordChar = true; // Bỏ comment nếu muốn ẩn mật khẩu

            SetupInput(this.grpInput, lblName, txtName, lineName, "Họ Tên Nhân Viên", 490, 70, 300);

            // Row 2: Role, Status (Căn chỉnh lại vị trí Y=140 cho thẳng hàng)
            // Combo Role
            this.lblRole.Text = "Chức Vụ / Quyền";
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRole.ForeColor = System.Drawing.Color.Gray;
            this.lblRole.Location = new System.Drawing.Point(30, 140);
            this.lblRole.AutoSize = true;
            this.grpInput.Controls.Add(this.lblRole);

            this.cbbRole.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbRole.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbRole.Location = new System.Drawing.Point(30, 162);
            this.cbbRole.Size = new System.Drawing.Size(200, 30);
            this.cbbRole.Items.AddRange(new object[] { "Admin", "Sale", "KeToan", "BaoVe" });
            this.grpInput.Controls.Add(this.cbbRole);

            // Combo Status
            this.lblStatus.Text = "Trạng Thái";
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(260, 140);
            this.lblStatus.AutoSize = true;
            this.grpInput.Controls.Add(this.lblStatus);

            this.cbbStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbStatus.Location = new System.Drawing.Point(260, 162);
            this.cbbStatus.Size = new System.Drawing.Size(200, 30);
            this.cbbStatus.Items.AddRange(new object[] { "Đang hoạt động", "Đã khóa" });
            this.grpInput.Controls.Add(this.cbbStatus);

            // Buttons (Y=200 giống các form khác)
            int btnY = 200;
            SetupButton(this.grpInput, btnAdd, "THÊM", System.Drawing.Color.FromArgb(0, 122, 204), 30, btnY);
            SetupButton(this.grpInput, btnEdit, "CẬP NHẬT", System.Drawing.Color.FromArgb(255, 193, 7), 160, btnY);
            SetupButton(this.grpInput, btnDelete, "XÓA / KHÓA", System.Drawing.Color.FromArgb(220, 53, 69), 290, btnY);
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

            this.lblListTitle.Text = "DANH SÁCH NHÂN VIÊN";
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblListTitle.Location = new System.Drawing.Point(20, 15);
            this.lblListTitle.AutoSize = true;
            this.grpList.Controls.Add(this.lblListTitle);

            // Search Bar (Đã fix lỗi che chữ)
            this.lblSearch.Text = "🔍 Tìm kiếm:";
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblSearch.Location = new System.Drawing.Point(550, 15);
            this.grpList.Controls.Add(this.lblSearch);

            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(720, 15); // Dời sang phải
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

            // DataGridView Style
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.EnableHeadersVisualStyles = false;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.ReadOnly = true;

            // Header Style
            headerStyle.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvStaff.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvStaff.ColumnHeadersHeight = 50;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Row Style (Fix lỗi màu chọn khó nhìn)
            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(24, 161, 251); // Màu xanh dương chuẩn
            rowStyle.SelectionForeColor = System.Drawing.Color.White;
            rowStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvStaff.DefaultCellStyle = rowStyle;
            this.dgvStaff.RowTemplate.Height = 45;
            this.dgvStaff.GridColor = System.Drawing.Color.WhiteSmoke;

            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            this.pnlGridWrapper.Controls.Add(this.dgvStaff);

            // Form Main
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStaff";
            this.Text = "FrmStaff";
            this.pnlMain.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpList.ResumeLayout(false);
            this.grpList.PerformLayout();
            this.pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
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
            b.Size = new System.Drawing.Size(120, 40); b.Location = new System.Drawing.Point(x, y); b.Cursor = System.Windows.Forms.Cursors.Hand; p.Controls.Add(b);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain, grpInput, grpList, pnlGridWrapper;
        private System.Windows.Forms.Label lblTitleInput, lblListTitle, lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel lineSearch;
        private System.Windows.Forms.DataGridView dgvStaff;

        // Input Controls
        private System.Windows.Forms.Label lblUser, lblPass, lblName, lblRole, lblStatus;
        private System.Windows.Forms.TextBox txtUser, txtPass, txtName;
        private System.Windows.Forms.ComboBox cbbRole, cbbStatus;
        private System.Windows.Forms.Panel lineUser, linePass, lineName;

        private System.Windows.Forms.Button btnAdd, btnEdit, btnDelete, btnClear;
    }
}