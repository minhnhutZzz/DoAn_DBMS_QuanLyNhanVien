use QL_NhanVien;
go

-- Hàm trả về bảng được định nghĩa
go
CREATE FUNCTION dbo.fn_HienThiThongTinLuong
    (@MaNV INT)
RETURNS @LuongTable TABLE 
(
    [Mã nhân viên] INT,          -- Mã nhân viên
    [Họ tên] NVARCHAR(100),      -- Họ tên của nhân viên
    [Ngày chấm công] DATE,       -- Ngày làm việc
    [Giờ vào] TIME,              -- Giờ vào làm
    [Giờ ra] TIME,               -- Giờ ra làm
    [Số giờ làm] INT,            -- Số giờ làm trong ngày
    [Số giờ tăng ca] INT,        -- Số giờ tăng ca
    [Lương thưởng] DECIMAL(18, 2), -- Lương thưởng của nhân viên
    [Lương phụ cấp] DECIMAL(18, 2), -- Phụ cấp của nhân viên
    [Lương tăng ca] DECIMAL(18, 2), -- Lương tăng ca
    [Tổng lương] DECIMAL(18, 2)  -- Tổng lương của nhân viên
)
AS
BEGIN
    -- Chèn dữ liệu vào bảng table trả về
    INSERT INTO @LuongTable
    SELECT 
        NV.MaNV, 
        NV.HoTen, 
        CC.Ngay, 
        CC.GioVao, 
        CC.GioRa, 
        DATEDIFF(HOUR, CC.GioVao, CC.GioRa) AS SoGioLam,  -- Tính số giờ làm việc trong ngày
        CC.SoGioTangCa, 
        L.Thuong, 
        L.PhuCap, 
        L.LuongTangCa, 
        L.TongLuong
    FROM 
        NhanVien NV
    JOIN 
        ChamCong CC ON NV.MaNV = CC.MaNV
    JOIN 
        Luong L ON NV.MaNV = L.MaNV
    WHERE 
        NV.MaNV = @MaNV;  -- Điều kiện lọc theo mã nhân viên

    -- Trả về bảng dữ liệu
    RETURN;
END;


GO
CREATE FUNCTION dbo.fn_Hosonhanvien (@MaTK INT)
RETURNS @HoSoTable TABLE
(
    [Tên Tài Khoản] NVARCHAR(100),
    [Mật khẩu] NVARCHAR(100),
    [Họ tên] NVARCHAR(100),
    [Địa chỉ] NVARCHAR(255),
    [Ngày sinh] DATE,
    [Email] NVARCHAR(100),
    [Số điện thoại] NVARCHAR(20),
    [Tên Công Việc] NVARCHAR(100)
)
AS
BEGIN
    -- Chọn dữ liệu từ bảng TaiKhoan, NhanVien, và CongViec
    INSERT INTO @HoSoTable
    SELECT 
        TK.TenTK, 
        TK.MatKhau, 
        NV.HoTen, 
        NV.DiaChi, 
        NV.NgaySinh, 
        NV.Email, 
        NV.SDT, 
        CV.TenCV
    FROM 
        TaiKhoan TK
    JOIN 
        NhanVien NV ON TK.MaTK = NV.MaTK
    JOIN 
        CongViec CV ON NV.MaCV = CV.MaCV
    WHERE 
        TK.MaTK = @MaTK;  

    RETURN;
END;
GO


--Hàm trả về bảng 
go 
CREATE FUNCTION fn_DanhSachNhanVienTheoTenCongViec(@TenCV NVARCHAR(50))
RETURNS TABLE
AS
RETURN
(
    SELECT NV.MaNV, NV.HoTen, NV.Email, CV.TenCV, CV.LuongCoBan
    FROM NhanVien NV
    JOIN CongViec CV ON NV.MaCV = CV.MaCV
    WHERE CV.TenCV = @TenCV
);

go
CREATE FUNCTION fn_ThongKeSoNhanVienTheoCongViec()
RETURNS TABLE
AS
RETURN
(
    SELECT
        CV.MaCV,              
        CV.TenCV,             
        COUNT(NV.MaNV) AS SoNhanVien  -- Số nhân viên
    FROM CongViec CV
    LEFT JOIN NhanVien NV ON NV.MaCV = CV.MaCV   
    GROUP BY CV.MaCV, CV.TenCV                   
);


