namespace Example
{
    partial class Example18
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
            this.lblSong = new System.Windows.Forms.Label();
            this.lblFavorite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSong (Danh sách nguồn)
            // 
            this.lbSong.FormattingEnabled = true;
            this.lbSong.Location = new System.Drawing.Point(20, 40);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(200, 250);
            this.lbSong.TabIndex = 0;
            // 
            // lbFavorite (Danh sách đích)
            // 
            this.lbFavorite.FormattingEnabled = true;
            this.lbFavorite.Location = new System.Drawing.Point(330, 40);
            this.lbFavorite.Name = "lbFavorite";
            this.lbFavorite.Size = new System.Drawing.Size(200, 250);
            this.lbFavorite.TabIndex = 1;
            // 
            // btSelect (Nút >)
            // 
            this.btSelect.Location = new System.Drawing.Point(240, 140);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(70, 30);
            this.btSelect.TabIndex = 2;
            this.btSelect.Text = ">";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Location = new System.Drawing.Point(20, 20);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(94, 13);
            this.lblSong.TabIndex = 3;
            this.lblSong.Text = "Danh sách bài hát";
            // 
            // lblFavorite
            // 
            this.lblFavorite.AutoSize = true;
            this.lblFavorite.Location = new System.Drawing.Point(330, 20);
            this.lblFavorite.Name = "lblFavorite";
            this.lblFavorite.Size = new System.Drawing.Size(131, 13);
            this.lblFavorite.TabIndex = 4;
            this.lblFavorite.Text = "Danh sách bài hát ưa thích";
            // 
            // Example18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 320);
            this.Controls.Add(this.lblFavorite);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.lbFavorite);
            this.Controls.Add(this.lbSong);
            this.Name = "Example18";
            this.Text = "Music Selector (Object)";
            this.Load += new System.EventHandler(this.Example18_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.ListBox lbFavorite;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.Label lblFavorite;
    }
}