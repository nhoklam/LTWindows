using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
namespace Example
{
    public partial class Example03 : Form
    {
        string path = @"D:\form_config.xml";
        InfoWindows iw = new InfoWindows();

        public Example03()
        {
            InitializeComponent();
        }

        public void Write(InfoWindows iw)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                using (StreamWriter file = new StreamWriter(path))
                {
                    writer.Serialize(file, iw);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }

        public InfoWindows Read()
        {
            try
            {
                if (!File.Exists(path)) return null;

                XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
                using (StreamReader file = new StreamReader(path))
                {
                    return (InfoWindows)reader.Deserialize(file);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void Example03_Load(object sender, EventArgs e)
        {
            InfoWindows savedInfo = Read();
            if (savedInfo != null)
            {
                this.Width = savedInfo.Width;
                this.Height = savedInfo.Height;
                this.Location = savedInfo.Location;
            }
        }

        private void Example03_FormClosing(object sender, FormClosingEventArgs e)
        {
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            iw.Location = this.Location;
            Write(iw);
        }
    }
}