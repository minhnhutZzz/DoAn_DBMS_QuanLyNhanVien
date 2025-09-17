use QL_NhanVien;
go

--Hàm 
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

go
CREATE FUNCTION fn_LuongTheoGio(@MaNV INT)
RETURNS DECIMAL(18,2)
AS
BEGIN
    DECLARE @Luong DECIMAL(18,2);
    SELECT @Luong = CV.LuongCoBan
    FROM CongViec CV
    JOIN NhanVien NV ON CV.MaCV = NV.MaCV
    WHERE NV.MaNV = @MaNV;
    RETURN ISNULL(@Luong, 0);
END;

go
CREATE FUNCTION fn_TongGioLamTrongThang(@MaNV INT, @Thang INT, @Nam INT)
RETURNS INT
AS
BEGIN
    RETURN (
        SELECT SUM(SoGioLam)
        FROM ChamCong
        WHERE MaNV = @MaNV AND MONTH(Ngay) = @Thang AND YEAR(Ngay) = @Nam
    );
END;

go
CREATE FUNCTION fn_TongGioTangCaTrongThang(@MaNV INT, @Thang INT, @Nam INT)
RETURNS INT
AS
BEGIN
    RETURN (
        SELECT SUM(SoGioTangCa)
        FROM ChamCong
        WHERE MaNV = @MaNV AND MONTH(Ngay) = @Thang AND YEAR(Ngay) = @Nam
    );
END;

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
CREATE FUNCTION fn_BangLuongThang(@Thang INT, @Nam INT)
RETURNS @BangLuong TABLE (
    MaNV INT,
    HoTen NVARCHAR(100),
    TongGioLam INT,
    TongGioTangCa INT,
    LuongCoBan DECIMAL(18,2),
    LuongTangCa DECIMAL(18,2),
    TongLuong DECIMAL(18,2)
)
AS
BEGIN
    INSERT INTO @BangLuong
    SELECT 
        NV.MaNV,
        NV.HoTen,
        ISNULL(SUM(CC.SoGioLam), 0) AS TongGioLam,
        ISNULL(SUM(CC.SoGioTangCa), 0) AS TongGioTangCa,
        CV.LuongCoBan,
        ISNULL(SUM(CC.SoGioTangCa), 0) * CV.LuongCoBan * 1.5 AS LuongTangCa,
        ISNULL(SUM(CC.SoGioLam), 0) * CV.LuongCoBan + 
        ISNULL(SUM(CC.SoGioTangCa), 0) * CV.LuongCoBan * 1.5 AS TongLuong
    FROM NhanVien NV
    JOIN CongViec CV ON NV.MaCV = CV.MaCV
    LEFT JOIN ChamCong CC ON NV.MaNV = CC.MaNV
        AND MONTH(CC.Ngay) = @Thang AND YEAR(CC.Ngay) = @Nam
    GROUP BY NV.MaNV, NV.HoTen, CV.LuongCoBan;

    RETURN;
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

CREATE TRIGGER trg_Update_LuongTangCa_TongLuong
ON ChamCong
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @MaNV INT, @SoGioTangCa INT, @LuongCoBan DECIMAL(18, 2), @LuongTangCa DECIMAL(18, 2), @TongLuong DECIMAL(18, 2);

    -- Lấy thông tin từ bảng ChamCong và CongViec
    SELECT @MaNV = i.MaNV, @SoGioTangCa = i.SoGioTangCa
    FROM INSERTED i;

    -- Tính LuongTangCa từ bảng CongViec và SoGioTangCa trong ChamCong
    SELECT @LuongCoBan = CV.LuongCoBan
    FROM CongViec CV
    JOIN NhanVien NV ON CV.MaCV = NV.MaCV
    WHERE NV.MaNV = @MaNV;

    -- Tính LuongTangCa
    SET @LuongTangCa = @SoGioTangCa * 1.5 * @LuongCoBan;

    -- Tính TongLuong (Thuong + PhuCap + LuongTangCa)
    SELECT @TongLuong = ISNULL(Lu.Thuong, 0) + ISNULL(Lu.PhuCap, 0) + @LuongTangCa
    FROM Luong Lu
    WHERE Lu.MaNV = @MaNV;

    -- Cập nhật bảng Luong với giá trị tính được
    UPDATE Luong
    SET LuongTangCa = @LuongTangCa, TongLuong = @TongLuong
    WHERE MaNV = @MaNV;
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
