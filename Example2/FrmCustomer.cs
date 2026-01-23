using System;
using System.Data;
using System.Windows.Forms;

namespace ADO_Example
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM Customers";
                dgvCustomer.DataSource = DatabaseHelper.GetData(query);

                if (dgvCustomer.Columns.Count > 0)
                {
                    dgvCustomer.Columns["Id"].HeaderText = "Mã KH";
                    dgvCustomer.Columns["Id"].Width = 80;
                    dgvCustomer.Columns["Name"].HeaderText = "Họ Tên";
                    dgvCustomer.Columns["Name"].Width = 200;
                    dgvCustomer.Columns["Phone"].HeaderText = "Số Điện Thoại";
                    dgvCustomer.Columns["Phone"].Width = 150;
                    dgvCustomer.Columns["Company"].HeaderText = "Công Ty / Đơn Vị";
                    dgvCustomer.Columns["Company"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvCustomer.Columns["Email"].HeaderText = "Email";
                    dgvCustomer.Columns["Email"].Width = 200;
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // --- SỰ KIỆN CLICK GRID ---
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvCustomer.Rows[e.RowIndex];
                txtID.Text = r.Cells["Id"].Value.ToString();
                txtName.Text = r.Cells["Name"].Value.ToString();
                txtPhone.Text = r.Cells["Phone"].Value.ToString();
                txtCompany.Text = r.Cells["Company"].Value.ToString();
                txtEmail.Text = r.Cells["Email"].Value.ToString();
            }
        }

        // --- CRUD ---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "") return;
            try
            {
                string query = $"INSERT INTO Customers (Name, Phone, Company, Email) VALUES (N'{txtName.Text}', '{txtPhone.Text}', N'{txtCompany.Text}', '{txtEmail.Text}')";
                DatabaseHelper.ExecuteQuery(query);
                LoadData(); ClearInput();
            }
            catch { MessageBox.Show("Lỗi thêm mới!"); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "AUTO") return;
            try
            {
                string query = $"UPDATE Customers SET Name=N'{txtName.Text}', Phone='{txtPhone.Text}', Company=N'{txtCompany.Text}', Email='{txtEmail.Text}' WHERE Id={txtID.Text}";
                DatabaseHelper.ExecuteQuery(query);
                MessageBox.Show("Cập nhật xong!");
                LoadData(); ClearInput();
            }
            catch { MessageBox.Show("Lỗi cập nhật!"); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "AUTO") return;
            if (MessageBox.Show("Xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DatabaseHelper.ExecuteQuery($"DELETE FROM Customers WHERE Id={txtID.Text}");
                    LoadData(); ClearInput();
                }
                catch { MessageBox.Show("Không thể xóa (Khách hàng đang có hợp đồng)."); }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearInput();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string kw = txtSearch.Text.Trim();
            string query = $"SELECT * FROM Customers WHERE Name LIKE N'%{kw}%' OR Phone LIKE '%{kw}%' OR Company LIKE N'%{kw}%'";
            dgvCustomer.DataSource = DatabaseHelper.GetData(query);
        }

        private void ClearInput()
        {
            txtID.Text = "AUTO"; txtName.Clear(); txtPhone.Clear(); txtCompany.Clear(); txtEmail.Clear();
            txtName.Focus();
        }
    }
}