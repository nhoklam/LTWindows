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

        private void button24_Click(object sender, EventArgs e)
        {
            Example03 objEx1 = new Example03();
            objEx1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Example05 objEx1 = new Example05();
            objEx1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Example06 objEx1 = new Example06();
            objEx1.Show();
        }
    }
}
