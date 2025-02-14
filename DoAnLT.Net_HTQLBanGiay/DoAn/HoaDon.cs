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
using DoAn;

namespace DoAn
{

    public partial class HoaDon : Form
    {
    
        public HoaDon()
        {
            InitializeComponent();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In hóa đơn thành công!");
        }

        private void btnDongHD_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        public static class Functions
        {
            private static string connectionString = "Data Source = QUIEZ; Initial Catalog = QLBangiay; Integrated Security = true";

            public static System.Data.DataTable GetDataToTable(string sql, SqlParameter[] parameters = null)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public static System.Data.DataTable GetDataToTable(string sql, SqlParameter[] parameters = null)
        {
            string connectionString = "Data Source=QUIEZ;Initial Catalog=QLBangiay;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();

                conn.Open();
                da.Fill(dt);
                conn.Close();

                return dt;
            }
        }

        public void ExecuteSQL(string sql, SqlParameter[] parameters = null)
        {
            string connectionString = "Data Source=QUIEZ;Initial Catalog=QLBangiay;Integrated Security=true";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                conn.Open();
                cmd.ExecuteNonQuery(); // Thực thi SQL (INSERT, UPDATE, DELETE)
            }
        }

        private void LoadDataGridView()
        {
            string sql = "SELECT CTHoaDonID, HoaDonID, GiayID, SoLuong, DonGia, ThanhTien FROM CTHOADON";
            System.Data.DataTable dt = GetDataToTable(sql, null);
            dataGridViewHoaDon.DataSource = dt;

            dataGridViewHoaDon.AllowUserToAddRows = false;
            dataGridViewHoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadHoaDonID()
        {
            string sql = "SELECT HoaDonID FROM HOADON";
            System.Data.DataTable dt = GetDataToTable(sql, null);

            cmbHoaDonID.DataSource = dt;
            cmbHoaDonID.DisplayMember = "HoaDonID";
            cmbHoaDonID.ValueMember = "HoaDonID";
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadHoaDonID();
            LoadGiayID();
            LoadKhachHangID();
            LoadNhanVienID();
            Console.WriteLine("cmbKhachHangID.DataSource: " + (cmbKhachHangID.DataSource != null ? "Có dữ liệu" : "NULL"));
            LoadMaCTHoaDon();
        }
        
        private void TinhThanhTien()
        {
            if (decimal.TryParse(txtGiaBan.Text, out decimal donGia) &&
                int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                decimal thanhTien = donGia * soLuong;
                txtThanhTien.Text = thanhTien.ToString("N0"); // Hiển thị số có dấu phân cách
            }
            else
            {
                txtThanhTien.Text = "0";
            }
        }

        // Sự kiện thay đổi giá trị của txtDonGia
        private void txtDongia_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        // Sự kiện thay đổi giá trị của txtSoLuong
        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void LoadNhanVienID()
        {
            string sql = "SELECT NhanVienID, HoTen FROM NHANVIEN";
            System.Data.DataTable dt = GetDataToTable(sql, null);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ngắt sự kiện để tránh lỗi khi load dữ liệu
            cmbNhanVienID.SelectedIndexChanged -= cmbNhanVienID_SelectedIndexChanged;

            cmbNhanVienID.DataSource = dt;
            cmbNhanVienID.DisplayMember = "NhanVienID";  // Hiển thị tên nhân viên
            cmbNhanVienID.ValueMember = "NhanVienID";  // Giá trị là mã nhân viên

            // Đăng ký lại sự kiện
            cmbNhanVienID.SelectedIndexChanged += cmbNhanVienID_SelectedIndexChanged;
        }

        private void cmbNhanVienID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNhanVienID.SelectedValue == null) return;

            string sql = "SELECT HoTen FROM NHANVIEN WHERE NhanVienID = @NhanVienID";
            SqlParameter[] parameters =
            {
            new SqlParameter("@NhanVienID", SqlDbType.Int) { Value = cmbNhanVienID.SelectedValue
            }
        };

