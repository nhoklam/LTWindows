using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    public partial class Example06 : Form
    {
        public Example06()
        {
            InitializeComponent();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            this.Text = "Article for Button";

            this.Size = new Size(500, 500);
        }
    }
}