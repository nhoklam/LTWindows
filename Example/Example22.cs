using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Example
{
    public partial class Example22 : Form
    {
        // 1. Khai báo List và BindingSource (Slide 149)
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

        // 2. Sự kiện Load: Kết nối BindingSource (Slide 149)
        private void Example22_Load(object sender, EventArgs e)
        {
            lstEmp = GetData();

            // Gán danh sách vào BindingSource
            bs.DataSource = lstEmp;

            // Gán BindingSource vào DataGridView
            // Nhờ bước này và DataPropertyName, dữ liệu sẽ tự hiện lên lưới
            dgvEmployee.DataSource = bs;
        }

        // 3. Sự kiện Thêm (Slide 149)
        private void btAddNew_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            // Nên dùng TryParse để tránh lỗi nếu nhập sai số
            int age = 0;
            int.TryParse(tbAge.Text, out age);
            em.Age = age;
            em.Gender = ckGender.Checked;

            // --- SỬA LỖI TẠI ĐÂY ---
            // lstEmp.Add(em);  <-- XÓA hoặc COMMENT dòng này đi

            // Chỉ cần dòng này là đủ, BindingSource sẽ tự thêm vào List và cập nhật Grid
            bs.Add(em);
        }
        // 4. Sự kiện Xóa (Slide 150)
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentCell != null)
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;

                // Xóa trong BindingSource
                bs.RemoveAt(idx);
                // Xóa trong List gốc (nếu cần đồng bộ)
                // Thực tế bs.RemoveAt thường đã xóa trong DataSource nếu nó hỗ trợ,
                // nhưng với List thường ta cần xóa thủ công để chắc chắn.
                // Tuy nhiên theo Slide 150 thì tác giả xóa cả 2.
                // lstEmp.RemoveAt(idx); 
            }
        }

        // 5. Sự kiện chọn dòng (Slide 150)
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            // Kiểm tra dòng hợp lệ (không phải dòng new row)
            if (idx >= 0 && idx < dgvEmployee.Rows.Count && !dgvEmployee.Rows[idx].IsNewRow)
            {
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();

                // Kiểm tra null trước khi convert để tránh lỗi
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