            System.Data.DataTable dt = GetDataToTable(sql, parameters);
            if (dt.Rows.Count > 0)
            {
                txtTenNhanVien.Text = dt.Rows[0]["HoTen"].ToString();
            }
        }
        private void LoadKhachHangID()
        {
            string sql = "SELECT KhachHangID, HoTen FROM KHACHHANG";
            System.Data.DataTable dt = GetDataToTable(sql, null);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ngắt sự kiện để tránh lỗi khi load dữ liệu
            cmbKhachHangID.SelectedIndexChanged -= cmbKhachHangID_SelectedIndexChanged;

            cmbKhachHangID.DataSource = dt;
            cmbKhachHangID.DisplayMember = "KhachHangID";  // Hiển thị tên khách hàng
            cmbKhachHangID.ValueMember = "KhachHangID";  // Lưu giá trị là ID

            // Đăng ký lại sự kiện sau khi load xong dữ liệu
            cmbKhachHangID.SelectedIndexChanged += cmbKhachHangID_SelectedIndexChanged;
        }

        private void cmbKhachHangID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhachHangID.SelectedValue == null || cmbKhachHangID.SelectedValue.ToString() == "")
                return;

            int khachHangID;
            if (!int.TryParse(cmbKhachHangID.SelectedValue.ToString(), out khachHangID))
            {
                MessageBox.Show("Lỗi khi lấy Mã Khách Hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "SELECT HoTen, DiaChi, SDT FROM KHACHHANG WHERE KhachHangID = @KhachHangID";
            SqlParameter[] parameters = {
        new SqlParameter("@KhachHangID", SqlDbType.Int) { Value = khachHangID }
    };

            System.Data.DataTable dt = GetDataToTable(sql, parameters);
            if (dt.Rows.Count > 0)
            {
                txtTenKhachHang.Text = dt.Rows[0]["HoTen"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtSoDienThoai.Text = dt.Rows[0]["SDT"].ToString();
            }
        }

        private void LoadGiayID()
        {
            string sql = "SELECT GiayID, TenGiay FROM GIAY";
            System.Data.DataTable dt = GetDataToTable(sql, null);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu giày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ngắt sự kiện để tránh lỗi khi load dữ liệu
            cmbGiayID.SelectedIndexChanged -= cmbGiayID_SelectedIndexChanged;

            cmbGiayID.DataSource = dt;
            cmbGiayID.DisplayMember = "GiayID";  // Hiển thị mã giày
            cmbGiayID.ValueMember = "GiayID";  // Lưu giá trị là ID

            // Đăng ký lại sự kiện sau khi load xong dữ liệu
            cmbGiayID.SelectedIndexChanged += cmbGiayID_SelectedIndexChanged;
        }
        private void cmbGiayID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGiayID.SelectedValue == null || cmbGiayID.SelectedValue.ToString() == "")
                return;

            int giayID;
            if (!int.TryParse(cmbGiayID.SelectedValue.ToString(), out giayID))
            {
                MessageBox.Show("Lỗi khi lấy Mã Giày", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "SELECT TenGiay, GiaBan FROM GIAY WHERE GiayID = @GiayID";
            SqlParameter[] parameters = {
        new SqlParameter("@GiayID", SqlDbType.Int) { Value = giayID }
    };

            System.Data.DataTable dt = GetDataToTable(sql, parameters);
            if (dt.Rows.Count > 0)
            {
                TenGiay.Text = dt.Rows[0]["TenGiay"].ToString();
                txtGiaBan.Text = dt.Rows[0]["GiaBan"].ToString();
            }
        }
        private void LoadMaCTHoaDon()
        {
            string sql = "SELECT CTHoaDonID FROM CTHOADON";
            System.Data.DataTable dt = GetDataToTable(sql, null);

            cmbMaCTHoaDon.DataSource = dt;
            cmbMaCTHoaDon.DisplayMember = "CTHoaDonID";
            cmbMaCTHoaDon.ValueMember = "CTHoaDonID";

            // Đảm bảo combobox không bị lỗi khi load lần đầu
            cmbMaCTHoaDon.SelectedIndex = -1;
        }

        private void cmbMaCTHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaCTHoaDon.SelectedValue == null || cmbMaCTHoaDon.SelectedIndex == -1)
            {
             
                return;
            }

            int maCTHoaDon;
            if (!int.TryParse(cmbMaCTHoaDon.SelectedValue.ToString(), out maCTHoaDon))
            {
                return; // Tránh lỗi nếu không thể chuyển đổi
            }

            // Truy vấn lấy thông tin từ CTHOADON
            string sql = "SELECT HoaDonID, GiayID, SoLuong, DonGia, (SoLuong * DonGia) AS ThanhTien " +
                         "FROM CTHOADON WHERE CTHoaDonID = @CTHoaDonID";

            SqlParameter[] parameters = {
        new SqlParameter("@CTHoaDonID", SqlDbType.Int) { Value = maCTHoaDon }
    };

            System.Data.DataTable dt = GetDataToTable(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                int hoaDonID = Convert.ToInt32(dt.Rows[0]["HoaDonID"]);

                cmbHoaDonID.Text = hoaDonID.ToString();
                cmbGiayID.SelectedValue = dt.Rows[0]["GiayID"];
                txtSoLuong.Text = dt.Rows[0]["SoLuong"].ToString();
                txtGiaBan.Text = dt.Rows[0]["DonGia"].ToString();
                txtThanhTien.Text = dt.Rows[0]["ThanhTien"].ToString();

                // Lấy thêm thông tin từ HOADON và KHACHHANG
                LoadThongTinHoaDon(hoaDonID);
            }
           
        }

        private void LoadThongTinHoaDon(int hoaDonID)
        {
            string sql = "SELECT H.KhachHangID, K.HoTen, K.DiaChi, K.SDT, " +
                         "H.NhanVienID, N.HoTen " +
                         "FROM HOADON H " +
                         "JOIN KHACHHANG K ON H.KhachHangID = K.KhachHangID " +
                         "JOIN NHANVIEN N ON H.NhanVienID = N.NhanVienID " +
                         "WHERE H.HoaDonID = @HoaDonID";

            SqlParameter[] parameters = {
        new SqlParameter("@HoaDonID", SqlDbType.Int) { Value = hoaDonID }
    };

            System.Data.DataTable dt = GetDataToTable(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                cmbKhachHangID.SelectedValue = dt.Rows[0]["KhachHangID"];
                txtTenKhachHang.Text = dt.Rows[0]["HoTen"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtSoDienThoai.Text = dt.Rows[0]["SDT"].ToString();
                cmbNhanVienID.SelectedValue = dt.Rows[0]["NhanVienID"];
                txtTenNhanVien.Text = dt.Rows[0]["HoTen"].ToString();
            }
        }
        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (cmbHoaDonID.SelectedValue == null || cmbGiayID.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text) || string.IsNullOrWhiteSpace(txtGiaBan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int hoaDonID = Convert.ToInt32(cmbHoaDonID.SelectedValue);
                int giayID = Convert.ToInt32(cmbGiayID.SelectedValue);
                int soLuong = Convert.ToInt32(txtSoLuong.Text);
                decimal donGia = Convert.ToDecimal(txtGiaBan.Text);
                decimal thanhTien = soLuong * donGia;

                string sql = "INSERT INTO CTHOADON (HoaDonID, GiayID, SoLuong, DonGia) " +
                             "VALUES (@HoaDonID, @GiayID, @SoLuong, @DonGia)";

                SqlParameter[] parameters = {
            new SqlParameter("@HoaDonID", SqlDbType.Int) { Value = hoaDonID },
            new SqlParameter("@GiayID", SqlDbType.Int) { Value = giayID },
            new SqlParameter("@SoLuong", SqlDbType.Int) { Value = soLuong },
            new SqlParameter("@DonGia", SqlDbType.Decimal) { Value = donGia },
                };

                ExecuteSQL(sql, parameters);
                LoadDataGridView(); // Cập nhật lại bảng sau khi lưu

                MessageBox.Show("Lưu hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Gọi lại hàm LoadMaCTHoaDon() sau khi thêm hóa đơn
            LoadMaCTHoaDon();

            // Đặt combobox về giá trị mới nhất (mã CT hóa đơn vừa thêm)
            if (cmbMaCTHoaDon.Items.Count > 0)
            {
                cmbMaCTHoaDon.SelectedIndex = cmbMaCTHoaDon.Items.Count - 1;
            }

        }
        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            if (cmbHoaDonID.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn mã hóa đơn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int hoaDonID = Convert.ToInt32(cmbHoaDonID.SelectedValue);

            // Xác nhận trước khi xóa
            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không?",
                                                   "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // Xóa chi tiết hóa đơn trước
                    string sqlXoaCT = "DELETE FROM CTHOADON WHERE HoaDonID = @HoaDonID";
                    SqlParameter[] paramXoaCT = {
                new SqlParameter("@HoaDonID", SqlDbType.Int) { Value = hoaDonID }
            };
                    ExecuteSQL(sqlXoaCT, paramXoaCT);

                    // Xóa hóa đơn chính
                    string sqlXoaHD = "DELETE FROM HOADON WHERE HoaDonID = @HoaDonID";
                    SqlParameter[] paramXoaHD = {
                new SqlParameter("@HoaDonID", SqlDbType.Int) { Value = hoaDonID }
            };
                    ExecuteSQL(sqlXoaHD, paramXoaHD);

                    MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại danh sách hóa đơn và combobox
                    LoadHoaDonID();
                    LoadMaCTHoaDon();
                    dataGridViewHoaDon.DataSource = null; // Xóa dữ liệu trong bảng

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}


