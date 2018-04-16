
CREATE TABLE NguoiDung
(
	TaiKhoan VARCHAR(50),
	MatKhau VARCHAR(50),
	PhanQuyen int
)

INSERT dbo.NguoiDung
        ( TaiKhoan, MatKhau, PhanQuyen )
VALUES  ( 'admin', -- TaiKhoan - varchar(50)
          'admin', -- MatKhau - varchar(50)
          1  -- PhanQuyen - int
          )

INSERT dbo.NguoiDung
        ( TaiKhoan, MatKhau, PhanQuyen )
VALUES  ( 'minh', -- TaiKhoan - varchar(50)
          '123', -- MatKhau - varchar(50)
          0  -- PhanQuyen - int
          )
CREATE PROC DangNhap(@TaiKhoan varCHAR(50),@MatKhau varCHAR(50))
AS
BEGIN
SELECT * FROM dbo.NguoiDung WHERE TaiKhoan=@TaiKhoan AND MatKhau=@MatKhau
END
GO