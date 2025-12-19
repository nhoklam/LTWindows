using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    public partial class Example23 : Form
    {
        PictureBox pb = new PictureBox();
        int x = 50; int y = 50;

        public Example23()
        {
            InitializeComponent();
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            pb.SizeMode = PictureBoxSizeMode.StretchImage; pb.Size = new Size(100, 100); pb.Location = new Point(x, y);
            this.Controls.Add(pb);

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pb.ImageLocation = dlg.FileName;
            }
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            x -= 10; pb.Location = new Point(x, y);
        }

        private void btRight_Click(object sender, EventArgs e)
        {
            x += 10; pb.Location = new Point(x, y);
        }
    }
}