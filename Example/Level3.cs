using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Example
{
    public partial class Level3 : Form
    {
        PictureBox pbBasket = new PictureBox();
        PictureBox pbEgg = new PictureBox();
        PictureBox pbChicken = new PictureBox();
        Label lblScore = new Label();

        System.Windows.Forms.Timer tmEgg = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer tmChicken = new System.Windows.Forms.Timer();
        WMPLib.WindowsMediaPlayer gameMusic = new WMPLib.WindowsMediaPlayer();
        SoundPlayer soundCollect = new SoundPlayer(@"D:\LTWindows\Example\Sounds\breaking.wav");

        Image imgEggNormal;
        Image imgEggBroken;
        bool isBroken = false;
        int brokenCount = 0;

        int score = 0;
        int targetScore = 20;
        int xDeltaChicken = 26; int yDeltaEgg = 18; int xDeltaBasket = 120;

        int xBasket = 600; int yBasket = 680;
        int xChicken = 300; int yChicken = 10;
        int xEgg = 300; int yEgg = 10;

        public Level3()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            this.Text = "LEVEL 3 (FINAL) - Mục tiêu: " + targetScore + " điểm";
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Load += new EventHandler(Level3_Load);
            this.KeyDown += new KeyEventHandler(Level3_KeyDown);
            this.MouseMove += new MouseEventHandler(Game_MouseMove);
        }

        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            xBasket = e.X - (pbBasket.Width / 2);
            if (xBasket < 0) xBasket = 0;
            if (xBasket > this.ClientSize.Width - pbBasket.Width)
                xBasket = this.ClientSize.Width - pbBasket.Width;
            pbBasket.Location = new Point(xBasket, yBasket);
        }

        private void Level3_Load(object sender, EventArgs e)
        {
            try
            {
                imgEggNormal = Image.FromFile(@"D:\LTWindows\Example\Images\egg.png");
                imgEggBroken = Image.FromFile(@"D:\LTWindows\Example\Images\egg_broken.png");
                this.BackgroundImage = Image.FromFile(@"D:\LTWindows\Example\Images\background.jpg");
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch { }

            tmEgg.Interval = 10;
            tmEgg.Tick += tmEgg_Tick;
            tmEgg.Start();

            tmChicken.Interval = 10;
            tmChicken.Tick += tmChicken_Tick;
            tmChicken.Start();

            yBasket = this.ClientSize.Height - 80;

            SetupPictureBox(pbBasket, xBasket, yBasket, 70, 70, @"D:\LTWindows\Example\Images\basket.png");

            SetupPictureBox(pbEgg, xEgg, yEgg, 40, 50, "");
            if (imgEggNormal != null) pbEgg.Image = imgEggNormal;

            SetupPictureBox(pbChicken, xChicken, yChicken, 100, 100, @"D:\LTWindows\Example\Images\chicken.png");

            lblScore.Text = "Level 3 - Score: 0 / " + targetScore;
            lblScore.Font = new Font("Arial", 14, FontStyle.Bold);
            lblScore.AutoSize = true;
            lblScore.Location = new Point(10, 10);
            lblScore.ForeColor = Color.DarkRed; lblScore.BackColor = Color.Transparent;
            this.Controls.Add(lblScore);

            try
            {
                gameMusic.URL = @"D:\LTWindows\Example\Sounds\music.mp3";
                gameMusic.settings.setMode("loop", true);
                gameMusic.settings.volume = 50;
                gameMusic.controls.play();
            }
            catch { }

            try { soundCollect.LoadAsync(); } catch { }
        }

        void SetupPictureBox(PictureBox pb, int x, int y, int w, int h, string path)
        {
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(w, h);
            pb.Location = new Point(x, y);
            pb.BackColor = Color.Transparent;
            this.Controls.Add(pb);
            if (path != "")
            {
                try { pb.Image = Image.FromFile(path); } catch { pb.BackColor = Color.Orange; }
            }
        }

        void tmEgg_Tick(object sender, EventArgs e)
        {
            if (isBroken)
            {
                brokenCount++;
                if (brokenCount > 30)
                {
                    ResetEgg();
                    isBroken = false;
                    brokenCount = 0;
                }
                return;
            }

            yEgg += yDeltaEgg;
            pbEgg.Location = new Point(xEgg, yEgg);

            if (pbEgg.Bounds.IntersectsWith(pbBasket.Bounds))
            {
                score++;
                lblScore.Text = "Level 3 - Score: " + score + " / " + targetScore;

                ResetEgg();
                try { soundCollect.Play(); } catch { }

                if (score >= targetScore)
                {
                    WinLevel();
                    return;
                }
            }

            if (yEgg > this.ClientSize.Height - pbEgg.Height)
            {
                isBroken = true;
                pbEgg.Image = imgEggBroken;
                yEgg = this.ClientSize.Height - pbEgg.Height;
                pbEgg.Location = new Point(xEgg, yEgg);
            }
        }

        void ResetEgg()
        {
            pbEgg.Image = imgEggNormal; yEgg = yChicken + pbChicken.Height;
            xEgg = xChicken + (pbChicken.Width / 2) - (pbEgg.Width / 2);
            pbEgg.Location = new Point(xEgg, yEgg);
        }

        void WinLevel()
        {
            tmEgg.Stop();
            tmChicken.Stop();
            gameMusic.controls.stop();
            MessageBox.Show("CHÚC MỪNG! BẠN ĐÃ PHÁ ĐẢO GAME HỨNG TRỨNG!", "WINNER");


            this.Hide();
        }

        void tmChicken_Tick(object sender, EventArgs e)
        {
            xChicken += xDeltaChicken;
            if (xChicken > this.ClientSize.Width - pbChicken.Width || xChicken <= 0)
            {
                xDeltaChicken = -xDeltaChicken;
            }
            pbChicken.Location = new Point(xChicken, yChicken);
        }

        private void Level3_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}