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
    public partial class Example07 : Form
    {
        public Example07()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbYear_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbYear.Text)) return;

            int year;
            if (int.TryParse(tbYear.Text, out year))
            {
                if (year > 2000)
                {
                    e.Cancel = true;
                    MessageBox.Show("Năm phải nhỏ hơn hoặc bằng 2000!", "Lỗi nhập liệu");
                }
            }
        }
    }
}
