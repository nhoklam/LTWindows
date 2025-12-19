using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Example19 : Form
    {
        public Example19()
        {
            InitializeComponent();
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";

            dlg.Filter = "JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = dlg.FileName;
            }
        }
    }
}