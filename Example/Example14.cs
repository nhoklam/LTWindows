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

        private void btRun_Click(object sender, EventArgs e)
        {
            string msg = null;
            int disc = 0;

            if (rbMale.Checked == true)
                msg += "Ông ";
            if (rbFemale.Checked == true)
                msg += "Bà ";

            if (ckDiscount.Checked == true)
            {
                disc = int.Parse(tbDiscount.Text);
            }

            tbResult.Text = msg + tbName.Text + " được giảm " + disc.ToString() + "%" + "\r\n";
        }

        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true)
                tbDiscount.Enabled = true;
            else
                tbDiscount.Enabled = false;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}