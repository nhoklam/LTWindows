using System;
using System.Drawing; // <-- Cần thêm thư viện này để dùng Size
using System.Windows.Forms;

namespace Example
{
    public partial class Example06 : Form
    {
        public Example06()
        {
            InitializeComponent();
        }

        // Sự kiện khi bấm nút OK
        private void bt_OK_Click(object sender, EventArgs e)
        {
            // Thay đổi tiêu đề của Form
            this.Text = "Article for Button";

            // Thay đổi kích thước Form thành 500x500
            this.Size = new Size(500, 500);
        }
    }
}