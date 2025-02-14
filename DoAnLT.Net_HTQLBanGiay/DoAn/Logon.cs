using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAn
{
    public partial class Logon : Form
    {
        private DataConnection dc;  // Khai báo đối tượng DataConnection
        private SqlDataAdapter da;
        private SqlCommand cmd;
        public Logon()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        // Hàm thực thi lệnh SQL (INSERT, UPDATE, DELETE)
        private void ExecuteSQL(string sql, SqlParameter[] parameters)
        {
            string connectionString = "Data Source=QUIEZ; Initial Catalog=QLBangiay; Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddRange(parameters);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Hàm thực thi lệnh SQL trả về 1 giá trị (SELECT COUNT(*), ...)
        private object ExecuteScalar(string sql, SqlParameter[] parameters)
        {
            string connectionString = "Data Source=QUIEZ; Initial Catalog=QLBangiay; Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddRange(parameters);
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }


        private void btnDangKi_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ giao diện
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string email = txtEmail.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();

            // Kiểm tra nhập liệu
            if (string.IsNullOrWhiteSpace(tenDangNhap) ||
                string.IsNullOrWhiteSpace(matKhau) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(soDienThoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem tài khoản đã tồn tại chưa
            string checkSql = "SELECT COUNT(*) FROM TaiKhoanKhachHang WHERE TenDangNhap = @TenDangNhap OR Email = @Email OR SoDienThoai = @SoDienThoai";
            SqlParameter[] checkParams = {
        new SqlParameter("@TenDangNhap", SqlDbType.NVarChar) { Value = tenDangNhap },
        new SqlParameter("@Email", SqlDbType.NVarChar) { Value = email },
        new SqlParameter("@SoDienThoai", SqlDbType.NVarChar) { Value = soDienThoai }
    };

            int existingCount = (int)ExecuteScalar(checkSql, checkParams);
            if (existingCount > 0)
            {
                MessageBox.Show("Tên đăng nhập, email hoặc số điện thoại đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chèn tài khoản mới
            string insertSql = "INSERT INTO TaiKhoanKhachHang (TenDangNhap, MatKhau, Email, SoDienThoai) " +
                               "VALUES (@TenDangNhap, @MatKhau, @Email, @SoDienThoai)";

            SqlParameter[] insertParams = {
        new SqlParameter("@TenDangNhap", SqlDbType.NVarChar) { Value = tenDangNhap },
        new SqlParameter("@MatKhau", SqlDbType.NVarChar) { Value = matKhau }, // Cần mã hóa mật khẩu
        new SqlParameter("@Email", SqlDbType.NVarChar) { Value = email },
        new SqlParameter("@SoDienThoai", SqlDbType.NVarChar) { Value = soDienThoai }
    };

            try
            {
                ExecuteSQL(insertSql, insertParams);
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login f = new Login();
                f.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
