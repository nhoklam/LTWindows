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
    public partial class Example08 : Form
    {
        public Example08()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);      // Lấy giá trị x
            int y = int.Parse(tbSoY.Text);      // Lấy giá trị y
            int kq = x + y;                     // Tính tổng
            tbKetQua.Text = kq.ToString();      // Hiển thị kết quả (phải đổi sang chuỗi)
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;
            tbKetQua.Text = kq.ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form hiện tại
        }
    }
}
