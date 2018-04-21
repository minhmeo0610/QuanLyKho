-- Sửa bảng Nhân Viên
GO
ALTER TABLE dbo.NhanVien 
ALTER COLUMN GioiTinh NVARCHAR(5)
-- Thủ tục Nhân Viên
-- Xem Nhân Viên
GO
CREATE PROC XemNV
AS
BEGIN
	SELECT *
	FROM dbo.NhanVien
END
-- Thêm NV
GO
CREATE PROC ThemNV(@MaNV NCHAR(10), @TenNV NVARCHAR(50), @NgaySinh DATE,@GioiTinh NVARCHAR(5), @DiaChi NVARCHAR(50), @SoDT NCHAR(20))
AS
BEGIN
	INSERT INTO dbo.NhanVien
	        ( MaNV ,
	          TenNV ,
	          NgaySinh ,
	          GioiTinh ,
	          DiaChi ,
	          SoDT
	        )
	VALUES  ( @MaNV,@TenNV,@NgaySinh,@GioiTinh,@DiaChi,@SoDT)
END
-- Sửa NV
GO
CREATE PROC SuaNV(@MaNV NCHAR(10), @TenNV NVARCHAR(50), @NgaySinh DATE,@GioiTinh NVARCHAR(5), @DiaChi NVARCHAR(50), @SoDT NCHAR(20))
AS
BEGIN
	UPDATE dbo.NhanVien
	SET TenNV=@TenNV,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,DiaChi=@DiaChi,SoDT=@SoDT
	WHERE MaNV=@MaNV
END
-- Xóa NV
GO
ALTER PROC XoaNV(@MaNV NCHAR(10))
AS
BEGIN
	UPDATE dbo.HoaDon
	SET MaNV=NULL
	WHERE MaNV=@MaNV
	DELETE dbo.NhanVien
	WHERE MaNV=@MaNV
END