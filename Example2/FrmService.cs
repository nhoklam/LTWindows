using System;
using System.Data;
using System.Windows.Forms;

namespace ADO_Example
{
    public partial class FrmService : Form
    {
        public FrmService()
        {
            InitializeComponent();

            // Chặn lỗi DataGrid (phòng hờ format tiền tệ)
            this.dgvService.DataError += delegate { };

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Ép kiểu DECIMAL để tránh lỗi format
                string query = "SELECT Id, Name, CAST(Price AS DECIMAL(18,0)) AS Price, Unit FROM Services";
                dgvService.DataSource = DatabaseHelper.GetData(query);
                FormatGrid();
            }
            catch { }
        }

        private void FormatGrid()
        {
            if (dgvService.Columns.Count > 0)
            {
                dgvService.Columns["Id"].HeaderText = "MÃ DV";
                dgvService.Columns["Id"].Width = 80;

                dgvService.Columns["Name"].HeaderText = "TÊN DỊCH VỤ";
                dgvService.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvService.Columns["Price"].HeaderText = "ĐƠN GIÁ";
                dgvService.Columns["Price"].DefaultCellStyle.Format = "N0"; // 50,000
                dgvService.Columns["Price"].Width = 150;

                dgvService.Columns["Unit"].HeaderText = "ĐƠN VỊ TÍNH";
                dgvService.Columns["Unit"].Width = 150;
            }
        }

        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var r = dgvService.Rows[e.RowIndex];
                txtID.Text = r.Cells["Id"].Value.ToString();
                txtName.Text = r.Cells["Name"].Value.ToString();
                txtPrice.Text = string.Format("{0:0}", r.Cells["Price"].Value);
                txtUnit.Text = r.Cells["Unit"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "") return;
            try
            {
                string price = txtPrice.Text.Replace(",", "");
                if (string.IsNullOrEmpty(price)) price = "0";

                string query = $"INSERT INTO Services (Name, Price, Unit) VALUES (N'{txtName.Text}', {price}, N'{txtUnit.Text}')";
                DatabaseHelper.ExecuteQuery(query);
                LoadData(); ClearInput();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi thêm: " + ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;
            try
            {
                string price = txtPrice.Text.Replace(",", "");
                string query = $"UPDATE Services SET Name=N'{txtName.Text}', Price={price}, Unit=N'{txtUnit.Text}' WHERE Id={txtID.Text}";
                DatabaseHelper.ExecuteQuery(query);
                LoadData(); ClearInput();
            }
            catch { MessageBox.Show("Lỗi sửa!"); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;
            if (MessageBox.Show("Xóa dịch vụ này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseHelper.ExecuteQuery($"DELETE FROM Services WHERE Id={txtID.Text}");
                LoadData(); ClearInput();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearInput();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string kw = txtSearch.Text.Trim();
            string query = $"SELECT Id, Name, CAST(Price AS DECIMAL(18,0)) AS Price, Unit FROM Services " +
                           $"WHERE Name LIKE N'%{kw}%'";
            dgvService.DataSource = DatabaseHelper.GetData(query);
            FormatGrid();
        }

        private void ClearInput()
        {
            txtID.Text = ""; txtName.Clear(); txtPrice.Clear(); txtUnit.Clear();
            txtName.Focus();
        }
    }
}