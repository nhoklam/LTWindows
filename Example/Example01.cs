using System;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Example
{
    public partial class Example01 : Form
    {
        string path = @"D:\form.xml";
        public Example01()
        {
            InitializeComponent();
        }
        public void Write(InfoWindows iw)
        {
            XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));

            StreamWriter file = new StreamWriter(path);

            writer.Serialize(file, iw);

            file.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();

            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;

            Write(iw);
        }
    }
}
