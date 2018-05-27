-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE DATABASE QUANLYSIEUTHI
GO
USE QUANLYSIEUTHI
GO

--1 Bảng Sản phẩm
CREATE TABLE SanPham (
	ID INT PRIMARY KEY NOT NULL IDENTITY,
	MaSP VARCHAR(10) NOT NULL,
	TenSP NVARCHAR(50) NOT NULL,
	GiaSP INT NOT NULL,
	SoLuong INT NOT NULL,
)
GO

--2 Bảng chi tiết hóa đơn
CREATE TABLE ChiTietHoaDon (
	ID INT PRIMARY KEY NOT NULL IDENTITY,
	ID_HoaDon INT NOT NULL,
	ID_SanPham INT NOT NULL,
	SoLuong INT NOT NULL,
)
GO

--3 Bảng hóa đơn
CREATE TABLE HoaDon (
	ID INT PRIMARY KEY NOT NULL IDENTITY,
	ID_KH INT NOT NULL,
	ID_NV INT NOT NULL,
	NgayLap DATE
)
GO

--4 Bảng khách hàng
CREATE TABLE KhachHang (
	ID INT PRIMARY KEY NOT NULL IDENTITY,
	HoTenKH NVARCHAR(50) NOT NULL,
	GioiTinh NVARCHAR(4) NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	SDT VARCHAR(12) NOT NULL
)
GO

--5 Bảng Nhân viên
CREATE TABLE NhanVien (
	ID INT PRIMARY KEY NOT NULL IDENTITY,
	TenNV NVARCHAR(50) NOT NULL,
	GioiTinhNV NVARCHAR(4) NOT NULL,
	DiaChiNV NVARCHAR(100) NOT NULL,
	SDT VARCHAR(12) NOT NULL,
	NgaySinh DATE
)
GO

-- Tạo khóa ngoại
ALTER TABLE ChiTietHoaDon
ADD CONSTRAINT FK_ChiTietHoaDon_HoaDon FOREIGN KEY (ID_HoaDon) REFERENCES HoaDon(ID)
GO

ALTER TABLE ChiTietHoaDon
ADD CONSTRAINT FK_ChiTietHoaDon_SanPham FOREIGN KEY (ID_SanPham) REFERENCES SanPham(ID)
GO
ALTER TABLE HoaDon
ADD CONSTRAINT FK_HoaDon_KhachHang FOREIGN KEY (ID_KH) REFERENCES KhachHang(ID)
GO
ALTER TABLE HoaDon
ADD CONSTRAINT FK_HoaDon_NhanVien FOREIGN KEY (ID_NV) REFERENCES NhanVien(ID)
GO

-- =============================================
-- Tạo store cho database
-- =============================================
--Table ChiTietHoaDon
--Lấy tất cả dữ liệu
CREATE PROCEDURE SP_ChiTietHoaDon_GetAllTable
AS
BEGIN
	SELECT * FROM ChiTietHoaDon
END
GO

--Lấy một dữ liệu theo id
CREATE PROCEDURE SP_ChiTietHoaDon_GetByID
	(@id int)
AS
BEGIN
	SELECT * FROM ChiTietHoaDon WHERE ID = @id
END
GO

--Thêm Chi tiết hóa đơn
CREATE PROCEDURE SP_ChiTietHoaDon_Add
	(@id_hoadon int, @id_sanpham int, @soluong int)
AS
BEGIN
	INSERT INTO ChiTietHoaDon(ID_HoaDon,ID_SanPham,SoLuong) VALUES (@id_hoadon,@id_sanpham,@soluong)
END
GO

--Sửa Chi Tiet hoa don
CREATE PROCEDURE SP_ChiTietHoaDon_Update
	(@id int, @id_hoadon int, @id_sanpham int, @soluong int)
AS
BEGIN
	UPDATE ChiTietHoaDon SET ID_HoaDon = @id_hoadon, ID_SanPham = @id_sanpham, SoLuong = @soluong WHERE ID = @id
END
GO

--Xóa Chi Tiet hoa don
CREATE PROCEDURE SP_ChiTietHoaDon_Delete
	(@id int)
AS
BEGIN
	DELETE ChiTietHoaDon  WHERE ID = @id
END
GO

-- =============================================
--Table HoaDon
--Lấy tất cả dữ liệu
CREATE PROCEDURE SP_HoaDon_GetAllTable
AS
BEGIN
	SELECT * FROM HoaDon
END
GO

--Lấy một dữ liệu theo id
CREATE PROCEDURE SP_HoaDon_GetByID
	(@id int)
AS
BEGIN
	SELECT * FROM HoaDon WHERE ID = @id
END
GO

--Thêm Hóa đơn
CREATE PROCEDURE SP_HoaDon_Add
	(@id_kh int, @id_nv int, @ngaylap date)
AS
BEGIN
	INSERT INTO HoaDon(ID_KH,ID_NV,NgayLap) VALUES (@id_kh,@id_nv,@ngaylap)
END
GO

