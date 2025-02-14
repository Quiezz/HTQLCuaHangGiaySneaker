using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAn
{
    public partial class Login : Form
    {
        private DataConnection dc;  // Khai báo đối tượng DataConnection
        private SqlDataAdapter da;
        private SqlCommand cmd;

        public Login()
        {
            InitializeComponent();
            dc = new DataConnection();  // 🔥 Quan trọng: Khởi tạo dc ở đây!
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public bool KiemTraDangNhap(string Username, string Password)
        {
            bool isValid = false;
            string sql = "SELECT COUNT(*) FROM Admin WHERE username = @username AND password = @password";

            try
            {
                using (SqlConnection con = dc.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Username", Username.Trim()); // Xóa khoảng trắng không mong muốn
                    cmd.Parameters.AddWithValue("@Password", Password.Trim());

                    con.Open();
                    int count = (int)cmd.ExecuteScalar(); // Lấy số lượng bản ghi tìm thấy
                    isValid = count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message);
            }

            return isValid;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string Username = txtBoxUsername.Text.Trim();
            string Password = txtBoxPassWord.Text.Trim();

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KiemTraDangNhap(Username, Password))  // Gọi hàm trực tiếp
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TableManager f = new TableManager();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
