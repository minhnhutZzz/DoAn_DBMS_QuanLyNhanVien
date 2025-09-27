use QL_NhanVien;
go

-- Hàm trả về bảng được định nghĩa
go
CREATE FUNCTION dbo.fn_HienThiThongTinLuong
    (@MaNV INT)
RETURNS @LuongTable TABLE 
(
    [Mã nhân viên] INT,         
    [Họ tên] NVARCHAR(100),      
    [Ngày chấm công] DATE,      
    [Giờ vào] TIME,              
    [Giờ ra] TIME,               
    [Số giờ làm] INT,            
    [Số giờ tăng ca] INT,       
    [Lương thưởng] DECIMAL(18, 2), 
    [Lương phụ cấp] DECIMAL(18, 2), 
    [Lương tăng ca] DECIMAL(18, 2), 
    [Tổng lương] DECIMAL(18, 2) 
)
AS
BEGIN
    INSERT INTO @LuongTable
    SELECT 
        NV.MaNV, 
        NV.HoTen, 
        CC.Ngay, 
        CC.GioVao, 
        CC.GioRa, 
        DATEDIFF(HOUR, CC.GioVao, CC.GioRa) AS SoGioLam, 
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
        NV.MaNV = @MaNV;  
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
        COUNT(NV.MaNV) AS SoNhanVien  
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



--Thủ tục 

GO
CREATE PROCEDURE sp_ThemTaiKhoan
    @TenTK NVARCHAR(50),
    @MatKhau NVARCHAR(255),
    @VaiTro NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    -- Bắt đầu giao dịch
    BEGIN TRANSACTION;

    BEGIN TRY
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

        -- Nếu tất cả các bước thành công, commit giao dịch
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Nếu có lỗi xảy ra, rollback giao dịch
        ROLLBACK TRANSACTION;

        -- Thông báo lỗi
        PRINT 'Lỗi: ' + ERROR_MESSAGE();
        THROW;  -- Ném lại lỗi để có thể xử lý thêm ngoài thủ tục này nếu cần
    END CATCH
END;
GO

