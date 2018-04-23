USE QLKhoHang

GO
CREATE PROC XemSP
AS
BEGIN
	SELECT * FROM dbo.SanPham
END

GO
CREATE PROC ThemSP(@masp NCHAR(10),@tensp NVARCHAR(50),@malsp NCHAR(10),@soluong INT,@gia INT,@ghichu NVARCHAR(MAX),@ngay DATE)
AS
BEGIN
	INSERT dbo.SanPham
	        ( MaSP ,
	          TenSP ,
	          MaLoaiSP ,
	          SoLuong ,
	          Gia ,
	          GhiChu ,
	          Ngay
	        )
	VALUES  (@masp,@tensp,@malsp,@soluong,@gia,@ghichu,@ngay)
END


GO
CREATE PROC SuaSP(@masp NCHAR(10),@tensp NVARCHAR(50),@malsp NCHAR(10),@soluong INT,@gia INT,@ghichu NVARCHAR(MAX),@ngay DATE)
AS
BEGIN
	UPDATE dbo.SanPham SET TenSP=@tensp,MaLoaiSP=@malsp,SoLuong=@soluong,Gia=@gia,GhiChu=@ghichu,Ngay=@ngay
	WHERE MaSP=@masp
END

GO
CREATE PROC XoaSP(@masp NCHAR(10))
AS
BEGIN
	DELETE dbo.SanPham 
	WHERE MaSP=@masp
END

GO

TRUNCATE TABLE dbo.NhanVien