-- Hàm trả về giá trị
go
CREATE FUNCTION fn_TinhTongLuong()
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @TongLuongToanBo DECIMAL(18, 2);

    -- Tính tổng tất cả các tổng lương trong bảng Luong
    SELECT @TongLuongToanBo = SUM(TongLuong)
    FROM Luong;

    -- Trả về tổng lương
    RETURN @TongLuongToanBo;
END;


go
CREATE FUNCTION fn_TinhTongLuongTheoMaNV(@MaNV INT)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @TongLuong DECIMAL(18, 2);

    -- Tính tổng tất cả các giá trị TongLuong của nhân viên trong bảng Luong
    SELECT @TongLuong = SUM(TongLuong)
    FROM Luong
    WHERE MaNV = @MaNV;

    -- Trả về tổng lương của nhân viên
    RETURN ISNULL(@TongLuong, 0);  -- Trả về 0 nếu không có bản ghi lương nào
END;


--Thủ tục 
go
CREATE PROCEDURE sp_ThemTaiKhoan
    @TenTK NVARCHAR(50),
    @MatKhau NVARCHAR(255),
    @VaiTro NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    -- 1. Thêm vào bảng TaiKhoan
    INSERT INTO TaiKhoan (TenTK, MatKhau, VaiTro)
    VALUES (@TenTK, @MatKhau, @VaiTro);

    -- 2. Tạo LOGIN nếu chưa có
    IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = @TenTK)
    BEGIN
        DECLARE @sqlLogin NVARCHAR(MAX);
        SET @sqlLogin = 'CREATE LOGIN [' + @TenTK + '] WITH PASSWORD = ''' + @MatKhau + ''';';
        EXEC(@sqlLogin);
    END

    -- 3. Tạo USER trong database nếu chưa có
    IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = @TenTK)
    BEGIN
        DECLARE @sqlUser NVARCHAR(MAX);
        SET @sqlUser = 'CREATE USER [' + @TenTK + '] FOR LOGIN [' + @TenTK + '];';
        EXEC(@sqlUser);
    END

    -- 4. Gán vào role tương ứng
    IF @VaiTro = 'QuanLy'
    BEGIN
        EXEC sp_addrolemember 'role_QuanLy', @TenTK;
    END
    ELSE IF @VaiTro = 'NhanVien'
    BEGIN
        EXEC sp_addrolemember 'role_NhanVien', @TenTK;
    END
END;

go
CREATE PROCEDURE sp_DoiMatKhau
    @TenTK NVARCHAR(50),
    @MatKhauMoi NVARCHAR(255)
AS
BEGIN
    UPDATE TaiKhoan
    SET MatKhau = @MatKhauMoi
    WHERE TenTK = @TenTK;
END;

go
CREATE PROCEDURE sp_XoaTaiKhoan
    @MaTK INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TenTK NVARCHAR(50);

    -- Lấy tên tài khoản từ MaTK
    SELECT @TenTK = TenTK FROM TaiKhoan WHERE MaTK = @MaTK;

    IF @TenTK IS NULL
    BEGIN
        RAISERROR(N'Tài khoản không tồn tại!', 16, 1);
        RETURN;	
    END

    -- 1. Xóa tài khoản trong bảng TaiKhoan
    DELETE FROM TaiKhoan WHERE MaTK = @MaTK;

    -- 2. Xóa USER trong database nếu tồn tại
    IF EXISTS (SELECT 1 FROM sys.database_principals WHERE name = @TenTK)
    BEGIN
        DECLARE @sqlDropUser NVARCHAR(MAX);
        SET @sqlDropUser = 'DROP USER [' + @TenTK + '];';
        EXEC(@sqlDropUser);
    END

    -- 3. Xóa LOGIN trong server nếu tồn tại
    IF EXISTS (SELECT 1 FROM sys.server_principals WHERE name = @TenTK)
    BEGIN
        DECLARE @sqlDropLogin NVARCHAR(MAX);
        SET @sqlDropLogin = 'DROP LOGIN [' + @TenTK + '];';
        EXEC(@sqlDropLogin);
    END
END;


go
CREATE PROCEDURE sp_ThemCongViec
    @TenCV NVARCHAR(50),
    @LuongCoBan DECIMAL(18,2)
AS
BEGIN
    INSERT INTO CongViec (TenCV, LuongCoBan)
    VALUES (@TenCV, @LuongCoBan);
END;

go
CREATE PROCEDURE sp_CapNhatCongViec
    @MaCV INT,
    @TenCV NVARCHAR(50),
    @LuongCoBan DECIMAL(18,2)
AS
BEGIN
    UPDATE CongViec
    SET TenCV = @TenCV, LuongCoBan = @LuongCoBan
    WHERE MaCV = @MaCV;
END;

go
CREATE PROCEDURE sp_XoaCongViec
    @MaCV INT
AS
BEGIN
    -- Kiểm tra xem công việc có đang được sử dụng không
    IF EXISTS (SELECT 1 FROM NhanVien WHERE MaCV = @MaCV)
    BEGIN
        RAISERROR(N'Không thể xóa công việc vì có nhân viên đang làm việc!', 16, 1);
    END
    ELSE
    BEGIN
        DELETE FROM CongViec WHERE MaCV = @MaCV;
    END
END;


go
CREATE PROCEDURE sp_ThemNhanVien
    @HoTen NVARCHAR(100),
    @DiaChi NVARCHAR(200),
    @NgaySinh DATE,
    @Email NVARCHAR(100),
    @SDT NVARCHAR(15),
    @MaTK INT,
    @MaCV INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM TaiKhoan WHERE MaTK = @MaTK)
        RAISERROR(N'Tài khoản không tồn tại', 16, 1);
    ELSE IF NOT EXISTS (SELECT 1 FROM CongViec WHERE MaCV = @MaCV)
        RAISERROR(N'Công việc không tồn tại', 16, 1);
    ELSE
        INSERT INTO NhanVien(HoTen, DiaChi, NgaySinh, Email, SDT, MaTK, MaCV)
        VALUES (@HoTen, @DiaChi, @NgaySinh, @Email, @SDT, @MaTK, @MaCV);
END;

go
CREATE PROCEDURE sp_XoaNhanVien
    @MaNV INT
AS
BEGIN
    -- Kiểm tra xem nhân viên có tồn tại không
    IF EXISTS (SELECT 1 FROM NhanVien WHERE MaNV = @MaNV)
    BEGIN
        -- Xóa thông tin chấm công của nhân viên
        DELETE FROM ChamCong WHERE MaNV = @MaNV;

        -- Xóa thông tin lương của nhân viên
        DELETE FROM Luong WHERE MaNV = @MaNV;

        -- Xóa nhân viên
        DELETE FROM NhanVien WHERE MaNV = @MaNV;
    END
    ELSE
    BEGIN
        RAISERROR(N'Nhân viên không tồn tại!', 16, 1);
    END
END;

go
CREATE PROCEDURE sp_CapNhatNhanVien
    @MaNV INT,
    @HoTen NVARCHAR(100),
    @DiaChi NVARCHAR(200),
    @NgaySinh DATE,
    @Email NVARCHAR(100),
    @SDT NVARCHAR(15),
    @MaCV INT
AS
BEGIN
    -- Kiểm tra xem nhân viên có tồn tại không
    IF EXISTS (SELECT 1 FROM NhanVien WHERE MaNV = @MaNV)
    BEGIN
        -- Kiểm tra công việc có tồn tại không
        IF NOT EXISTS (SELECT 1 FROM CongViec WHERE MaCV = @MaCV)
        BEGIN
            RAISERROR(N'Công việc không tồn tại!', 16, 1);
        END
        ELSE
        BEGIN
            -- Cập nhật thông tin nhân viên
            UPDATE NhanVien
            SET HoTen = @HoTen,
                DiaChi = @DiaChi,
                NgaySinh = @NgaySinh,
                Email = @Email,
                SDT = @SDT,
                MaCV = @MaCV
            WHERE MaNV = @MaNV;
        END
    END
    ELSE
    BEGIN
        RAISERROR(N'Nhân viên không tồn tại!', 16, 1);
    END
END;

go
CREATE PROCEDURE sp_ChamCong
    @MaNV INT,
    @Ngay DATE,
    @GioVao TIME,
    @GioRa TIME,
    @SoGioTangCa INT
AS
BEGIN
    -- Chèn thông tin chấm công vào bảng ChamCong
    INSERT INTO ChamCong (MaNV, Ngay, GioVao, GioRa, SoGioTangCa)
    VALUES (@MaNV, @Ngay, @GioVao, @GioRa, @SoGioTangCa);
END;


go  
CREATE PROCEDURE sp_TinhLuong
    @MaNV INT,
    @Thuong DECIMAL(18, 2),
    @PhuCap DECIMAL(18, 2)
AS
BEGIN
    DECLARE @LuongCoBan DECIMAL(18, 2), @SoGioLam INT, @LuongTangCa DECIMAL(18, 2), @TongLuong DECIMAL(18, 2);

    -- Lấy Lương cơ bản từ bảng CongViec (lương theo giờ của công việc)
    SELECT @LuongCoBan = CV.LuongCoBan
    FROM CongViec CV
    JOIN NhanVien NV ON NV.MaCV = CV.MaCV
    WHERE NV.MaNV = @MaNV;

    -- Lấy số giờ làm việc thực tế của nhân viên trong tháng từ bảng ChamCong
    SELECT @SoGioLam = SUM(DATEDIFF(HOUR, GioVao, GioRa))
    FROM ChamCong
    WHERE MaNV = @MaNV;

    -- Tính Lương tăng ca (Số giờ tăng ca * tỷ lệ 1.5 * lương theo giờ)
    SELECT @LuongTangCa = SUM(SoGioTangCa * 1.5 * @LuongCoBan)
    FROM ChamCong
    WHERE MaNV = @MaNV;

    -- Tính Tổng lương (Lương cơ bản + Thưởng + Phụ cấp + Lương tăng ca)
    SET @TongLuong = (@LuongCoBan * @SoGioLam) + @Thuong + @PhuCap + ISNULL(@LuongTangCa, 0);

    -- Kiểm tra xem bản ghi lương đã có chưa, nếu chưa thì thêm mới
    IF NOT EXISTS (SELECT 1 FROM Luong WHERE MaNV = @MaNV)
    BEGIN
        INSERT INTO Luong (MaNV, Thuong, PhuCap, LuongTangCa, TongLuong)
        VALUES (@MaNV, @Thuong, @PhuCap, @LuongTangCa, @TongLuong);
    END
    ELSE
    BEGIN
        -- Nếu đã có bản ghi, cập nhật thông tin
        UPDATE Luong
        SET Thuong = @Thuong, PhuCap = @PhuCap, LuongTangCa = @LuongTangCa, TongLuong = @TongLuong
        WHERE MaNV = @MaNV;
    END

   
END;


go
CREATE PROCEDURE sp_XoaLuong
    @MaNV INT
AS
BEGIN
    -- Xóa bản ghi trong bảng Luong dựa trên MaNV
    DELETE FROM Luong
    WHERE MaNV = @MaNV;
    
    -- Trả về thông báo hoặc số lượng bản ghi bị xóa (tùy theo yêu cầu)
    SELECT 'Xóa lương thành công' AS Message;
END;





go
CREATE TRIGGER trg_Delete_Luong_Khi_Xoa_NhanVien
ON NhanVien
AFTER DELETE
AS
BEGIN
    DECLARE @MaNV INT;

    -- Lấy MaNV của nhân viên đã bị xóa
    SELECT @MaNV = d.MaNV
    FROM DELETED d;

    -- Xóa bản ghi lương của nhân viên trong bảng Luong
    DELETE FROM Luong WHERE MaNV = @MaNV;
END;



go
CREATE TRIGGER trg_KiemTraGioRa
ON ChamCong
INSTEAD OF INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1 FROM inserted WHERE GioRa <= GioVao
    )
    BEGIN
        RAISERROR(N'Giờ ra phải lớn hơn giờ vào!', 16, 1);
        RETURN;
    END

    MERGE ChamCong AS target
    USING inserted AS source
    ON target.MaNV = source.MaNV AND target.Ngay = source.Ngay
    WHEN MATCHED THEN
        UPDATE SET GioVao = source.GioVao, GioRa = source.GioRa, SoGioTangCa = source.SoGioTangCa
    WHEN NOT MATCHED THEN
        INSERT (MaNV, Ngay, GioVao, GioRa, SoGioTangCa)
        VALUES (source.MaNV, source.Ngay, source.GioVao, source.GioRa, source.SoGioTangCa);
END;

go
BEGIN TRANSACTION;
BEGIN TRY
    DECLARE @MaNV INT;
    DECLARE @Thang INT = MONTH(GETDATE());
    DECLARE @Nam INT = YEAR(GETDATE());

    DECLARE cur CURSOR FOR
    SELECT MaNV FROM NhanVien;

    OPEN cur;
    FETCH NEXT FROM cur INTO @MaNV;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        EXEC sp_TinhLuongNhanVien_TheoThang @MaNV, @Thang, @Nam;
        FETCH NEXT FROM cur INTO @MaNV;
    END

    CLOSE cur;
    DEALLOCATE cur;

    COMMIT TRANSACTION;
    PRINT N'✅ Đã tính lương cho toàn bộ nhân viên.';
END TRY
BEGIN CATCH
    ROLLBACK TRANSACTION;
    PRINT N'❌ Có lỗi xảy ra, đã rollback toàn bộ.';
END CATCH;
