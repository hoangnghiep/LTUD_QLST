USE [master]
GO
/****** Object:  Database [QUANLYSIEUTHI]    Script Date: 05/06/2018 10:04:21 CH ******/
CREATE DATABASE [QUANLYSIEUTHI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYSIEUTHI', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QUANLYSIEUTHI.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QUANLYSIEUTHI_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QUANLYSIEUTHI_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QUANLYSIEUTHI] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYSIEUTHI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYSIEUTHI] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYSIEUTHI] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET QUERY_STORE = OFF
GO
USE [QUANLYSIEUTHI]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [QUANLYSIEUTHI]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 05/06/2018 10:04:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_HoaDon] [int] NOT NULL,
	[ID_SanPham] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_KH] [int] NOT NULL,
	[ID_NV] [int] NOT NULL,
	[NgayLap] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTenKH] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](4) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SDT] [varchar](12) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[GioiTinhNV] [nvarchar](4) NOT NULL,
	[DiaChiNV] [nvarchar](100) NOT NULL,
	[SDT] [varchar](12) NOT NULL,
	[NgaySinh] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[GiaSP] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([ID], [HoTenKH], [GioiTinh], [DiaChi], [SDT]) VALUES (1, N'Trần Văn Minh', N'Nam', N'Quy Nhơn', N'0988456982')
INSERT [dbo].[KhachHang] ([ID], [HoTenKH], [GioiTinh], [DiaChi], [SDT]) VALUES (2, N'Nguyễn Công Phượng', N'Nam', N'Hà Nội', N'01258793425')
INSERT [dbo].[KhachHang] ([ID], [HoTenKH], [GioiTinh], [DiaChi], [SDT]) VALUES (3, N'Võ Thị Quỳnh', N'Nữ', N'Nha Trang', N'09763286459')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([ID], [TenNV], [GioiTinhNV], [DiaChiNV], [SDT], [NgaySinh]) VALUES (4, N'Hoàng Văn Nghiệp', N'Nam', N'Đăk Lăk', N'19008788', CAST(N'1997-11-27' AS Date))
INSERT [dbo].[NhanVien] ([ID], [TenNV], [GioiTinhNV], [DiaChiNV], [SDT], [NgaySinh]) VALUES (5, N'Phạm Minh Nhàn Phamk', N'Nữ', N'Bình Phước', N'19008197', CAST(N'2018-02-13' AS Date))
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([ID], [MaSP], [TenSP], [GiaSP], [SoLuong]) VALUES (1, N'SP01', N'Apple iPad 2018 Wi-Fi 32GB', 8689000, 10)
INSERT [dbo].[SanPham] ([ID], [MaSP], [TenSP], [GiaSP], [SoLuong]) VALUES (2, N'SP02', N'Apple iPhone 8 Plus Red
', 23990000, 15)
INSERT [dbo].[SanPham] ([ID], [MaSP], [TenSP], [GiaSP], [SoLuong]) VALUES (3, N'SP03', N'Apple iPhone X 64GB Silver', 25870000, 21)
INSERT [dbo].[SanPham] ([ID], [MaSP], [TenSP], [GiaSP], [SoLuong]) VALUES (4, N'SP04', N'Apple MacBook Pro', 29750000, 12)
INSERT [dbo].[SanPham] ([ID], [MaSP], [TenSP], [GiaSP], [SoLuong]) VALUES (5, N'SP05', N'Camera hành động chống nước', 259000, 18)
INSERT [dbo].[SanPham] ([ID], [MaSP], [TenSP], [GiaSP], [SoLuong]) VALUES (6, N'SP06', N'Máy ảnh KTS Sony', 3299000, 11)
INSERT [dbo].[SanPham] ([ID], [MaSP], [TenSP], [GiaSP], [SoLuong]) VALUES (7, N'SP07', N'Tai nghe Tàng Hình Bluetooth', 175000, 28)
INSERT [dbo].[SanPham] ([ID], [MaSP], [TenSP], [GiaSP], [SoLuong]) VALUES (8, N'SP08', N'Tai Nghe Bluetooth V9 4.0', 170000, 14)
INSERT [dbo].[SanPham] ([ID], [MaSP], [TenSP], [GiaSP], [SoLuong]) VALUES (9, N'SP09', N'Micro Karaoke tích hợp Loa Bluetooth', 99000, 22)
INSERT [dbo].[SanPham] ([ID], [MaSP], [TenSP], [GiaSP], [SoLuong]) VALUES (11, N'SP10', N'Chinh Chủ', 199000, 20)
INSERT [dbo].[SanPham] ([ID], [MaSP], [TenSP], [GiaSP], [SoLuong]) VALUES (12, N'SP11', N'Người yêu', 999999, 1)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([ID_HoaDon])
REFERENCES [dbo].[HoaDon] ([ID])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([ID_SanPham])
REFERENCES [dbo].[SanPham] ([ID])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([ID_KH])
REFERENCES [dbo].[KhachHang] ([ID])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([ID_NV])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[SP_ChiTietHoaDon_Add]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Thêm Chi tiết hóa đơn
CREATE PROCEDURE [dbo].[SP_ChiTietHoaDon_Add]
	(@id_hoadon int, @id_sanpham int, @soluong int)
AS
BEGIN
	INSERT INTO ChiTietHoaDon(ID_HoaDon,ID_SanPham,SoLuong) VALUES (@id_hoadon,@id_sanpham,@soluong)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ChiTietHoaDon_Delete]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Xóa Chi Tiet hoa don
