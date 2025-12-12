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
    public partial class Example09 : Form
    {
        public Example09()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;

            // Cộng dồn chuỗi kết quả vào TextBox (Dùng += hoặc nối chuỗi như slide)
            // "\r\n" là ký tự xuống dòng
            tbKetQua.Text = tbKetQua.Text + x.ToString() + " + " + y.ToString() + " = " + kq.ToString() + "\r\n";
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;

            // Cộng dồn kết quả phép nhân và xuống dòng
            tbKetQua.Text = tbKetQua.Text + x.ToString() + " * " + y.ToString() + " = " + kq.ToString() + "\r\n";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            // Mở file "Calculator.txt" để ghi. 
            // Tham số 'true' ở cuối nghĩa là ghi nối tiếp (append), không xóa nội dung cũ.
            StreamWriter sw = new StreamWriter("Calculator.txt", true);
            sw.Write(tbKetQua.Text);
            sw.Close(); // Nhớ đóng file sau khi ghi xong
            MessageBox.Show("Đã lưu thành công!");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