--Sửa Hoa don
CREATE PROCEDURE SP_HoaDon_Update
	(@id int, @id_kh int, @id_nv int, @ngaylap date)
AS
BEGIN
	UPDATE HoaDon SET ID_KH = @id_kh, ID_NV = @id_nv, NgayLap = @ngaylap WHERE ID = @id
END
GO

--Xóa Hoa don
CREATE PROCEDURE SP_HoaDon_Delete
	(@id int)
AS
BEGIN
	DELETE HoaDon  WHERE ID = @id
END
GO


-- =============================================
--Table KhachHang
--Lấy tất cả dữ liệu
CREATE PROCEDURE SP_KhachHang_GetAllTable
AS
BEGIN
	SELECT * FROM KhachHang
END
GO

--Lấy một dữ liệu theo id
CREATE PROCEDURE SP_KhachHang_GetByID
	(@id int)
AS
BEGIN
	SELECT * FROM KhachHang WHERE ID = @id
END
GO

--Thêm Khách hàng
CREATE PROCEDURE SP_KhachHang_Add
	(@hoten nvarchar(50), @gioitinh nvarchar(4), @diachi nvarchar(100), @sdt varchar(12))
AS
BEGIN
	INSERT INTO KhachHang(HoTenKH,GioiTinh,DiaChi,SDT) VALUES (@hoten, @gioitinh, @diachi, @sdt)
END
GO

--Sửa Khách hàng
CREATE PROCEDURE SP_KhachHang_Update
	(@id int, @hoten nvarchar(50), @gioitinh nvarchar(4), @diachi nvarchar(100), @sdt varchar(12))
AS
BEGIN
	UPDATE KhachHang SET HoTenKH = @hoten, GioiTinh = @gioitinh, DiaChi = @diachi, SDT = @sdt WHERE ID = @id
END
GO

--Xóa Khách hàng
CREATE PROCEDURE SP_KhachHang_Delete
	(@id int)
AS
BEGIN
	DELETE KhachHang  WHERE ID = @id
END
GO


-- =============================================
--Table NhanVien
--Lấy tất cả dữ liệu
CREATE PROCEDURE SP_NhanVien_GetAllTable
AS
BEGIN
	SELECT * FROM NhanVien
END
GO

--Lấy một dữ liệu theo id
CREATE PROCEDURE SP_NhanVien_GetByID
	(@id int)
AS
BEGIN
	SELECT * FROM NhanVien WHERE ID = @id
END
GO

--Thêm Nhân viên
CREATE PROCEDURE SP_NhanVien_Add
	(@hoten nvarchar(50), @gioitinh nvarchar(4), @diachi nvarchar(100), @sdt varchar(12), @ngaysinh date)
AS
BEGIN
	INSERT INTO NhanVien(TenNV,GioiTinhNV,DiaChiNV,SDT,NgaySinh) VALUES (@hoten, @gioitinh, @diachi, @sdt, @ngaysinh)
END
GO

--Sửa Nhân viên
CREATE PROCEDURE SP_NhanVien_Update
	(@id int, @hoten nvarchar(50), @gioitinh nvarchar(4), @diachi nvarchar(100), @sdt varchar(12), @ngaysinh date)
AS
BEGIN
	UPDATE NhanVien SET TenNV = @hoten, GioiTinhNV = @gioitinh, DiaChiNV = @diachi, SDT = @sdt, NgaySinh = @ngaysinh WHERE ID = @id
END
GO

--Xóa Nhân viên
CREATE PROCEDURE SP_NhanVien_Delete
	(@id int)
AS
BEGIN
	DELETE NhanVien WHERE ID = @id
END
GO


-- =============================================
--Table SanPham
--Lấy tất cả dữ liệu
CREATE PROCEDURE SP_SanPham_GetAllTable
AS
BEGIN
	SELECT MaSP,TenSP, GiaSP, SoLuong FROM SanPham
END
GO
--drop proc SP_SanPham_GetAllTable

--Lấy một dữ liệu theo id
CREATE PROCEDURE SP_SanPham_GetByID
	(@id int)
AS
BEGIN
	SELECT MaSP,TenSP, GiaSP, SoLuong FROM SanPham WHERE ID = @id
END
GO

--Thêm Sản phẩm
CREATE PROCEDURE SP_SanPham_Add
	(@masp varchar(10), @tensp nvarchar(50), @giasp int, @soluong int)
AS
BEGIN
	INSERT INTO SanPham(MaSP,TenSP,GiaSP,SoLuong) VALUES (@masp, @tensp, @giasp, @soluong)
END
GO

--Sửa Sản phẩm
CREATE PROCEDURE SP_SanPham_Update
	(@id int, @masp varchar(10), @tensp nvarchar(50), @giasp int, @soluong int)
AS
BEGIN
	UPDATE SanPham SET MaSP = @masp, TenSP = @tensp, GiaSP = @giasp, SoLuong = @soluong WHERE ID = @id
END
GO

--Xóa Sản phẩm
CREATE PROCEDURE SP_SanPham_Delete
	(@id int)
AS
BEGIN
	DELETE SanPham WHERE ID = @id
END
GO