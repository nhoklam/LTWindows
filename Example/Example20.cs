using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Example20 : Form
    {
        public Example20()
        {
            InitializeComponent();
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentCell != null)
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;

                if (idx < dgvEmployee.Rows.Count - 1)
                {
                    dgvEmployee.Rows.RemoveAt(idx);
                }
            }
        }

        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;

            if (idx >= 0 && idx < dgvEmployee.Rows.Count - 1)
            {
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();

                string genderValue = dgvEmployee.Rows[idx].Cells[3].Value.ToString();
                ckGender.Checked = bool.Parse(genderValue);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}