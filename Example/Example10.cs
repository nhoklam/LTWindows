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
    public partial class Example10 : Form
    {
        // 1. Khai báo biến toàn cục (Global Variables) để lưu trữ giá trị và phép toán
        // Theo Slide 78
        decimal workingMemory = 0; // Lưu số hạng đầu tiên
        string opr = "";           // Lưu phép toán (+ hoặc *)
        public Example10()
        {
            InitializeComponent();
        }

        private void tbDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt0.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt1.Text; // Slide 78
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt2.Text; // Slide 78
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt3.Text;
        }

        private void btDot_Click(object sender, EventArgs e)
        {
            // Kiểm tra để tránh nhập 2 dấu chấm (tùy chọn thêm)
            if (!tbDisplay.Text.Contains("."))
            {
                tbDisplay.Text += ".";
            }
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            opr = btPlus.Text; // Lưu dấu "+" vào biến opr
            workingMemory = decimal.Parse(tbDisplay.Text); // Lưu số hiện tại vào bộ nhớ
            tbDisplay.Clear(); // Xóa màn hình để nhập số thứ hai
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            opr = btMul.Text; // Lưu dấu "*"
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        private void btEquals_Click(object sender, EventArgs e)
        {
            // Lấy số thứ hai từ màn hình
            decimal secondValue = decimal.Parse(tbDisplay.Text);

            // Kiểm tra phép toán đã chọn trước đó và tính toán
            if (opr == "+")
            {
                tbDisplay.Text = (workingMemory + secondValue).ToString();
            }

            if (opr == "*")
            {
                tbDisplay.Text = (workingMemory * secondValue).ToString();
            }

            // Slide 79 gợi ý dùng if(opr == ...), bạn có thể dùng switch-case cũng được.
        }
    }
}
