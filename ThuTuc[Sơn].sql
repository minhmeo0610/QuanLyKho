USE QLKhoHang
GO
CREATE PROC HD_SelectAll 
AS
BEGIN
	SELECT HoaDon.MaHD,TenDoiTac,TenNV,NgayLap, KieuHoaDon FROM dbo.HoaDon,dbo.DoiTac,dbo.NhanVien
	WHERE HoaDon.MaNV = NhanVien.MaNV AND DoiTac.MaDoiTac =HoaDon.MaDoiTac
END
GO 
CREATE PROC Them_HD(@MaHD VARCHAR(10),@MaDT VARCHAR(10),@MaNV VARCHAR(10),@NgayLap DATE,@KieuHD NVARCHAR(10))
AS
BEGIN
	INSERT INTO dbo.HoaDon ( MaHD ,MaDoiTac ,NgayLap ,MaNV,KieuHoaDon)
	VALUES  (@MaHD,@MaDT,@NgayLap,@MaNV,@KieuHD )
END
GO 
CREATE PROC Xoa_HD (@Ma varchar(10) )
AS 
BEGIN
	DELETE dbo.HoaDon WHERE MaHD = @Ma 
END
GO
ALTER PROC CTHD_SelectByID (@Ma VARCHAR(10))
AS
BEGIN
	SELECT MaHD,TenSP,SoLuong,DonGia,(SoLuong*DonGia) AS ThanhTien FROM dbo.ChiTietHoaDon,dbo.SanPham
	WHERE ChiTietHoaDon.MaSP= SanPham.MaSP AND  MaHD = @Ma
END
GO 
ALTER PROC Them_CTHD (@MaHD VARCHAR(10), @MaSP VARCHAR(10),@SoLuong INT, @DonGia INT)
AS
BEGIN
	INSERT INTO dbo.ChiTietHoaDon
	        ( MaSP, MaHD, SoLuong, DonGia )
	VALUES  ( @MaSP,@MaHD,@SoLuong,@DonGia)
END
GO
CREATE PROC Xoa_CTHD (@MaHD varchar(10),@MaSP varchar(10))
AS 
BEGIN
	DELETE dbo.ChiTietHoaDon WHERE MaHD = @MaHD AND MaSP =@MaSP 
END
GO
CREATE PROC Select_SP
AS
BEGIN	
	SELECT*FROM dbo.SanPham
END
GO
CREATE PROC Select_DT
AS
BEGIN	
	SELECT*FROM dbo.DoiTac
END
GO 
CREATE PROC Select_NV
AS
BEGIN	
	SELECT*FROM dbo.NhanVien
END
GO 