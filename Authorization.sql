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

-- Các thủ tục
GRANT EXECUTE ON sp_ThemTaiKhoan TO role_QuanLy;
GRANT EXECUTE ON sp_XoaTaiKhoan TO role_QuanLy;
GRANT EXECUTE ON sp_QuenMatKhau TO role_QuanLy;
GRANT EXECUTE ON sp_TimKiemTaiKhoan TO role_QuanLy;

GRANT EXECUTE ON sp_ThemNhanVien TO role_QuanLy;
GRANT EXECUTE ON sp_XoaNhanVien TO role_QuanLy;
GRANT EXECUTE ON sp_CapNhatNhanVien TO role_QuanLy;
GRANT EXECUTE ON sp_TimKiemNhanVien TO role_QuanLy;

GRANT EXECUTE ON sp_ThemCongViec TO role_QuanLy;
GRANT EXECUTE ON sp_XoaCongViec TO role_QuanLy;
GRANT EXECUTE ON sp_CapNhatCongViec TO role_QuanLy;
GRANT EXECUTE ON sp_TimKiemCongViec TO role_QuanLy;

GRANT EXECUTE ON sp_ChamCong TO role_QuanLy;
GRANT EXECUTE ON sp_XoaBangGhiChamCong TO role_QuanLy;
GRANT EXECUTE ON sp_XoaTatCaChamCong TO role_QuanLy;

GRANT EXECUTE ON sp_XoaLuong TO role_QuanLy;
GRANT EXECUTE ON sp_TinhLuong TO role_QuanLy;

-- Các hàm trả về giá trị
GRANT EXECUTE ON fn_TinhTongLuong TO role_QuanLy;

-- Các hàm trả về bảng
GRANT SELECT ON fn_ThongKeSoNhanVienTheoCongViec TO role_QuanLy;
GRANT SELECT ON fn_DanhSachNhanVienTheoTenCongViec TO role_QuanLy;



-- PHÂN QUYỀN CHO ROLE: NhanVien

GRANT SELECT ON ChamCong TO role_NhanVien;
GRANT SELECT ON NhanVien TO role_NhanVien;
GRANT SELECT ON Luong TO role_NhanVien;
GRANT UPDATE ON TaiKhoan TO role_NhanVien;

--Thủ tục 
GRANT EXECUTE ON sp_QuenMatKhau TO role_NhanVien;

-- Các hàm 
GRANT SELECT ON fn_HienThiThongTinLuong TO role_NhanVien;
GRANT SELECT ON fn_Hosonhanvien TO role_NhanVien;


-- GÁN USER VÀO ROLE 
EXEC sp_addrolemember 'role_QuanLy', 'user_QuanLy'; 
