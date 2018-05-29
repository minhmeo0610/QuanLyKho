USE QLKhoHang
GO
INSERT dbo.DoiTac
VALUES  ( N'DT01' ,N'Đối tác Mỹ' ,N'Mỹ' ,N'0125325554' , N'doitacmy@gmail.com' , N'' , N'đối tác hàng hóa')
INSERT dbo.DoiTac
VALUES  ( N'DT02' ,N'Đối tác Canada' ,N'Canada' ,N'0156523597' , N'doitaccanada@gmail.com' , N'' , N'đối tác hàng hóa')
INSERT dbo.DoiTac
VALUES  ( N'DT03' ,N'Đối tác Hàn Quốc' ,N'Hàn Quốc' ,N'0985642564' , N'doitachanquoc@gmail.com' , N'' , N'đối tác dịch vụ')
INSERT dbo.DoiTac
VALUES  ( N'DT04' ,N'Đối tác Nhật Bản' ,N'Nhật Bản' ,N'0452124545' , N'doitacnhatban@gmail.com' , N'' , N'đối tác xuất khẩu')
INSERT dbo.DoiTac
VALUES  ( N'DT05' ,N'Đối tác Singapo' ,N'Singapo' ,N'0169856525' , N'doitacsingapo@gmail.com' , N'' , N'đối tác xuất khẩu')
INSERT dbo.DoiTac
VALUES  ( N'DT06' ,N'Đối tác Vương Quốc Anh' ,N'Anh Quốc' ,N'098621214' , N'doitacanh@gmail.com' , N'' , N'đối tác hàng hóa')
INSERT dbo.DoiTac
VALUES  ( N'DT07' ,N'Đối tác Nga' ,N'Nga' ,N'0963256874' , N'doitacnga@gmail.com' , N'' , N'đối tác dịch vụ')
INSERT dbo.DoiTac
VALUES  ( N'DT08' ,N'Đối tác Trung Quốc' ,N'Trung Quốc' ,N'0986521454' , N'doitactrungquoc@gmail.com' , N'' , N'đối tác xuất khẩu')
INSERT dbo.DoiTac
VALUES  ( N'DT09' ,N'Đối tác Phan Thị' ,N'Việt Nam' ,N'0999656969' , N'doitacphanthi@gmail.com' , N'' , N'đối tác hàng hóa')
INSERT dbo.DoiTac
VALUES  ( N'DT010' ,N'Đối tác Pháp' ,N'Pháp' ,N'0168954787' , N'doitacphap@gmail.com' , N'' , N'đối tác xuất khẩu')

GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          SoDT
        )
VALUES  ( N'NV01' , -- MaNV - nchar(10)
          N'Hoàng Mạnh Nam' , -- TenNV - nvarchar(50)
          '1993-09-02' , -- NgaySinh - date
          N'Nam' , -- GioiTinh - nvarchar(5)
          N'Hà Nội' , -- DiaChi - nvarchar(50)
          N'0987654987'  -- SoDT - nchar(20)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          SoDT
        )
VALUES  ( N'NV02' , -- MaNV - nchar(10)
          N'Nguyễn Văn Mạnh' , -- TenNV - nvarchar(50)
          '1992-05-12' , -- NgaySinh - date
          N'Nam' , -- GioiTinh - nvarchar(5)
          N'Hà Nội' , -- DiaChi - nvarchar(50)
          N'0987659107'  -- SoDT - nchar(20)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          SoDT
        )
VALUES  ( N'NV03' , -- MaNV - nchar(10)
          N'Lý Thị Huyền' , -- TenNV - nvarchar(50)
          '1993-11-02' , -- NgaySinh - date
          N'Nữ' , -- GioiTinh - nvarchar(5)
          N'Hà Nội' , -- DiaChi - nvarchar(50)
          N'0989014987'  -- SoDT - nchar(20)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          SoDT
        )
VALUES  ( N'NV04' , -- MaNV - nchar(10)
          N'Lý Ngọc Minh' , -- TenNV - nvarchar(50)
          '1991-01-24' , -- NgaySinh - date
          N'Nữ' , -- GioiTinh - nvarchar(5)
          N'Hà Nội' , -- DiaChi - nvarchar(50)
          N'0989010987'  -- SoDT - nchar(20)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          SoDT
        )
VALUES  ( N'NV05' , -- MaNV - nchar(10)
          N'Đào Văn Huấn' , -- TenNV - nvarchar(50)
          '1991-09-02' , -- NgaySinh - date
          N'Nam' , -- GioiTinh - nvarchar(5)
          N'Hà Nội' , -- DiaChi - nvarchar(50)
          N'0987894987'  -- SoDT - nchar(20)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          SoDT
        )
VALUES  ( N'NV06' , -- MaNV - nchar(10)
          N'Trần Văn Mạnh' , -- TenNV - nvarchar(50)
          '1993-01-12' , -- NgaySinh - date
          N'Nam' , -- GioiTinh - nvarchar(5)
          N'Hà Nội' , -- DiaChi - nvarchar(50)
          N'0989356987'  -- SoDT - nchar(20)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          SoDT
        )
VALUES  ( N'NV07' , -- MaNV - nchar(10)
          N'Nguyễn Huy Hoàng' , -- TenNV - nvarchar(50)
          '1992-06-04' , -- NgaySinh - date
          N'Nam' , -- GioiTinh - nvarchar(5)
          N'Hà Nội' , -- DiaChi - nvarchar(50)
          N'09901254987'  -- SoDT - nchar(20)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          SoDT
        )
VALUES  ( N'NV08' , -- MaNV - nchar(10)
          N'Trần Văn Toàn' , -- TenNV - nvarchar(50)
          '1995-07-03' , -- NgaySinh - date
          N'Nam' , -- GioiTinh - nvarchar(5)
          N'Hà Nội' , -- DiaChi - nvarchar(50)
          N'0986824987'  -- SoDT - nchar(20)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          SoDT
        )
VALUES  ( N'NV09' , -- MaNV - nchar(10)
          N'Trần Hữu Quyết' , -- TenNV - nvarchar(50)
          '1995-02-03' , -- NgaySinh - date
          N'Nam' , -- GioiTinh - nvarchar(5)
          N'Hà Nội' , -- DiaChi - nvarchar(50)
          N'0990824987'  -- SoDT - nchar(20)
        )
GO
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          SoDT
        )
VALUES  ( N'NV10' , -- MaNV - nchar(10)
          N'Lê Văn Huy' , -- TenNV - nvarchar(50)
          '1989-04-09' , -- NgaySinh - date
          N'Nam' , -- GioiTinh - nvarchar(5)
          N'Hà Nội' , -- DiaChi - nvarchar(50)
          N'0986345687'  -- SoDT - nchar(20)
        )


