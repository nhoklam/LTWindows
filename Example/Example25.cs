using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    public partial class Example25 : Form
    {
        PictureBox pb = new PictureBox();
        System.Windows.Forms.Timer tmGame = new System.Windows.Forms.Timer();

        int xBall = 0;
        int yBall = 0;

        int xDelta = 5;
        int yDelta = 5;

        public Example25()
        {
            InitializeComponent();
        }

        private void Example25_Load_1(object sender, EventArgs e)
        {
            tmGame.Interval = 10; tmGame.Tick += new EventHandler(tmGame_Tick); tmGame.Start();
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(50, 50); pb.Location = new Point(xBall, yBall);

            pb.ImageLocation = @"Images\egg.png";


            this.Controls.Add(pb);
        }

        void tmGame_Tick(object sender, EventArgs e)
        {
            xBall += xDelta;
            yBall += yDelta;

            if (xBall > this.ClientSize.Width - pb.Width || xBall <= 0)
            {
                xDelta = -xDelta;
            }

            if (yBall > this.ClientSize.Height - pb.Height || yBall <= 0)
            {
                yDelta = -yDelta;
            }

            pb.Location = new Point(xBall, yBall);
        }
    }
}