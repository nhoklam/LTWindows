using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ADO_Example
{
    public class GeminiHelper
    {
        // ⚠️ Dán Key API của bạn vào đây
        private const string API_KEY = "AIzaSyB3vVUG7GKk8Ies_q8tihGkdD9GnRjtVH0";
        private const string API_URL = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent?key=" + API_KEY;

        public static async Task<string> ChatWithGemini(string userQuestion, string systemContext)
        {
            using (HttpClient client = new HttpClient())
            {
                // TẠO CÂU NHẮC (PROMPT) CHUYÊN SÂU
                // Đây là bí quyết để AI thông minh hơn:
                string prompt = $@"
Bạn là Trợ lý ảo thông minh của Hệ thống Quản lý Ký Túc Xá (KTX).
Nhiệm vụ của bạn là hỗ trợ sinh viên và quản lý dựa trên dữ liệu thực tế được cung cấp dưới đây.

=== DỮ LIỆU HỆ THỐNG THỜI GIAN THỰC (DATABASE) ===
{systemContext}
==================================================

QUY TẮC TRẢ LỜI:
1. Chỉ sử dụng thông tin trong phần 'DỮ LIỆU HỆ THỐNG' để trả lời. Nếu không có thông tin, hãy nói 'Hiện tại em chưa có dữ liệu về vấn đề này'.
2. Khi nói về phòng trống, hãy liệt kê tên các phòng cụ thể nếu có.
3. Khi nói về giá tiền, hãy format số đẹp (ví dụ: 3,500đ thay vì 3500).
4. Giọng điệu: Thân thiện, lễ phép (xưng 'em', gọi 'anh/chị'), ngắn gọn và đi thẳng vào vấn đề.
5. Nếu người dùng hỏi các câu xã giao (xin chào, cảm ơn), hãy đáp lại tự nhiên.

Câu hỏi của người dùng: ""{userQuestion}""
Trả lời:";

                var requestBody = new
                {
                    contents = new[]
                    {
                        new
                        {
                            parts = new[] { new { text = prompt } }
                        }
                    }
                };

                string jsonContent = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync(API_URL, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = await response.Content.ReadAsStringAsync();
                        JObject json = JObject.Parse(responseString);
                        return json["candidates"][0]["content"]["parts"][0]["text"].ToString();
                    }
                    else
                    {
                        return "Lỗi kết nối AI: " + response.StatusCode;
                    }
                }
                catch (Exception ex)
                {
                    return "Lỗi hệ thống: " + ex.Message;
                }
            }
        }
    }
}