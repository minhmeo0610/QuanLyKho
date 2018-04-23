USE QLKhoHang
GO
 CREATE TABLE ChiTietHoaDon
 (
	MaHD NCHAR(10)REFERENCES dbo.HoaDon(MaHD),
	MaSP NCHAR(10) REFERENCES dbo.SanPham(MaSP),
	SoLuong INT ,
	GiaSP INT, 
	PRIMARY KEY( MaHD ,MaSP)
 )
 --INSERT
 GO 
 INSERT dbo.LoaiSanPham( MaLoaiSP, TenLoaiSP, MoTa )
 VALUES  ('LSP01',N'Máy Tính',N'Đắt tiền ')
 INSERT dbo.LoaiSanPham( MaLoaiSP, TenLoaiSP, MoTa )
 VALUES  ('LSP02',N'Tủ Lạnh',N'Đắt tiền ')
 INSERT dbo.LoaiSanPham( MaLoaiSP, TenLoaiSP, MoTa )
 VALUES  ('LSP03',N'Màn hình',N'Đắt tiền ')

 GO 
 INSERT dbo.SanPham( MaSP , TenSP ,MaLoaiSP ,SoLuong ,Gia , GhiChu , Ngay)
 VALUES  ('SP01',N'Máy tính Dell','LSP01',10,14500000,N'Không',GETDATE())
 INSERT dbo.SanPham( MaSP , TenSP ,MaLoaiSP ,SoLuong ,Gia , GhiChu , Ngay)
 VALUES  ('SP02',N'Máy tính ASUS','LSP01',10,15500000,N'Không',GETDATE())
 INSERT dbo.SanPham( MaSP , TenSP ,MaLoaiSP ,SoLuong ,Gia , GhiChu , Ngay)
 VALUES  ('SP03',N'Máy tính HP','LSP01',10,10500000,N'Không',GETDATE())

 GO 
 INSERT dbo.NhanVien( MaNV ,TenNV , NgaySinh , GioiTinh ,DiaChi ,SoDT)
 VALUES  ('NV01',N'Nguyễn Hồng Son','12-04-1997',N'Nữ',N'Quốc Oai','0955666355')
 INSERT dbo.NhanVien( MaNV ,TenNV , NgaySinh , GioiTinh ,DiaChi ,SoDT)
 VALUES  ('NV02',N'Phan Duy Dương','08-12-1997',N'Nữ',N'Quốc Oai','0954236894')
 INSERT dbo.NhanVien( MaNV ,TenNV , NgaySinh , GioiTinh ,DiaChi ,SoDT)
 VALUES  ('NV03',N'Phạm Quang Min','12-12-1997',N'Nữ',N'Quảng Ninh','0955111355')

 GO
 INSERT dbo.DoiTac( MaDoiTac,TenDoiTac,DiaChi, SoDT, Email,GhiChu ,KieuDoiTac )
 VALUES  ('DT01',N'Công Ty ABC',N'Hà Nội','0123987654',N'tacke@gmail.com',N'ABC',N'Kiểu gì bây giờ minh' )
 INSERT dbo.DoiTac( MaDoiTac,TenDoiTac,DiaChi, SoDT, Email,GhiChu ,KieuDoiTac )
 VALUES  ('DT03',N'Công Ty MIN',N'Hà Nội','0987456321',N'min@gmail.com',N'MIN',N'bây giờ  kiểu gì minh' )
  INSERT dbo.DoiTac( MaDoiTac,TenDoiTac,DiaChi, SoDT, Email,GhiChu ,KieuDoiTac )
 VALUES  ('DT02',N'Công Ty SON',N'Hà Nội','0123987654',N'sonqa@gmail.com',N'SON',N'minh bây giờ  kiểu gì' )

 GO
 INSERT dbo.HoaDon( MaHD , MaDoiTac , Ngay , MaNV ,KieuHoaDon)
 VALUES  ('HD01','DT01',GETDATE(),'NV01',N'minh')
 INSERT dbo.HoaDon( MaHD , MaDoiTac , Ngay , MaNV ,KieuHoaDon)
 VALUES  ('HD02','DT02',GETDATE(),'NV02',N'bây giờ ')
 INSERT dbo.HoaDon( MaHD , MaDoiTac , Ngay , MaNV ,KieuHoaDon)
 VALUES  ('HD03','DT03',GETDATE(),'NV03',N'Kiểu gì ')


GO
INSERT dbo.ChiTietHoaDon( MaHD, MaSP, SoLuong, GiaSP )
VALUES  ('HD01','SP01',1,14500000)
INSERT dbo.ChiTietHoaDon( MaHD, MaSP, SoLuong, GiaSP )
VALUES  ('HD02','SP02',1,15500000)
INSERT dbo.ChiTietHoaDon( MaHD, MaSP, SoLuong, GiaSP )
VALUES  ('HD03','SP03',1,10500000)

 GO 
 CREATE PROC SP_XemLoaiSanPham
 AS
 BEGIN
	SELECT *FROM dbo.LoaiSanPham
 END 

 GO 
 CREATE PROC SP_ThemLoaiSP @MaLoaiSP VARCHAR(10), @TenLoaiSP VARCHAR(10), @MoTa NVARCHAR(50)
 AS
 BEGIN
	INSERT dbo.LoaiSanPham( MaLoaiSP, TenLoaiSP, MoTa )
	VALUES  (@MaLoaiSP,@TenLoaiSP,@MoTa)
 END
 
 GO 
 CREATE PROC SP_SuaLoaiSP @MaLoaiSP VARCHAR(10), @TenLoaiSP VARCHAR(10), @MoTa NVARCHAR(50)
 AS
 BEGIN
	UPDATE dbo.LoaiSanPham SET TenLoaiSP = @TenLoaiSP,MoTa = @MoTa
	WHERE MaLoaiSP = @MaLoaiSP
 END

 GO 
 CREATE PROC SP_XoaLoaiSP @MaLoaiSP VARCHAR(10)
 AS
 BEGIN
	DELETE dbo.LoaiSanPham 
	WHERE MaLoaiSP =@MaLoaiSP
 END