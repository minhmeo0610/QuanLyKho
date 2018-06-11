USE QLKhoHang 
GO
------Hóa Đơn-------
INSERT dbo.HoaDon
        ( MaHD ,MaDoiTac ,NgayLap ,MaNV ,KieuHoaDon )
VALUES  ( 'HD01' , 'DT01' , '6/8/2018' ,'NV01' ,  N'Xuất Kho')
INSERT dbo.HoaDon
        ( MaHD ,MaDoiTac ,NgayLap ,MaNV ,KieuHoaDon )
VALUES  ( 'HD02' , 'DT02' , '6/8/2018 ','NV02' ,  N'Nhập Kho')
INSERT dbo.HoaDon
        ( MaHD ,MaDoiTac ,NgayLap ,MaNV ,KieuHoaDon )
VALUES  ( 'HD03' , 'DT03' , '6/2/2018' ,'NV01' ,  N'Xuất Kho')
INSERT dbo.HoaDon
        ( MaHD ,MaDoiTac ,NgayLap ,MaNV ,KieuHoaDon )
VALUES  ( 'HD04' , 'DT02' , '6/2/2018' ,'NV02' ,  N'Nhập Kho')
INSERT dbo.HoaDon
        ( MaHD ,MaDoiTac ,NgayLap ,MaNV ,KieuHoaDon )
VALUES  ( 'HD05' , 'DT01' ,'6/3/2018','NV01' ,  N'Xuất Kho')
INSERT dbo.HoaDon
        ( MaHD ,MaDoiTac ,NgayLap ,MaNV ,KieuHoaDon )
VALUES  ( 'HD06' , 'DT03' , '5/2/2018 ','NV02' ,  N'Nhập Kho')
INSERT dbo.HoaDon
        ( MaHD ,MaDoiTac ,NgayLap ,MaNV ,KieuHoaDon )
VALUES  ( 'HD07' , 'DT04' , '3/10/2018' ,'NV01' ,  N'Xuất Kho')
INSERT dbo.HoaDon
        ( MaHD ,MaDoiTac ,NgayLap ,MaNV ,KieuHoaDon )
VALUES  ( 'HD08' , 'DT03' , '5/10/2018' ,'NV01' ,  N'Xuất Kho')
INSERT dbo.HoaDon
        ( MaHD ,MaDoiTac ,NgayLap ,MaNV ,KieuHoaDon )
VALUES  ( 'HD09' , 'DT04' , '4/10/2018' ,'NV02' ,  N'Nhập Kho')
INSERT dbo.HoaDon
        ( MaHD ,MaDoiTac ,NgayLap ,MaNV ,KieuHoaDon )
VALUES  ( 'HD010' , 'DT02' , '6/10/2018' ,'NV01' ,  N'Xuất Kho')

----Chi Tiết Hóa Đơn------

INSERT INTO dbo.ChiTietHoaDon
        ( MaSP , MaHD ,SoLuong , DonGia)
VALUES  ( 'SP01' ,'HD01' ,10,  10000000)
INSERT INTO dbo.ChiTietHoaDon
        ( MaSP , MaHD ,SoLuong , DonGia)
VALUES  ( 'SP02' ,'HD02' ,20,  15000000)
INSERT INTO dbo.ChiTietHoaDon
        ( MaSP , MaHD ,SoLuong , DonGia)
VALUES  ( 'SP03' ,'HD03' ,10,  9000000)
INSERT INTO dbo.ChiTietHoaDon
        ( MaSP , MaHD ,SoLuong , DonGia)
VALUES  ( 'SP04' ,'HD04' ,10,  8000000)
INSERT INTO dbo.ChiTietHoaDon
        ( MaSP , MaHD ,SoLuong , DonGia)
VALUES  ( 'SP05' ,'HD05' ,10,  12000000)
INSERT INTO dbo.ChiTietHoaDon
        ( MaSP , MaHD ,SoLuong , DonGia)
VALUES  ( 'SP03' ,'HD06' ,10,  9000000)
INSERT INTO dbo.ChiTietHoaDon
        ( MaSP , MaHD ,SoLuong , DonGia)
VALUES  ( 'SP02' ,'HD07' ,10,  15000000)
INSERT INTO dbo.ChiTietHoaDon
        ( MaSP , MaHD ,SoLuong , DonGia)
VALUES  ( 'SP04' ,'HD08' ,10,  8000000)
INSERT INTO dbo.ChiTietHoaDon
        ( MaSP , MaHD ,SoLuong , DonGia)
VALUES  ( 'SP05' ,'HD09' ,10,  12000000)
INSERT INTO dbo.ChiTietHoaDon
        ( MaSP , MaHD ,SoLuong , DonGia)
VALUES  ( 'SP01' ,'HD10' ,10,  10000000)
INSERT INTO dbo.ChiTietHoaDon
        ( MaSP , MaHD ,SoLuong , DonGia)
VALUES  ( 'SP02' ,'HD01' ,10,  15000000)