CREATE PROCEDURE sp_XoaTaiKhoan
    @MaTK INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Bắt đầu giao dịch
    BEGIN TRANSACTION;

    DECLARE @TenTK NVARCHAR(50);

    -- Lấy tên tài khoản từ MaTK
    SELECT @TenTK = TenTK FROM TaiKhoan WHERE MaTK = @MaTK;

    IF @TenTK IS NULL
    BEGIN
        -- Nếu không tìm thấy tài khoản, ném lỗi và rollback giao dịch
        RAISERROR(N'Tài khoản không tồn tại!', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END

    BEGIN TRY
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

        -- Nếu mọi thao tác thành công, commit giao dịch
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Nếu có lỗi xảy ra, rollback giao dịch
        ROLLBACK TRANSACTION;

        -- Thông báo lỗi
        PRINT 'Lỗi: ' + ERROR_MESSAGE();
        THROW;  -- Ném lại lỗi để có thể xử lý thêm ngoài thủ tục này nếu cần
    END CATCH
END;
GO




CREATE PROCEDURE sp_QuenMatKhau
    @TenTK NVARCHAR(50),
    @MatKhauMoi NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    -- Bắt đầu giao dịch
    BEGIN TRANSACTION;

    BEGIN TRY
        -- 1. Cập nhật mật khẩu trong bảng TaiKhoan
        UPDATE TaiKhoan
        SET MatKhau = @MatKhauMoi
        WHERE TenTK = @TenTK;

        -- 2. Cập nhật mật khẩu trong SQL Server Login
        IF EXISTS (SELECT * FROM sys.server_principals WHERE name = @TenTK)
        BEGIN
            -- Cập nhật mật khẩu cho Login trong SQL Server
            DECLARE @sqlLogin NVARCHAR(MAX);
            SET @sqlLogin = 'ALTER LOGIN [' + @TenTK + '] WITH PASSWORD = ''' + @MatKhauMoi + ''';';
            EXEC(@sqlLogin);
        END
        ELSE
        BEGIN
            -- Nếu Login không tồn tại trong SQL Server, ném lỗi
            RAISERROR('Login không tồn tại trong SQL Server', 16, 1);
        END

        -- Nếu tất cả thành công, commit giao dịch
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Nếu có lỗi xảy ra, rollback giao dịch
        ROLLBACK TRANSACTION;

        -- Xử lý lỗi
        PRINT 'Lỗi: ' + ERROR_MESSAGE();
        -- Thông báo lỗi cho người dùng hoặc ghi log lỗi tùy theo nhu cầu
        THROW;
    END CATCH
END;
GO



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
CREATE PROCEDURE sp_TimKiemNhanVien
    @Search NVARCHAR(100)
AS
BEGIN
    SELECT * FROM vw_NhanVien
    WHERE HoTen LIKE '%' + @Search + '%'
       OR Email LIKE '%' + @Search + '%'
       OR SDT LIKE '%' + @Search + '%'
END


go
CREATE PROCEDURE sp_TimKiemTaiKhoan
    @Search NVARCHAR(100)
AS
BEGIN
    SELECT * 
    FROM TaiKhoan
    WHERE TenTK LIKE '%' + @Search + '%'
END

go
CREATE PROCEDURE sp_TimKiemCongViec
    @Search NVARCHAR(100)
AS
BEGIN
    SELECT * 
    FROM CongViec
    WHERE TenCV LIKE '%' + @Search + '%'
END



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
CREATE PROCEDURE sp_XoaBangGhiChamCong
    @MaNV INT,
    @Ngay DATE
AS
BEGIN
    DELETE FROM ChamCong
    WHERE MaNV = @MaNV AND Ngay = @Ngay;
END;

go 

CREATE PROCEDURE sp_XoaTatCaChamCong
AS
BEGIN
    DELETE FROM ChamCong;
END;


go
CREATE PROCEDURE sp_TinhLuong
    @MaNV INT,
    @Thuong DECIMAL(18, 2),
    @PhuCap DECIMAL(18, 2)
AS
BEGIN
    DECLARE @LuongCoBan DECIMAL(18, 2), @SoGioLam INT, @LuongTangCa DECIMAL(18, 2), @TongLuong DECIMAL(18, 2);

    -- Bắt đầu transaction
    BEGIN TRY
        BEGIN TRANSACTION;

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

        -- Commit transaction nếu tất cả các thao tác thành công
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Nếu có lỗi xảy ra, rollback transaction
        ROLLBACK TRANSACTION;

        -- Thông báo lỗi
        DECLARE @ErrorMessage NVARCHAR(4000), @ErrorSeverity INT, @ErrorState INT;
        SELECT @ErrorMessage = ERROR_MESSAGE(), 
               @ErrorSeverity = ERROR_SEVERITY(), 
               @ErrorState = ERROR_STATE();
        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
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




-- Trigger


go
CREATE TRIGGER trg_Delete_ChamCong_Khi_Xoa_Luong
ON Luong
AFTER DELETE
AS
BEGIN
    -- Kiểm tra xem có bản ghi nào bị xóa không
    IF EXISTS (SELECT 1 FROM deleted)
    BEGIN
        -- Lấy mã nhân viên từ bảng deleted 
        DECLARE @MaNV INT;
        SELECT @MaNV = MaNV FROM deleted;

        -- Xóa các bản ghi trong bảng ChamCong tương ứng với MaNV của nhân viên
        DELETE FROM ChamCong
        WHERE MaNV = @MaNV;
    END
END;
GO

CREATE TRIGGER trg_UpdateLuongKhiThayDoiLuongCoBan
ON CongViec
AFTER UPDATE
AS
BEGIN
    -- Kiểm tra nếu cột LuongCoBan có thay đổi
    IF UPDATE(LuongCoBan)
    BEGIN
        DECLARE @MaCV INT, @LuongCoBanMoi DECIMAL(18, 2);

        -- Lấy thông tin MaCV và Lương cơ bản mới từ bản ghi đã cập nhật
        SELECT @MaCV = MaCV, @LuongCoBanMoi = LuongCoBan
        FROM INSERTED;  -- INSERTED chứa giá trị của bản ghi sau khi cập nhật

        -- Cập nhật lại Lương tăng ca cho tất cả nhân viên có MaCV tương ứng
        -- Tính lại lương tăng ca dựa trên số giờ tăng ca và lương cơ bản mới
        WITH UpdatedLuongTangCa AS (
            SELECT MaNV,
                   SUM(SoGioTangCa * 1.5 * @LuongCoBanMoi) AS NewLuongTangCa
            FROM ChamCong
            WHERE MaNV IN (SELECT MaNV FROM NhanVien WHERE MaCV = @MaCV)
            GROUP BY MaNV
        )
        -- Cập nhật lại Lương tăng ca và Tổng lương cho nhân viên có MaCV tương ứng
        UPDATE Luong
        SET 
            LuongTangCa = ULT.NewLuongTangCa,
            -- Tính lại tổng lương sau khi đã cập nhật Lương tăng ca
            TongLuong = (@LuongCoBanMoi * CL.SoGioLam) + Thuong + PhuCap + ISNULL(ULT.NewLuongTangCa, 0)
        FROM Luong L
        JOIN UpdatedLuongTangCa ULT ON L.MaNV = ULT.MaNV
        JOIN ChamCong CL ON CL.MaNV = L.MaNV  -- Join với ChamCong để lấy SoGioLam
        WHERE L.MaNV IN (SELECT MaNV FROM NhanVien WHERE MaCV = @MaCV);  -- Cập nhật cho tất cả nhân viên có MaCV đã thay đổi
    END
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



-- View
go
CREATE VIEW vw_TaiKhoan AS
SELECT * 
FROM TaiKhoan;

go
CREATE VIEW vw_NhanVien AS
SELECT * 
FROM NhanVien;

go
CREATE VIEW vw_CongViec AS
SELECT * 
FROM CongViec;


go
CREATE VIEW vw_ChamCong AS
SELECT * 
FROM ChamCong;


go
CREATE VIEW vw_Luong AS
SELECT * 
FROM Luong;






