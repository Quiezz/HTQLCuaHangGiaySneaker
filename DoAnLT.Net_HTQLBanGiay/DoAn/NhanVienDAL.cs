using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn
{
    internal class NhanVienDAL
    {
        private DataConnection dc;
        private SqlDataAdapter da;
        private SqlCommand cmd;

        public NhanVienDAL()
        {
            dc = new DataConnection(); // Kết nối Database
        }

        // Lấy tất cả nhân viên từ bảng NHANVIEN
        public DataTable getAllNhanVien()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM NHANVIEN";

            try
            {
                using (SqlConnection con = dc.GetConnection())
                using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
                {
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu nhân viên: " + ex.Message);
            }

            return dt;
        }

        // Thêm nhân viên mới vào bảng NHANVIEN
        public bool ThemNhanVien(NhanVien nv)
        {
            string sql = "INSERT INTO NHANVIEN (HoTen, NgaySinh, GioiTinh, SDT, DiaChi, Email, ChucVu) " +
                         "VALUES (@HoTen, @NgaySinh, @GioiTinh, @SDT, @DiaChi, @Email, @ChucVu)";

            using (SqlConnection con = dc.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nv.HoTen;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nv.NgaySinh;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nv.GioiTinh;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nv.SDT;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nv.DiaChi;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = nv.Email;
                cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = nv.ChucVu;

                try
                {
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
                    return false;
                }
            }
        }

        // Cập nhật thông tin nhân viên
        public bool SuaNhanVien(NhanVien nv)
        {
            string sql = "UPDATE NHANVIEN SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, " +
                         "SDT = @SDT, DiaChi = @DiaChi, Email = @Email, ChucVu = @ChucVu WHERE NhanVienID = @NhanVienID";

            using (SqlConnection con = dc.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.Add("@NhanVienID", SqlDbType.Int).Value = nv.NhanVienID; // Đảm bảo tham số đúng
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nv.HoTen;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nv.NgaySinh;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nv.GioiTinh;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nv.SDT;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nv.DiaChi;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = nv.Email;
                cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = nv.ChucVu;

                try
                {
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi SQL khi cập nhật nhân viên: " + ex.Message);
                    return false;
                }
            }
        }


        // Xóa nhân viên theo ID
        public bool XoaNhanVien(int nhanvienID)
        {
            string sql = "DELETE FROM NHANVIEN WHERE NhanVienID = @NhanVienID";

            using (SqlConnection con = dc.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.Add("@NhanVienID", SqlDbType.Int).Value = nhanvienID;

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi: " + e.Message);
                    return false;
                }
            }
        }


        // Tìm kiếm nhân viên theo tên hoặc số điện thoại
        public DataTable TimNhanVien(string keyword)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM NHANVIEN WHERE HoTen LIKE @keyword OR SDT LIKE @keyword";

            try
            {
                using (SqlConnection con = dc.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@keyword", SqlDbType.NVarChar).Value = "%" + keyword + "%";

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm nhân viên: " + ex.Message);
            }

            return dt;
        }
    }
}
