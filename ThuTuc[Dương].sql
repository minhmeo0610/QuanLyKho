--thủ tục dương

USE QLKhoHang
GO
CREATE PROC SP_XemDoiTac
AS
BEGIN
	SELECT * FROM dbo.DoiTac
END
GO
--thủ thục thêm đối tác
CREATE PROC SP_ThemDoiTac(@MaDoiTac VARCHAR(10),@TenDoiTac VARCHAR(10),@DiaChi NVARCHAR(50),@SoDT VARCHAR(20),@Email VARCHAR(50),@GhiChu NVARCHAR(50),@KieuDoiTac NVARCHAR(50))
AS
BEGIN
	INSERT dbo.DoiTac
	VALUES  ( @MaDoiTac ,@TenDoiTac ,@DiaChi , @SoDT ,@Email ,@GhiChu, @KieuDoiTac)
END
GO
--thủ tục sửa đối tác
CREATE PROC SP_SuaDoiTac(@MaDoiTac VARCHAR(10),@TenDoiTac VARCHAR(10),@DiaChi NVARCHAR(50),@SoDT VARCHAR(20),@Email VARCHAR(50),@GhiChu NVARCHAR(50),@KieuDoiTac NVARCHAR(50))
AS
BEGIN
	UPDATE dbo.DoiTac
	SET TenDoiTac=@TenDoiTac,DiaChi=@DiaChi,SoDT=@SoDT,Email=@Email,GhiChu=@GhiChu,KieuDoiTac=@KieuDoiTac
	WHERE MaDoiTac=@MaDoiTac
END
GO
--thủ tục xóa đối tác
ALTER PROC SP_XoaDoiTac(@MaDoiTac VARCHAR(10))
AS
BEGIN
	UPDATE dbo.HoaDon
	SET MaDoiTac=NULL
	WHERE MaDoiTac=@MaDoiTac
	DELETE dbo.DoiTac
	WHERE MaDoiTac=@MaDoiTac
END
GO 