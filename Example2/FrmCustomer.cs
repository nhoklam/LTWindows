using System;
using System.Data;
using System.Drawing;
using System.IO; // Thư viện để xử lý file ảnh
using System.Windows.Forms;

namespace ADO_Example
{
    public partial class FrmCustomer : Form
    {
        // Đường dẫn thư mục ảnh trong dự án (bin/Debug/images)
        private string imageFolder = Application.StartupPath + "\\images\\";
        private string currentAvatarName = ""; // Lưu tên ảnh tạm thời khi chọn file

        public FrmCustomer()
        {
            InitializeComponent();

            // Tạo thư mục images nếu chưa có
            if (!Directory.Exists(imageFolder))
            {
                Directory.CreateDirectory(imageFolder);
            }

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = @"SELECT c.Id, c.Name, c.Phone, c.Company, c.Email, c.Avatar, 
                                        ISNULL(r.Name, N'Chưa xếp phòng') AS RoomName
                                 FROM Customers c
                                 LEFT JOIN Contracts ct ON c.Id = ct.CustomerId AND ct.Status = N'Hiệu lực'
                                 LEFT JOIN Rooms r ON ct.RoomId = r.Id";

                dgvCustomer.DataSource = DatabaseHelper.GetData(query);
                SetupGrid();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
        }

        private void SetupGrid()
        {
            if (dgvCustomer.Columns.Count > 0)
            {
                dgvCustomer.Columns["Avatar"].Visible = false; // Ẩn cột tên ảnh đi

                dgvCustomer.Columns["Id"].HeaderText = "Mã SV";
                dgvCustomer.Columns["Id"].Width = 60;

                dgvCustomer.Columns["Name"].HeaderText = "Họ Tên";
                dgvCustomer.Columns["Name"].Width = 180;

                dgvCustomer.Columns["Phone"].HeaderText = "SĐT";
                dgvCustomer.Columns["Phone"].Width = 100;

                dgvCustomer.Columns["Company"].HeaderText = "Trường / Quê Quán";
                dgvCustomer.Columns["Company"].Width = 180;

                dgvCustomer.Columns["Email"].HeaderText = "Email";
                dgvCustomer.Columns["Email"].Width = 150;

                if (dgvCustomer.Columns.Contains("RoomName"))
                {
                    dgvCustomer.Columns["RoomName"].HeaderText = "Phòng";
                    dgvCustomer.Columns["RoomName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        // --- XỬ LÝ CLICK VÀO LƯỚI ---
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

                // Xử lý hiển thị ảnh
                string avatarName = r.Cells["Avatar"].Value.ToString();
                if (!string.IsNullOrEmpty(avatarName))
                {
                    string fullPath = imageFolder + avatarName;
                    if (File.Exists(fullPath))
                    {
                        // Dùng FileStream để không bị lock file (giúp xóa/sửa dễ dàng)
                        using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                        {
                            picAvatar.Image = Image.FromStream(fs);
                        }
                        currentAvatarName = avatarName; // Lưu lại để dùng nếu update
                    }
                    else
                    {
                        picAvatar.Image = null; // File không tồn tại
                    }
                }
                else
                {
                    picAvatar.Image = null; // Không có ảnh
                }
            }
        }

        // --- CHỌN ẢNH TỪ MÁY ---
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picAvatar.Image = Image.FromFile(open.FileName); // Hiển thị tạm
                picAvatar.Tag = open.FileName; // Lưu đường dẫn gốc vào Tag để tí nữa copy
            }
        }

        // --- HÀM LƯU ẢNH VÀO FOLDER ---
        private string SaveImage()
        {
            // Nếu có chọn ảnh mới (Tag chứa đường dẫn file)
            if (picAvatar.Tag != null)
            {
                string sourcePath = picAvatar.Tag.ToString();
                // Tạo tên file mới ngẫu nhiên để không bị trùng (dùng GUID)
                string newFileName = Guid.NewGuid().ToString() + Path.GetExtension(sourcePath);
                string destPath = imageFolder + newFileName;

                try
                {
                    File.Copy(sourcePath, destPath, true); // Copy vào folder images
                    return newFileName;
                }
                catch { return ""; }
            }
            // Nếu không chọn ảnh mới, giữ nguyên ảnh cũ (nếu đang sửa)
            return currentAvatarName;
        }

        // --- CRUD ---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên!");
                return;
            }

            try
            {
                string avatarFile = SaveImage(); // Lưu ảnh và lấy tên file

                string query = $"INSERT INTO Customers (Name, Phone, Company, Email, Avatar) " +
                               $"VALUES (N'{txtName.Text}', '{txtPhone.Text}', N'{txtCompany.Text}', '{txtEmail.Text}', '{avatarFile}')";

                DatabaseHelper.ExecuteQuery(query);
                LoadData();
                ClearInput();
                MessageBox.Show("Thêm hồ sơ thành công!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "AUTO") return;
            try
            {
                string avatarFile = SaveImage(); // Lưu ảnh mới hoặc giữ ảnh cũ

                string query = $"UPDATE Customers SET Name=N'{txtName.Text}', Phone='{txtPhone.Text}', " +
                               $"Company=N'{txtCompany.Text}', Email='{txtEmail.Text}', Avatar='{avatarFile}' " +
                               $"WHERE Id={txtID.Text}";

                DatabaseHelper.ExecuteQuery(query);
                MessageBox.Show("Cập nhật thông tin thành công!");
                LoadData();
                ClearInput();
            }
            catch { MessageBox.Show("Lỗi cập nhật!"); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "AUTO") return;
            if (MessageBox.Show("Xóa hồ sơ sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    // Logic KTX: Nếu SV đang ở thì không được xóa
                    string checkQuery = $"SELECT COUNT(*) FROM Contracts WHERE CustomerId={txtID.Text} AND Status=N'Hiệu lực'";
                    DataTable dt = DatabaseHelper.GetData(checkQuery);
                    if (dt.Rows[0][0].ToString() != "0")
                    {
                        MessageBox.Show("Không thể xóa sinh viên đang ở trong KTX.");
                        return;
                    }

                    DatabaseHelper.ExecuteQuery($"DELETE FROM Customers WHERE Id={txtID.Text}");
                    LoadData();
                    ClearInput();
                }
                catch { MessageBox.Show("Lỗi khi xóa dữ liệu."); }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearInput();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string kw = txtSearch.Text.Trim();
            string query = $@"SELECT c.Id, c.Name, c.Phone, c.Company, c.Email, c.Avatar,
                                     ISNULL(r.Name, N'Chưa xếp phòng') AS RoomName
                              FROM Customers c
                              LEFT JOIN Contracts ct ON c.Id = ct.CustomerId AND ct.Status = N'Hiệu lực'
                              LEFT JOIN Rooms r ON ct.RoomId = r.Id
                              WHERE c.Name LIKE N'%{kw}%' OR c.Phone LIKE '%{kw}%' OR c.Company LIKE N'%{kw}%'";

            dgvCustomer.DataSource = DatabaseHelper.GetData(query);
            SetupGrid();
        }

        private void ClearInput()
        {
            txtID.Text = "AUTO";
            txtName.Clear(); txtPhone.Clear(); txtCompany.Clear(); txtEmail.Clear();
            picAvatar.Image = null; // Xóa ảnh trên picturebox
            picAvatar.Tag = null;   // Xóa đường dẫn file tạm
            currentAvatarName = ""; // Reset tên file
            txtName.Focus();
        }
    }
}