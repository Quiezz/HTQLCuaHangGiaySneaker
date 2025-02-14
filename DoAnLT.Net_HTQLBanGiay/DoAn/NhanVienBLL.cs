using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    internal class NhanVienBLL
    {
        private NhanVienDAL dalNhanVien;

        public NhanVienBLL()
        {
            dalNhanVien = new NhanVienDAL(); // Tạo đối tượng kết nối với tầng DAL
        }

        // Lấy danh sách tất cả nhân viên
        public DataTable getAllNhanVien()
        {
            return dalNhanVien.getAllNhanVien();
        }

        // Thêm nhân viên mới
        public bool ThemNhanVien(NhanVien nv)
        {
            try
            {
                return dalNhanVien.ThemNhanVien(nv);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Sửa thông tin nhân viên
        public bool SuaNhanVien(NhanVien nv)
        {
            return dalNhanVien.SuaNhanVien(nv);
        }

        // Xóa nhân viên theo ID
        public bool XoaNhanVien(int nhanVienID)
        {
            return dalNhanVien.XoaNhanVien(nhanVienID);
        }

        // Tìm kiếm nhân viên theo tên hoặc ID
        public DataTable TimNhanVien(string keyword)
        {
            return dalNhanVien.TimNhanVien(keyword);
        }
    }
}
