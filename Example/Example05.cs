using System;
using System.Windows.Forms;
using System.IO;
namespace Example
{
    public partial class Example05 : Form
    {
        public Example05()
        {
            InitializeComponent();
        }

        private void Example05_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"D:\Key_Logger.txt", true);

                sw.Write(e.KeyCode.ToString() + " ");

                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }
    }
}