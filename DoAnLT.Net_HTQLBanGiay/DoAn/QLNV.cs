using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace DoAn
{
    public partial class QuanLiNhanVien : Form
    {
        NhanVienBLL bllNhanVien;

        public QuanLiNhanVien()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            bllNhanVien = new NhanVienBLL();
        }

        public void ShowAllNhanVien()
        {
            DataTable dt = bllNhanVien.getAllNhanVien();
            if (dt != null)
                dataGridViewNhanVien.DataSource = dt;
            else
                MessageBox.Show("Không có dữ liệu nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void QuanLiNhanVien_Load(object sender, EventArgs e)
        {
            ShowAllNhanVien();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtBoxTenNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxTenNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBoxChucVu.Text))
            {
                MessageBox.Show("Bạn chưa nhập chức vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxChucVu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBoxNgaySinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxNgaySinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBoxGioiTinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxGioiTinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBoxNgaySinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Bạn chưa nhập lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxDiaChi.Focus();
                return false;
            }
            return true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!CheckData()) return;

            NhanVien nv = new NhanVien
            {
                HoTen = txtBoxTenNV.Text.Trim(),
                NgaySinh = Convert.ToDateTime(txtBoxNgaySinh.Text.Trim()), // Chuyển đổi trực tiếp
                GioiTinh = txtBoxGioiTinh.Text.Trim(),
                SDT = txtBoxSDT.Text.Trim(),
                DiaChi = txtBoxDiaChi.Text.Trim(),
                Email = txtBoxEmail.Text.Trim(),
                ChucVu = txtBoxChucVu.Text.Trim(),
            };


            if (bllNhanVien.ThemNhanVien(nv))
                ShowAllNhanVien();
            else
                MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        int ID;
        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewNhanVien.Rows[e.RowIndex];

                // Kiểm tra xem cột ID có tên chính xác không
                if (row.Cells["NhanVienID"].Value != null)
                {
                    ID = Convert.ToInt32(row.Cells["NhanVienID"].Value);
                    txtBoxTenNV.Text = row.Cells["HoTen"].Value.ToString();
                    txtBoxNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
                    txtBoxGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                    txtBoxSDT.Text = row.Cells["SDT"].Value.ToString();
                    txtBoxDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                    txtBoxEmail.Text = row.Cells["Email"].Value.ToString();
                    txtBoxChucVu.Text = row.Cells["ChucVu"].Value.ToString();

    
                }
                else
                {
                    MessageBox.Show("Không thể lấy ID nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            if (!CheckData()) return;

            if (ID <= 0) // Kiểm tra nếu ID chưa hợp lệ
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để chỉnh sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                NhanVien nv = new NhanVien
                {
                    NhanVienID = ID, // Lấy ID của nhân viên cần sửa
                    HoTen = txtBoxTenNV.Text.Trim(),
                    NgaySinh = DateTime.ParseExact(txtBoxNgaySinh.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture), // Định dạng chuẩn
                    GioiTinh = txtBoxGioiTinh.Text.Trim(),
                    SDT = txtBoxSDT.Text.Trim(),
                    DiaChi = txtBoxDiaChi.Text.Trim(),
                    Email = txtBoxEmail.Text.Trim(),
                    ChucVu = txtBoxChucVu.Text.Trim()
                };

                // Debug - Hiển thị dữ liệu trước khi gửi đi
                MessageBox.Show($"ID: {nv.NhanVienID}, Tên: {nv.HoTen}, Ngày Sinh: {nv.NgaySinh}, Giới Tính: {nv.GioiTinh}, SĐT: {nv.SDT}, Địa Chỉ: {nv.DiaChi}, Email: {nv.Email}, Chức Vụ: {nv.ChucVu}",
                "DEBUG - Kiểm tra dữ liệu");

                if (bllNhanVien.SuaNhanVien(nv)) // Gọi phương thức cập nhật
                {
                    ShowAllNhanVien(); // Cập nhật lại danh sách nhân viên trên DataGridView
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            if (dataGridViewNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy ID từ hàng được chọn
            int ID = Convert.ToInt32(dataGridViewNhanVien.SelectedRows[0].Cells["NhanVienID"].Value);

            if (MessageBox.Show("Bạn có muốn xóa nhân viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (bllNhanVien.XoaNhanVien(ID))
                {
                    ShowAllNhanVien(); // Cập nhật lại danh sách nhân viên
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa nhân viên này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }


        private void dataGridViewNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBoxTimNV_TextChanged(object sender, EventArgs e)
        {
            string value = txtBoxTimNV.Text.Trim(); // Loại bỏ khoảng trắng thừa

            if (string.IsNullOrEmpty(value))
            {
                ShowAllNhanVien(); // Nếu rỗng, hiển thị toàn bộ sản phẩm
            }
            else
            {
                DataTable dt = bllNhanVien.TimNhanVien(value); // Gọi hàm tìm kiếm
                dataGridViewNhanVien.DataSource = dt; // Cập nhật DataGridView
            }
        }
    }
}
