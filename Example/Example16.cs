using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Example16 : Form
    {
        int count = 0;

        public Example16()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            count++;

            string name = tbName.Text;

            string gender = "Nam";
            if (rbFemale.Checked)
            {
                gender = "Nữ";
            }

            string dob = dtpDob.Value.ToShortDateString();

            string faculty = cbFaculty.SelectedItem.ToString();

            string result = count + ". " + name + "\r\n" +
            "   -Giới tính: " + gender + "\r\n" +
            "   -Ngày Sinh: " + dob + "\r\n" +
            "   -Khoa: " + faculty + "\r\n";
            tbDisplay.Text += result;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}