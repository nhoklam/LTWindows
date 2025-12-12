using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Example14 : Form
    {
        public Example14()
        {
            InitializeComponent();
        }

        // Sự kiện khi bấm nút Tính tiền (Slide 106)
        private void btRun_Click(object sender, EventArgs e)
        {
            string msg = null;
            int disc = 0;

            // Kiểm tra RadioButton nào đang được chọn (Checked)
            if (rbMale.Checked == true)
                msg += "Ông ";
            if (rbFemale.Checked == true)
                msg += "Bà ";

            // Kiểm tra CheckBox có được chọn không
            if (ckDiscount.Checked == true)
            {
                // Slide 106 gán cứng giá trị là 5. 
                // Nếu muốn lấy từ ô nhập liệu, bạn có thể sửa thành: int.Parse(tbDiscount.Text)
                disc = int.Parse(tbDiscount.Text);
            }

            // Hiển thị kết quả
            tbResult.Text = msg + tbName.Text + " được giảm " + disc.ToString() + "%" + "\r\n";
        }

        // Sự kiện khi CheckBox thay đổi trạng thái (Slide 106)
        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            // Nếu check thì cho phép nhập (Enable = true), ngược lại thì khóa (Enable = false)
            if (ckDiscount.Checked == true)
                tbDiscount.Enabled = true;
            else
                tbDiscount.Enabled = false;
        }

        // Nút Thoát
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}