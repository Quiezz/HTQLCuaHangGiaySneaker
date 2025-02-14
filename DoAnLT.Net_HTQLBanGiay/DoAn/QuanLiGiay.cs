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

    public partial class QuanLiGiay : Form
    {
        GiayBLL bllGiay; // Khai báo biến

        public QuanLiGiay()
        {
            InitializeComponent(); // Chỉ gọi một lần

            // Thiết lập Form con
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            // Khởi tạo `bllGiay`
            bllGiay = new GiayBLL();
        }

        public void ShowAllGiay()
        {
            if (bllGiay == null)
            {
                MessageBox.Show("Lỗi hệ thống: `bllGiay` chưa được khởi tạo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt = bllGiay.getAllGiay();
            if (dt != null)
                dataGridViewGiay.DataSource = dt;
            else
                MessageBox.Show("Không có dữ liệu giày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void QuanLiGiay_Load(object sender, EventArgs e)
        {
            ShowAllGiay();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose(); // Đóng form con
        }


        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtTenGiay.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên giày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenGiay.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMauSac.Text))
            {
                MessageBox.Show("Bạn chưa nhập màu sắc của giày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMauSac.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtGiaBan.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá của giày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaBan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtKhoID.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã kho của giày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKhoID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSoLuongTon.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng tồn của giày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuongTon.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNhaCungCapID.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhà cung cấp của giày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhaCungCapID.Focus();
                return false;
            }
            return true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!CheckData())
                return;

            Giay giay = new Giay();

            if (string.IsNullOrWhiteSpace(txtTenGiay.Text) || string.IsNullOrWhiteSpace(txtMauSac.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            giay.TenGiay = txtBoxTenGiay.Text.Trim();
            giay.MauSac = txtBoxMauSac.Text.Trim();


            // Lấy giá trị từ TextBox và chuẩn hóa dấu phân cách
            string giaBanText = txtBoxGiaBan.Text.Trim();

            // Chuyển đổi nếu người dùng nhập dấu phẩy làm dấu thập phân
            giaBanText = giaBanText.Replace(",", ".");

            // Thử chuyển đổi chuỗi thành số float
            if (!float.TryParse(giaBanText, NumberStyles.Float, CultureInfo.InvariantCulture, out float giaBan))
            {
                MessageBox.Show("Giá bán không hợp lệ! Vui lòng nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiaBan.Focus();
                return;
            }

            // Nếu hợp lệ, gán giá trị cho đối tượng giay
            giay.GiaBan = giaBan;


            // Kiểm tra và chuyển đổi mã kho
            if (!int.TryParse(txtBoxKhoID.Text, out int khoID))
            {
                MessageBox.Show("Mã kho không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            giay.KhoID = khoID;

            // Kiểm tra số lượng tồn
            if (!int.TryParse(txtBoxSoLuongTon.Text, out int soLuongTon))
            {
                MessageBox.Show("Số lượng tồn không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            giay.SoLuongTon = soLuongTon;

            // Kiểm tra mã nhà cung cấp
            if (!int.TryParse(txtBoxNhaCungCapID.Text, out int nhaCungCap))
            {
                MessageBox.Show("Mã nhà cung cấp không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            giay.NhaCungCap = nhaCungCap;

            // Kiểm tra kích cỡ
            if (!int.TryParse(txtBoxKichCo.Text, out int kichCo))
            {
                MessageBox.Show("Kích cỡ không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            giay.KichCo = kichCo;
            MessageBox.Show($"Tên: {giay.TenGiay}, Màu: {giay.MauSac}, Giá: {giay.GiaBan}, KhoID: {giay.KhoID}, NCC: {giay.NhaCungCap}, Số lượng: {giay.SoLuongTon}, Kích cỡ: {giay.KichCo}",
    "DEBUG - Kiểm tra dữ liệu");

            // Sau khi kiểm tra xong, tiếp tục xử lý lưu dữ liệu
            if (bllGiay.ThemGiay(giay))
                ShowAllGiay();
            else
                MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }
        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Phong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewGiay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int ID;
        private void dataGridViewGiay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                ID = Int32.Parse(dataGridViewGiay.Rows[index].Cells["GiayID"].Value.ToString());
                txtBoxTenGiay.Text = dataGridViewGiay.Rows[index].Cells["TenGiay"].Value.ToString();
                txtBoxMauSac.Text = dataGridViewGiay.Rows[index].Cells["MauSac"].Value.ToString();
                txtBoxKichCo.Text = dataGridViewGiay.Rows[index].Cells["KichCo"].Value.ToString();
                txtBoxGiaBan.Text = dataGridViewGiay.Rows[index].Cells["GiaBan"].Value.ToString();
                txtBoxSoLuongTon.Text = dataGridViewGiay.Rows[index].Cells["SoLuongTon"].Value.ToString();
                txtBoxKhoID.Text = dataGridViewGiay.Rows[index].Cells["KhoID"].Value.ToString();
                txtBoxNhaCungCapID.Text = dataGridViewGiay.Rows[index].Cells["NhaCungCapID"].Value.ToString();
            }
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            if (!CheckData())
                return;

            if (ID <= 0) // Kiểm tra nếu ID chưa hợp lệ
            {
                MessageBox.Show("Vui lòng chọn một mục để chỉnh sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Giay giay = new Giay();
            giay.GiayID = ID; 

            giay.TenGiay = txtBoxTenGiay.Text.Trim();
            giay.MauSac = txtBoxMauSac.Text.Trim();

            // Kiểm tra và chuyển đổi giá bán
            string giaBanText = txtBoxGiaBan.Text.Trim().Replace(",", ".");
            if (!float.TryParse(giaBanText, NumberStyles.Float, CultureInfo.InvariantCulture, out float giaBan))
            {
                MessageBox.Show("Giá bán không hợp lệ! Vui lòng nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            giay.GiaBan = giaBan;

            // Kiểm tra dữ liệu khác
            if (!int.TryParse(txtBoxKhoID.Text, out int khoID) ||
                !int.TryParse(txtBoxSoLuongTon.Text, out int soLuongTon) ||
                !int.TryParse(txtBoxNhaCungCapID.Text, out int nhaCungCap) ||
                !int.TryParse(txtBoxKichCo.Text, out int kichCo))
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            giay.KhoID = khoID;
            giay.SoLuongTon = soLuongTon;
            giay.NhaCungCap = nhaCungCap;
            giay.KichCo = kichCo;
          
            MessageBox.Show($"ID: {giay.GiayID}, Tên: {giay.TenGiay}, Màu: {giay.MauSac}, Giá: {giay.GiaBan}, KhoID: {giay.KhoID}, NCC: {giay.NhaCungCap}, Số lượng: {giay.SoLuongTon}, Kích cỡ: {giay.KichCo}",
            "DEBUG - Kiểm tra dữ liệu");

            if (bllGiay.SuaGiay(giay))
            {
                ShowAllGiay();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (ID <= 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (bllGiay.XoaGiay(ID)) // Truyền ID trực tiếp
                {
                    ShowAllGiay();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void txtBoxTimGiay_TextChanged(object sender, EventArgs e)
        {
            string value = txtBoxTimGiay.Text.Trim(); // Loại bỏ khoảng trắng thừa

            if (string.IsNullOrEmpty(value))
            {
                ShowAllGiay(); // Nếu rỗng, hiển thị toàn bộ sản phẩm
            }
            else
            {
                DataTable dt = bllGiay.TimGiay(value); // Gọi hàm tìm kiếm
                dataGridViewGiay.DataSource = dt; // Cập nhật DataGridView
            }
        }
        private void QuanLiGiay_FormClosed(object sender, FormClosedEventArgs e)
        {
            TableManager mainForm = Application.OpenForms["TableManager"] as TableManager;
            if (mainForm != null)
            {
                mainForm.Show();  // Hiển thị lại form cha
            }
        }


    }
}
