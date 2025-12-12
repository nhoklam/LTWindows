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

        // 1. Thêm dòng mới (Slide 136)
        private void btAddNew_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các control và thêm vào DataGridView
            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
        }

        // 2. Xóa dòng đang chọn (Slide 137)
        private void btDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có ô nào đang được chọn không để tránh lỗi
            if (dgvEmployee.CurrentCell != null)
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;

                // Kiểm tra nếu không phải là dòng mới (dòng trắng cuối cùng)
                if (idx < dgvEmployee.Rows.Count - 1)
                {
                    dgvEmployee.Rows.RemoveAt(idx);
                }
            }
        }

        // 3. Sự kiện khi chọn một dòng (Slide 137)
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;

            // Kiểm tra chỉ số dòng hợp lệ và không phải dòng mới chưa có dữ liệu
            if (idx >= 0 && idx < dgvEmployee.Rows.Count - 1)
            {
                // Lấy dữ liệu từ các cột (Cells) gán vào TextBox
                // Cột 0: Mã, Cột 1: Tên, Cột 2: Tuổi, Cột 3: Giới tính
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();

                // Chuyển đổi chuỗi "True"/"False" sang kiểu bool cho CheckBox
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