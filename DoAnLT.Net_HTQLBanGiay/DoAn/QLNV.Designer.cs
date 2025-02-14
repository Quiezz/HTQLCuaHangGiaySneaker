namespace DoAn
{
    partial class QuanLiNhanVien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxTimNV = new System.Windows.Forms.TextBox();
            this.panelContainer1 = new System.Windows.Forms.Panel();
            this.btnThoatNV = new System.Windows.Forms.Button();
            this.btnSuaNhanVien = new System.Windows.Forms.Button();
            this.btnXoaNhanVien = new System.Windows.Forms.Button();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxChucVu = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.NhanVienID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtBoxTenNV = new System.Windows.Forms.TextBox();
            this.txtBoxDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.Label();
            this.txtBoxGioiTinh = new System.Windows.Forms.TextBox();
            this.txtBoxNgaySinh = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.Label();
            this.txtBoxSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_ChinhSua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panelContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxTimNV
            // 
            this.txtBoxTimNV.Location = new System.Drawing.Point(643, 69);
            this.txtBoxTimNV.Name = "txtBoxTimNV";
            this.txtBoxTimNV.Size = new System.Drawing.Size(100, 22);
            this.txtBoxTimNV.TabIndex = 28;
            this.txtBoxTimNV.TextChanged += new System.EventHandler(this.txtBoxTimNV_TextChanged);
            // 
            // panelContainer1
            // 
            this.panelContainer1.Controls.Add(this.btnThoatNV);
            this.panelContainer1.Controls.Add(this.btnSuaNhanVien);
            this.panelContainer1.Controls.Add(this.btnXoaNhanVien);
            this.panelContainer1.Controls.Add(this.btnThemNhanVien);
            this.panelContainer1.Controls.Add(this.label2);
            this.panelContainer1.Controls.Add(this.txtBoxChucVu);
            this.panelContainer1.Controls.Add(this.txtChucVu);
            this.panelContainer1.Controls.Add(this.txtBoxTimNV);
            this.panelContainer1.Controls.Add(this.txtBoxEmail);
            this.panelContainer1.Controls.Add(this.label1);
            this.panelContainer1.Controls.Add(this.dataGridViewNhanVien);
            this.panelContainer1.Controls.Add(this.txtEmail);
            this.panelContainer1.Controls.Add(this.txtBoxTenNV);
            this.panelContainer1.Controls.Add(this.txtBoxDiaChi);
            this.panelContainer1.Controls.Add(this.txtTenNV);
            this.panelContainer1.Controls.Add(this.txtDiaChi);
            this.panelContainer1.Controls.Add(this.txtNgaySinh);
            this.panelContainer1.Controls.Add(this.txtBoxGioiTinh);
            this.panelContainer1.Controls.Add(this.txtBoxNgaySinh);
            this.panelContainer1.Controls.Add(this.txtGioiTinh);
            this.panelContainer1.Controls.Add(this.txtSDT);
            this.panelContainer1.Controls.Add(this.txtBoxSDT);
            this.panelContainer1.Location = new System.Drawing.Point(1, 58);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.Size = new System.Drawing.Size(796, 611);
            this.panelContainer1.TabIndex = 44;
            // 
            // btnThoatNV
            // 
            this.btnThoatNV.Location = new System.Drawing.Point(551, 562);
            this.btnThoatNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoatNV.Name = "btnThoatNV";
            this.btnThoatNV.Size = new System.Drawing.Size(116, 49);
            this.btnThoatNV.TabIndex = 42;
            this.btnThoatNV.Text = "Thoát";
            this.btnThoatNV.UseVisualStyleBackColor = true;
            this.btnThoatNV.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btnSuaNhanVien
            // 
            this.btnSuaNhanVien.Location = new System.Drawing.Point(424, 562);
            this.btnSuaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaNhanVien.Name = "btnSuaNhanVien";
            this.btnSuaNhanVien.Size = new System.Drawing.Size(116, 49);
            this.btnSuaNhanVien.TabIndex = 41;
            this.btnSuaNhanVien.Text = "Chỉnh sửa";
            this.btnSuaNhanVien.UseVisualStyleBackColor = true;
            this.btnSuaNhanVien.Click += new System.EventHandler(this.btn_ChinhSua_Click);
            // 
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.Location = new System.Drawing.Point(297, 562);
            this.btnXoaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.Size = new System.Drawing.Size(116, 49);
            this.btnXoaNhanVien.TabIndex = 40;
            this.btnXoaNhanVien.Text = "Xóa";
            this.btnXoaNhanVien.UseVisualStyleBackColor = true;
            this.btnXoaNhanVien.Click += new System.EventHandler(this.btn_XoaNV_Click);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Location = new System.Drawing.Point(168, 562);
            this.btnThemNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(116, 49);
            this.btnThemNhanVien.TabIndex = 39;
            this.btnThemNhanVien.Text = "Thêm";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tìm kiếm";
            // 
            // txtBoxChucVu
            // 
            this.txtBoxChucVu.Location = new System.Drawing.Point(168, 297);
            this.txtBoxChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxChucVu.Name = "txtBoxChucVu";
            this.txtBoxChucVu.Size = new System.Drawing.Size(242, 22);
            this.txtBoxChucVu.TabIndex = 37;
            // 
            // txtChucVu
            // 
            this.txtChucVu.AutoSize = true;
            this.txtChucVu.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.Location = new System.Drawing.Point(37, 297);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(75, 23);
            this.txtChucVu.TabIndex = 36;
            this.txtChucVu.Text = "Chức Vụ";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(168, 258);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(242, 22);
            this.txtBoxEmail.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quản lí nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NhanVienID,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.SDT,
            this.DiaChi,
            this.Email,
            this.ChucVu});
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(14, 353);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.RowHeadersWidth = 51;
            this.dataGridViewNhanVien.RowTemplate.Height = 24;
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(764, 195);
            this.dataGridViewNhanVien.TabIndex = 27;
            this.dataGridViewNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhanVien_CellClick);
            this.dataGridViewNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhanVien_CellContentClick);
            // 
            // NhanVienID
            // 
            this.NhanVienID.DataPropertyName = "NhanVienID";
            this.NhanVienID.HeaderText = "NhanVienID";
            this.NhanVienID.MinimumWidth = 6;
            this.NhanVienID.Name = "NhanVienID";
            this.NhanVienID.Width = 50;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "HoTen";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "NgaySinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "GioiTinh";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 80;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "DiaChi";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "ChucVu";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Width = 125;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(37, 258);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(54, 23);
            this.txtEmail.TabIndex = 34;
            this.txtEmail.Text = "Email";
            // 
            // txtBoxTenNV
            // 
            this.txtBoxTenNV.Location = new System.Drawing.Point(168, 69);
            this.txtBoxTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTenNV.Name = "txtBoxTenNV";
            this.txtBoxTenNV.Size = new System.Drawing.Size(242, 22);
            this.txtBoxTenNV.TabIndex = 14;
            // 
            // txtBoxDiaChi
            // 
            this.txtBoxDiaChi.Location = new System.Drawing.Point(168, 219);
            this.txtBoxDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDiaChi.Name = "txtBoxDiaChi";
            this.txtBoxDiaChi.Size = new System.Drawing.Size(242, 22);
            this.txtBoxDiaChi.TabIndex = 33;
            // 
            // txtTenNV
            // 
            this.txtTenNV.AutoSize = true;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(37, 67);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(127, 23);
            this.txtTenNV.TabIndex = 22;
            this.txtTenNV.Text = "Tên Nhân viên";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoSize = true;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(37, 219);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(66, 23);
            this.txtDiaChi.TabIndex = 32;
            this.txtDiaChi.Text = "Địa Chỉ";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.AutoSize = true;
            this.txtNgaySinh.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinh.Location = new System.Drawing.Point(37, 108);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(91, 23);
            this.txtNgaySinh.TabIndex = 24;
            this.txtNgaySinh.Text = "Ngày sinh";
            // 
            // txtBoxGioiTinh
            // 
            this.txtBoxGioiTinh.Location = new System.Drawing.Point(168, 181);
            this.txtBoxGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxGioiTinh.Name = "txtBoxGioiTinh";
            this.txtBoxGioiTinh.Size = new System.Drawing.Size(242, 22);
            this.txtBoxGioiTinh.TabIndex = 31;
            // 
            // txtBoxNgaySinh
            // 
            this.txtBoxNgaySinh.Location = new System.Drawing.Point(168, 108);
            this.txtBoxNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNgaySinh.Name = "txtBoxNgaySinh";
            this.txtBoxNgaySinh.Size = new System.Drawing.Size(242, 22);
            this.txtBoxNgaySinh.TabIndex = 25;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.AutoSize = true;
            this.txtGioiTinh.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.Location = new System.Drawing.Point(37, 181);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(82, 23);
            this.txtGioiTinh.TabIndex = 30;
            this.txtGioiTinh.Text = "Giới Tính";
            // 
            // txtSDT
            // 
            this.txtSDT.AutoSize = true;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(37, 146);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(43, 23);
            this.txtSDT.TabIndex = 28;
            this.txtSDT.Text = "SĐT";
            // 
            // txtBoxSDT
            // 
            this.txtBoxSDT.Location = new System.Drawing.Point(168, 146);
            this.txtBoxSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSDT.Name = "txtBoxSDT";
            this.txtBoxSDT.Size = new System.Drawing.Size(242, 22);
            this.txtBoxSDT.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 39;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(549, 588);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(116, 67);
            this.btn_Thoat.TabIndex = 43;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_ChinhSua
            // 
            this.btn_ChinhSua.Location = new System.Drawing.Point(422, 588);
            this.btn_ChinhSua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ChinhSua.Name = "btn_ChinhSua";
            this.btn_ChinhSua.Size = new System.Drawing.Size(116, 67);
            this.btn_ChinhSua.TabIndex = 42;
            this.btn_ChinhSua.Text = "Chỉnh sửa";
            this.btn_ChinhSua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(295, 588);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(116, 67);
            this.btn_Xoa.TabIndex = 41;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(169, 588);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(116, 67);
            this.btn_Them.TabIndex = 40;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // QuanLiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 725);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_ChinhSua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Name = "QuanLiNhanVien";
            this.Text = "QLNV";
            this.Load += new System.EventHandler(this.QuanLiNhanVien_Load);
            this.panelContainer1.ResumeLayout(false);
            this.panelContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxTimNV;
        private System.Windows.Forms.Panel panelContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxChucVu;
        private System.Windows.Forms.Label txtChucVu;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.TextBox txtBoxTenNV;
        private System.Windows.Forms.TextBox txtBoxDiaChi;
        private System.Windows.Forms.Label txtTenNV;
        private System.Windows.Forms.Label txtDiaChi;
        private System.Windows.Forms.Label txtNgaySinh;
        private System.Windows.Forms.TextBox txtBoxGioiTinh;
        private System.Windows.Forms.TextBox txtBoxNgaySinh;
        private System.Windows.Forms.Label txtGioiTinh;
        private System.Windows.Forms.Label txtSDT;
        private System.Windows.Forms.TextBox txtBoxSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_ChinhSua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Button btnThoatNV;
        private System.Windows.Forms.Button btnSuaNhanVien;
        private System.Windows.Forms.Button btnXoaNhanVien;
    }
}