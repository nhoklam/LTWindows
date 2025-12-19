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

        private void btOK_Click(object sender, EventArgs e)
        {
            this.Text = dtpDate.Value.ToLongDateString();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            this.Text = dtpDate.Value.ToShortDateString();
        }
    }
}