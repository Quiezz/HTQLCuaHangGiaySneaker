# Quản Lý Bán Giày - DoAN1

## 📌 Giới thiệu
Dự án **DoAN1** là một phần mềm quản lý bán giày, được phát triển bằng C# trên nền tảng .NET với SQL Server làm hệ quản trị cơ sở dữ liệu.

## 🚀 Công nghệ sử dụng
- **Ngôn ngữ lập trình:** C# (.NET Framework)  
- **Cơ sở dữ liệu:** SQL Server  
- **IDE phát triển:** Visual Studio  

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
