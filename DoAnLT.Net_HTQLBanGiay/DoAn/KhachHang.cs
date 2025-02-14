using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    internal class KhachHang
    {
        public int KhachHangID { get; set; }  // Khóa chính, kiểu int
        public string HoTen { get; set; }  // nvarchar(100)
        public DateTime NgaySinh { get; set; }  // Kiểu DateTime để khớp với SQL 'date'
        public string SDT { get; set; }  // nvarchar(15), lưu số điện thoại dưới dạng string
        public string DiaChi { get; set; }  // nvarchar(255)
        public string Email { get; set; }  // nvarchar(100)
    }
}

