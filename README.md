# Quản Lý Bán Giày - DoAN1

## 📌 Giới thiệu
Dự án **DoAN1** là một phần mềm quản lý bán giày, được phát triển bằng C# trên nền tảng .NET với SQL Server làm hệ quản trị cơ sở dữ liệu.

## 🚀 Công nghệ sử dụng
- **Ngôn ngữ lập trình:** C# (.NET Framework)  
- **Cơ sở dữ liệu:** SQL Server  
- **IDE phát triển:** Visual Studio  

## ✨ Chức năng chính
1. **Quản lý sản phẩm**  
   - Thêm, sửa, xóa thông tin giày (tên, giá, số lượng, thương hiệu, danh mục, hình ảnh).  
   - Tìm kiếm giày theo tên, giá hoặc thương hiệu.  
   
2. **Quản lý khách hàng**  
   - Lưu thông tin khách hàng (họ tên, số điện thoại, địa chỉ).  
   - Tìm kiếm khách hàng theo số điện thoại hoặc tên.  

3. **Quản lý đơn hàng**  
   - Tạo đơn hàng mới, thêm sản phẩm vào giỏ hàng.  
   - Tính tổng tiền, áp dụng khuyến mãi.  
   - Xuất hóa đơn và in biên lai.  

4. **Quản lý nhân viên**  
   - Phân quyền tài khoản nhân viên (Admin, Nhân viên bán hàng).  
   - Theo dõi lịch sử làm việc của nhân viên.  

5. **Báo cáo & Thống kê**  
   - Doanh thu theo ngày, tháng, năm.  
   - Sản phẩm bán chạy nhất.  
   - Tồn kho sản phẩm.  

## 📂 Cấu trúc dự án
- `DoAn/` - Thư mục chứa mã nguồn chính  
- `DoAn.sln` - File solution để mở bằng Visual Studio  
- `QLBangiay.BAK` - File backup cơ sở dữ liệu  

## 🛠️ Cách cài đặt và sử dụng
### **1. Cấu hình cơ sở dữ liệu**
1. Mở **SQL Server Management Studio (SSMS)**  
2. Chạy lệnh restore database:  
   ```sql
   RESTORE DATABASE QLBangiay FROM DISK = 'D:\Path\QLBangiay.BAK' WITH RECOVERY;
