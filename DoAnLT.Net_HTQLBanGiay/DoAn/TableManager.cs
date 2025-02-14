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
    public partial class TableManager : Form
    {
        public TableManager()
        {
            InitializeComponent();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Hiển thị lại form đăng nhập
            Login dangnhap = new Login();
            dangnhap.Show();

            // Đóng form hiện tại
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private Form currentFormChild; // Lưu trữ form con đang mở

        private void OpenChildForm(Form childForm)
        {
            
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;

            childForm.FormClosed += (s, e) => currentFormChild = null; // Giải phóng form khi đóng

            childForm.Show();
        }

        private void QLKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLiKhachHang());
        }

        private void QLNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLiNhanVien());
        }

        private void QLSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLiGiay());
        }

        private void TableManager_Load(object sender, EventArgs e)
        {

        }
        private void TableManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ứng dụng không?",
                                                  "Xác nhận thoát",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close(); // Đóng form con
                currentFormChild = null; // Xóa tham chiếu đến form con
            }

            // Hiển thị lại PictureBox khi không có form con nào mở
            pictureBox1.Visible = true;
        }
        private void QuanLiGiay_FormClosed(object sender, FormClosedEventArgs e)
        {
            pictureBox1.Visible = true; // Hiển thị lại PictureBox khi form con đóng
            this.Show(); // Hiển thị lại Form cha nếu bị ẩn
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoaDon());
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngKíTàiKhoảnNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Logon());
        }
    }
}
