using System;

namespace DoAn
{
    internal class NhanVien
    {
        public int NhanVienID { get; set; }  // Khóa chính, kiểu int
        public string HoTen { get; set; }  // nvarchar(100)

        public DateTime NgaySinh { get; set; }  // Kiểu DateTime để khớp với SQL 'date'

        public string GioiTinh { get; set; }  // nvarchar(10), có thể là "Nam" hoặc "Nữ"
        public string SDT { get; set; }  // nvarchar(15), lưu số điện thoại dưới dạng string
        public string DiaChi { get; set; }  // nvarchar(255)
        public string Email { get; set; }  // nvarchar(100)
        public string ChucVu { get; set; }  // nvarchar(50)
    }
}
