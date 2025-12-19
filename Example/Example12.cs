using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Example12 : Form
    {
        public Example12()
        {
            InitializeComponent();
        }

        private void Example12_Load(object sender, EventArgs e)
        {
            cb_Faculty.SelectedIndex = 2;
        }

        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_Faculty.SelectedIndex;
            tbDisplay.Text = "Bạn đã chọn khoa thứ: " + index.ToString();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            string item = cb_Faculty.SelectedItem.ToString();
            tbDisplay.Text = "Bạn là sinh viên khoa : " + item;
        }
    }
}