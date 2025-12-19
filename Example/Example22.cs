using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Example
{
    public partial class Example22 : Form
    {
        List<Employee> lstEmp;
        BindingSource bs = new BindingSource();

        public Example22()
        {
            InitializeComponent();
        }

        public List<Employee> GetData()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Id = "53418", Name = "Trần Tiến", Age = 20, Gender = true });
            list.Add(new Employee() { Id = "53416", Name = "Nguyễn Cường", Age = 25, Gender = false });
            list.Add(new Employee() { Id = "53417", Name = "Nguyễn Hào", Age = 23, Gender = true });
            return list;
        }

        private void Example22_Load(object sender, EventArgs e)
        {
            lstEmp = GetData();

            bs.DataSource = lstEmp;

            dgvEmployee.DataSource = bs;
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            int age = 0;
            int.TryParse(tbAge.Text, out age);
            em.Age = age;
            em.Gender = ckGender.Checked;


            bs.Add(em);
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentCell != null)
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;

                bs.RemoveAt(idx);
            }
        }

        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0 && idx < dgvEmployee.Rows.Count && !dgvEmployee.Rows[idx].IsNewRow)
            {
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();

                if (dgvEmployee.Rows[idx].Cells[3].Value != null)
                {
                    ckGender.Checked = (bool)dgvEmployee.Rows[idx].Cells[3].Value;
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}