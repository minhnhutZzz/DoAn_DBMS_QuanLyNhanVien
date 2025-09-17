--TẠO LOGIN USER 
CREATE LOGIN user_QuanLy WITH PASSWORD = '12345'; 
CREATE USER user_QuanLy FOR LOGIN user_QuanLy;

go
ALTER SERVER ROLE sysadmin ADD MEMBER [user_QuanLy];
go

use QL_NhanVien;
go
CREATE ROLE role_QuanLy; 
CREATE ROLE role_NhanVien;

-- PHÂN QUYỀN CHO ROLE: QuanLy
-- Toàn quyền 
GRANT SELECT, INSERT, UPDATE, DELETE ON NhanVien TO role_QuanLy;
GRANT SELECT, INSERT, UPDATE, DELETE ON CongViec TO role_QuanLy;	
GRANT SELECT, INSERT, UPDATE, DELETE ON ChamCong TO role_QuanLy;
GRANT SELECT, INSERT, UPDATE, DELETE ON TaiKhoan TO role_QuanLy;
GRANT SELECT, INSERT, UPDATE, DELETE ON Luong TO role_QuanLy;

-- Các stored procedure
GRANT EXECUTE ON sp_ThemTaiKhoan TO role_QuanLy;
GRANT EXECUTE ON sp_XoaTaiKhoan TO role_QuanLy;
GRANT EXECUTE ON sp_DoiMatKhau TO role_QuanLy;

GRANT EXECUTE ON sp_ThemNhanVien TO role_QuanLy;
GRANT EXECUTE ON sp_XoaNhanVien TO role_QuanLy;
GRANT EXECUTE ON sp_CapNhatNhanVien TO role_QuanLy;

GRANT EXECUTE ON sp_ThemCongViec TO role_QuanLy;
GRANT EXECUTE ON sp_XoaCongViec TO role_QuanLy;
GRANT EXECUTE ON sp_CapNhatCongViec TO role_QuanLy;


-- Các scalar function
GRANT EXECUTE ON fn_LuongTheoGio TO role_QuanLy;
GRANT EXECUTE ON fn_TongGioLamTrongThang TO role_QuanLy;
GRANT EXECUTE ON fn_TongGioTangCaTrongThang TO role_QuanLy;

-- Table-valued functions (cấp quyền SELECT)
GRANT SELECT ON fn_ThongKeSoNhanVienTheoCongViec TO role_QuanLy;
GRANT SELECT ON fn_DanhSachNhanVienTheoTenCongViec TO role_QuanLy;
GRANT SELECT ON fn_BangLuongThang TO role_QuanLy;

-- PHÂN QUYỀN CHO ROLE: NhanVien
-- Chỉ được xem và chấm công cho chính mình
GRANT SELECT, INSERT ON ChamCong TO role_NhanVien;
-- Được xem thông tin nhân viên
GRANT SELECT ON NhanVien TO role_NhanVien;
-- Được xem bảng lương cá nhân
GRANT SELECT ON Luong TO role_NhanVien;
-- Được đổi mật khẩu
GRANT UPDATE ON TaiKhoan TO role_NhanVien;
-- Cho phép nhân viên tự đổi mật khẩu
GRANT EXECUTE ON sp_DoiMatKhau TO role_NhanVien;
-- Các function dùng để xem dữ liệu lương cá nhân
GRANT EXECUTE ON fn_LuongTheoGio TO role_NhanVien;
GRANT EXECUTE ON fn_TongGioLamTrongThang TO role_NhanVien;
GRANT EXECUTE ON fn_TongGioTangCaTrongThang TO role_NhanVien;
GRANT SELECT ON fn_BangLuongThang TO role_NhanVien;


-- GÁN USER VÀO ROLE 
-- Gán người dùng SQL Server vào vai trò 
EXEC sp_addrolemember 'role_QuanLy', 'user_QuanLy'; 
