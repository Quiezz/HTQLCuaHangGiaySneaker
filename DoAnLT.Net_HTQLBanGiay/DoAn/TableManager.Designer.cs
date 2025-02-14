namespace DoAn
{
    partial class TableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.QLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuPhầnMềmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tồnKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKíTàiKhoảnNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKíTàiKhoảnKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 31);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.QLToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.thốngKêHóaĐơnToolStripMenuItem,
            this.giớiThiệuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem1,
            this.đăngKíTàiKhoảnNhânViênToolStripMenuItem,
            this.đăngKíTàiKhoảnKháchHàngToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.menuToolStripMenuItem.Text = "Admin";
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(160, 26);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem1.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem1_Click);
            // 
            // QLToolStripMenuItem
            // 
            this.QLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLNVToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.quảnLýHóaĐơnToolStripMenuItem,
            this.QLSPToolStripMenuItem});
            this.QLToolStripMenuItem.Name = "QLToolStripMenuItem";
            this.QLToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.QLToolStripMenuItem.Text = "Quản lý";
            this.QLToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click_1);
            // 
            // QLNVToolStripMenuItem
            // 
            this.QLNVToolStripMenuItem.Name = "QLNVToolStripMenuItem";
            this.QLNVToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.QLNVToolStripMenuItem.Text = "Quản lý nhân viên";
            this.QLNVToolStripMenuItem.Click += new System.EventHandler(this.QLNVToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Quản lý khách hàng";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.QLKHToolStripMenuItem_Click);
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            this.quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            this.quảnLýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.quảnLýHóaĐơnToolStripMenuItem.Text = "Quản lý hóa đơn";
            this.quảnLýHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHóaĐơnToolStripMenuItem_Click);
            // 
            // QLSPToolStripMenuItem
            // 
            this.QLSPToolStripMenuItem.Name = "QLSPToolStripMenuItem";
            this.QLSPToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.QLSPToolStripMenuItem.Text = "Quản lý sản phẩm";
            this.QLSPToolStripMenuItem.Click += new System.EventHandler(this.QLSPToolStripMenuItem_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.pictureBox1);
            this.panelContainer.Location = new System.Drawing.Point(13, 65);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(909, 705);
            this.panelContainer.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(903, 696);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuToolStripMenuItem,
            this.khoToolStripMenuItem,
            this.phiếuNhậpToolStripMenuItem,
            this.tồnKhoToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.reportToolStripMenuItem.Text = "Báo Cáo";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.doanhThuToolStripMenuItem.Text = "Doanh Thu";
            // 
            // khoToolStripMenuItem
            // 
            this.khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            this.khoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.khoToolStripMenuItem.Text = "Phiếu Nhập";
            // 
            // phiếuNhậpToolStripMenuItem
            // 
            this.phiếuNhậpToolStripMenuItem.Name = "phiếuNhậpToolStripMenuItem";
            this.phiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.phiếuNhậpToolStripMenuItem.Text = "Phiếu Xuất";
            this.phiếuNhậpToolStripMenuItem.Click += new System.EventHandler(this.phiếuNhậpToolStripMenuItem_Click);
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giớiThiệuPhầnMềmToolStripMenuItem});
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            // 
            // giớiThiệuPhầnMềmToolStripMenuItem
            // 
            this.giớiThiệuPhầnMềmToolStripMenuItem.Name = "giớiThiệuPhầnMềmToolStripMenuItem";
            this.giớiThiệuPhầnMềmToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.giớiThiệuPhầnMềmToolStripMenuItem.Text = "Giới thiệu phần mềm";
            // 
            // tồnKhoToolStripMenuItem
            // 
            this.tồnKhoToolStripMenuItem.Name = "tồnKhoToolStripMenuItem";
            this.tồnKhoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tồnKhoToolStripMenuItem.Text = "Tồn Kho";
            // 
            // đăngKíTàiKhoảnNhânViênToolStripMenuItem
            // 
            this.đăngKíTàiKhoảnNhânViênToolStripMenuItem.Name = "đăngKíTàiKhoảnNhânViênToolStripMenuItem";
            this.đăngKíTàiKhoảnNhânViênToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.đăngKíTàiKhoảnNhânViênToolStripMenuItem.Text = "Đăng kí tài khoản ( Nhân viên )";
            this.đăngKíTàiKhoảnNhânViênToolStripMenuItem.Click += new System.EventHandler(this.đăngKíTàiKhoảnNhânViênToolStripMenuItem_Click);
            // 
            // đăngKíTàiKhoảnKháchHàngToolStripMenuItem
            // 
            this.đăngKíTàiKhoảnKháchHàngToolStripMenuItem.Name = "đăngKíTàiKhoảnKháchHàngToolStripMenuItem";
            this.đăngKíTàiKhoảnKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.đăngKíTàiKhoảnKháchHàngToolStripMenuItem.Text = "Đăng kí tài khoản ( Khách hàng )";
            // 
            // thốngKêHóaĐơnToolStripMenuItem
            // 
            this.thốngKêHóaĐơnToolStripMenuItem.Name = "thốngKêHóaĐơnToolStripMenuItem";
            this.thốngKêHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.thốngKêHóaĐơnToolStripMenuItem.Text = "Thống kê hóa đơn";
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 786);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TableManager";
            this.Text = "TableManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableManager_FormClosing);
            this.Load += new System.EventHandler(this.TableManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLNVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLSPToolStripMenuItem;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuPhầnMềmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tồnKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKíTàiKhoảnNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKíTàiKhoảnKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêHóaĐơnToolStripMenuItem;
    }
}