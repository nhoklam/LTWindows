using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    public partial class Example26 : Form
    {
        PictureBox pbEgg = new PictureBox();

        System.Windows.Forms.Timer tmEgg = new System.Windows.Forms.Timer();

        int xEgg = 300; int yEgg = 0; int yDelta = 3;
        public Example26()
        {
            InitializeComponent();
            this.Load += new EventHandler(Example26_Load);
        }

        private void Example26_Load(object? sender, EventArgs e)
        {
            tmEgg.Interval = 10;
            tmEgg.Tick += new EventHandler(tmEgg_Tick);
            tmEgg.Start();

            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(100, 100);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;

            this.Controls.Add(pbEgg);

            try
            {
                pbEgg.Image = Image.FromFile(@"D:\LTwindows\LTWindows\Example\Images\egg.jpg");
            }
            catch
            {
                pbEgg.BackColor = Color.Gold;
            }
        }

        void tmEgg_Tick(object? sender, EventArgs e)
        {
            yEgg += yDelta;

            if (yEgg > this.ClientSize.Height - pbEgg.Height || yEgg <= 0)
            {
                try
                {
                    pbEgg.Image = Image.FromFile(@"D:\LTwindows\LTWindows\Example\Images\egg_broken.jpg");
                }
                catch
                {
                    pbEgg.BackColor = Color.Gray;
                }

            }

            pbEgg.Location = new Point(xEgg, yEgg);
        }
    }
}