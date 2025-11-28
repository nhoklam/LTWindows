using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Example00 : Form
    {
        public Example00()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;

            this.Text = width.ToString() + " - " + height.ToString();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            // Lấy chiều rộng hiện tại của form
            int width = this.Size.Width;
            // Lấy chiều cao hiện tại của form
            int height = this.Size.Height;

            // Cập nhật tiêu đề form (Text) bằng chuỗi kết hợp
            // ToString() dùng để đổi số sang chữ
            this.Text = width.ToString() + " - " + height.ToString();
        }
    }
}
