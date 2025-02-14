using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    internal class QLGiayDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public QLGiayDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllGiay()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Giay";

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
                MessageBox.Show("Lỗi khi lấy dữ liệu giày: " + ex.Message);
            }

            return dt;
        }

        public bool ThemGiay(Giay giay)
        {
            string sql = "INSERT INTO Giay (TenGiay, MauSac, KichCo, GiaBan, SoLuongTon, KhoID, NhaCungCapID) VALUES (@TenGiay, @MauSac, @KichCo, @GiaBan, @SoLuongTon, @KhoID, @NhaCungCapID)";

            using (SqlConnection con = dc.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.Add("@TenGiay", SqlDbType.NVarChar).Value = giay.TenGiay;
                cmd.Parameters.Add("@MauSac", SqlDbType.NVarChar).Value = giay.MauSac;
                cmd.Parameters.Add("@KichCo", SqlDbType.Int).Value = giay.KichCo;
                cmd.Parameters.Add("@GiaBan", SqlDbType.Decimal).Value = giay.GiaBan;
                cmd.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = giay.SoLuongTon;
                cmd.Parameters.Add("@KhoID", SqlDbType.Int).Value = giay.KhoID;
                cmd.Parameters.Add("@NhaCungCapID", SqlDbType.Int).Value = giay.NhaCungCap; 

                try
                {
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();

                    if (result > 0)
                        return true;
                    else
                    {
                        Console.WriteLine("Không có dòng nào được thêm.");
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi: " + e.Message);
                    return false;
                }
            }
        }


        public bool SuaGiay(Giay giay)
        {
            string sql = "UPDATE Giay SET TenGiay = @TenGiay, MauSac = @MauSac, KichCo = @KichCo, GiaBan = @GiaBan, SoLuongTon = @SoLuongTon, KhoID = @KhoID, NhaCungCapID = @NhaCungCapID WHERE GiayID = @GiayID";

            using (SqlConnection con = dc.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.Add("@GiayID", SqlDbType.Int).Value = giay.GiayID;
                cmd.Parameters.Add("@TenGiay", SqlDbType.NVarChar).Value = giay.TenGiay;
                cmd.Parameters.Add("@MauSac", SqlDbType.NVarChar).Value = giay.MauSac;
                cmd.Parameters.Add("@KichCo", SqlDbType.Int).Value = giay.KichCo;
                cmd.Parameters.Add("@GiaBan", SqlDbType.Decimal).Value = giay.GiaBan;
                cmd.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = giay.SoLuongTon;
                cmd.Parameters.Add("@KhoID", SqlDbType.Int).Value = giay.KhoID;
                cmd.Parameters.Add("@NhaCungCapID", SqlDbType.Int).Value = giay.NhaCungCap;

                try
                {
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi: " + e.Message);
                    return false;
                }
            }
        }


        public bool XoaGiay(int giayID)
        {
            string sql = "DELETE FROM Giay WHERE GiayID = @GiayID";

            using (SqlConnection con = dc.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.Add("@GiayID", SqlDbType.Int).Value = giayID;

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
        public DataTable TimGiay(string giay)
        {
            DataTable dt = new DataTable();  // Tạo DataTable để chứa kết quả

            string sql = "SELECT * FROM Giay WHERE TenGiay LIKE @TenGiay";

            try
            {
                using (SqlConnection con = dc.GetConnection()) // Mở kết nối
                using (SqlCommand cmd = new SqlCommand(sql, con)) // Tạo command
                {
                    cmd.Parameters.Add("@TenGiay", SqlDbType.NVarChar).Value = "%" + giay + "%"; // Dùng parameter

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd)) // Tạo SqlDataAdapter
                    {
                        da.Fill(dt);  // Đổ dữ liệu vào DataTable
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm giày: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt; // Trả về kết quả tìm kiếm
        }


    }
}
