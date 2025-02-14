using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    internal class KhachHangBLL
    {
        private KhachHangDAL dalKhachHang;

        public KhachHangBLL()
        {
            dalKhachHang = new KhachHangDAL(); // Tạo đối tượng kết nối với tầng DAL
        }

        // Lấy danh sách tất cả nhân viên
        public DataTable getAllKhachHang()
        {
            return dalKhachHang.getAllKhachHang();
        }

        // Thêm nhân viên mới
        public bool ThemKhachHang(KhachHang nv)
        {
            try
            {
                return dalKhachHang.ThemKhachHang(nv);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm Khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Sửa thông tin nhân viên
        public bool SuaKhachHang(KhachHang nv)
        {
            return dalKhachHang.SuaKhachHang(nv);
        }

        // Xóa nhân viên theo ID
        public bool XoaKhachHang(int KhachHangID)
        {
            return dalKhachHang.XoaKhachHang(KhachHangID);
        }

        // Tìm kiếm nhân viên theo tên hoặc ID
        public DataTable TimKhachHang(string keyword)
        {
            return dalKhachHang.TimKhachHang(keyword);
        }
    }
}
