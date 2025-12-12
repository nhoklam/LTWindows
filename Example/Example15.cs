using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Example15 : Form
    {
        public Example15()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút OK: Hiển thị ngày dạng dài lên tiêu đề Form (Slide 110)
        // Ví dụ: "Monday, September 30, 2017"
        private void btOK_Click(object sender, EventArgs e)
        {
            this.Text = dtpDate.Value.ToLongDateString();
        }

        // Sự kiện khi thay đổi ngày trên lịch: Hiển thị ngày dạng ngắn lên tiêu đề Form (Slide 110)
        // Ví dụ: "30/09/2017"
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            this.Text = dtpDate.Value.ToShortDateString();
        }
    }
}