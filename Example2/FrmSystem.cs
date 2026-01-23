using System;
using System.Data;
using System.Windows.Forms;

namespace ADO_Example
{
    public partial class FrmSystem : Form
    {
        public FrmSystem()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = "SELECT CfgKey, CfgValue, Description FROM SystemConfig";
                dgvConfig.DataSource = DatabaseHelper.GetData(query);

                if (dgvConfig.Columns.Count > 0)
                {
                    dgvConfig.Columns["CfgKey"].HeaderText = "MÃ THAM SỐ";
                    dgvConfig.Columns["CfgKey"].Width = 150;

                    dgvConfig.Columns["Description"].HeaderText = "MÔ TẢ";
                    dgvConfig.Columns["Description"].Width = 300;

                    dgvConfig.Columns["CfgValue"].HeaderText = "GIÁ TRỊ HIỆN TẠI";
                    dgvConfig.Columns["CfgValue"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvConfig.Columns["CfgValue"].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                }
            }
            catch { }
        }

        private void dgvConfig_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var r = dgvConfig.Rows[e.RowIndex];
                txtKey.Text = r.Cells["CfgKey"].Value.ToString();
                txtValue.Text = r.Cells["CfgValue"].Value.ToString();
                txtDesc.Text = r.Cells["Description"].Value.ToString();
                txtValue.Focus(); // Focus ngay vào ô Giá trị để sửa cho nhanh
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtKey.Text == "") return;
            try
            {
                // Chỉ cho phép sửa CfgValue (Giá trị)
                string query = $"UPDATE SystemConfig SET CfgValue = N'{txtValue.Text}' WHERE CfgKey = '{txtKey.Text}'";
                DatabaseHelper.ExecuteQuery(query);

                MessageBox.Show("Đã lưu cấu hình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }
    }
}