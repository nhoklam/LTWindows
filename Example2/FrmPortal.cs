using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Example
{
    public partial class FrmPortal : Form
    {
        // Sửa hàm khởi tạo để nhận tham số string
        public FrmPortal(string tenCuDan = "")
        {
            InitializeComponent();
        }

        // Nếu Visual Studio tự tạo constructor mặc định, hãy xóa nó đi hoặc sửa nó như trên
    }
}