CREATE PROCEDURE [dbo].[SP_ChiTietHoaDon_Delete]
	(@id int)
AS
BEGIN
	DELETE ChiTietHoaDon  WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ChiTietHoaDon_GetAllTable]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Tạo store cho database
-- =============================================
--Table ChiTietHoaDon
--Lấy tất cả dữ liệu
CREATE PROCEDURE [dbo].[SP_ChiTietHoaDon_GetAllTable]
AS
BEGIN
	SELECT * FROM ChiTietHoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ChiTietHoaDon_GetByID]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Lấy một dữ liệu theo id
CREATE PROCEDURE [dbo].[SP_ChiTietHoaDon_GetByID]
	(@id int)
AS
BEGIN
	SELECT * FROM ChiTietHoaDon WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ChiTietHoaDon_Update]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Sửa Chi Tiet hoa don
CREATE PROCEDURE [dbo].[SP_ChiTietHoaDon_Update]
	(@id int, @id_hoadon int, @id_sanpham int, @soluong int)
AS
BEGIN
	UPDATE ChiTietHoaDon SET ID_HoaDon = @id_hoadon, ID_SanPham = @id_sanpham, SoLuong = @soluong WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_HoaDon_Add]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Thêm Hóa đơn
CREATE PROCEDURE [dbo].[SP_HoaDon_Add]
	(@id_kh int, @id_nv int, @ngaylap date)
AS
BEGIN
	INSERT INTO HoaDon(ID_KH,ID_NV,NgayLap) VALUES (@id_kh,@id_nv,@ngaylap)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_HoaDon_Delete]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Xóa Hoa don
CREATE PROCEDURE [dbo].[SP_HoaDon_Delete]
	(@id int)
AS
BEGIN
	DELETE HoaDon  WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_HoaDon_GetAllTable]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
--Table HoaDon
--Lấy tất cả dữ liệu
CREATE PROCEDURE [dbo].[SP_HoaDon_GetAllTable]
AS
BEGIN
	SELECT * FROM HoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[SP_HoaDon_GetByID]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Lấy một dữ liệu theo id
CREATE PROCEDURE [dbo].[SP_HoaDon_GetByID]
	(@id int)
AS
BEGIN
	SELECT * FROM HoaDon WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_HoaDon_Update]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Sửa Hoa don
CREATE PROCEDURE [dbo].[SP_HoaDon_Update]
	(@id int, @id_kh int, @id_nv int, @ngaylap date)
AS
BEGIN
	UPDATE HoaDon SET ID_KH = @id_kh, ID_NV = @id_nv, NgayLap = @ngaylap WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_KhachHang_Add]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Thêm Khách hàng
CREATE PROCEDURE [dbo].[SP_KhachHang_Add]
	(@hoten nvarchar(50), @gioitinh nvarchar(4), @diachi nvarchar(100), @sdt varchar(12))
AS
BEGIN
	INSERT INTO KhachHang(HoTenKH,GioiTinh,DiaChi,SDT) VALUES (@hoten, @gioitinh, @diachi, @sdt)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_KhachHang_Delete]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Xóa Khách hàng
