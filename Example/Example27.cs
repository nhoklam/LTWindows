using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    public partial class Example27 : Form
    {

        PictureBox pbEgg = new PictureBox();
        System.Windows.Forms.Timer tmEgg = new System.Windows.Forms.Timer();
        int xEgg = 300;
        int yEgg = 0;
        int yDelta = 3;

        PictureBox pbBasket = new PictureBox();
        int xBasket = 300;
        int yBasket = 380; int xDeltaBasket = 10;
        public Example27()
        {
            InitializeComponent();

            this.Load += new EventHandler(Example27_Load);
            this.KeyDown += new KeyEventHandler(Example27_KeyDown);
        }

        private void Example27_Load(object? sender, EventArgs e)
        {
            tmEgg.Interval = 10;
            tmEgg.Tick += new EventHandler(tmEgg_Tick);
            tmEgg.Start();

            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(50, 50);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;
            this.Controls.Add(pbEgg);

            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(80, 80);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;
            this.Controls.Add(pbBasket);

            try
            {
                pbEgg.Image = Image.FromFile(@"Images\egg.png");
                pbBasket.Image = Image.FromFile(@"Images\basket.png");
            }
            catch
            {
                pbEgg.BackColor = Color.Gold; pbBasket.BackColor = Color.Blue;
            }
        }

        void tmEgg_Tick(object? sender, EventArgs e)
        {
            yEgg += yDelta;

            if (yEgg > this.ClientSize.Height - pbEgg.Height)
            {
                yEgg = 0;
                Random rnd = new Random();
                xEgg = rnd.Next(0, this.ClientSize.Width - pbEgg.Width);
            }

            pbEgg.Location = new Point(xEgg, yEgg);

        }

        private void Example27_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyValue == 39 && (xBasket < this.ClientSize.Width - pbBasket.Width))
            {
                xBasket += xDeltaBasket;
            }

            if (e.KeyValue == 37 && xBasket > 0)
            {
                xBasket -= xDeltaBasket;
            }

            pbBasket.Location = new Point(xBasket, yBasket);
        }
    }
}