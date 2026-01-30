using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ADO_Example
{
    public partial class FrmChatbot : Form
    {
        public FrmChatbot()
        {
            InitializeComponent();
            AppendMessage("Bot", "Xin chào! Em là trợ lý KTX. Anh/chị cần tìm phòng, tra cứu giá dịch vụ hay xem quy định ạ?");
        }

        // Sự kiện khi nhấn nút Gửi
        private async void btnSend_Click(object sender, EventArgs e)
        {
            await SendMessage();
        }

        // --- ĐÂY LÀ HÀM BẠN ĐANG THIẾU ---
        // Sự kiện khi nhấn phím Enter trong ô nhập liệu
        private async void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn tiếng "ding" của Windows
                await SendMessage();       // Gọi hàm gửi tin nhắn
            }
        }
        // ---------------------------------

        // Hàm xử lý gửi tin nhắn chung (để dùng cho cả nút Gửi và phím Enter)
        private async System.Threading.Tasks.Task SendMessage()
        {
            // Kiểm tra placeholder (nếu người dùng chưa nhập gì mà vẫn là chữ mờ)
            if (txtMessage.ForeColor == System.Drawing.Color.Gray || string.IsNullOrWhiteSpace(txtMessage.Text))
                return;

            string userMsg = txtMessage.Text.Trim();

            // Hiển thị tin nhắn người dùng
            AppendMessage("Bạn", userMsg);

            // Xóa ô nhập và reset lại placeholder nếu cần (logic reset ở Designer rồi)
            txtMessage.Clear();

            // Khóa nút để tránh spam
            btnSend.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                // Lấy dữ liệu ngữ cảnh từ Database
                string contextData = GetRichDatabaseContext();

                // Gọi API Gemini (hoặc Mockup nếu chưa có API)
                string aiResponse = await GeminiHelper.ChatWithGemini(userMsg, contextData);

                // Hiển thị phản hồi
                AppendMessage("Trợ lý KTX", aiResponse);
            }
            catch (Exception ex)
            {
                AppendMessage("Lỗi", "Không thể kết nối: " + ex.Message);
            }
            finally
            {
                btnSend.Enabled = true;
                this.Cursor = Cursors.Default;
                txtMessage.Focus(); // Đưa con trỏ chuột quay lại ô nhập
            }
        }

        // Hàm lấy dữ liệu thông minh từ Database để "mớm" cho AI
        private string GetRichDatabaseContext()
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                // 1. DỮ LIỆU TÒA NHÀ
                string sqlBuildings = "SELECT Name, LocationDesc, TotalFloors, GenderType FROM Buildings";
                DataTable dtBuild = DatabaseHelper.GetData(sqlBuildings);

                sb.AppendLine("[DANH SÁCH TÒA NHÀ & QUY ĐỊNH GIỚI TÍNH]:");
                if (dtBuild.Rows.Count > 0)
                {
                    foreach (DataRow r in dtBuild.Rows)
                    {
                        string gender = (r["GenderType"].ToString() == "1") ? "Dành cho NAM" : "Dành cho NỮ";
                        sb.AppendLine($"- Tòa {r["Name"]}: {gender}, cao {r["TotalFloors"]} tầng. Vị trí: {r["LocationDesc"]}.");
                    }
                }
                else { sb.AppendLine("Chưa có dữ liệu tòa nhà."); }
                sb.AppendLine();

                // 2. CHI TIẾT PHÒNG TRỐNG
                string sqlRooms = @"SELECT r.Name AS RoomName, r.Price, r.Area, 
                                   b.Name AS BuildingName, b.GenderType 
                            FROM Rooms r 
                            JOIN Buildings b ON r.BuildingId = b.Id 
                            WHERE r.Status = N'Còn trống'";

                DataTable dtEmpty = DatabaseHelper.GetData(sqlRooms);

                sb.AppendLine($"[DANH SÁCH PHÒNG CÒN TRỐNG ({dtEmpty.Rows.Count} phòng)]:");
                if (dtEmpty.Rows.Count > 0)
                {
                    foreach (DataRow r in dtEmpty.Rows)
                    {
                        string gender = (r["GenderType"].ToString() == "1") ? "Nam" : "Nữ";
                        sb.AppendLine($"- Phòng {r["RoomName"]} (Tòa {r["BuildingName"]} - Khu {gender}): Giá {Convert.ToDecimal(r["Price"]):N0} VNĐ, {r["Area"]}m2.");
                    }
                }
                else { sb.AppendLine("Hiện tại đã hết sạch phòng trống."); }
                sb.AppendLine();

                // 3. GIÁ DỊCH VỤ
                DataTable dtService = DatabaseHelper.GetData("SELECT Name, Price, Unit FROM Services");
                sb.AppendLine("[BẢNG GIÁ DỊCH VỤ HIỆN HÀNH]:");
                foreach (DataRow r in dtService.Rows)
                {
                    sb.AppendLine($"- {r["Name"]}: {Convert.ToDecimal(r["Price"]):N0} VNĐ / {r["Unit"]}");
                }
                sb.AppendLine();

                // 4. QUY ĐỊNH KHÁC
                DataTable dtConfig = DatabaseHelper.GetData("SELECT Description, CfgValue FROM SystemConfig");
                sb.AppendLine("[QUY ĐỊNH CHUNG]:");
                foreach (DataRow r in dtConfig.Rows)
                {
                    sb.AppendLine($"- {r["Description"]}: {r["CfgValue"]}");
                }
            }
            catch (Exception ex)
            {
                sb.AppendLine("Lỗi truy xuất dữ liệu database: " + ex.Message);
            }

            return sb.ToString();
        }

        // Hàm hiển thị tin nhắn lên giao diện
        private void AppendMessage(string sender, string msg)
        {
            rtbHistory.SelectionStart = rtbHistory.TextLength;
            rtbHistory.SelectionLength = 0;

            // Định dạng tên người gửi (In đậm + Màu sắc)
            rtbHistory.SelectionFont = new System.Drawing.Font(rtbHistory.Font, System.Drawing.FontStyle.Bold);
            if (sender == "Trợ lý KTX")
                rtbHistory.SelectionColor = System.Drawing.Color.FromArgb(0, 128, 0); // Màu xanh lá đậm
            else if (sender == "Lỗi")
                rtbHistory.SelectionColor = System.Drawing.Color.Red;
            else
                rtbHistory.SelectionColor = System.Drawing.Color.FromArgb(0, 102, 204); // Màu xanh dương (Bạn)

            rtbHistory.AppendText(sender + ": ");

            // Định dạng nội dung tin nhắn (Chữ thường + Màu đen)
            rtbHistory.SelectionFont = new System.Drawing.Font(rtbHistory.Font, System.Drawing.FontStyle.Regular);
            rtbHistory.SelectionColor = System.Drawing.Color.Black;
            rtbHistory.AppendText(msg + "\n\n");

            rtbHistory.ScrollToCaret(); // Tự động cuộn xuống dưới cùng
        }
    }
}