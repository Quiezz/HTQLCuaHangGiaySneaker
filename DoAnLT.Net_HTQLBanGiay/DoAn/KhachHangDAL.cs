using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn
{
    internal class KhachHangDAL
    {
        private DataConnection dc;
        private SqlDataAdapter da;
        private SqlCommand cmd;

        public KhachHangDAL()
        {
            dc = new DataConnection(); // Kết nối Database
        }

        // Lấy tất cả nhân viên từ bảng KhachHang
        public DataTable getAllKhachHang()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM KhachHang";

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
                MessageBox.Show("Lỗi khi lấy dữ liệu Khách hàng: " + ex.Message);
            }

            return dt;
        }

        // Thêm nhân viên mới vào bảng KhachHang
        public bool ThemKhachHang(KhachHang kh)
        {
            string sql = "INSERT INTO KhachHang (HoTen, NgaySinh, SDT, DiaChi, Email) " +
                         "VALUES (@HoTen, @NgaySinh, @SDT, @DiaChi, @Email)";

            using (SqlConnection con = dc.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = kh.HoTen ?? (object)DBNull.Value;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = kh.NgaySinh == DateTime.MinValue ? (object)DBNull.Value : kh.NgaySinh;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = kh.SDT ?? (object)DBNull.Value;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = kh.DiaChi ?? (object)DBNull.Value;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = kh.Email ?? (object)DBNull.Value;

                try
                {
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm Khách hàng: " + ex.ToString());
                    return false;
                }
            }
        }

        // Cập nhật thông tin nhân viên
        public bool SuaKhachHang(KhachHang kh)
        {
            string sql = "UPDATE KhachHang SET HoTen = @HoTen, NgaySinh = @NgaySinh, " +
                         "SDT = @SDT, DiaChi = @DiaChi, Email = @Email WHERE KhachHangID = @KhachHangID";

            using (SqlConnection con = dc.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.Add("@KhachHangID", SqlDbType.Int).Value = kh.KhachHangID;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = kh.HoTen;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = kh.NgaySinh;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = kh.SDT;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = kh.DiaChi;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = kh.Email;

                try
                {
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa Khách hàng: " + ex.Message);
                    return false;
                }
            }
        }

        // Xóa nhân viên theo ID
        public bool XoaKhachHang(int KhachHangID)
        {
            string sql = "DELETE FROM KhachHang WHERE KhachHangID = @KhachHangID";

            using (SqlConnection con = dc.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.Add("@KhachHangID", SqlDbType.Int).Value = KhachHangID;

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
        public DataTable TimKhachHang(string keyword)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM KhachHang WHERE HoTen LIKE @keyword OR SDT LIKE @keyword";

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
                MessageBox.Show("Lỗi khi tìm Khách hàng: " + ex.Message);
            }

            return dt;
        }
    }
}
