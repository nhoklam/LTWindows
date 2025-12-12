using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Example11 : Form
    {
        // 1. Khai báo biến toàn cục (Theo Slide 83)
        decimal memory = 0;
        decimal workingMemory = 0;
        string opr = "";

        public Example11()
        {
            InitializeComponent();
        }

        // 2. Hàm xử lý sự kiện chung cho TẤT CẢ các nút (Theo Slide 84 -> 90)
        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender; // Lấy nút vừa bấm

            // --- Nhóm 1: Nhập số và dấu chấm (Slide 84) ---
            // Kiểm tra nếu là số (0-9) hoặc dấu chấm (.)
            if ((char.IsDigit(bt.Text, 0) && bt.Text.Length == 1) || bt.Text == ".")
            {
                // Nếu màn hình đang là "0" và bấm số khác 0 thì thay thế, ngược lại thì nối thêm
                if (txtDisplay.Text == "0" && bt.Text != ".")
                {
                    txtDisplay.Text = bt.Text;
                }
                else
                {
                    // Chặn không cho nhập nhiều dấu chấm
                    if (bt.Text == "." && txtDisplay.Text.Contains("."))
                    {
                        return;
                    }
                    txtDisplay.Text += bt.Text;
                }
            }

            // --- Nhóm 2: Các phép toán cơ bản (+, -, *, /) (Slide 86) ---
            else if (bt.Text == "*" || bt.Text == "/" || bt.Text == "+" || bt.Text == "-")
            {
                opr = bt.Text;
                workingMemory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }

            // --- Nhóm 3: Dấu bằng (=) (Slide 87) ---
            else if (bt.Text == "=")
            {
                decimal secondValue = decimal.Parse(txtDisplay.Text);
                switch (opr)
                {
                    case "+":
                        txtDisplay.Text = (workingMemory + secondValue).ToString();
                        break;
                    case "-":
                        txtDisplay.Text = (workingMemory - secondValue).ToString();
                        break;
                    case "*":
                        txtDisplay.Text = (workingMemory * secondValue).ToString();
                        break;
                    case "/":
                        // Kiểm tra chia cho 0
                        if (secondValue != 0)
                            txtDisplay.Text = (workingMemory / secondValue).ToString();
                        else
                            MessageBox.Show("Không thể chia cho 0");
                        break;
                }
            }

            // --- Nhóm 4: Các phép toán một ngôi (±, √, %, 1/x) (Slide 88) ---
            else if (bt.Text == "±")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = -currVal;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "√")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                if (currVal >= 0)
                {
                    currVal = (decimal)Math.Sqrt((double)currVal);
                    txtDisplay.Text = currVal.ToString();
                }
            }
            else if (bt.Text == "%")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = currVal / 100;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "1/x")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                if (currVal != 0)
                {
                    currVal = 1 / currVal;
                    txtDisplay.Text = currVal.ToString();
                }
            }

            // --- Nhóm 5: Xóa và Backspace (Slide 89 & 90) ---
            else if (bt.Text == "←") // Backspace
            {
                if (txtDisplay.TextLength != 0)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.TextLength - 1);
                    if (txtDisplay.Text == "") txtDisplay.Text = "0"; // Nếu xóa hết thì về 0
                }
            }
            else if (bt.Text == "C") // Clear All (Slide 90)
            {
                workingMemory = 0;
                opr = "";
                txtDisplay.Clear();
            }
            else if (bt.Text == "CE") // Clear Entry (Slide 90)
            {
                txtDisplay.Clear();
            }

            // --- Nhóm 6: Bộ nhớ (Memory) (Slide 89 & 90) ---
            else if (bt.Text == "MC") // Memory Clear
            {
                memory = 0;
            }
            else if (bt.Text == "MR") // Memory Read
            {
                txtDisplay.Text = memory.ToString();
            }
            else if (bt.Text == "MS") // Memory Save
            {
                memory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            else if (bt.Text == "M+") // Memory Add (Slide 90)
            {
                memory = memory + decimal.Parse(txtDisplay.Text);
            }
            else if (bt.Text == "M-") // Memory Subtract (Slide 90)
            {
                memory = memory - decimal.Parse(txtDisplay.Text);
            }
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}