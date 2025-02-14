namespace DoAn
{
    partial class QuanLiKhachHang
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
            this.txtBoxTimKH = new System.Windows.Forms.TextBox();
            this.panelContainer1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewKhachHang = new System.Windows.Forms.DataGridView();
            this.KhachHangID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxHoTen = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.Label();
            this.txtBoxNgaySinh = new System.Windows.Forms.TextBox();
            this.txtBoxSDT = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.Label();
            this.txtBoxDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ChinhSua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.panelContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxTimKH
            // 
            this.txtBoxTimKH.Location = new System.Drawing.Point(643, 69);
            this.txtBoxTimKH.Name = "txtBoxTimKH";
            this.txtBoxTimKH.Size = new System.Drawing.Size(100, 22);
            this.txtBoxTimKH.TabIndex = 28;
            this.txtBoxTimKH.TextChanged += new System.EventHandler(this.txtBoxTimKH_TextChanged);
            // 
            // panelContainer1
            // 
            this.panelContainer1.Controls.Add(this.btnThoat);
            this.panelContainer1.Controls.Add(this.btnSuaKH);
            this.panelContainer1.Controls.Add(this.btnXoaKH);
            this.panelContainer1.Controls.Add(this.btnThemKH);
            this.panelContainer1.Controls.Add(this.label2);
            this.panelContainer1.Controls.Add(this.txtBoxTimKH);
            this.panelContainer1.Controls.Add(this.label1);
            this.panelContainer1.Controls.Add(this.dataGridViewKhachHang);
            this.panelContainer1.Controls.Add(this.txtBoxHoTen);
            this.panelContainer1.Controls.Add(this.txtBoxEmail);
            this.panelContainer1.Controls.Add(this.txtHoTen);
            this.panelContainer1.Controls.Add(this.txtEmail);
            this.panelContainer1.Controls.Add(this.txtSDT);
            this.panelContainer1.Controls.Add(this.txtBoxNgaySinh);
            this.panelContainer1.Controls.Add(this.txtBoxSDT);
            this.panelContainer1.Controls.Add(this.txtNgaySinh);
            this.panelContainer1.Controls.Add(this.txtDiaChi);
            this.panelContainer1.Controls.Add(this.txtBoxDiaChi);
            this.panelContainer1.Location = new System.Drawing.Point(71, 38);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.Size = new System.Drawing.Size(796, 613);
            this.panelContainer1.TabIndex = 44;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(529, 498);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 49);
            this.btnThoat.TabIndex = 42;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Location = new System.Drawing.Point(402, 498);
            this.btnSuaKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(116, 49);
            this.btnSuaKH.TabIndex = 41;
            this.btnSuaKH.Text = "Chỉnh sửa";
            this.btnSuaKH.UseVisualStyleBackColor = true;
            this.btnSuaKH.Click += new System.EventHandler(this.btn_ChinhSua_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Location = new System.Drawing.Point(275, 498);
            this.btnXoaKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(116, 49);
            this.btnXoaKH.TabIndex = 40;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btn_XoaKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(149, 498);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(116, 49);
            this.btnThemKH.TabIndex = 39;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quản lí Khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewKhachHang
            // 
            this.dataGridViewKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KhachHangID,
            this.HoTen,
            this.SDT,
            this.DiaChi,
            this.Email,
            this.NgaySinh});
            this.dataGridViewKhachHang.Location = new System.Drawing.Point(17, 277);
            this.dataGridViewKhachHang.Name = "dataGridViewKhachHang";
            this.dataGridViewKhachHang.RowHeadersWidth = 51;
            this.dataGridViewKhachHang.RowTemplate.Height = 24;
            this.dataGridViewKhachHang.Size = new System.Drawing.Size(764, 195);
            this.dataGridViewKhachHang.TabIndex = 27;
            this.dataGridViewKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKhachHang_CellClick);
            // 
            // KhachHangID
            // 
            this.KhachHangID.DataPropertyName = "KhachHangID";
            this.KhachHangID.HeaderText = "KhachHangID";
            this.KhachHangID.MinimumWidth = 6;
            this.KhachHangID.Name = "KhachHangID";
            this.KhachHangID.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
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
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 120;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // txtBoxHoTen
            // 
            this.txtBoxHoTen.Location = new System.Drawing.Point(168, 69);
            this.txtBoxHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxHoTen.Name = "txtBoxHoTen";
            this.txtBoxHoTen.Size = new System.Drawing.Size(242, 22);
            this.txtBoxHoTen.TabIndex = 14;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(168, 219);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(242, 22);
            this.txtBoxEmail.TabIndex = 33;
            // 
            // txtHoTen
            // 
            this.txtHoTen.AutoSize = true;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(37, 67);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(69, 23);
            this.txtHoTen.TabIndex = 22;
            this.txtHoTen.Text = "Tên KH";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(37, 219);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(54, 23);
            this.txtEmail.TabIndex = 32;
            this.txtEmail.Text = "Email";
            // 
            // txtSDT
            // 
            this.txtSDT.AutoSize = true;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(37, 108);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(43, 23);
            this.txtSDT.TabIndex = 24;
            this.txtSDT.Text = "SĐT";
            // 
            // txtBoxNgaySinh
            // 
            this.txtBoxNgaySinh.Location = new System.Drawing.Point(168, 181);
            this.txtBoxNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNgaySinh.Name = "txtBoxNgaySinh";
            this.txtBoxNgaySinh.Size = new System.Drawing.Size(242, 22);
            this.txtBoxNgaySinh.TabIndex = 31;
            // 
            // txtBoxSDT
            // 
            this.txtBoxSDT.Location = new System.Drawing.Point(168, 108);
            this.txtBoxSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSDT.Name = "txtBoxSDT";
            this.txtBoxSDT.Size = new System.Drawing.Size(242, 22);
            this.txtBoxSDT.TabIndex = 25;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.AutoSize = true;
            this.txtNgaySinh.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinh.Location = new System.Drawing.Point(37, 181);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(93, 23);
            this.txtNgaySinh.TabIndex = 30;
            this.txtNgaySinh.Text = "Ngày Sinh";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoSize = true;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(37, 146);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(66, 23);
            this.txtDiaChi.TabIndex = 28;
            this.txtDiaChi.Text = "Địa Chỉ";
            // 
            // txtBoxDiaChi
            // 
            this.txtBoxDiaChi.Location = new System.Drawing.Point(168, 146);
            this.txtBoxDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDiaChi.Name = "txtBoxDiaChi";
            this.txtBoxDiaChi.Size = new System.Drawing.Size(242, 22);
            this.txtBoxDiaChi.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 39;
            // 
            // btn_ChinhSua
            // 
            this.btn_ChinhSua.Location = new System.Drawing.Point(492, 593);
            this.btn_ChinhSua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ChinhSua.Name = "btn_ChinhSua";
            this.btn_ChinhSua.Size = new System.Drawing.Size(116, 49);
            this.btn_ChinhSua.TabIndex = 42;
            this.btn_ChinhSua.Text = "Chỉnh sửa";
            this.btn_ChinhSua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(365, 593);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(116, 49);
            this.btn_Xoa.TabIndex = 41;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(239, 593);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(116, 49);
            this.btn_Them.TabIndex = 40;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(619, 593);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(116, 49);
            this.btn_Thoat.TabIndex = 43;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // QuanLiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 688);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ChinhSua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Thoat);
            this.Name = "QuanLiKhachHang";
            this.Text = "QuanLiKhachHang";
            this.Load += new System.EventHandler(this.QuanLiKhachHang_Load);
            this.panelContainer1.ResumeLayout(false);
            this.panelContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxTimKH;
        private System.Windows.Forms.Panel panelContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewKhachHang;
        private System.Windows.Forms.TextBox txtBoxHoTen;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label txtHoTen;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtSDT;
        private System.Windows.Forms.TextBox txtBoxNgaySinh;
        private System.Windows.Forms.TextBox txtBoxSDT;
        private System.Windows.Forms.Label txtNgaySinh;
        private System.Windows.Forms.Label txtDiaChi;
        private System.Windows.Forms.TextBox txtBoxDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ChinhSua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHangID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
    }
}