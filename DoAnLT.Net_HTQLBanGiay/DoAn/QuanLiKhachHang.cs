using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class QuanLiKhachHang : Form
    {
        KhachHangBLL bllKhachHang; // Khai báo biến

        public QuanLiKhachHang()
        {
            InitializeComponent(); // Chỉ gọi một lần

            // Thiết lập Form con
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            // Khởi tạo `bllGiay`
            bllKhachHang = new KhachHangBLL();
        }

        public void ShowAllKhachHang()
        {
            if (bllKhachHang == null)
            {
                MessageBox.Show("Lỗi hệ thống: `bllKhachHang` chưa được khởi tạo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt = bllKhachHang.getAllKhachHang();
            if (dt != null)
                dataGridViewKhachHang.DataSource = dt;
            else
                MessageBox.Show("Không có dữ liệu Khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void QuanLiKhachHang_Load(object sender, EventArgs e)
        {
            ShowAllKhachHang();
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtBoxHoTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên Khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxHoTen.Focus();
                return false;
            }
            
            if (string.IsNullOrEmpty(txtBoxNgaySinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxNgaySinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBoxSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập SĐT.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxSDT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBoxEmail.Text))
            {
                MessageBox.Show("Bạn chưa nhập Email.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxEmail.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBoxDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập Địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxDiaChi.Focus();
                return false;
            }
            return true;
        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (!CheckData()) return;

            KhachHang kh = new KhachHang
            {
                HoTen = txtBoxHoTen.Text.Trim(),
                NgaySinh = Convert.ToDateTime(txtBoxNgaySinh.Text.Trim()), // Chuyển đổi trực tiếp
                SDT = txtBoxSDT.Text.Trim(),
                DiaChi = txtBoxDiaChi.Text.Trim(),
                Email = txtBoxEmail.Text.Trim(),
            };


            if (bllKhachHang.ThemKhachHang(kh))
                ShowAllKhachHang();
            else
                MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        int ID;
        private void dataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu hàng hợp lệ
            if (e.RowIndex >= 0 && dataGridViewKhachHang.Rows[e.RowIndex].Cells["KhachHangID"].Value != null)
            {
                try
                {
                    ID = Convert.ToInt32(dataGridViewKhachHang.Rows[e.RowIndex].Cells["KhachHangID"].Value);

                    txtBoxHoTen.Text = dataGridViewKhachHang.Rows[e.RowIndex].Cells["HoTen"].Value?.ToString() ?? "";
                    txtBoxNgaySinh.Text = dataGridViewKhachHang.Rows[e.RowIndex].Cells["NgaySinh"].Value?.ToString() ?? "";
                    txtBoxSDT.Text = dataGridViewKhachHang.Rows[e.RowIndex].Cells["SDT"].Value?.ToString() ?? "";
                    txtBoxDiaChi.Text = dataGridViewKhachHang.Rows[e.RowIndex].Cells["DiaChi"].Value?.ToString() ?? "";
                    txtBoxEmail.Text = dataGridViewKhachHang.Rows[e.RowIndex].Cells["Email"].Value?.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn Khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            if (!CheckData()) return;

            if (ID <= 0) // Kiểm tra nếu ID chưa hợp lệ
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để chỉnh sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Tạo đối tượng khách hàng từ dữ liệu nhập
                KhachHang kh = new KhachHang
                {
                    KhachHangID = ID, // Lấy ID khách hàng cần sửa
                    HoTen = txtBoxHoTen.Text.Trim(),
                    NgaySinh = DateTime.TryParseExact(txtBoxNgaySinh.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaySinh) ? ngaySinh : DateTime.MinValue,
                    SDT = txtBoxSDT.Text.Trim(),
                    DiaChi = txtBoxDiaChi.Text.Trim(),
                    Email = txtBoxEmail.Text.Trim()
                };

                // Debug - Hiển thị dữ liệu trước khi cập nhật
                MessageBox.Show($"ID: {kh.KhachHangID}, Tên: {kh.HoTen}, Ngày Sinh: {kh.NgaySinh}, SĐT: {kh.SDT}, Địa Chỉ: {kh.DiaChi}, Email: {kh.Email}", "DEBUG - Kiểm tra dữ liệu");

                if (bllKhachHang.SuaKhachHang(kh)) // Gọi phương thức cập nhật
                {
                    ShowAllKhachHang(); // Cập nhật lại danh sách khách hàng trên DataGridView
                    MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            if (dataGridViewKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một Khách hàng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy ID từ hàng được chọn
            int ID = Convert.ToInt32(dataGridViewKhachHang.SelectedRows[0].Cells["KhachHangID"].Value);

            if (MessageBox.Show("Bạn có muốn xóa Khách hàng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (bllKhachHang.XoaKhachHang(ID))
                {
                    ShowAllKhachHang(); 
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa Khách hàng này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private void txtBoxTimKH_TextChanged(object sender, EventArgs e)
        {
            string value = txtBoxTimKH.Text.Trim(); // Loại bỏ khoảng trắng thừa

            if (string.IsNullOrEmpty(value))
            {
                ShowAllKhachHang(); // Nếu rỗng, hiển thị toàn bộ sản phẩm
            }
            else
            {
                DataTable dt = bllKhachHang.TimKhachHang(value); // Gọi hàm tìm kiếm
                dataGridViewKhachHang.DataSource = dt; // Cập nhật DataGridView
            }
        }
    }
}
