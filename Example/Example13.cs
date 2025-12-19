using System;
using System.Collections;
using System.Windows.Forms;

namespace Example
{
    public partial class Example13 : Form
    {
        public Example13()
        {
            InitializeComponent();
        }

        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Faculty f = new Faculty();
            f.Id = "K01";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02";
            f.Name = "Quản trị kinh doanh";
            f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K03"; f.Name = "Kế toán tài chính";
            f.Quantity = 5200;
            lst.Add(f);

            return lst;
        }

        private void Example13_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();

            cb_Faculty.DataSource = lst;

            cb_Faculty.DisplayMember = "Name";
        }

        private void cb_Faculty_SelectedValueChanged(object sender, EventArgs e)
        {
            cb_Faculty.ValueMember = "Id";
            string id = cb_Faculty.SelectedValue.ToString();
            tbDisplay.Text = "Bạn đã chọn khoa có mã : " + id;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            cb_Faculty.ValueMember = "Name";
            string name = cb_Faculty.SelectedValue.ToString();
            tbDisplay.Text = "Bạn đã chọn khoa có tên : " + name;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();
        }
    }
}