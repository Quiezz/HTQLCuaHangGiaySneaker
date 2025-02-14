namespace DoAn
{
    partial class HoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private System.Windows.Forms.DataGridView dgvHDBanHang;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.TenGiay = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cmbGiayID = new System.Windows.Forms.ComboBox();
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.cmbKhachHangID = new System.Windows.Forms.ComboBox();
            this.cmbNhanVienID = new System.Windows.Forms.ComboBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnDongHD = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMaCTHoaDon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnHuyHD = new System.Windows.Forms.Button();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbHoaDonID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(589, 79);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(100, 22);
            this.txtThanhTien.TabIndex = 11;
            // 
            // TenGiay
            // 
            this.TenGiay.Location = new System.Drawing.Point(367, 47);
            this.TenGiay.Name = "TenGiay";
            this.TenGiay.Size = new System.Drawing.Size(120, 22);
            this.TenGiay.TabIndex = 10;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(97, 77);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(120, 22);
            this.txtSoLuong.TabIndex = 8;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoluong_TextChanged);
            // 
            // cmbGiayID
            // 
            this.cmbGiayID.FormattingEnabled = true;
            this.cmbGiayID.Location = new System.Drawing.Point(97, 47);
            this.cmbGiayID.Name = "cmbGiayID";
            this.cmbGiayID.Size = new System.Drawing.Size(121, 24);
            this.cmbGiayID.TabIndex = 7;
            this.cmbGiayID.SelectedIndexChanged += new System.EventHandler(this.cmbGiayID_SelectedIndexChanged);
            // 
            // dataGridViewHoaDon
            // 
            this.dataGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDon.Location = new System.Drawing.Point(31, 117);
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.RowHeadersWidth = 51;
            this.dataGridViewHoaDon.RowTemplate.Height = 24;
            this.dataGridViewHoaDon.Size = new System.Drawing.Size(718, 156);
            this.dataGridViewHoaDon.TabIndex = 6;
            // 
            // cmbKhachHangID
            // 
            this.cmbKhachHangID.FormattingEnabled = true;
            this.cmbKhachHangID.Location = new System.Drawing.Point(589, 21);
            this.cmbKhachHangID.Name = "cmbKhachHangID";
            this.cmbKhachHangID.Size = new System.Drawing.Size(100, 24);
            this.cmbKhachHangID.TabIndex = 18;
            this.cmbKhachHangID.SelectedIndexChanged += new System.EventHandler(this.cmbKhachHangID_SelectedIndexChanged);
            // 
            // cmbNhanVienID
            // 
            this.cmbNhanVienID.FormattingEnabled = true;
            this.cmbNhanVienID.Location = new System.Drawing.Point(107, 93);
            this.cmbNhanVienID.Name = "cmbNhanVienID";
            this.cmbNhanVienID.Size = new System.Drawing.Size(110, 24);
            this.cmbNhanVienID.TabIndex = 17;
            this.cmbNhanVienID.SelectedIndexChanged += new System.EventHandler(this.cmbNhanVienID_SelectedIndexChanged);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(589, 129);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(100, 22);
            this.txtSoDienThoai.TabIndex = 16;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(589, 93);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 22);
            this.txtDiaChi.TabIndex = 15;
            // 
            // btnDongHD
            // 
            this.btnDongHD.Location = new System.Drawing.Point(568, 507);
            this.btnDongHD.Name = "btnDongHD";
            this.btnDongHD.Size = new System.Drawing.Size(82, 37);
            this.btnDongHD.TabIndex = 26;
            this.btnDongHD.Text = "Đóng ";
            this.btnDongHD.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(301, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Tên giày";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Số lượng ";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(589, 59);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(100, 22);
            this.txtTenKhachHang.TabIndex = 14;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(107, 129);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(110, 22);
            this.txtTenNhanVien.TabIndex = 11;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Location = new System.Drawing.Point(107, 57);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(110, 22);
            this.dtpNgayBan.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(518, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 16);
            this.label16.TabIndex = 4;
            this.label16.Text = "Đơn giá";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(456, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Số điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(456, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tên khách hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mã khách hàng";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(511, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 16);
            this.label17.TabIndex = 5;
            this.label17.Text = "Thành tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(456, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Địa chỉ ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tên nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGiaBan);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.TenGiay);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.cmbGiayID);
            this.groupBox2.Controls.Add(this.dataGridViewHoaDon);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 279);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng ";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(589, 47);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(100, 22);
            this.txtGiaBan.TabIndex = 12;
            this.txtGiaBan.TextChanged += new System.EventHandler(this.txtDongia_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã giày";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbMaCTHoaDon);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 557);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 49);
            this.panel1.TabIndex = 24;
            // 
            // cmbMaCTHoaDon
            // 
            this.cmbMaCTHoaDon.FormattingEnabled = true;
            this.cmbMaCTHoaDon.Location = new System.Drawing.Point(397, 13);
            this.cmbMaCTHoaDon.Name = "cmbMaCTHoaDon";
            this.cmbMaCTHoaDon.Size = new System.Drawing.Size(121, 24);
            this.cmbMaCTHoaDon.TabIndex = 1;
            this.cmbMaCTHoaDon.SelectedIndexChanged += new System.EventHandler(this.cmbMaCTHoaDon_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã CT Hóa đơn";
            // 
            // btnInHD
            // 
            this.btnInHD.Location = new System.Drawing.Point(418, 507);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(100, 37);
            this.btnInHD.TabIndex = 23;
            this.btnInHD.Text = "In hóa đơn ";
            this.btnInHD.UseVisualStyleBackColor = true;
            // 
            // btnHuyHD
            // 
            this.btnHuyHD.Location = new System.Drawing.Point(269, 507);
            this.btnHuyHD.Name = "btnHuyHD";
            this.btnHuyHD.Size = new System.Drawing.Size(105, 37);
            this.btnHuyHD.TabIndex = 22;
            this.btnHuyHD.Text = "Xóa hóa đơn ";
            this.btnHuyHD.UseVisualStyleBackColor = true;
            this.btnHuyHD.Click += new System.EventHandler(this.btnXoaHoaDon_Click);
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.Location = new System.Drawing.Point(109, 507);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(108, 37);
            this.btnLuuHD.TabIndex = 21;
            this.btnLuuHD.Text = "Lưu Hóa đơn";
            this.btnLuuHD.UseVisualStyleBackColor = true;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHoaDon_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, -3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(792, 502);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbHoaDonID);
            this.groupBox1.Controls.Add(this.cmbKhachHangID);
            this.groupBox1.Controls.Add(this.cmbNhanVienID);
            this.groupBox1.Controls.Add(this.txtSoDienThoai);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.dtpNgayBan);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung ";
            // 
            // cmbHoaDonID
            // 
            this.cmbHoaDonID.FormattingEnabled = true;
            this.cmbHoaDonID.Location = new System.Drawing.Point(107, 27);
            this.cmbHoaDonID.Name = "cmbHoaDonID";
            this.cmbHoaDonID.Size = new System.Drawing.Size(110, 24);
            this.cmbHoaDonID.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày bán ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(251, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hóa đơn khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 606);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnDongHD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.btnHuyHD);
            this.Controls.Add(this.btnLuuHD);
            this.Controls.Add(this.label1);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox TenGiay;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cmbGiayID;
        private System.Windows.Forms.DataGridView dataGridViewHoaDon;
        private System.Windows.Forms.ComboBox cmbKhachHangID;
        private System.Windows.Forms.ComboBox cmbNhanVienID;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnDongHD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbMaCTHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnHuyHD;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHoaDonID;
    }
}