CREATE PROCEDURE [dbo].[SP_KhachHang_Delete]
	(@id int)
AS
BEGIN
	DELETE KhachHang  WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_KhachHang_GetAllTable]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
--Table KhachHang
--Lấy tất cả dữ liệu
CREATE PROCEDURE [dbo].[SP_KhachHang_GetAllTable]
AS
BEGIN
	SELECT * FROM KhachHang
END
GO
/****** Object:  StoredProcedure [dbo].[SP_KhachHang_GetByID]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Lấy một dữ liệu theo id
CREATE PROCEDURE [dbo].[SP_KhachHang_GetByID]
	(@id int)
AS
BEGIN
	SELECT * FROM KhachHang WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_KhachHang_Update]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Sửa Khách hàng
CREATE PROCEDURE [dbo].[SP_KhachHang_Update]
	(@id int, @hoten nvarchar(50), @gioitinh nvarchar(4), @diachi nvarchar(100), @sdt varchar(12))
AS
BEGIN
	UPDATE KhachHang SET HoTenKH = @hoten, GioiTinh = @gioitinh, DiaChi = @diachi, SDT = @sdt WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_NhanVien_Add]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Thêm Nhân viên
CREATE PROCEDURE [dbo].[SP_NhanVien_Add]
	(@hoten nvarchar(50), @gioitinh nvarchar(4), @diachi nvarchar(100), @sdt varchar(12), @ngaysinh date)
AS
BEGIN
	INSERT INTO NhanVien(TenNV,GioiTinhNV,DiaChiNV,SDT,NgaySinh) VALUES (@hoten, @gioitinh, @diachi, @sdt, @ngaysinh)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_NhanVien_Delete]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Xóa Nhân viên
CREATE PROCEDURE [dbo].[SP_NhanVien_Delete]
	(@id int)
AS
BEGIN
	DELETE NhanVien WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_NhanVien_GetAllTable]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
--Table NhanVien
--Lấy tất cả dữ liệu
CREATE PROCEDURE [dbo].[SP_NhanVien_GetAllTable]
AS
BEGIN
	SELECT * FROM NhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[SP_NhanVien_GetByID]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Lấy một dữ liệu theo id
CREATE PROCEDURE [dbo].[SP_NhanVien_GetByID]
	(@id int)
AS
BEGIN
	SELECT * FROM NhanVien WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_NhanVien_Update]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Sửa Nhân viên
CREATE PROCEDURE [dbo].[SP_NhanVien_Update]
	(@id int, @hoten nvarchar(50), @gioitinh nvarchar(4), @diachi nvarchar(100), @sdt varchar(12), @ngaysinh date)
AS
BEGIN
	UPDATE NhanVien SET TenNV = @hoten, GioiTinhNV = @gioitinh, DiaChiNV = @diachi, SDT = @sdt, NgaySinh = @ngaysinh WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SanPham_Add]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Thêm Sản phẩm
CREATE PROCEDURE [dbo].[SP_SanPham_Add]
	(@masp varchar(10), @tensp nvarchar(50), @giasp int, @soluong int)
AS
BEGIN
	INSERT INTO SanPham(MaSP,TenSP,GiaSP,SoLuong) VALUES (@masp, @tensp, @giasp, @soluong)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SanPham_Delete]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Xóa Sản phẩm
CREATE PROCEDURE [dbo].[SP_SanPham_Delete]
	(@id int)
AS
BEGIN
	DELETE SanPham WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SanPham_GetAllTable]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SanPham_GetAllTable]
AS
BEGIN
	SELECT * FROM SanPham
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SanPham_GetByID]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SanPham_GetByID]
	(@id int)
AS
BEGIN
	SELECT * FROM SanPham WHERE ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SanPham_Update]    Script Date: 05/06/2018 10:04:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Sửa Sản phẩm
CREATE PROCEDURE [dbo].[SP_SanPham_Update]
	(@id int, @masp varchar(10), @tensp nvarchar(50), @giasp int, @soluong int)
AS
BEGIN
	UPDATE SanPham SET MaSP = @masp, TenSP = @tensp, GiaSP = @giasp, SoLuong = @soluong WHERE ID = @id
END
GO
USE [master]
GO
ALTER DATABASE [QUANLYSIEUTHI] SET  READ_WRITE 
GO
