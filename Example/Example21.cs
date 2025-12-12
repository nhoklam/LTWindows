using System;
using System.Collections.Generic; // Để dùng List<>
using System.Windows.Forms;

namespace Example
{
    public partial class Example21 : Form
    {
        // 1. Khai báo danh sách chứa nhân viên (Slide 142)
        List<Employee> lst;

        public Example21()
        {
            InitializeComponent();
        }

        // 2. Hàm tạo dữ liệu giả lập (Slide 141)
        public List<Employee> GetData()
        {
            List<Employee> list = new List<Employee>();

            Employee em = new Employee();
            em.Id = "53418";
            em.Name = "Trần Tiến";
            em.Age = 20;
            em.Gender = true; // Nam
            list.Add(em);

            em = new Employee();
            em.Id = "53416";
            em.Name = "Nguyễn Cường";
            em.Age = 25;
            em.Gender = false; // Nữ
            list.Add(em);

            em = new Employee();
            em.Id = "53417";
            em.Name = "Nguyễn Hào";
            em.Age = 23;
            em.Gender = true;
            list.Add(em);

            return list;
        }

        // 3. Sự kiện Load Form: Nạp dữ liệu vào List và Grid (Slide 142)
        private void Example21_Load(object sender, EventArgs e)
        {
            lst = GetData(); // Lấy dữ liệu mẫu

            // Duyệt danh sách và thêm vào DataGridView
            foreach (Employee em in lst)
            {
                dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
            }
        }

        // 4. Sự kiện Thêm mới (Slide 143)
        private void btAddNew_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng nhân viên mới từ ô nhập liệu
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            em.Age = int.Parse(tbAge.Text); // Lưu ý: Cần nhập số hợp lệ
            em.Gender = ckGender.Checked;

            // Thêm vào LIST (quan trọng)
            lst.Add(em);

            // Thêm vào GRID để hiển thị
            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
        }

        // 5. Sự kiện Xóa (Slide 144)
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentCell != null)
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;

                if (idx >= 0 && idx < lst.Count) // Kiểm tra index hợp lệ
                {
                    // Xóa trong LIST trước
                    lst.RemoveAt(idx);

                    // Sau đó xóa trên GRID
                    dgvEmployee.Rows.RemoveAt(idx);
                }
            }
        }

        // 6. Sự kiện chọn dòng để hiển thị lại (Slide 144)
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0 && idx < dgvEmployee.Rows.Count - 1)
            {
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();
                ckGender.Checked = bool.Parse(dgvEmployee.Rows[idx].Cells[3].Value.ToString());
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}