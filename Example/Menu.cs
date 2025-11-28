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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Example00 objEx1 = new Example00();
            objEx1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Example01 objEx1 = new Example01();
            objEx1.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Example02 objEx1 = new Example02();
            objEx1.Show();
        }
    }
}
