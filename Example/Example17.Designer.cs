namespace Example
{
    partial class Example17
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lbSong = new System.Windows.Forms.ListBox();
            this.lbFavorite = new System.Windows.Forms.ListBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.btDeselect = new System.Windows.Forms.Button();
            this.btSelectAll = new System.Windows.Forms.Button();
            this.btDeselectAll = new System.Windows.Forms.Button();
            this.lblSong = new System.Windows.Forms.Label();
            this.lblFavorite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSong (Danh sách bài hát nguồn)
            // 
            this.lbSong.FormattingEnabled = true;
            // Dữ liệu mẫu từ Slide 116
            this.lbSong.Items.AddRange(new object[] {
            "Giấc mơ Chapi",
            "Đôi mắt Pleiku",
            "Em Muốn Sống Bên Anh Trọn Đời",
            "H'Zen Lên Rẫy",
            "Còn Thương Nhau Thì Về Buôn Mê Thuột",
            "Ly Cà Phê Ban Mê",
            "Đi tìm lời ru mặt trời"});
            this.lbSong.Location = new System.Drawing.Point(20, 40);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(200, 250);
            this.lbSong.TabIndex = 0;
            this.lbSong.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSong_MouseDoubleClick);
            // 
            // lbFavorite (Danh sách yêu thích)
            // 
            this.lbFavorite.FormattingEnabled = true;
            this.lbFavorite.Location = new System.Drawing.Point(330, 40);
            this.lbFavorite.Name = "lbFavorite";
            this.lbFavorite.Size = new System.Drawing.Size(200, 250);
            this.lbFavorite.TabIndex = 1;
            this.lbFavorite.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbFavorite_MouseDoubleClick);
            // 
            // btSelect (>)
            // 
            this.btSelect.Location = new System.Drawing.Point(240, 60);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(70, 30);
            this.btSelect.TabIndex = 2;
            this.btSelect.Text = ">";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btDeselect (<)
            // 
            this.btDeselect.Location = new System.Drawing.Point(240, 100);
            this.btDeselect.Name = "btDeselect";
            this.btDeselect.Size = new System.Drawing.Size(70, 30);
            this.btDeselect.TabIndex = 3;
            this.btDeselect.Text = "<";
            this.btDeselect.UseVisualStyleBackColor = true;
            this.btDeselect.Click += new System.EventHandler(this.btDeselect_Click);
            // 
            // btSelectAll (>>)
            // 
            this.btSelectAll.Location = new System.Drawing.Point(240, 140);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(70, 30);
            this.btSelectAll.TabIndex = 4;
            this.btSelectAll.Text = ">>";
            this.btSelectAll.UseVisualStyleBackColor = true;
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);
            // 
            // btDeselectAll (<<)
            // 
            this.btDeselectAll.Location = new System.Drawing.Point(240, 180);
            this.btDeselectAll.Name = "btDeselectAll";
            this.btDeselectAll.Size = new System.Drawing.Size(70, 30);
            this.btDeselectAll.TabIndex = 5;
            this.btDeselectAll.Text = "<<";
            this.btDeselectAll.UseVisualStyleBackColor = true;
            this.btDeselectAll.Click += new System.EventHandler(this.btDeselectAll_Click);
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Location = new System.Drawing.Point(20, 20);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(94, 13);
            this.lblSong.TabIndex = 6;
            this.lblSong.Text = "Danh sách bài hát";
            // 
            // lblFavorite
            // 
            this.lblFavorite.AutoSize = true;
            this.lblFavorite.Location = new System.Drawing.Point(330, 20);
            this.lblFavorite.Name = "lblFavorite";
            this.lblFavorite.Size = new System.Drawing.Size(131, 13);
            this.lblFavorite.TabIndex = 7;
            this.lblFavorite.Text = "Danh sách bài hát ưa thích";
            // 
            // Example17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 320);
            this.Controls.Add(this.lblFavorite);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.btDeselectAll);
            this.Controls.Add(this.btSelectAll);
            this.Controls.Add(this.btDeselect);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.lbFavorite);
            this.Controls.Add(this.lbSong);
            this.Name = "Example17";
            this.Text = "Music Selector";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.ListBox lbFavorite;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btDeselect;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.Button btDeselectAll;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.Label lblFavorite;
    }
}