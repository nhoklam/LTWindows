namespace ADO_Example
{
    partial class FrmBuilding
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpInput = new System.Windows.Forms.Panel();
            this.lblTitleInput = new System.Windows.Forms.Label();

            this.lblID = new System.Windows.Forms.Label(); this.txtID = new System.Windows.Forms.TextBox(); this.lineID = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label(); this.txtName = new System.Windows.Forms.TextBox(); this.lineName = new System.Windows.Forms.Panel();
            this.lblAddr = new System.Windows.Forms.Label(); this.txtAddress = new System.Windows.Forms.TextBox(); this.lineAddr = new System.Windows.Forms.Panel();
            this.lblManager = new System.Windows.Forms.Label(); this.txtManager = new System.Windows.Forms.TextBox(); this.lineManager = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label(); this.txtPrice = new System.Windows.Forms.TextBox(); this.linePrice = new System.Windows.Forms.Panel();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.grpList = new System.Windows.Forms.Panel();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lineSearch = new System.Windows.Forms.Panel();
            this.dgvBuilding = new System.Windows.Forms.DataGridView();
            this.pnlGridWrapper = new System.Windows.Forms.Panel();

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
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMain.Controls.Add(this.grpList);
            this.pnlMain.Controls.Add(this.grpInput);

            // 
            // --- INPUT PANEL ---
            // 
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInput.Height = 260;
            this.grpInput.BackColor = System.Drawing.Color.White;
            this.grpInput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);

            this.lblTitleInput.Text = "THÔNG TIN TÒA NHÀ";
            this.lblTitleInput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleInput.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblTitleInput.Location = new System.Drawing.Point(25, 20);
            this.lblTitleInput.AutoSize = true;
            this.grpInput.Controls.Add(this.lblTitleInput);

            // Inputs
            SetupInput(this.grpInput, lblID, txtID, lineID, "Mã Tòa", 30, 70, 100);
            this.txtID.Enabled = false; this.txtID.BackColor = System.Drawing.Color.White;

            SetupInput(this.grpInput, lblName, txtName, lineName, "Tên Tòa Nhà", 170, 70, 350);
            SetupInput(this.grpInput, lblManager, txtManager, lineManager, "Quản Lý Phụ Trách", 560, 70, 300);
            SetupInput(this.grpInput, lblAddr, txtAddress, lineAddr, "Địa Chỉ", 30, 140, 490);
            SetupInput(this.grpInput, lblPrice, txtPrice, linePrice, "Giá Sàn Tham Khảo ($)", 560, 140, 200);

            // Buttons
            int btnY = 200;
            SetupButton(this.grpInput, btnAdd, "THÊM", System.Drawing.Color.FromArgb(0, 122, 204), 30, btnY);
            SetupButton(this.grpInput, btnEdit, "CẬP NHẬT", System.Drawing.Color.FromArgb(255, 193, 7), 160, btnY);
            SetupButton(this.grpInput, btnDelete, "XÓA", System.Drawing.Color.FromArgb(220, 53, 69), 290, btnY);
            SetupButton(this.grpInput, btnClear, "LÀM MỚI", System.Drawing.Color.Gray, 420, btnY);

            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // --- LIST PANEL ---
            // 
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.BackColor = System.Drawing.Color.White;
            this.grpList.Padding = new System.Windows.Forms.Padding(20);
            this.grpList.BringToFront();

            this.lblListTitle.Text = "DANH SÁCH TÒA NHÀ";
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblListTitle.Location = new System.Drawing.Point(20, 15);
            this.lblListTitle.AutoSize = true;
            this.grpList.Controls.Add(this.lblListTitle);

            // --- SỬA LỖI TÌM KIẾM TẠI ĐÂY ---
            // 1. Label Tìm kiếm
            this.lblSearch.Text = "🔍 Tìm kiếm:";
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblSearch.Location = new System.Drawing.Point(550, 15);
            this.grpList.Controls.Add(this.lblSearch);

            // 2. TextBox Tìm kiếm (Dời vị trí X ra xa label hơn: từ 650 -> 720)
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black; // Đảm bảo chữ màu đen
            this.txtSearch.Location = new System.Drawing.Point(720, 15); // <--- Đã dời sang phải
            this.txtSearch.Size = new System.Drawing.Size(210, 20);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.grpList.Controls.Add(this.txtSearch);

            // 3. Đường kẻ chân (Dời theo TextBox)
            this.lineSearch.BackColor = System.Drawing.Color.LightGray;
            this.lineSearch.Location = new System.Drawing.Point(720, 38); // <--- Đã dời sang phải
            this.lineSearch.Size = new System.Drawing.Size(210, 2);
            this.grpList.Controls.Add(this.lineSearch);


            // Grid Wrapper
            this.pnlGridWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridWrapper.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.grpList.Controls.Add(this.pnlGridWrapper);

            // 
            // --- SỬA MÀU SẮC DATAGRIDVIEW ---
            //
            this.dgvBuilding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBuilding.BackgroundColor = System.Drawing.Color.White;
            this.dgvBuilding.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBuilding.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBuilding.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBuilding.RowHeadersVisible = false;
            this.dgvBuilding.EnableHeadersVisualStyles = false;

            // Chế độ chọn Full dòng
            this.dgvBuilding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuilding.AllowUserToAddRows = false;
            this.dgvBuilding.ReadOnly = true;

            // Header Style
            headerStyle.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvBuilding.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvBuilding.ColumnHeadersHeight = 50;
            this.dgvBuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Row Style (Màu nền bình thường)
            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);

            // --- KHẮC PHỤC LỖI "KHÓ NHÌN" KHI CHỌN DÒNG ---
            // Dùng màu nền Đậm và chữ Trắng
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(24, 161, 251); // Màu Xanh thương hiệu (Hoặc dùng màu Cam: 255, 193, 7)
            rowStyle.SelectionForeColor = System.Drawing.Color.White; // Chữ trắng nổi bật

            rowStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvBuilding.DefaultCellStyle = rowStyle;
            this.dgvBuilding.RowTemplate.Height = 45;
            this.dgvBuilding.GridColor = System.Drawing.Color.WhiteSmoke;

            this.dgvBuilding.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuilding_CellClick);
            this.pnlGridWrapper.Controls.Add(this.dgvBuilding);

            // Form Building
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuilding";
            this.Text = "FrmBuilding";
            this.pnlMain.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpList.ResumeLayout(false);
            this.grpList.PerformLayout();
            this.pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilding)).EndInit();
            this.ResumeLayout(false);
        }

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

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel grpInput;
        private System.Windows.Forms.Panel grpList;
        private System.Windows.Forms.Label lblTitleInput;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Label lblID, lblName, lblAddr, lblManager, lblPrice;
        private System.Windows.Forms.TextBox txtID, txtName, txtAddress, txtManager, txtPrice;
        private System.Windows.Forms.Panel lineID, lineName, lineAddr, lineManager, linePrice;
        private System.Windows.Forms.Button btnAdd, btnEdit, btnDelete, btnClear;
        private System.Windows.Forms.DataGridView dgvBuilding;
        private System.Windows.Forms.Panel pnlGridWrapper;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel lineSearch;
    }
}