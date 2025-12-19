using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Example24 : Form
    {
        int second = 0;

        public Example24()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            tmStopwatch.Interval = 1000; tmStopwatch.Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            tmStopwatch.Stop();
        }

        private void tmStopwatch_Tick(object sender, EventArgs e)
        {
            second++;
            lblDisplay.Text = second.ToString();

        }
    }
}