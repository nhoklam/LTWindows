using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; // <-- Cần thêm thư viện này để dùng Point

namespace Example
{
    public class InfoWindows
    {
        public int Width { get; set; }
        public int Height { get; set; }
        // Thêm thuộc tính Location như Slide 38
        public Point Location { get; set; }
    }
}