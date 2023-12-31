USE [master]
GO
/****** Object:  Database [HOSPITAL]    Script Date: 7/10/2023 1:40:36 PM ******/
CREATE DATABASE [HOSPITAL]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HOSPITAL', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SERVER0\MSSQL\DATA\HOSPITAL.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HOSPITAL_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SERVER0\MSSQL\DATA\HOSPITAL_log.ldf' , SIZE = 1600KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HOSPITAL] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HOSPITAL].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HOSPITAL] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HOSPITAL] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HOSPITAL] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HOSPITAL] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HOSPITAL] SET ARITHABORT OFF 
GO
ALTER DATABASE [HOSPITAL] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HOSPITAL] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HOSPITAL] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HOSPITAL] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HOSPITAL] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HOSPITAL] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HOSPITAL] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HOSPITAL] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HOSPITAL] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HOSPITAL] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HOSPITAL] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HOSPITAL] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HOSPITAL] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HOSPITAL] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HOSPITAL] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HOSPITAL] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HOSPITAL] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HOSPITAL] SET RECOVERY FULL 
GO
ALTER DATABASE [HOSPITAL] SET  MULTI_USER 
GO
ALTER DATABASE [HOSPITAL] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HOSPITAL] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HOSPITAL] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HOSPITAL] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [HOSPITAL] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'HOSPITAL', N'ON'
GO
USE [HOSPITAL]
GO
/****** Object:  User [vanan]    Script Date: 7/10/2023 1:40:36 PM ******/
CREATE USER [vanan] FOR LOGIN [Admin_Hospital_Login] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [NV018]    Script Date: 7/10/2023 1:40:36 PM ******/
CREATE USER [NV018] FOR LOGIN [ytatruong1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [NV012]    Script Date: 7/10/2023 1:40:36 PM ******/
CREATE USER [NV012] FOR LOGIN [yta2] WITH DEFAULT_SCHEMA=[NV012]
GO
/****** Object:  User [NV011]    Script Date: 7/10/2023 1:40:36 PM ******/
CREATE USER [NV011] FOR LOGIN [bacsi2] WITH DEFAULT_SCHEMA=[NV011]
GO
/****** Object:  User [NV010]    Script Date: 7/10/2023 1:40:36 PM ******/
CREATE USER [NV010] FOR LOGIN [yta1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [NV009]    Script Date: 7/10/2023 1:40:36 PM ******/
CREATE USER [NV009] FOR LOGIN [admin1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [NV007]    Script Date: 7/10/2023 1:40:36 PM ******/
CREATE USER [NV007] FOR LOGIN [admin2] WITH DEFAULT_SCHEMA=[NV007]
GO
/****** Object:  User [NV005]    Script Date: 7/10/2023 1:40:36 PM ******/
CREATE USER [NV005] FOR LOGIN [bacsi1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [NV003]    Script Date: 7/10/2023 1:40:36 PM ******/
CREATE USER [NV003] FOR LOGIN [LVC] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [NV002]    Script Date: 7/10/2023 1:40:36 PM ******/
CREATE USER [NV002] FOR LOGIN [TTB] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [Nurse_Role]    Script Date: 7/10/2023 1:40:36 PM ******/
CREATE ROLE [Nurse_Role]
GO
/****** Object:  DatabaseRole [Head_Nurse_Role]    Script Date: 7/10/2023 1:40:36 PM ******/
CREATE ROLE [Head_Nurse_Role]
GO
/****** Object:  DatabaseRole [Doctor_Role]    Script Date: 7/10/2023 1:40:36 PM ******/
CREATE ROLE [Doctor_Role]
GO
/****** Object:  DatabaseRole [Admin_Hospital_Role]    Script Date: 7/10/2023 1:40:36 PM ******/
CREATE ROLE [Admin_Hospital_Role]
GO
ALTER ROLE [Admin_Hospital_Role] ADD MEMBER [vanan]
GO
ALTER ROLE [db_owner] ADD MEMBER [vanan]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [vanan]
GO
ALTER ROLE [Head_Nurse_Role] ADD MEMBER [NV018]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [NV018]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [NV018]
GO
ALTER ROLE [db_datareader] ADD MEMBER [NV018]
GO
ALTER ROLE [Nurse_Role] ADD MEMBER [NV012]
GO
ALTER ROLE [Doctor_Role] ADD MEMBER [NV011]
GO
ALTER ROLE [db_datareader] ADD MEMBER [NV011]
GO
ALTER ROLE [Nurse_Role] ADD MEMBER [NV010]
GO
ALTER ROLE [Admin_Hospital_Role] ADD MEMBER [NV009]
GO
ALTER ROLE [db_owner] ADD MEMBER [NV009]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [NV009]
GO
ALTER ROLE [Admin_Hospital_Role] ADD MEMBER [NV007]
GO
ALTER ROLE [db_owner] ADD MEMBER [NV007]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [NV007]
GO
ALTER ROLE [Doctor_Role] ADD MEMBER [NV005]
GO
ALTER ROLE [db_datareader] ADD MEMBER [NV005]
GO
ALTER ROLE [Doctor_Role] ADD MEMBER [NV003]
GO
ALTER ROLE [db_datareader] ADD MEMBER [NV003]
GO
ALTER ROLE [Nurse_Role] ADD MEMBER [NV002]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [Head_Nurse_Role]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [Head_Nurse_Role]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Head_Nurse_Role]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Doctor_Role]
GO
ALTER ROLE [db_owner] ADD MEMBER [Admin_Hospital_Role]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [Admin_Hospital_Role]
GO
/****** Object:  Schema [NV007]    Script Date: 7/10/2023 1:40:36 PM ******/
CREATE SCHEMA [NV007]
GO
/****** Object:  Schema [NV011]    Script Date: 7/10/2023 1:40:36 PM ******/
CREATE SCHEMA [NV011]
GO
/****** Object:  Schema [NV012]    Script Date: 7/10/2023 1:40:36 PM ******/
CREATE SCHEMA [NV012]
GO
/****** Object:  UserDefinedFunction [dbo].[CalculateTotalAmount]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[CalculateTotalAmount](@MaBN VARCHAR(50))
RETURNS DECIMAL(18, 0)
AS
BEGIN
  DECLARE @TotalAmount DECIMAL(18, 0);

  SELECT @TotalAmount = SUM(sdvt.[Số lượng] * vt.DonGia)
  FROM vw_SDVT_All sdvt
  INNER JOIN VatTu vt ON vt.MaVT = sdvt.[Mã Vật Tư]
  WHERE sdvt.[Mã Bệnh Nhân] = @MaBN;

  RETURN @TotalAmount;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GetSoLuongBacSi]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetSoLuongBacSi]()
RETURNS INT
AS
BEGIN
    DECLARE @SoLuong INT;
    
    SELECT @SoLuong = COUNT(*)
    FROM vw_ThongTinBacSi
    
    RETURN @SoLuong;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GetSoLuongBenhNhan]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetSoLuongBenhNhan]()
RETURNS INT
AS
BEGIN
    DECLARE @SoLuong INT;
    
    SELECT @SoLuong = COUNT(*)
    FROM vw_ThongTinBenhNhanDangDieuTri
    
    RETURN @SoLuong;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GetSoLuongBenhNhanNgoaiTru]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetSoLuongBenhNhanNgoaiTru]()
RETURNS INT
AS
BEGIN
    DECLARE @SoLuong INT;
    
    SELECT @SoLuong = COUNT(*)
    FROM vw_ThongTinBenhNhanNgoaiTru
    
    RETURN @SoLuong;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GetSoLuongBenhNhanNoiTru]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetSoLuongBenhNhanNoiTru]()
RETURNS INT
AS
BEGIN
    DECLARE @SoLuong INT;
    
    SELECT @SoLuong = COUNT(*)
    FROM vw_ThongTinBenhNhanNoiTru
    
    RETURN @SoLuong;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GetSoLuongGiuong]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetSoLuongGiuong]()
RETURNS INT
AS
BEGIN
    DECLARE @SoLuong INT;
    
    SELECT @SoLuong = COUNT(*)
    FROM vw_Giuong
    
    RETURN @SoLuong;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GetSoLuongKhuChuaTri]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetSoLuongKhuChuaTri]()
RETURNS INT
AS
BEGIN
    DECLARE @SoLuong INT;
    
    SELECT @SoLuong = COUNT(*)
    FROM vw_ThongTinKhuChuaTri
    
    RETURN @SoLuong;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GetSoLuongNhanVien]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetSoLuongNhanVien]()
RETURNS INT
AS
BEGIN
    DECLARE @SoLuong INT;
    
    SELECT @SoLuong = COUNT(*)
    FROM vw_ThongTinNhanVien
    
    RETURN @SoLuong;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GetSoLuongPhong]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetSoLuongPhong]()
RETURNS INT
AS
BEGIN
    DECLARE @SoLuong INT;
    
    SELECT @SoLuong = COUNT(*)
    FROM vw_Phong_ConHoatDong
    
    RETURN @SoLuong;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GetSoLuongSuChuaTri]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetSoLuongSuChuaTri]()
RETURNS INT
AS
BEGIN
    DECLARE @SoLuong INT;
    
    SELECT @SoLuong = COUNT(*)
    FROM vw_SuChuaTri
    
    RETURN @SoLuong;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GetSoLuongVatTu]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetSoLuongVatTu]()
RETURNS INT
AS
BEGIN
    DECLARE @SoLuong INT;
    
    SELECT @SoLuong = COUNT(*)
    FROM vw_VatTuDangDuocSuDung
    RETURN @SoLuong;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GetSoLuongYTa]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetSoLuongYTa]()
RETURNS INT
AS
BEGIN
    DECLARE @SoLuong INT;
    
    SELECT @SoLuong = COUNT(*)
    FROM vw_ThongTinYTa
    
    RETURN @SoLuong;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GetUserRole]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetUserRole]()
RETURNS NVARCHAR(50)
AS
BEGIN
    DECLARE @UserRole NVARCHAR(50)
    
    IF IS_ROLEMEMBER('Admin_Hospital_Role', USER_NAME()) = 1
    BEGIN
        SET @UserRole = 'Admin_Hospital_Role';
    END
    ELSE IF IS_ROLEMEMBER('Doctor_Role', USER_NAME()) = 1
    BEGIN
        SET @UserRole = 'Doctor_Role';
    END
    ELSE IF IS_ROLEMEMBER('Nurse_Role', USER_NAME()) = 1
    BEGIN
        SET @UserRole = 'Nurse_Role';
    END
	ELSE IF IS_ROLEMEMBER('Head_Nurse_Role', USER_NAME()) = 1
    BEGIN
        SET @UserRole = 'Head_Nurse_Role';
    END
    ELSE
    BEGIN
        SET @UserRole = 'Unknown';
    END
    
    RETURN @UserRole;
END
GO
/****** Object:  UserDefinedFunction [dbo].[TongTienSDVT]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[TongTienSDVT]()
RETURNS DECIMAL(18, 0)
AS
BEGIN
    DECLARE @TotalAmount DECIMAL(18, 0);

    SELECT @TotalAmount = SUM(sdvt.[Số lượng] * vt.DonGia)
    FROM vw_SDVT_All sdvt
    INNER JOIN VatTu vt ON vt.MaVT = sdvt.[Mã Vật Tư];

    RETURN @TotalAmount;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[TongTienSDVT_BNddt]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[TongTienSDVT_BNddt]()
RETURNS DECIMAL(18, 0)
AS
BEGIN
    DECLARE @TotalAmount DECIMAL(18, 0);

    SELECT @TotalAmount = SUM(sdvt.[Số lượng] * vt.DonGia)
    FROM vw_SDVT_All sdvt
    INNER JOIN VatTu vt ON vt.MaVT = sdvt.[Mã Vật Tư]
	WHERE sdvt.[Trạng thái điều trị] = N'Đang điều trị';

    RETURN @TotalAmount;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[TongTienSDVT_BNdxv]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[TongTienSDVT_BNdxv]()
RETURNS DECIMAL(18, 0)
AS
BEGIN
    DECLARE @TotalAmount DECIMAL(18, 0);

    SELECT @TotalAmount = SUM(sdvt.[Số lượng] * vt.DonGia)
    FROM vw_SDVT_All sdvt
    INNER JOIN VatTu vt ON vt.MaVT = sdvt.[Mã Vật Tư]
	WHERE sdvt.[Trạng thái điều trị] = N'Đã xuất viện';

    RETURN @TotalAmount;
END;
GO
/****** Object:  Table [dbo].[BacSi]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BacSi](
	[MaBSi] [varchar](10) NOT NULL,
	[ChuyenMon] [nvarchar](30) NULL,
 CONSTRAINT [PK_BacSi] PRIMARY KEY CLUSTERED 
(
	[MaBSi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BenhNhan](
	[MaBN] [varchar](10) NOT NULL,
	[TenBN] [nvarchar](30) NULL,
	[NgSinh] [date] NULL,
	[MaBSiTheoDoi] [varchar](10) NULL,
	[MaBSiTiepNhan] [varchar](10) NULL,
	[HinhThucKham] [nvarchar](20) NOT NULL,
	[CCCD] [varchar](30) NULL,
	[TrangThai] [tinyint] NOT NULL CONSTRAINT [DF_BenhNhan_TrangThai]  DEFAULT ((1)),
 CONSTRAINT [pk_BenhNhan] PRIMARY KEY CLUSTERED 
(
	[MaBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BenhNhanNgoaiTru]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BenhNhanNgoaiTru](
	[MaBN] [varchar](10) NOT NULL,
	[MoTaBenh] [nvarchar](50) NULL,
 CONSTRAINT [pk_BenhNhanNgoaiTru] PRIMARY KEY CLUSTERED 
(
	[MaBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BenhNhanNoiTru]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BenhNhanNoiTru](
	[MaBN] [varchar](10) NOT NULL,
	[MoTaBenh] [nvarchar](50) NULL,
	[MaGiuong] [varchar](10) NULL,
 CONSTRAINT [pk_BenhNhanNoiTru] PRIMARY KEY CLUSTERED 
(
	[MaBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CuocDieuTri]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CuocDieuTri](
	[ID_CDT] [varchar](10) NOT NULL,
	[MaBSi] [varchar](10) NULL,
	[MaBN] [varchar](10) NULL,
	[MaCT] [varchar](20) NULL,
	[ThGian] [int] NULL,
	[Ngay] [date] NULL,
	[KetQua] [nvarchar](100) NULL,
 CONSTRAINT [pk_CuocDieuTri] PRIMARY KEY CLUSTERED 
(
	[ID_CDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Giuong]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Giuong](
	[MaGiuong] [varchar](10) NOT NULL,
	[MaPhong] [varchar](10) NULL,
	[MaKhu] [varchar](10) NULL,
 CONSTRAINT [pk_Giuong] PRIMARY KEY CLUSTERED 
(
	[MaGiuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhuChuaTri]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhuChuaTri](
	[MaKhuCT] [varchar](10) NOT NULL,
	[TenKhuCT] [nvarchar](20) NOT NULL,
	[MaYTaTruong] [varchar](10) NULL,
	[TrangThaiKCT] [tinyint] NOT NULL DEFAULT ((1)),
 CONSTRAINT [pk_KhuChuaTri] PRIMARY KEY CLUSTERED 
(
	[MaKhuCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](30) NOT NULL,
	[ChucVu] [nvarchar](20) NOT NULL,
	[Phai] [nvarchar](5) NULL,
	[SDT] [varchar](30) NULL,
	[CCCD] [varchar](30) NULL,
	[isActive] [tinyint] NOT NULL DEFAULT ((1)),
 CONSTRAINT [pk_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [varchar](10) NOT NULL,
	[MaKhuCT] [varchar](10) NOT NULL,
	[TenPhong] [nvarchar](100) NULL,
	[TrangThaiP] [tinyint] NOT NULL DEFAULT ((1)),
 CONSTRAINT [pk_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SuChuaTri]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SuChuaTri](
	[MaCT] [varchar](20) NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[TrangThai] [tinyint] NOT NULL DEFAULT ((1)),
 CONSTRAINT [pk_SuChuaTri] PRIMARY KEY CLUSTERED 
(
	[MaCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SuDungVatTu]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SuDungVatTu](
	[ID_SDVT] [varchar](10) NOT NULL,
	[MaBN] [varchar](10) NULL,
	[MaVT] [varchar](10) NULL,
	[NgaySD] [date] NULL,
	[ThGian] [int] NULL,
	[SoLuong] [int] NULL,
	[TongTien] [decimal](18, 0) NULL,
 CONSTRAINT [pk_SuDungVatTu] PRIMARY KEY CLUSTERED 
(
	[ID_SDVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThongKeGioLam]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThongKeGioLam](
	[MaNV] [varchar](10) NOT NULL,
	[MaKhu] [varchar](10) NOT NULL,
	[SoGioLV] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VatTu]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VatTu](
	[MaVT] [varchar](10) NOT NULL,
	[DonGia] [int] NOT NULL,
	[DacTa] [nvarchar](50) NULL,
	[LoaiVT] [nvarchar](20) NULL,
	[TrangThaiVT] [tinyint] NOT NULL DEFAULT ((1)),
 CONSTRAINT [pk_VatTu] PRIMARY KEY CLUSTERED 
(
	[MaVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[YTa]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[YTa](
	[MaYTa] [varchar](10) NOT NULL,
	[ViTriCongViec] [nvarchar](30) NULL,
 CONSTRAINT [PK_YTa] PRIMARY KEY CLUSTERED 
(
	[MaYTa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[vw_ThongTinNhanVien]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_ThongTinNhanVien]
as
	select nv.MaNV as 'Mã Nhân Viên', nv.TenNV as 'Họ tên' , nv.ChucVu as 'Chức vụ' , nv.Phai as 'Phái', nv.SDT, nv.CCCD
	from NhanVien nv
	where nv.isActive = 1

GO
/****** Object:  View [dbo].[vw_ThongTinYTa]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_ThongTinYTa]
as
	select v_ttnv.[Mã Nhân Viên] as 'Mã Y Tá', v_ttnv.[Họ tên] as 'Tên Y Tá',v_ttnv.[Chức vụ], v_ttnv.[Phái],
			 v_ttnv.SDT, v_ttnv.CCCD ,yt.ViTriCongViec as 'Vị trí công việc'
	from vw_ThongTinNhanVien v_ttnv
	left join YTa yt on v_ttnv.[Mã Nhân Viên] = yt.MaYTa
	where v_ttnv.[Chức vụ] = N'Y Tá' 

GO
/****** Object:  View [dbo].[vw_SDVT_All]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vw_SDVT_All]
AS
	SELECT sdvt.ID_SDVT, sdvt.MaBN as 'Mã Bệnh Nhân', bn.TenBN as 'Tên bệnh nhân' , sdvt.MaVT as 'Mã Vật Tư', vt.DacTa as 'Đặc tả vật tư',
		sdvt.NgaySD as 'Ngày sử dụng', sdvt.ThGian as 'Thời gian sử dụng', sdvt.SoLuong as 'Số lượng', sdvt.TongTien as 'Tổng tiền',
		CASE bn.TrangThai 
			when 1 then N'Đang điều trị'
			when 0 then N'Đã xuất viện'
		end as 'Trạng thái điều trị'
	FROM SuDungVatTu sdvt
	left join BenhNhan bn ON bn.MaBN = sdvt.MaBN
	left join VatTu vt ON vt.MaVT = sdvt.MaVT

GO
/****** Object:  UserDefinedFunction [dbo].[GetTongHopVienPhi]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetTongHopVienPhi]()
RETURNS TABLE
AS
RETURN (
    SELECT bn.[Mã Bệnh Nhân], bn.[Tên bệnh nhân], dbo.CalculateTotalAmount(bn.[Mã Bệnh Nhân]) AS 'Tổng tiền phải trả'
    FROM vw_SDVT_All bn
    GROUP BY bn.[Mã Bệnh Nhân], bn.[Tên bệnh nhân]
)
GO
/****** Object:  View [dbo].[vw_ThongTinBacSi]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_ThongTinBacSi]
as
	select v_ttnv.[Mã Nhân Viên] as 'Mã Bác Sĩ', v_ttnv.[Họ tên] as 'Tên Bác Sĩ',v_ttnv.[Chức vụ], v_ttnv.[Phái],
			 v_ttnv.SDT, v_ttnv.CCCD ,bs.ChuyenMon as 'Chuyên Môn'
	from vw_ThongTinNhanVien v_ttnv
	left join BacSi bs on bs.MaBSi = v_ttnv.[Mã Nhân Viên]
	where v_ttnv.[Chức vụ] = N'Bác Sĩ'

GO
/****** Object:  UserDefinedFunction [dbo].[GetThongTinSDVT]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetThongTinSDVT](@MaBN varchar(20))
RETURNS TABLE
AS
RETURN (
    SELECT sdvt.[Mã Vật Tư], sdvt.[Đặc tả vật tư] as 'Tên vật tư', sdvt.[Số lượng], vt.DonGia as 'Giá'
    FROM vw_SDVT_All sdvt
	INNER JOIN VatTu vt ON vt.MaVT = sdvt.[Mã Vật Tư]
    WHERE sdvt.[Mã Bệnh Nhân] = @MaBN
)

GO
/****** Object:  View [dbo].[vw_ThongTinBenhNhanDangDieuTri]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_ThongTinBenhNhanDangDieuTri]
AS
	SELECT bn.MaBN as 'Mã BN', bn.TenBN as 'Tên BN', bn.NgSinh as 'Ngày sinh', bn.MaBSiTheoDoi as 'Mã BSi Theo Dõi',
			bn.MaBSiTiepNhan as 'Mã BSi Tiếp Nhận', bn.HinhThucKham as 'Hình thức khám', bn.CCCD
	FROM BenhNhan bn
	WHERE TrangThai = 1

GO
/****** Object:  View [dbo].[vw_ThongTinBenhNhanNgoaiTru]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_ThongTinBenhNhanNgoaiTru]
AS
	SELECT bn.[Mã BN], bn.[Tên BN], bn.[Ngày sinh], bn.CCCD, bn.[Mã BSi Theo Dõi], 
	bn.[Mã BSi Tiếp Nhận], bnngoaitru.MoTaBenh as 'Mô tả bệnh'
	FROM vw_ThongTinBenhNhanDangDieuTri bn
	LEFT JOIN BenhNhanNgoaiTru bnngoaitru on bnngoaitru.MaBN = bn.[Mã BN]
	WHERE bn.[Hình thức khám] = N'Ngoại Trú'

GO
/****** Object:  View [dbo].[vw_ThongTinBenhNhanNoiTru]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_ThongTinBenhNhanNoiTru]
AS
	SELECT bn.[Mã BN], bn.[Tên BN], bn.[Ngày sinh], bn.CCCD, bn.[Mã BSi Theo Dõi], bn.[Mã BSi Tiếp Nhận], bnnoitru.MoTaBenh as 'Mô tả bệnh', bnnoitru.MaGiuong as 'Mã giường'
	FROM vw_ThongTinBenhNhanDangDieuTri bn
	LEFT JOIN BenhNhanNoiTru bnnoitru on bnnoitru.MaBN = bn.[Mã BN]
	WHERE bn.[Hình thức khám] = N'Nội Trú'

GO
/****** Object:  View [dbo].[vw_VatTuDangDuocSuDung]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_VatTuDangDuocSuDung]
AS
	SELECT MaVT as 'Mã Vật Tư', DacTa as 'Đặc tả vật tư', DonGia as 'Đơn giá', LoaiVT as 'Loại Vật Tư'
	FROM VatTu
	WHERE TrangThaiVT = 1

GO
/****** Object:  View [dbo].[vw_VatTu_DungCu]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_VatTu_DungCu]
AS
	SELECT *
	FROM vw_VatTuDangDuocSuDung vt
	WHERE vt.[Loại Vật Tư] = N'Dụng Cụ'

GO
/****** Object:  View [dbo].[vw_VatTu_ThuocMen]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----------------------
CREATE VIEW [dbo].[vw_VatTu_ThuocMen]
AS
	SELECT *
	FROM vw_VatTuDangDuocSuDung vt
	WHERE vt.[Loại Vật Tư] = N'Thuốc Men'

GO
/****** Object:  View [dbo].[vw_MaYTC]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_MaYTC]
as
	Select [Mã Y Tá], [Tên Y Tá] from vw_ThongTinYTa where [Vị trí công việc] = N'Y Tá Chính'

GO
/****** Object:  UserDefinedFunction [dbo].[GetThongTinBacSi]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetThongTinBacSi]()
RETURNS TABLE
AS
RETURN
(
    SELECT nv.MaNV AS 'Mã Bác Sĩ',
           nv.TenNV AS 'Tên Bác Sĩ',
           nv.Phai AS 'Phái',
           nv.SDT, 
           nv.CCCD,
           bs.ChuyenMon AS 'Chuyên Môn'
    FROM NhanVien nv
    LEFT JOIN BacSi bs ON bs.MaBSi =nv.MaNV
    WHERE nv.ChucVu = N'Bác Sĩ'
)
GO
/****** Object:  View [dbo].[vw_CuocDieuTri_All]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_CuocDieuTri_All]
AS
	SELECT cdt.ID_CDT, cdt.MaBSi as 'Mã bác sĩ', nv.TenNV as 'Tên Bác Sĩ', cdt.MaBN as 'Mã bệnh nhân', bn.TenBN as 'Tên bệnh nhân', 
	cdt.MaCT as 'Mã sự chữa trị', sct.Ten as 'Tên sự chữa trị', cdt.ThGian as 'Thời gian điều trị', cdt.Ngay as 'Ngày điều trị', cdt.KetQua as 'Kết quả', 
	CASE bn.TrangThai WHEN 1 THEN N'Đang điều trị'
			WHEN 0 THEN N'Đã xuất viện'
		END as 'Trạng thái điều trị'
	FROM CuocDieuTri cdt
	LEFT JOIN NhanVien nv ON nv.MaNV = cdt.MaBSi
	LEFT JOIN BenhNhan bn ON bn.MaBN = cdt.MaBN
	LEFT JOIN SuChuaTri sct ON sct.MaCT = cdt.MaCT

GO
/****** Object:  View [dbo].[vw_CuocDieuTri_DangDieuTri]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------------------------------
CREATE VIEW [dbo].[vw_CuocDieuTri_DangDieuTri]
AS
	SELECT cdt.ID_CDT, cdt.MaBSi, nv.TenNV as 'Tên Bác Sĩ', cdt.MaBN, bn.TenBN as 'Tên bệnh nhân', 
	cdt.MaCT, sct.Ten as 'Tên sự chữa trị', cdt.ThGian as 'Thời gian', cdt.Ngay as 'Ngày', cdt.KetQua as 'Kết quả'
	FROM CuocDieuTri cdt
	LEFT JOIN NhanVien nv ON nv.MaNV = cdt.MaBSi
	LEFT JOIN BenhNhan bn ON bn.MaBN = cdt.MaBN
	LEFT JOIN SuChuaTri sct ON sct.MaCT = cdt.MaCT
	WHERE bn.TrangThai = 1

GO
/****** Object:  View [dbo].[vw_CuocDieuTri_DaXuatVien]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------------------------------------------------
CREATE VIEW [dbo].[vw_CuocDieuTri_DaXuatVien]
AS
	SELECT cdt.ID_CDT, cdt.MaBSi, nv.TenNV as 'Tên Bác Sĩ', cdt.MaBN, bn.TenBN as 'Tên bệnh nhân', 
	cdt.MaCT, sct.Ten as 'Tên sự chữa trị', cdt.ThGian as 'Thời gian', cdt.Ngay as 'Ngày', cdt.KetQua as 'Kết quả'
	FROM CuocDieuTri cdt
	LEFT JOIN NhanVien nv ON nv.MaNV = cdt.MaBSi
	LEFT JOIN BenhNhan bn ON bn.MaBN = cdt.MaBN
	LEFT JOIN SuChuaTri sct ON sct.MaCT = cdt.MaCT
	WHERE bn.TrangThai = 0

GO
/****** Object:  View [dbo].[vw_Giuong]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_Giuong]
AS
	SELECT g.MaGiuong as 'Mã Giường', g.MaPhong as 'Mã phòng', p.TenPhong as 'Tên Phòng', g.MaKhu as 'Mã Khu', kct.TenKhuCT as 'Tên Khu chữa trị'
	FROM Giuong g
	LEFT JOIN Phong p ON p.MaPhong = g.MaPhong
	LEFT JOIN KhuChuaTri kct ON kct.MaKhuCT = g.MaKhu

GO
/****** Object:  View [dbo].[vw_MaYTChinh]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_MaYTChinh]
AS
	SELECT yt.MaYTa
	FROM NhanVien nv
	INNER JOIN YTa yt ON yt.MaYTa = nv.MaNV
	WHERE nv.isActive = 1 AND yt.ViTriCongViec = N'Y Tá Chính'

GO
/****** Object:  View [dbo].[vw_Phong_ConHoatDong]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_Phong_ConHoatDong]
AS
	SELECT p.MaPhong as 'Mã Phòng', p.MaKhuCT as 'Mã Khu chữa trị', p.TenPhong as 'Tên phòng', kct.TenKhuCT as 'Tên Khu chữa trị'
	FROM Phong p
	LEFT JOIN KhuChuaTri kct ON kct.MaKhuCT = p.MaKhuCT
	WHERE TrangThaiP = 1

GO
/****** Object:  View [dbo].[vw_Phong_DaNgungHoatDong]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_Phong_DaNgungHoatDong]
AS
	SELECT p.MaPhong as 'Mã Phòng', p.MaKhuCT as 'Mã Khu chữa trị', p.TenPhong as 'Tên phòng', kct.TenKhuCT as 'Tên Khu chữa trị'
	FROM Phong p
	LEFT JOIN KhuChuaTri kct ON kct.MaKhuCT = p.MaKhuCT
	WHERE TrangThaiP = 0

GO
/****** Object:  View [dbo].[vw_SDVT_BN_ChuaXuatVien]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_SDVT_BN_ChuaXuatVien]
AS
	SELECT sdvt.ID_SDVT, sdvt.MaBN as 'Mã Bệnh Nhân', bn.TenBN as 'Tên bệnh nhân' , sdvt.MaVT as 'Mã Vật Tư', vt.DacTa as 'Đặc tả vật tư',
		sdvt.NgaySD as 'Ngày sử dụng', sdvt.ThGian as 'Thời gian sử dụng', sdvt.SoLuong as 'Số lượng'
	FROM SuDungVatTu sdvt
	left join BenhNhan bn ON bn.MaBN = sdvt.MaBN
	left join VatTu vt ON vt.MaVT = sdvt.MaVT
	WHERE bn.TrangThai = 1

GO
/****** Object:  View [dbo].[vw_SDVT_BN_DaXuatVien]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_SDVT_BN_DaXuatVien]
AS
	SELECT sdvt.ID_SDVT, sdvt.MaBN as 'Mã Bệnh Nhân', bn.TenBN as 'Tên bệnh nhân' , sdvt.MaVT as 'Mã Vật Tư', vt.DacTa as 'Đặc tả vật tư',
		sdvt.NgaySD as 'Ngày sử dụng', sdvt.ThGian as 'Thời gian sử dụng', sdvt.SoLuong as 'Số lượng'
	FROM SuDungVatTu sdvt
	left join BenhNhan bn ON bn.MaBN = sdvt.MaBN
	left join VatTu vt ON vt.MaVT = sdvt.MaVT
	WHERE bn.TrangThai = 0

GO
/****** Object:  View [dbo].[vw_SuChuaTri]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_SuChuaTri]
AS
	SELECT MaCT as 'Mã sự chữa trị', Ten as 'Tên sự chữa trị'
	FROM SuChuaTri
	WHERE TrangThai = 1

GO
/****** Object:  View [dbo].[vw_SuChuaTri_Deleted]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------
CREATE VIEW [dbo].[vw_SuChuaTri_Deleted]
AS
	SELECT MaCT as 'Mã sự chữa trị', Ten as 'Tên sự chữa trị'
	FROM SuChuaTri
	WHERE TrangThai = 0

GO
/****** Object:  View [dbo].[vw_ThongTinBenhNhanDaXuatVien]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_ThongTinBenhNhanDaXuatVien]
AS
	SELECT *
	FROM BenhNhan 
	WHERE TrangThai = 0

GO
/****** Object:  View [dbo].[vw_ThongTinGioLamNV]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_ThongTinGioLamNV]
as
	select tkgl.MaNV as 'Mã NV', nv.TenNV as 'Tên Nhân Viên', tkgl.MaKhu as 'Mã Khu', kct.TenKhuCT as 'Tên Khu làm việc', tkgl.SoGioLV as 'Số giờ làm việc'
	from ThongKeGioLam tkgl
	left join NhanVien nv on nv.MaNV = tkgl.MaNV
	left join KhuChuaTri kct on tkgl.MaKhu = kct.MaKhuCT
	where nv.isActive = 1

GO
/****** Object:  View [dbo].[vw_ThongTinKhuChuaTri]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_ThongTinKhuChuaTri]
as
	select kct.MaKhuCT as N'Mã Khu', kct.TenKhuCT as N'Tên Khu Chữa Trị', kct.MaYTaTruong as N'Mã Y Tá Trưởng', nv.TenNV as N'Tên Y Tá Trưởng', nv.SDT 
	from KhuChuaTri kct
	left join NhanVien nv on nv.MaNV = kct.MaYTaTruong
	where kct.TrangThaiKCT = 1

GO
/****** Object:  View [dbo].[vw_VatTuDaNgungSuDung]    Script Date: 7/10/2023 1:40:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_VatTuDaNgungSuDung]
AS
	SELECT MaVT as 'Mã Vật Tư', DacTa as 'Đặc tả vật tư', DonGia as 'Đơn giá', LoaiVT as 'Loại Vật Tư'
	FROM VatTu
	WHERE TrangThaiVT = 0

GO
INSERT [dbo].[BacSi] ([MaBSi], [ChuyenMon]) VALUES (N'NV001', N'Nội khoa')
INSERT [dbo].[BacSi] ([MaBSi], [ChuyenMon]) VALUES (N'NV003', N'Phẫu thuật')
INSERT [dbo].[BacSi] ([MaBSi], [ChuyenMon]) VALUES (N'NV005', N'Sản khoa')
INSERT [dbo].[BacSi] ([MaBSi], [ChuyenMon]) VALUES (N'NV007', N'Tim mạch')
INSERT [dbo].[BacSi] ([MaBSi], [ChuyenMon]) VALUES (N'NV009', N'Nhi khoa')
INSERT [dbo].[BacSi] ([MaBSi], [ChuyenMon]) VALUES (N'NV011', N'Tâm lý')
INSERT [dbo].[BacSi] ([MaBSi], [ChuyenMon]) VALUES (N'NV013', N'Nhi Khoa')
INSERT [dbo].[BacSi] ([MaBSi], [ChuyenMon]) VALUES (N'NV015', N'Phẫu thuật')
INSERT [dbo].[BacSi] ([MaBSi], [ChuyenMon]) VALUES (N'NV017', N'Sản khoa')
INSERT [dbo].[BacSi] ([MaBSi], [ChuyenMon]) VALUES (N'NV019', N'Tim mạch')
INSERT [dbo].[BacSi] ([MaBSi], [ChuyenMon]) VALUES (N'NV022', N'Phẫu Thuật')
INSERT [dbo].[BacSi] ([MaBSi], [ChuyenMon]) VALUES (N'NV023', N'Tim Mạch')
INSERT [dbo].[BacSi] ([MaBSi], [ChuyenMon]) VALUES (N'NV025', NULL)
INSERT [dbo].[BacSi] ([MaBSi], [ChuyenMon]) VALUES (N'NV026', NULL)
INSERT [dbo].[BacSi] ([MaBSi], [ChuyenMon]) VALUES (N'NV027', N'')
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [NgSinh], [MaBSiTheoDoi], [MaBSiTiepNhan], [HinhThucKham], [CCCD], [TrangThai]) VALUES (N'BN001', N'Nguyễn Thị Anh', CAST(N'1990-05-10' AS Date), N'NV001', N'NV003', N'Nội Trú', N'657760405710', 0)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [NgSinh], [MaBSiTheoDoi], [MaBSiTiepNhan], [HinhThucKham], [CCCD], [TrangThai]) VALUES (N'BN002', N'Trần Văn Bình', CAST(N'1985-09-15' AS Date), N'NV003', N'NV005', N'Ngoại Trú', N'981764999415', 1)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [NgSinh], [MaBSiTheoDoi], [MaBSiTiepNhan], [HinhThucKham], [CCCD], [TrangThai]) VALUES (N'BN003', N'Lê Thị Cẩm Tú', CAST(N'1992-03-22' AS Date), N'NV005', N'NV007', N'Ngoại Trú', N'928721818087', 1)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [NgSinh], [MaBSiTheoDoi], [MaBSiTiepNhan], [HinhThucKham], [CCCD], [TrangThai]) VALUES (N'BN004', N'Phạm Xuân Dũng', CAST(N'1988-12-03' AS Date), N'NV007', N'NV009', N'Nội Trú', N'597226920698', 1)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [NgSinh], [MaBSiTheoDoi], [MaBSiTiepNhan], [HinhThucKham], [CCCD], [TrangThai]) VALUES (N'BN005', N'Hoàng Thị Mai', CAST(N'1995-07-19' AS Date), N'NV007', N'NV011', N'Ngoại Trú', N'516539701146', 1)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [NgSinh], [MaBSiTheoDoi], [MaBSiTiepNhan], [HinhThucKham], [CCCD], [TrangThai]) VALUES (N'BN006', N'Vũ Văn Nam', CAST(N'1987-11-28' AS Date), N'NV003', N'NV005', N'Nội Trú', N'574334935196', 1)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [NgSinh], [MaBSiTheoDoi], [MaBSiTiepNhan], [HinhThucKham], [CCCD], [TrangThai]) VALUES (N'BN007', N'Nguyễn Huy Hoàng', CAST(N'2023-02-06' AS Date), N'NV003', N'NV007', N'Nội Trú', N'585609326497', 0)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [NgSinh], [MaBSiTheoDoi], [MaBSiTiepNhan], [HinhThucKham], [CCCD], [TrangThai]) VALUES (N'BN008', N'Nguyễn Thị Hoa', CAST(N'2015-02-06' AS Date), N'NV011', N'NV007', N'Ngoại Trú', N'202572122784', 0)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [NgSinh], [MaBSiTheoDoi], [MaBSiTiepNhan], [HinhThucKham], [CCCD], [TrangThai]) VALUES (N'BN009', N'Đoàn Minh Dự', CAST(N'2012-02-09' AS Date), N'NV011', N'NV007', N'Ngoại Trú', N'201686122847', 0)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [NgSinh], [MaBSiTheoDoi], [MaBSiTiepNhan], [HinhThucKham], [CCCD], [TrangThai]) VALUES (N'BN010', N'Nguyễn Thị Hoa', CAST(N'2012-02-09' AS Date), N'NV009', N'NV007', N'Ngoại Trú', N'613070887687', 1)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [NgSinh], [MaBSiTheoDoi], [MaBSiTiepNhan], [HinhThucKham], [CCCD], [TrangThai]) VALUES (N'BN011', N'Huyền Ngọc Hà', CAST(N'2012-02-09' AS Date), N'NV009', N'NV007', N'Nội Trú', N'865962540439', 1)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [NgSinh], [MaBSiTheoDoi], [MaBSiTiepNhan], [HinhThucKham], [CCCD], [TrangThai]) VALUES (N'BN012', N'Ngô Thị Ngân', CAST(N'2012-02-09' AS Date), N'NV009', N'NV007', N'Nội Trú', N'981636564190', 1)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [NgSinh], [MaBSiTheoDoi], [MaBSiTiepNhan], [HinhThucKham], [CCCD], [TrangThai]) VALUES (N'BN013', N'Tuyết Hoa', CAST(N'2012-02-09' AS Date), N'NV011', N'NV007', N'Nội Trú', N'981636864190', 0)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [NgSinh], [MaBSiTheoDoi], [MaBSiTiepNhan], [HinhThucKham], [CCCD], [TrangThai]) VALUES (N'BN014', N'Nguyễn Nam', CAST(N'2005-01-05' AS Date), N'NV005', N'NV009', N'Ngoại Trú', N'124791645651', 1)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [NgSinh], [MaBSiTheoDoi], [MaBSiTiepNhan], [HinhThucKham], [CCCD], [TrangThai]) VALUES (N'BN015', N'Nguyễn Thoa', CAST(N'2023-06-12' AS Date), N'NV003', N'NV007', N'Ngoại Trú', N'123594364112', 1)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [NgSinh], [MaBSiTheoDoi], [MaBSiTiepNhan], [HinhThucKham], [CCCD], [TrangThai]) VALUES (N'BN016', N'Nguyễn Bình Minh', CAST(N'2001-01-25' AS Date), N'NV015', N'NV005', N'Ngoại Trú', N'125466231741', 0)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [NgSinh], [MaBSiTheoDoi], [MaBSiTiepNhan], [HinhThucKham], [CCCD], [TrangThai]) VALUES (N'BN017', N'Hoàng Văn Nghĩa', CAST(N'2001-01-12' AS Date), N'NV007', N'NV003', N'Nội Trú', N'123564872122', 1)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [NgSinh], [MaBSiTheoDoi], [MaBSiTiepNhan], [HinhThucKham], [CCCD], [TrangThai]) VALUES (N'BN018', N'Mai Linh', CAST(N'2023-02-13' AS Date), N'NV003', N'NV005', N'Nội Trú', N'123452132221', 1)
INSERT [dbo].[BenhNhanNgoaiTru] ([MaBN], [MoTaBenh]) VALUES (N'BN002', N'Bình thường')
INSERT [dbo].[BenhNhanNgoaiTru] ([MaBN], [MoTaBenh]) VALUES (N'BN003', N'Trào ngược dạ dày')
INSERT [dbo].[BenhNhanNgoaiTru] ([MaBN], [MoTaBenh]) VALUES (N'BN005', N'Bình thường')
INSERT [dbo].[BenhNhanNgoaiTru] ([MaBN], [MoTaBenh]) VALUES (N'BN008', N'Sốt nhẹ')
INSERT [dbo].[BenhNhanNgoaiTru] ([MaBN], [MoTaBenh]) VALUES (N'BN009', N'Sốt nhẹ')
INSERT [dbo].[BenhNhanNgoaiTru] ([MaBN], [MoTaBenh]) VALUES (N'BN010', N'')
INSERT [dbo].[BenhNhanNgoaiTru] ([MaBN], [MoTaBenh]) VALUES (N'BN014', N'Bình thường')
INSERT [dbo].[BenhNhanNgoaiTru] ([MaBN], [MoTaBenh]) VALUES (N'BN015', N'Sốt cao')
INSERT [dbo].[BenhNhanNgoaiTru] ([MaBN], [MoTaBenh]) VALUES (N'BN016', N'Dị ứng da')
INSERT [dbo].[BenhNhanNoiTru] ([MaBN], [MoTaBenh], [MaGiuong]) VALUES (N'BN001', N'Điều trị gãy xương đùi', N'G001')
INSERT [dbo].[BenhNhanNoiTru] ([MaBN], [MoTaBenh], [MaGiuong]) VALUES (N'BN004', N'Bệnh Nhẹ', N'G001')
INSERT [dbo].[BenhNhanNoiTru] ([MaBN], [MoTaBenh], [MaGiuong]) VALUES (N'BN006', N'Sốt xuất huyết', N'G003')
INSERT [dbo].[BenhNhanNoiTru] ([MaBN], [MoTaBenh], [MaGiuong]) VALUES (N'BN011', N'Bệnh da liễu', N'G004')
INSERT [dbo].[BenhNhanNoiTru] ([MaBN], [MoTaBenh], [MaGiuong]) VALUES (N'BN012', N'Sốt siêu vi', N'G005')
INSERT [dbo].[BenhNhanNoiTru] ([MaBN], [MoTaBenh], [MaGiuong]) VALUES (N'BN017', N'   ', N'G006')
INSERT [dbo].[BenhNhanNoiTru] ([MaBN], [MoTaBenh], [MaGiuong]) VALUES (N'BN018', NULL, NULL)
INSERT [dbo].[CuocDieuTri] ([ID_CDT], [MaBSi], [MaBN], [MaCT], [ThGian], [Ngay], [KetQua]) VALUES (N'CDT001', N'NV001', N'BN005', N'CT05', 2, CAST(N'2023-02-23' AS Date), N'Nhiễm trùng')
INSERT [dbo].[CuocDieuTri] ([ID_CDT], [MaBSi], [MaBN], [MaCT], [ThGian], [Ngay], [KetQua]) VALUES (N'CDT002', N'NV013', N'BN001', N'CT02', 0, CAST(N'2023-01-23' AS Date), N'Gãy xương')
INSERT [dbo].[CuocDieuTri] ([ID_CDT], [MaBSi], [MaBN], [MaCT], [ThGian], [Ngay], [KetQua]) VALUES (N'CDT003', N'NV007', N'BN004', N'CT02', 1, CAST(N'2023-03-02' AS Date), N'Thành công')
INSERT [dbo].[CuocDieuTri] ([ID_CDT], [MaBSi], [MaBN], [MaCT], [ThGian], [Ngay], [KetQua]) VALUES (N'CDT004', N'NV005', N'BN007', N'CT02', 3, CAST(N'2023-02-15' AS Date), N'Bình Thường')
INSERT [dbo].[CuocDieuTri] ([ID_CDT], [MaBSi], [MaBN], [MaCT], [ThGian], [Ngay], [KetQua]) VALUES (N'CDT005', N'NV007', N'BN007', N'CT04', 2, CAST(N'2023-01-03' AS Date), N'Bình Thường')
INSERT [dbo].[CuocDieuTri] ([ID_CDT], [MaBSi], [MaBN], [MaCT], [ThGian], [Ngay], [KetQua]) VALUES (N'CDT006', N'NV022', N'BN006', N'CT01', 2, CAST(N'2023-07-09' AS Date), N'')
INSERT [dbo].[Giuong] ([MaGiuong], [MaPhong], [MaKhu]) VALUES (N'G001', N'P006', N'KCT02')
INSERT [dbo].[Giuong] ([MaGiuong], [MaPhong], [MaKhu]) VALUES (N'G002', NULL, NULL)
INSERT [dbo].[Giuong] ([MaGiuong], [MaPhong], [MaKhu]) VALUES (N'G003', N'P008', N'KCT02')
INSERT [dbo].[Giuong] ([MaGiuong], [MaPhong], [MaKhu]) VALUES (N'G004', N'P006', N'KCT02')
INSERT [dbo].[Giuong] ([MaGiuong], [MaPhong], [MaKhu]) VALUES (N'G005', N'P016', N'KCT04')
INSERT [dbo].[Giuong] ([MaGiuong], [MaPhong], [MaKhu]) VALUES (N'G006', N'P001', N'KCT01')
INSERT [dbo].[Giuong] ([MaGiuong], [MaPhong], [MaKhu]) VALUES (N'G007', N'P006', N'KCT02')
INSERT [dbo].[Giuong] ([MaGiuong], [MaPhong], [MaKhu]) VALUES (N'G008', N'P016', N'KCT04')
INSERT [dbo].[Giuong] ([MaGiuong], [MaPhong], [MaKhu]) VALUES (N'G009', N'P003', N'KCT01')
INSERT [dbo].[KhuChuaTri] ([MaKhuCT], [TenKhuCT], [MaYTaTruong], [TrangThaiKCT]) VALUES (N'KCT01', N'Ngoại khoa', N'NV018', 1)
INSERT [dbo].[KhuChuaTri] ([MaKhuCT], [TenKhuCT], [MaYTaTruong], [TrangThaiKCT]) VALUES (N'KCT02', N'Nội Khoa', N'NV004', 1)
INSERT [dbo].[KhuChuaTri] ([MaKhuCT], [TenKhuCT], [MaYTaTruong], [TrangThaiKCT]) VALUES (N'KCT03', N'Ung bướu', N'NV006', 1)
INSERT [dbo].[KhuChuaTri] ([MaKhuCT], [TenKhuCT], [MaYTaTruong], [TrangThaiKCT]) VALUES (N'KCT04', N'Phục hồi chức năng', N'NV021', 1)
INSERT [dbo].[KhuChuaTri] ([MaKhuCT], [TenKhuCT], [MaYTaTruong], [TrangThaiKCT]) VALUES (N'KCT05', N'Khoa Lâm Sàng', N'NV024', 0)
INSERT [dbo].[KhuChuaTri] ([MaKhuCT], [TenKhuCT], [MaYTaTruong], [TrangThaiKCT]) VALUES (N'KCT06', N'Khu Xét Nghiệm', N'NV008', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV001', N'Nguyễn Văn An', N'Bác Sĩ', N'Nam', N'0901234566', N'282473319444', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV002', N'Trần Thị Bình', N'Y Tá', N'Nữ', N'0902349178', N'486905147192', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV003', N'Lê Văn Cường', N'Bác Sĩ', N'Nam', N'0903456709', N'632513949592', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV004', N'Phạm Thị Dung', N'Y Tá', N'Nữ', N'0904567890', N'786633552297', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV005', N'Trần Văn Kiên', N'Bác Sĩ', N'Nam', N'0905673901', N'742683188381', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV006', N'Nguyễn Thị Dông', N'Y Tá', N'Nữ', N'0906789012', N'866965859491', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV007', N'Phạm Văn Giàu', N'Bác Sĩ', N'Nam', N'0907890123', N'964043530870', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV008', N'Lê Thị Hạnh', N'Y Tá', N'Nữ', N'0908901234', N'250488852803', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV009', N'Trần Văn Hiếu', N'Bác Sĩ', N'Nam', N'0909012345', N'495466903898', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV010', N'Nguyễn Thị Loan', N'Y Tá', N'Nữ', N'0900123456', N'256185722335', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV011', N'Lê Văn Khoa', N'Bác Sĩ', N'Nam', N'0901264967', N'572425655214', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV012', N'Phạm Thị Lan', N'Y Tá', N'Nữ', N'0902345178', N'590322296968', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV013', N'Trần Văn Mạnh', N'Bác Sĩ', N'Nam', N'0909456789', N'159237093365', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV014', N'Nguyễn Văn Nghĩa', N'Y Tá', N'Nam', N'0914567820', N'381214471983', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV015', N'Lê Thị Oanh', N'Bác Sĩ', N'Nữ', N'0905672901', N'681788816892', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV016', N'Phạm Văn Phúc', N'Y Tá', N'Nam', N'0906799012', N'165816233998', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV017', N'Trần Thị Quỳnh', N'Bác Sĩ', N'Nữ', N'0903890123', N'759801971826', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV018', N'Nguyễn Văn Khoa', N'Y Tá', N'Nam', N'0901901234', N'222000330368', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV019', N'Lê Thị Sơn', N'Bác Sĩ', N'Nữ', N'0919011945', N'550298581679', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV020', N'Phạm Thị Trinh', N'Y Tá', N'Nữ', N'0900193451', N'970589782040', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV021', N'Nguyễn Thị Hoa', N'Y Tá', N'Nữ', N'0123456890', N'108939801026', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV022', N'Nguyễn Thị Quỳnh Chi', N'Bác Sĩ', N'Nữ', N'0160331010', N'118050018526', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV023', N'Nguyễn Đức Ngọc', N'Bác Sĩ', N'Nam', N'0235493385', N'128645473268', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV024', N'Nguyễn Thị Hoa', N'Y Tá', N'Nữ', N'0209931887', N'108929801026', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV025', N'Nguyễn Thị Nay', N'Bác Sĩ', N'Nữ', N'0160371310', N'102050018526', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV026', N'Trương Quỳnh Anh', N'Bác Sĩ', N'Nữ', N'0235984231', N'256947233312', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Phai], [SDT], [CCCD], [isActive]) VALUES (N'NV027', N'Nguyễn Văn Hoàng', N'Bác Sĩ', N'Nam', N'0231542323', N'124586232156', 0)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P001', N'KCT01', N'Phòng Phẫu Thuật K1', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P002', N'KCT01', N'Phòng Bệnh Nhẹ K1-1', 0)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P003', N'KCT01', N'Phòng Bệnh Nhẹ K1-2', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P004', N'KCT01', N'Phòng Bệnh Nhẹ K1-3', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P005', N'KCT01', N'Phòng Chăm Sóc Đặc Biệt K1', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P006', N'KCT02', N'Phòng Phẫu Thuật K2', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P007', N'KCT02', N'Phòng Bệnh Nhẹ K2-1', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P008', N'KCT02', N'Phòng Bệnh Nhẹ K2-2', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P009', N'KCT02', N'Phòng Bệnh Nhẹ K2-3', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P010', N'KCT02', N'Phòng Chăm Sóc Đặc Biệt K2', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P011', N'KCT03', N'Phòng Phẫu Thuật K3', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P012', N'KCT03', N'Phòng Bệnh Nhẹ K3-1', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P013', N'KCT03', N'Phòng Bệnh Nhẹ K3-2', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P014', N'KCT03', N'Phòng Bệnh Nhẹ K3-3', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P015', N'KCT03', N'Phòng Chăm Sóc Đặc Biệt K3', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P016', N'KCT04', N'Phòng Phẫu Thuật K4', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P017', N'KCT04', N'Phòng Bệnh Nhẹ K4-1', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P018', N'KCT04', N'Phòng Bệnh Nhẹ K4-2', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P019', N'KCT04', N'Phòng Bệnh Nhẹ K4-3', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P020', N'KCT04', N'Phòng Chăm Sóc Đặc Biệt K4', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P021', N'KCT05', N'Phòng Phẫu Thuật K5', 0)
INSERT [dbo].[Phong] ([MaPhong], [MaKhuCT], [TenPhong], [TrangThaiP]) VALUES (N'P022', N'KCT04', N'Phòng hồi sức', 1)
INSERT [dbo].[SuChuaTri] ([MaCT], [Ten], [TrangThai]) VALUES (N'CT01', N'Xét Nghiệm Máu', 1)
INSERT [dbo].[SuChuaTri] ([MaCT], [Ten], [TrangThai]) VALUES (N'CT02', N'Phẫu Thuật Tim', 1)
INSERT [dbo].[SuChuaTri] ([MaCT], [Ten], [TrangThai]) VALUES (N'CT03', N'Chụp X-Quang', 1)
INSERT [dbo].[SuChuaTri] ([MaCT], [Ten], [TrangThai]) VALUES (N'CT04', N'Điện tim', 1)
INSERT [dbo].[SuChuaTri] ([MaCT], [Ten], [TrangThai]) VALUES (N'CT05', N'Điện sóng não', 1)
INSERT [dbo].[SuChuaTri] ([MaCT], [Ten], [TrangThai]) VALUES (N'CT06', N'Nội soi dạ dày', 1)
INSERT [dbo].[SuChuaTri] ([MaCT], [Ten], [TrangThai]) VALUES (N'CT07', N'Tiểu phẫu', 0)
INSERT [dbo].[SuChuaTri] ([MaCT], [Ten], [TrangThai]) VALUES (N'CT08', N'Điện tâm đồ', 1)
INSERT [dbo].[SuDungVatTu] ([ID_SDVT], [MaBN], [MaVT], [NgaySD], [ThGian], [SoLuong], [TongTien]) VALUES (N'SDVT001', N'BN001', N'VT01', CAST(N'2023-02-23' AS Date), 5, 1, CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[SuDungVatTu] ([ID_SDVT], [MaBN], [MaVT], [NgaySD], [ThGian], [SoLuong], [TongTien]) VALUES (N'SDVT002', N'BN002', N'VT04', CAST(N'2023-03-02' AS Date), 3, 2, CAST(20000 AS Decimal(18, 0)))
INSERT [dbo].[SuDungVatTu] ([ID_SDVT], [MaBN], [MaVT], [NgaySD], [ThGian], [SoLuong], [TongTien]) VALUES (N'SDVT003', N'BN003', N'VT03', CAST(N'2023-02-15' AS Date), 2, 2, CAST(120000 AS Decimal(18, 0)))
INSERT [dbo].[SuDungVatTu] ([ID_SDVT], [MaBN], [MaVT], [NgaySD], [ThGian], [SoLuong], [TongTien]) VALUES (N'SDVT004', N'BN004', N'VT02', CAST(N'2023-03-06' AS Date), 9, 2, CAST(160000 AS Decimal(18, 0)))
INSERT [dbo].[SuDungVatTu] ([ID_SDVT], [MaBN], [MaVT], [NgaySD], [ThGian], [SoLuong], [TongTien]) VALUES (N'SDVT005', N'BN004', N'VT03', CAST(N'2023-03-07' AS Date), 2, 2, CAST(120000 AS Decimal(18, 0)))
INSERT [dbo].[SuDungVatTu] ([ID_SDVT], [MaBN], [MaVT], [NgaySD], [ThGian], [SoLuong], [TongTien]) VALUES (N'SDVT006', N'BN009', N'VT05', CAST(N'2023-06-18' AS Date), 3, 1, CAST(15000 AS Decimal(18, 0)))
INSERT [dbo].[SuDungVatTu] ([ID_SDVT], [MaBN], [MaVT], [NgaySD], [ThGian], [SoLuong], [TongTien]) VALUES (N'SDVT007', N'BN009', N'VT06', CAST(N'2023-06-18' AS Date), 3, 1, CAST(30000 AS Decimal(18, 0)))
INSERT [dbo].[SuDungVatTu] ([ID_SDVT], [MaBN], [MaVT], [NgaySD], [ThGian], [SoLuong], [TongTien]) VALUES (N'SDVT008', N'BN015', N'VT07', CAST(N'2023-07-07' AS Date), 2, 2, CAST(20000 AS Decimal(18, 0)))
INSERT [dbo].[SuDungVatTu] ([ID_SDVT], [MaBN], [MaVT], [NgaySD], [ThGian], [SoLuong], [TongTien]) VALUES (N'SDVT009', N'BN006', N'VT03', CAST(N'2023-07-07' AS Date), 2, 3, CAST(180000 AS Decimal(18, 0)))
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV001', N'KCT01', 55)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV002', N'KCT02', 62)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV003', N'KCT03', 51)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV004', N'KCT01', 68)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV005', N'KCT02', 57)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV006', N'KCT03', 66)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV007', N'KCT01', 52)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV008', N'KCT02', 60)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV009', N'KCT03', 65)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV010', N'KCT01', 53)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV011', N'KCT02', 61)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV012', N'KCT03', 56)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV013', N'KCT01', 69)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV014', N'KCT02', 54)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV015', N'KCT03', 67)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV016', N'KCT01', 59)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV017', N'KCT02', 63)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV018', N'KCT03', 60)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV019', N'KCT01', 64)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV020', N'KCT02', 50)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV021', N'KCT02', 89)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV023', N'KCT02', 23)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV024', N'KCT02', 24)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV025', N'KCT02', 56)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV022', N'KCT02', 12)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV004', N'KCT03', 68)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV026', N'KCT03', NULL)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV009', N'KCT02', 0)
INSERT [dbo].[ThongKeGioLam] ([MaNV], [MaKhu], [SoGioLV]) VALUES (N'NV009', N'KCT01', 12)
INSERT [dbo].[VatTu] ([MaVT], [DonGia], [DacTa], [LoaiVT], [TrangThaiVT]) VALUES (N'VT01', 100000, N'Máy chụp X-Quang', N'Dụng cụ', 1)
INSERT [dbo].[VatTu] ([MaVT], [DonGia], [DacTa], [LoaiVT], [TrangThaiVT]) VALUES (N'VT02', 80000, N'Máy Siêu Âm', N'Dụng cụ', 1)
INSERT [dbo].[VatTu] ([MaVT], [DonGia], [DacTa], [LoaiVT], [TrangThaiVT]) VALUES (N'VT03', 60000, N'Máy Điện Tim', N'Dụng Cụ', 1)
INSERT [dbo].[VatTu] ([MaVT], [DonGia], [DacTa], [LoaiVT], [TrangThaiVT]) VALUES (N'VT04', 10000, N'Kim tiêm, Băng gạc', N'Dụng cụ', 0)
INSERT [dbo].[VatTu] ([MaVT], [DonGia], [DacTa], [LoaiVT], [TrangThaiVT]) VALUES (N'VT05', 15000, N'Thuốc giảm đau (Analgesics)', N'Thuốc men', 1)
INSERT [dbo].[VatTu] ([MaVT], [DonGia], [DacTa], [LoaiVT], [TrangThaiVT]) VALUES (N'VT06', 30000, N'Thuốc chống rối loạn nhịp tim', N'Thuốc Men', 1)
INSERT [dbo].[VatTu] ([MaVT], [DonGia], [DacTa], [LoaiVT], [TrangThaiVT]) VALUES (N'VT07', 10000, N'Thuốc an thần', N'Thuốc Men', 1)
INSERT [dbo].[VatTu] ([MaVT], [DonGia], [DacTa], [LoaiVT], [TrangThaiVT]) VALUES (N'VT08', 14000, N'Thuốc hạ sốt', N'Thuốc men', 1)
INSERT [dbo].[VatTu] ([MaVT], [DonGia], [DacTa], [LoaiVT], [TrangThaiVT]) VALUES (N'VT09', 30000, N'Dụng cụ mổ', N'Dụng Cụ', 1)
INSERT [dbo].[VatTu] ([MaVT], [DonGia], [DacTa], [LoaiVT], [TrangThaiVT]) VALUES (N'VT10', 26000, N'Thuốc cảm', N'Thuốc Men', 1)
INSERT [dbo].[YTa] ([MaYTa], [ViTriCongViec]) VALUES (N'NV002', N'Y Tá Chính')
INSERT [dbo].[YTa] ([MaYTa], [ViTriCongViec]) VALUES (N'NV004', N'Y Tá Chính')
INSERT [dbo].[YTa] ([MaYTa], [ViTriCongViec]) VALUES (N'NV006', N'Y Tá Chính')
INSERT [dbo].[YTa] ([MaYTa], [ViTriCongViec]) VALUES (N'NV008', N'Y Tá Chính')
INSERT [dbo].[YTa] ([MaYTa], [ViTriCongViec]) VALUES (N'NV010', N'Y Tá Chính')
INSERT [dbo].[YTa] ([MaYTa], [ViTriCongViec]) VALUES (N'NV012', N'Y Tá Phụ')
INSERT [dbo].[YTa] ([MaYTa], [ViTriCongViec]) VALUES (N'NV014', N'Y Tá Chính')
INSERT [dbo].[YTa] ([MaYTa], [ViTriCongViec]) VALUES (N'NV016', N'Y Tá Phụ')
INSERT [dbo].[YTa] ([MaYTa], [ViTriCongViec]) VALUES (N'NV018', N'Y Tá Chính')
INSERT [dbo].[YTa] ([MaYTa], [ViTriCongViec]) VALUES (N'NV020', N'Y Tá Phụ')
INSERT [dbo].[YTa] ([MaYTa], [ViTriCongViec]) VALUES (N'NV021', N'Y Tá Chính')
INSERT [dbo].[YTa] ([MaYTa], [ViTriCongViec]) VALUES (N'NV024', N'Y Tá Chính')
SET ANSI_PADDING ON

GO
/****** Object:  Index [uk_CCCD_BN]    Script Date: 7/10/2023 1:40:37 PM ******/
ALTER TABLE [dbo].[BenhNhan] ADD  CONSTRAINT [uk_CCCD_BN] UNIQUE NONCLUSTERED 
(
	[CCCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [idx_TrangThaiBenhNhan]    Script Date: 7/10/2023 1:40:37 PM ******/
CREATE NONCLUSTERED INDEX [idx_TrangThaiBenhNhan] ON [dbo].[BenhNhan]
(
	[TrangThai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [uk_MaYTaTruong]    Script Date: 7/10/2023 1:40:37 PM ******/
ALTER TABLE [dbo].[KhuChuaTri] ADD  CONSTRAINT [uk_MaYTaTruong] UNIQUE NONCLUSTERED 
(
	[MaYTaTruong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [uk_TenKhuCT]    Script Date: 7/10/2023 1:40:37 PM ******/
ALTER TABLE [dbo].[KhuChuaTri] ADD  CONSTRAINT [uk_TenKhuCT] UNIQUE NONCLUSTERED 
(
	[TenKhuCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [idx_KhuCT]    Script Date: 7/10/2023 1:40:37 PM ******/
CREATE NONCLUSTERED INDEX [idx_KhuCT] ON [dbo].[KhuChuaTri]
(
	[TrangThaiKCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [uk_CCCD]    Script Date: 7/10/2023 1:40:37 PM ******/
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [uk_CCCD] UNIQUE NONCLUSTERED 
(
	[CCCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [uk_SDT]    Script Date: 7/10/2023 1:40:37 PM ******/
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [uk_SDT] UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [idx_TrangThaiNhanVien]    Script Date: 7/10/2023 1:40:37 PM ******/
CREATE NONCLUSTERED INDEX [idx_TrangThaiNhanVien] ON [dbo].[NhanVien]
(
	[isActive] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [uk_Phong_KhuCT]    Script Date: 7/10/2023 1:40:37 PM ******/
ALTER TABLE [dbo].[Phong] ADD  CONSTRAINT [uk_Phong_KhuCT] UNIQUE NONCLUSTERED 
(
	[MaPhong] ASC,
	[MaKhuCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [uk_Phong_TenPhong]    Script Date: 7/10/2023 1:40:37 PM ******/
ALTER TABLE [dbo].[Phong] ADD  CONSTRAINT [uk_Phong_TenPhong] UNIQUE NONCLUSTERED 
(
	[TenPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [idx_Phong]    Script Date: 7/10/2023 1:40:37 PM ******/
CREATE NONCLUSTERED INDEX [idx_Phong] ON [dbo].[Phong]
(
	[TrangThaiP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [uk_TenSCT]    Script Date: 7/10/2023 1:40:37 PM ******/
ALTER TABLE [dbo].[SuChuaTri] ADD  CONSTRAINT [uk_TenSCT] UNIQUE NONCLUSTERED 
(
	[Ten] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [idx_TrangThaiSCT]    Script Date: 7/10/2023 1:40:37 PM ******/
CREATE NONCLUSTERED INDEX [idx_TrangThaiSCT] ON [dbo].[SuChuaTri]
(
	[TrangThai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [idx_SDVT]    Script Date: 7/10/2023 1:40:37 PM ******/
CREATE NONCLUSTERED INDEX [idx_SDVT] ON [dbo].[SuDungVatTu]
(
	[MaBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [uk_NVLV]    Script Date: 7/10/2023 1:40:37 PM ******/
ALTER TABLE [dbo].[ThongKeGioLam] ADD  CONSTRAINT [uk_NVLV] UNIQUE NONCLUSTERED 
(
	[MaNV] ASC,
	[MaKhu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [uk_DacTa]    Script Date: 7/10/2023 1:40:37 PM ******/
ALTER TABLE [dbo].[VatTu] ADD  CONSTRAINT [uk_DacTa] UNIQUE NONCLUSTERED 
(
	[DacTa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [idx_TrangThaiVatTu]    Script Date: 7/10/2023 1:40:37 PM ******/
CREATE NONCLUSTERED INDEX [idx_TrangThaiVatTu] ON [dbo].[VatTu]
(
	[TrangThaiVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BacSi]  WITH CHECK ADD  CONSTRAINT [FK_BacSi_NhanVien] FOREIGN KEY([MaBSi])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[BacSi] CHECK CONSTRAINT [FK_BacSi_NhanVien]
GO
ALTER TABLE [dbo].[BenhNhan]  WITH CHECK ADD  CONSTRAINT [fk_BsiTheoDoi_BenhNhan_BacSi] FOREIGN KEY([MaBSiTheoDoi])
REFERENCES [dbo].[BacSi] ([MaBSi])
GO
ALTER TABLE [dbo].[BenhNhan] CHECK CONSTRAINT [fk_BsiTheoDoi_BenhNhan_BacSi]
GO
ALTER TABLE [dbo].[BenhNhan]  WITH CHECK ADD  CONSTRAINT [fk_BsiTiepNhan_BenhNhan_BacSi] FOREIGN KEY([MaBSiTiepNhan])
REFERENCES [dbo].[BacSi] ([MaBSi])
GO
ALTER TABLE [dbo].[BenhNhan] CHECK CONSTRAINT [fk_BsiTiepNhan_BenhNhan_BacSi]
GO
ALTER TABLE [dbo].[BenhNhanNgoaiTru]  WITH CHECK ADD  CONSTRAINT [fk_BenhNhanNgoaiTru] FOREIGN KEY([MaBN])
REFERENCES [dbo].[BenhNhan] ([MaBN])
GO
ALTER TABLE [dbo].[BenhNhanNgoaiTru] CHECK CONSTRAINT [fk_BenhNhanNgoaiTru]
GO
ALTER TABLE [dbo].[BenhNhanNoiTru]  WITH CHECK ADD  CONSTRAINT [fk_BenhNhanNoiTru] FOREIGN KEY([MaBN])
REFERENCES [dbo].[BenhNhan] ([MaBN])
GO
ALTER TABLE [dbo].[BenhNhanNoiTru] CHECK CONSTRAINT [fk_BenhNhanNoiTru]
GO
ALTER TABLE [dbo].[BenhNhanNoiTru]  WITH CHECK ADD  CONSTRAINT [fk_NoiTru_Giuong] FOREIGN KEY([MaGiuong])
REFERENCES [dbo].[Giuong] ([MaGiuong])
GO
ALTER TABLE [dbo].[BenhNhanNoiTru] CHECK CONSTRAINT [fk_NoiTru_Giuong]
GO
ALTER TABLE [dbo].[CuocDieuTri]  WITH CHECK ADD  CONSTRAINT [fk_CuocDieuTri_BacSi] FOREIGN KEY([MaBSi])
REFERENCES [dbo].[BacSi] ([MaBSi])
GO
ALTER TABLE [dbo].[CuocDieuTri] CHECK CONSTRAINT [fk_CuocDieuTri_BacSi]
GO
ALTER TABLE [dbo].[CuocDieuTri]  WITH CHECK ADD  CONSTRAINT [fk_CuocDieuTri_BenhNhan] FOREIGN KEY([MaBN])
REFERENCES [dbo].[BenhNhan] ([MaBN])
GO
ALTER TABLE [dbo].[CuocDieuTri] CHECK CONSTRAINT [fk_CuocDieuTri_BenhNhan]
GO
ALTER TABLE [dbo].[CuocDieuTri]  WITH CHECK ADD  CONSTRAINT [fk_CuocDieuTri_SuChuaTri] FOREIGN KEY([MaCT])
REFERENCES [dbo].[SuChuaTri] ([MaCT])
GO
ALTER TABLE [dbo].[CuocDieuTri] CHECK CONSTRAINT [fk_CuocDieuTri_SuChuaTri]
GO
ALTER TABLE [dbo].[Giuong]  WITH CHECK ADD  CONSTRAINT [fk_Giuong_Phong] FOREIGN KEY([MaPhong], [MaKhu])
REFERENCES [dbo].[Phong] ([MaPhong], [MaKhuCT])
GO
ALTER TABLE [dbo].[Giuong] CHECK CONSTRAINT [fk_Giuong_Phong]
GO
ALTER TABLE [dbo].[KhuChuaTri]  WITH CHECK ADD FOREIGN KEY([MaYTaTruong])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[KhuChuaTri]  WITH CHECK ADD  CONSTRAINT [fk_YTaTruong] FOREIGN KEY([MaYTaTruong])
REFERENCES [dbo].[YTa] ([MaYTa])
GO
ALTER TABLE [dbo].[KhuChuaTri] CHECK CONSTRAINT [fk_YTaTruong]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [fk_Phong_KhuCT] FOREIGN KEY([MaKhuCT])
REFERENCES [dbo].[KhuChuaTri] ([MaKhuCT])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [fk_Phong_KhuCT]
GO
ALTER TABLE [dbo].[SuDungVatTu]  WITH CHECK ADD  CONSTRAINT [fk_SuDungVatTu_BenhNhan] FOREIGN KEY([MaBN])
REFERENCES [dbo].[BenhNhan] ([MaBN])
GO
ALTER TABLE [dbo].[SuDungVatTu] CHECK CONSTRAINT [fk_SuDungVatTu_BenhNhan]
GO
ALTER TABLE [dbo].[SuDungVatTu]  WITH CHECK ADD  CONSTRAINT [fk_SuDungVatTu_VatTu] FOREIGN KEY([MaVT])
REFERENCES [dbo].[VatTu] ([MaVT])
GO
ALTER TABLE [dbo].[SuDungVatTu] CHECK CONSTRAINT [fk_SuDungVatTu_VatTu]
GO
ALTER TABLE [dbo].[ThongKeGioLam]  WITH CHECK ADD  CONSTRAINT [fk_KhuCT] FOREIGN KEY([MaKhu])
REFERENCES [dbo].[KhuChuaTri] ([MaKhuCT])
GO
ALTER TABLE [dbo].[ThongKeGioLam] CHECK CONSTRAINT [fk_KhuCT]
GO
ALTER TABLE [dbo].[ThongKeGioLam]  WITH CHECK ADD  CONSTRAINT [fk_NV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ThongKeGioLam] CHECK CONSTRAINT [fk_NV]
GO
ALTER TABLE [dbo].[YTa]  WITH CHECK ADD  CONSTRAINT [FK_YTa_NhanVien] FOREIGN KEY([MaYTa])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[YTa] CHECK CONSTRAINT [FK_YTa_NhanVien]
GO
ALTER TABLE [dbo].[BenhNhan]  WITH CHECK ADD  CONSTRAINT [CK_BenhNhan_CCCD] CHECK  (([CCCD] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[BenhNhan] CHECK CONSTRAINT [CK_BenhNhan_CCCD]
GO
ALTER TABLE [dbo].[BenhNhan]  WITH CHECK ADD  CONSTRAINT [CK_BenhNhan_HTK] CHECK  (([HinhThucKham]=N'Ngoại Trú' OR [HinhThucKham]=N'Nội Trú'))
GO
ALTER TABLE [dbo].[BenhNhan] CHECK CONSTRAINT [CK_BenhNhan_HTK]
GO
ALTER TABLE [dbo].[BenhNhan]  WITH CHECK ADD  CONSTRAINT [CK_BenhNhan_TT] CHECK  (([TrangThai]='1' OR [TrangThai]='0'))
GO
ALTER TABLE [dbo].[BenhNhan] CHECK CONSTRAINT [CK_BenhNhan_TT]
GO
ALTER TABLE [dbo].[KhuChuaTri]  WITH CHECK ADD  CONSTRAINT [ck_TrangThaiKCT] CHECK  (([TrangThaiKCT]='0' OR [TrangThaiKCT]='1'))
GO
ALTER TABLE [dbo].[KhuChuaTri] CHECK CONSTRAINT [ck_TrangThaiKCT]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [CK_CCCD_NV] CHECK  (([CCCD] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CK_CCCD_NV]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [CK_NhanVien_ChucVu] CHECK  (([ChucVu]=N'Y Tá' OR [ChucVu]=N'Bác Sĩ'))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [CK_NhanVien_isActive] CHECK  (([isActive]='0' OR [isActive]='1'))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CK_NhanVien_isActive]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [CK_NhanVien_SDT] CHECK  (([SDT] like '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CK_NhanVien_SDT]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [CK_Phong_TrangThaiP] CHECK  (([TrangThaiP]='1' OR [TrangThaiP]='0'))
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [CK_Phong_TrangThaiP]
GO
ALTER TABLE [dbo].[SuChuaTri]  WITH CHECK ADD  CONSTRAINT [CK_SuChuaTri_TT] CHECK  (([TrangThai]='1' OR [TrangThai]='0'))
GO
ALTER TABLE [dbo].[SuChuaTri] CHECK CONSTRAINT [CK_SuChuaTri_TT]
GO
ALTER TABLE [dbo].[VatTu]  WITH CHECK ADD  CONSTRAINT [CK_VatTu_LoaiVT] CHECK  (([LoaiVT]=N'Thuốc Men' OR [LoaiVT]=N'Dụng Cụ'))
GO
ALTER TABLE [dbo].[VatTu] CHECK CONSTRAINT [CK_VatTu_LoaiVT]
GO
ALTER TABLE [dbo].[VatTu]  WITH CHECK ADD  CONSTRAINT [CK_VatTu_TrangThaiVT] CHECK  (([TrangThaiVT]='1' OR [TrangThaiVT]='0'))
GO
ALTER TABLE [dbo].[VatTu] CHECK CONSTRAINT [CK_VatTu_TrangThaiVT]
GO
ALTER TABLE [dbo].[YTa]  WITH CHECK ADD  CONSTRAINT [CK_YTa_VTCV] CHECK  (([ViTriCongViec]=N'Y Tá Phụ' OR [ViTriCongViec]=N'Y Tá Chính'))
GO
ALTER TABLE [dbo].[YTa] CHECK CONSTRAINT [CK_YTa_VTCV]
GO
/****** Object:  StoredProcedure [dbo].[SP_BackupHospitalDatabase]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BackupHospitalDatabase]
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @BackupPath NVARCHAR(255) = 'C:\SQLBackups\Hospital.bak';
    DECLARE @DatabaseName NVARCHAR(128) = 'HOSPITAL';

    -- Kiểm tra xem tệp backup đã tồn tại hay chưa
    IF EXISTS (SELECT 1 FROM sys.sysdevices WHERE name = 'HospitalBackupDevice')
    BEGIN
        -- Thực hiện backup database
        BACKUP DATABASE @DatabaseName
        TO DISK = @BackupPath
        WITH FORMAT, NAME = 'Full Database Backup';

        -- Hiển thị thông báo khi backup thành công
        PRINT 'Backup database HOSPITAL thành công.';
    END
    ELSE
    BEGIN
        -- Hiển thị thông báo khi thiết bị backup chưa được tạo
        PRINT 'Thiết bị backup HospitalBackupDevice chưa được tạo.';
    END
END
--------
GO
/****** Object:  StoredProcedure [dbo].[SP_BackupHospitalDatabase2]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_BackupHospitalDatabase2]
    @BackupPath NVARCHAR(255),
    @NameFile NVARCHAR(128)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @FullBackupPath NVARCHAR(255) = CONCAT(@BackupPath, '\', @NameFile, '.bak');
    DECLARE @DatabaseName NVARCHAR(128) = 'HOSPITAL';

    -- Kiểm tra xem tệp backup đã tồn tại hay chưa
    IF EXISTS (SELECT 1 FROM sys.sysdevices WHERE name = 'HospitalBackupDevice')
	BEGIN
		-- Thực hiện backup database
		BACKUP DATABASE @DatabaseName
		TO DISK = @FullBackupPath
		WITH FORMAT, NAME = 'Full Database Backup';

		-- Hiển thị thông báo khi backup thành công
		PRINT N'Backup database HOSPITAL thành công.';
	END
	ELSE
	BEGIN
		-- Thiết bị backup không tồn tại, tạo thông báo lỗi
		DECLARE @ErrorMessage NVARCHAR(4000) = N'Thiết bị backup HospitalBackupDevice chưa được tạo.';
		RAISERROR(@ErrorMessage, 16, 1);
	END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatBenhNhanNgoaiTru]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CapNhatBenhNhanNgoaiTru]
    @MaBN varchar(10),
    @MoTaBenh nvarchar(100)
AS
BEGIN
    -- Kiểm tra xem MaBN có tồn tại trong bảng BenhNhanNgoaiTru hay không
    IF NOT EXISTS (
        SELECT 1
        FROM BenhNhanNgoaiTru
        WHERE MaBN = @MaBN
    )
    BEGIN
        -- MaBN không tồn tại, thông báo lỗi
        RAISERROR('Mã bệnh nhân không tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra TrangThai của bệnh nhân trong bảng BenhNhan
    DECLARE @TrangThai bit;
    SELECT @TrangThai = TrangThai
    FROM BenhNhan
    WHERE MaBN = @MaBN;

    -- Nếu TrangThai là 0, không cho phép cập nhật
    IF @TrangThai = 0
    BEGIN
        RAISERROR('Bệnh nhân không thể cập nhật do đã xuất viện.', 16, 1);
        RETURN;
    END;

    -- Cập nhật thông tin bệnh nhân ngoại trú
    UPDATE BenhNhanNgoaiTru
    SET MoTaBenh = @MoTaBenh
    WHERE MaBN = @MaBN;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatCuocDieuTri]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CapNhatCuocDieuTri]
    @ID_CDT varchar(10),
    @MaBSi varchar(10),
    @MaBN varchar(10),
    @MaCT varchar(20),
    @ThGian int,
    @Ngay date,
    @KetQua nvarchar(100)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra ID_CDT có tồn tại
    IF NOT EXISTS (SELECT 1 FROM CuocDieuTri WHERE ID_CDT = @ID_CDT)
    BEGIN
        RAISERROR('Mã cuộc điều trị không tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra MaBSi có là Bác Sĩ và isActive = 1
    IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaNV = @MaBSi)
    BEGIN
        RAISERROR('Không tồn tại MaBSi này.', 16, 1);
        RETURN;
    END;
    ELSE
    BEGIN
        IF (SELECT ChucVu FROM NhanVien WHERE MaNV = @MaBSi) <> N'Bác Sĩ'
        BEGIN
            RAISERROR('Đây không phải là Bác sĩ.', 16, 1);
            RETURN;
        END;
        ELSE IF (SELECT isActive FROM NhanVien WHERE MaNV = @MaBSi) = 0
        BEGIN
            RAISERROR('Bác Sĩ này không còn làm việc.', 16, 1);
            RETURN;
        END;
    END;

    -- Kiểm tra MaBN và TrangThai của bệnh nhân
    IF NOT EXISTS (SELECT 1 FROM BenhNhan WHERE MaBN = @MaBN)
    BEGIN
        RAISERROR('Mã bệnh nhân không tồn tại.', 16, 1);
        RETURN;
    END;
    ELSE
    BEGIN
        IF (SELECT TrangThai FROM BenhNhan WHERE MaBN = @MaBN) = 0
        BEGIN
            RAISERROR('Bệnh nhân đã xuất viện.', 16, 1);
            RETURN;
        END;
    END;

    -- Kiểm tra MaCT và TrangThai của sự chữa trị
    IF NOT EXISTS (SELECT 1 FROM SuChuaTri WHERE MaCT = @MaCT)
    BEGIN
        RAISERROR('Mã sự chữa trị không tồn tại.', 16, 1);
        RETURN;
    END;
    ELSE
    BEGIN
        IF (SELECT TrangThai FROM SuChuaTri WHERE MaCT = @MaCT) = 0
        BEGIN
            RAISERROR('Sự chữa trị đã ngừng.', 16, 1);
            RETURN;
        END;
    END;

    -- Kiểm tra ngày hợp lệ (trước ngày hiện tại)
    IF @Ngay >= CONVERT(date, GETDATE())
    BEGIN
        RAISERROR('Ngày không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Cập nhật thông tin cuộc điều trị
    UPDATE CuocDieuTri
    SET MaBSi = @MaBSi, MaBN = @MaBN, MaCT = @MaCT, ThGian = @ThGian, Ngay = @Ngay, KetQua = @KetQua
    WHERE ID_CDT = @ID_CDT;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatGiuong]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------
CREATE PROCEDURE [dbo].[sp_CapNhatGiuong]
    @MaGiuong varchar(10),
    @MaPhong varchar(10),
    @MaKhu varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra MaGiuong có tồn tại trong bảng Giuong
    IF NOT EXISTS (
        SELECT 1
        FROM Giuong
        WHERE MaGiuong = @MaGiuong
    )
    BEGIN
        RAISERROR('Không có giường này.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra MaPhong có tồn tại trong bảng Phong và có TrangThaiP là 1
    IF NOT EXISTS (
        SELECT 1
        FROM Phong
        WHERE MaPhong = @MaPhong AND TrangThaiP = 1
    )
    BEGIN
        RAISERROR('Phòng này không tồn tại hoặc không có trạng thái hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra MaKhu có tồn tại trong bảng KhuChuaTri
    IF NOT EXISTS (
        SELECT 1
        FROM KhuChuaTri
        WHERE MaKhuCT = @MaKhu
    )
    BEGIN
        RAISERROR('Mã khu chữa trị không tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra MaPhong và MaKhu có tồn tại trong bảng Phong
    IF NOT EXISTS (
        SELECT 1
        FROM Phong
        WHERE MaPhong = @MaPhong AND MaKhuCT = @MaKhu
    )
    BEGIN
        RAISERROR('Phòng vừa nhập không nằm trong Khu chữa trị vừa nhập. Hãy kiểm tra lại.', 16, 1);
        RETURN;
    END;

    -- Cập nhật thông tin giường trong bảng Giuong
    UPDATE Giuong
    SET MaPhong = @MaPhong, MaKhu = @MaKhu
    WHERE MaGiuong = @MaGiuong;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatKhuChuaTri]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_CapNhatKhuChuaTri]
    @MaKhuCT varchar(10),
    @TenKhuCT nvarchar(20),
    @MaYTaTruong varchar(10)
AS
BEGIN
    -- Kiểm tra MaKhuCT đã tồn tại trong bảng KhuChuaTri
	IF NOT EXISTS (
        SELECT 1
        FROM KhuChuaTri
        WHERE MaKhuCT = @MaKhuCT
    )
    BEGIN
        -- MaKhuCT không tồn tại trong bảng KhuChuaTri, thông báo lỗi
        RAISERROR('Mã Khu Chữa Trị này không tồn tại', 16, 1);
        RETURN;
    END

    -- Kiểm tra trùng tên khu chữa trị với các khu khác trong bảng
    IF EXISTS (
        SELECT 1
        FROM KhuChuaTri
        WHERE TenKhuCT = @TenKhuCT AND MaKhuCT <> @MaKhuCT
    )
    BEGIN
        -- Tên khu chữa trị trùng với khu khác, thông báo lỗi
        RAISERROR('Tên khu chữa trị đã tồn tại', 16, 1);
        RETURN;
    END

    -- Kiểm tra MaYTaTruong có tồn tại trong bảng NhanVien
    IF NOT EXISTS (
        SELECT 1
        FROM NhanVien
        WHERE MaNV = @MaYTaTruong
    )
    BEGIN
        -- MaYTaTruong không tồn tại trong bảng NhanVien, thông báo lỗi
        RAISERROR('Không có Y tá này', 16, 1);
        RETURN;
    END

    -- Kiểm tra MaYTaTruong có ChucVu là 'Y Tá' hay không
    IF NOT EXISTS (
        SELECT 1
        FROM NhanVien
        WHERE MaNV = @MaYTaTruong AND ChucVu = N'Y Tá'
    )
    BEGIN
        -- MaYTaTruong không có ChucVu là 'Y Tá', thông báo lỗi
        RAISERROR('Đây không phải Y Tá', 16, 1);
        RETURN;
    END

    -- Kiểm tra MaYTaTruong có isActive = 1 hay không
    IF NOT EXISTS (
        SELECT 1
        FROM NhanVien
        WHERE MaNV = @MaYTaTruong AND isActive = 1
    )
    BEGIN
        -- MaYTaTruong không có isActive = 1, thông báo lỗi
        RAISERROR('Y Tá này không còn làm việc', 16, 1);
        RETURN;
    END

    -- Kiểm tra ViTriCongViec của MaYTaTruong có là 'Y Tá Trưởng' hay không
    IF NOT EXISTS (
        SELECT 1
        FROM YTa
        WHERE MaYTa = @MaYTaTruong AND ViTriCongViec = N'Y Tá Chính'
    )
    BEGIN
        -- MaYTaTruong không có ViTriCongViec là 'Y Tá Trưởng', thông báo lỗi
        RAISERROR('Đây không phải Y Tá Trưởng', 16, 1);
        RETURN;
    END

    -- Cập nhật thông tin Khu Chữa Trị
    UPDATE KhuChuaTri
    SET TenKhuCT = @TenKhuCT, MaYTaTruong = @MaYTaTruong
    WHERE MaKhuCT = @MaKhuCT;
    
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatNV]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CapNhatNV]
    @MaNV varchar(10),
	@TenNV nvarchar(30),
    @ChucVu nvarchar(20),
	@Phai nvarchar(5),
    @SDT varchar(30),
    @CCCD varchar(30),
	@isActive tinyint = NULL
AS
BEGIN
    -- Kiểm tra chức vụ
    IF (@ChucVu <> N'Bác Sĩ' AND @ChucVu <> N'Y Tá')
    BEGIN
        RAISERROR('Chức vụ không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra số điện thoại
    IF (LEN(@SDT) <> 10 OR @SDT NOT LIKE '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
    BEGIN
        RAISERROR('Số điện thoại không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra CCCD
    IF (LEN(@CCCD) <> 12 OR @CCCD NOT LIKE REPLICATE('[0-9]', 12))
    BEGIN
        RAISERROR('CCCD không hợp lệ.', 16, 1);
        RETURN;
    END;

	IF EXISTS (
        SELECT 1
        FROM NhanVien
        WHERE CCCD = @CCCD AND MaNV <> @MaNV
    )
    BEGIN
        -- MaYTaTruong đã tồn tại trong bảng KhuChuaTri, thông báo lỗi
        RAISERROR('CCCD này đã tồn tại', 16, 1);
        RETURN;
    END

	--Kiểm Tra isActive
	IF (@isActive <> 1 AND @isActive <> 0)
    BEGIN
        RAISERROR('Trạng thái isActive chỉ nhận giá trị 1 hoặc 0.', 16, 1);
        RETURN;
    END;

    -- Cập nhật thông tin nhân viên trong bảng NhanVien
    UPDATE NhanVien
    SET TenNV = @TenNV,
		ChucVu = @ChucVu,
		Phai = @Phai,
        SDT = @SDT,
        CCCD = @CCCD,
		isActive = COALESCE(@isActive, isActive)
    WHERE MaNV = @MaNV;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatPhong]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CapNhatPhong]
    @MaPhong varchar(10),
    @MaKhuCT varchar(10),
    @TenPhong nvarchar(100),
	@TrangThaiP tinyint = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra MaPhong có tồn tại trong bảng Phong
    IF NOT EXISTS (SELECT 1 FROM Phong WHERE MaPhong = @MaPhong)
    BEGIN
        RAISERROR('Mã phòng không tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra MaKhuCT có tồn tại trong bảng KhuChuaTri
    IF NOT EXISTS (SELECT 1 FROM KhuChuaTri WHERE MaKhuCT = @MaKhuCT)
    BEGIN
        RAISERROR('Mã khu chữa trị không tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra TenPhong không trùng với những tên đã có trừ phòng đang được cập nhật
    IF EXISTS (SELECT 1 FROM Phong WHERE TenPhong = @TenPhong AND MaPhong != @MaPhong)
    BEGIN
        RAISERROR('Tên phòng đã tồn tại.', 16, 1);
        RETURN;
    END;

	    IF @TrangThaiP NOT IN (0, 1)
    BEGIN
        RAISERROR('Trạng thái Phòng không hợp lệ, chỉ nhận 1(còn sử dụng) hoặc 0(Ngưng sử dụng).', 16, 1);
        RETURN;
    END;

    -- Cập nhật thông tin phòng
    UPDATE Phong
    SET MaKhuCT = @MaKhuCT,
        TenPhong = @TenPhong,
		TrangThaiP = COALESCE(@TrangThaiP, TrangThaiP)
    WHERE MaPhong = @MaPhong;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatSuChuaTri]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CapNhatSuChuaTri]
    @MaCT varchar(10),
    @Ten nvarchar(100),
    @TrangThai tinyint = NULL
AS
BEGIN
    -- Kiểm tra MaCT có tồn tại không
    IF NOT EXISTS (
        SELECT 1
        FROM SuChuaTri
        WHERE MaCT = @MaCT
    )
    BEGIN
        RAISERROR('Mã sự chữa trị không tồn tại.', 16, 1);
        RETURN;
    END;

    

    -- Kiểm tra giá trị hợp lệ cho TrangThaiVT
    IF @TrangThai NOT IN (0, 1)
    BEGIN
        RAISERROR('Trạng thái của Sự chữa trị không hợp lệ, chỉ nhận 1(còn sử dụng) hoặc 0(Ngưng sử dụng).', 16, 1);
        RETURN;
    END;

    -- Cập nhật thông tin vật tư trong bảng VatTu
    UPDATE SuChuaTri
    SET Ten = @Ten,
        TrangThai = COALESCE(@TrangThai, TrangThai)
    WHERE MaCT = @MaCT;

END;
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatSuDungVatTu]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CapNhatSuDungVatTu]
    @ID_SDVT varchar(10),
    @MaBN varchar(10),
    @MaVT varchar(10),
    @NgaySD date,
    @ThGian int,
    @SoLuong int
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra ID_SDVT có tồn tại trong bảng SuDungVatTu
    IF NOT EXISTS (
        SELECT 1
        FROM SuDungVatTu
        WHERE ID_SDVT = @ID_SDVT
    )
    BEGIN
        RAISERROR('Mã lần sử dụng vật tư không tồn tại trong bảng SuDungVatTu.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra MaBN có tồn tại trong bảng BenhNhan
    IF NOT EXISTS (
        SELECT 1
        FROM BenhNhan
        WHERE MaBN = @MaBN
    )
    BEGIN
        RAISERROR('Mã bệnh nhân không tồn tại trong bảng BenhNhan.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra TrangThai của bệnh nhân
    DECLARE @TrangThaiBN bit;
    SET @TrangThaiBN = (
        SELECT TrangThai
        FROM BenhNhan
        WHERE MaBN = @MaBN
    );

    IF @TrangThaiBN = 0
    BEGIN
        RAISERROR('Bệnh nhân đã xuất viện (TrangThai = 0), không thể cập nhật lần sử dụng vật tư.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra MaVT có tồn tại trong bảng VatTu
    IF NOT EXISTS (
        SELECT 1
        FROM VatTu
        WHERE MaVT = @MaVT
    )
    BEGIN
        RAISERROR('Mã vật tư không tồn tại trong bảng VatTu.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra NgaySD hợp lệ
    IF @NgaySD > GETDATE()
    BEGIN
        RAISERROR('Ngày sử dụng không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Cập nhật thông tin lần sử dụng vật tư trong bảng SuDungVatTu
    UPDATE SuDungVatTu
    SET MaBN = @MaBN,
        MaVT = @MaVT,
        NgaySD = @NgaySD,
        ThGian = @ThGian,
        SoLuong = @SoLuong
    WHERE ID_SDVT = @ID_SDVT;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatThongKeGioLam]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_CapNhatThongKeGioLam]
    @MaNV varchar(10),
    @MaKhu varchar(10),
    @SoGioLV int
AS
BEGIN
    IF NOT EXISTS (
		SELECT 1
		FROM NhanVien
		WHERE MaNV = @MaNV
	)
	BEGIN
		-- MaNV không tồn tại, thông báo lỗi
		RAISERROR('Mã Nhân Viên không tồn tại', 16, 1);
		RETURN;
	END
	ELSE
	BEGIN
		-- MaNV tồn tại, kiểm tra trạng thái isActive
		IF EXISTS (
			SELECT 1
			FROM NhanVien
			WHERE MaNV = @MaNV AND isActive = 0
		)
		BEGIN
			-- Nhân viên đã nghỉ việc, thông báo lỗi
			RAISERROR('Nhân viên đã nghỉ việc', 16, 1);
			RETURN;
		END
	END

    -- Kiểm tra MaKhu có tồn tại trong bảng KhuChuaTri
    IF NOT EXISTS (
        SELECT 1
        FROM KhuChuaTri
        WHERE MaKhuCT = @MaKhu
    )
    BEGIN
        -- MaKhu không tồn tại trong bảng KhuChuaTri, thông báo lỗi
        RAISERROR('Mã Khu không tồn tại', 16, 1);
        RETURN;
    END
	-- Kiểm tra xem cặp giá trị MaNV và MaKhu đã tồn tại trong bảng ThongKeGioLam chưa
    IF NOT EXISTS (
        SELECT 1
        FROM ThongKeGioLam
        WHERE MaNV = @MaNV AND MaKhu = @MaKhu
    )
    BEGIN
        -- Cặp giá trị MaNV và MaKhu đã tồn tại, thông báo lỗi
        RAISERROR('Cặp MaNV và MaKhu không tồn tại trong bảng ThongKeGioLam', 16, 1);
        RETURN;
    END

    -- Cập nhật thông tin trong bảng ThongKeGioLam
    UPDATE ThongKeGioLam
    SET SoGioLV = @SoGioLV,  MaKhu = @MaKhu
    WHERE MaNV = @MaNV AND MaKhu = @MaKhu;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatThongTinBenhNhan]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------
CREATE PROCEDURE [dbo].[sp_CapNhatThongTinBenhNhan]
    @MaBN varchar(10),
    @TenBN nvarchar(30),
    @NgSinh date,
    @CCCD varchar(30),
    @MaBSiTheoDoi varchar(10),
    @MaBSiTiepNhan varchar(10),
    @HinhThucKham nvarchar(20),
    @TrangThai tinyint = NULL
AS
BEGIN
    -- Kiểm tra ngày sinh hợp lệ là ngày trước ngày hiện tại
    IF @NgSinh >= CAST(GETDATE() AS date)
    BEGIN
        RAISERROR('Ngày sinh không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra xem MaBSiTheoDoi có tồn tại và hợp lệ hay không
    IF NOT EXISTS (
        SELECT 1
        FROM NhanVien
        WHERE MaNV = @MaBSiTheoDoi AND ChucVu = N'Bác Sĩ' AND isActive = 1
    )
    BEGIN
        -- MaBSiTheoDoi không tồn tại hoặc không hợp lệ, thông báo lỗi
        RAISERROR('Mã Bác sĩ theo dõi không tồn tại hoặc không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra xem MaBSiTiepNhan có tồn tại và hợp lệ hay không
    IF NOT EXISTS (
        SELECT 1
        FROM NhanVien
        WHERE MaNV = @MaBSiTiepNhan AND ChucVu = N'Bác Sĩ' AND isActive = 1
    )
    BEGIN
        -- MaBSiTiepNhan không tồn tại hoặc không hợp lệ, thông báo lỗi
        RAISERROR('Mã Bác sĩ tiếp nhận không tồn tại hoặc không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra HinhThucKham
    IF @HinhThucKham NOT IN (N'Nội Trú', N'Ngoại Trú')
    BEGIN
        RAISERROR('Hình thức khám không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra CCCD
    IF (LEN(@CCCD) <> 12 OR @CCCD NOT LIKE REPLICATE('[0-9]', 12))
    BEGIN
        RAISERROR('CCCD không hợp lệ.', 16, 1);
        RETURN;
    END;

    IF EXISTS (
        SELECT 1
        FROM BenhNhan
        WHERE CCCD = @CCCD AND MaBN <> @MaBN
    )
    BEGIN
        -- CCCD đã tồn tại trong bảng, thông báo lỗi
        RAISERROR('CCCD này đã tồn tại', 16, 1);
        RETURN;
    END

    IF (@TrangThai <> 1 AND @TrangThai <> 0)
    BEGIN
        RAISERROR('Trạng Thái chỉ nhận 1 (đang điều trị) hoặc 0 (đã xuất viện).', 16, 1);
        RETURN;
    END;
	/*
    IF (@TrangThai = 0)
    BEGIN
        -- Kiểm tra xem bệnh nhân đã được cập nhật MoTaBenh hay chưa
        IF NOT EXISTS (
            SELECT 1
            FROM BenhNhanNgoaiTru
            WHERE MaBN = @MaBN AND MoTaBenh IS NOT NULL
        )
        BEGIN
            RAISERROR('Bệnh nhân chưa được cập nhật MoTaBenh, không thể chuyển TrangThai từ 1 về 0.', 16, 1);
            RETURN;
        END;
    END;*/

    -- Cập nhật thông tin bệnh nhân
    UPDATE BenhNhan
    SET TenBN = @TenBN,
        NgSinh = @NgSinh,
        CCCD = @CCCD,
        MaBSiTheoDoi = @MaBSiTheoDoi,
        MaBSiTiepNhan = @MaBSiTiepNhan,
        HinhThucKham = @HinhThucKham,
        TrangThai = COALESCE(@TrangThai, TrangThai)
    WHERE MaBN = @MaBN;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatThongTinBenhNhanNoiTru]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_CapNhatThongTinBenhNhanNoiTru]
    @MaBN varchar(10),
    @MoTaBenh nvarchar(100),
    @MaGiuong varchar(10)
AS
BEGIN
    -- Kiểm tra MaBN có tồn tại trong bảng BenhNhanNoiTru
    IF NOT EXISTS (
        SELECT 1
        FROM BenhNhanNoiTru
        WHERE MaBN = @MaBN
    )
    BEGIN
        -- MaBN không tồn tại, thông báo lỗi
        RAISERROR('Mã bệnh nhân không tồn tại trong bảng BenhNhanNoiTru.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra TrangThai của bệnh nhân
    DECLARE @TrangThai bit;
    SET @TrangThai = (
        SELECT TrangThai
        FROM BenhNhan
        WHERE MaBN = @MaBN
    );
    
    IF @TrangThai = 0
    BEGIN
        -- Trạng thái bệnh nhân là 0, không thể cập nhật MoTaBenh
        RAISERROR('Bệnh nhân đã xuất viện, không thể cập nhật MoTaBenh.', 16, 1);
        RETURN;
    END;

	-- Kiểm tra MaGiuong đã tồn tại trong bảng Giuong hay không
	IF NOT EXISTS (
		SELECT 1
		FROM Giuong
		WHERE MaGiuong = @MaGiuong
	)
	BEGIN
		-- MaGiuong không tồn tại, thông báo lỗi
		RAISERROR('Không có giường này.', 16, 1);
		RETURN;
	END;

	-- Kiểm tra MaPhong và MaKhu đã tồn tại trong bảng Giuong hay chưa
	IF NOT EXISTS (
		SELECT 1
		FROM Giuong
		WHERE MaGiuong = @MaGiuong AND MaPhong IS NOT NULL AND MaKhu IS NOT NULL
	)
	BEGIN
		-- Giường này hiện chưa sẵn sàng để sử dụng, thông báo lỗi
		RAISERROR('Giường này hiện chưa sẵn sàng để sử dụng.', 16, 1);
		RETURN;
	END;

    -- Kiểm tra MaGiuong đã tồn tại trong bảng BenhNhanNoiTru hay chưa
    IF EXISTS (
        SELECT 1
        FROM BenhNhanNoiTru
        WHERE MaGiuong = @MaGiuong AND MaBN <> @MaBN
    )
    BEGIN
        -- MaGiuong đã tồn tại, kiểm tra TrangThai của bệnh nhân
        IF EXISTS (
            SELECT 1
            FROM BenhNhanNoiTru bnnt
			INNER JOIN BenhNhan bn ON bnnt.MaBN = bn.MaBN
            WHERE bnnt.MaGiuong = @MaGiuong AND bn.MaBN <> @MaBN AND bn.TrangThai = 1
        )
        BEGIN
            -- Giường đang được sử dụng (TrangThai = 1), không thể cập nhật MaGiuong
            RAISERROR('Giường đang được bệnh nhân khác sử dụng, không thể cập nhật MaGiuong.', 16, 1);
            RETURN;
        END;
    END;

    -- Cập nhật thông tin bệnh nhân trong bảng BenhNhanNoiTru
    UPDATE BenhNhanNoiTru
    SET MoTaBenh = @MoTaBenh,
        MaGiuong = @MaGiuong
    WHERE MaBN = @MaBN;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatVatTu]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CapNhatVatTu]
    @MaVT varchar(10),
    @DonGia int,
    @DacTa nvarchar(100),
    @LoaiVT nvarchar(20),
    @TrangThaiVT tinyint = NULL
AS
BEGIN
    -- Kiểm tra MaVT có tồn tại trong bảng VatTu
    IF NOT EXISTS (
        SELECT 1
        FROM VatTu
        WHERE MaVT = @MaVT
    )
    BEGIN
        RAISERROR('Mã vật tư không tồn tại trong bảng VatTu.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra giá trị hợp lệ cho LoaiVT
    IF @LoaiVT NOT IN (N'Dụng Cụ', N'Thuốc Men')
    BEGIN
        RAISERROR('Loại vật tư không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra giá trị hợp lệ cho TrangThaiVT
    IF @TrangThaiVT NOT IN (0, 1)
    BEGIN
        RAISERROR('Trạng thái vật tư không hợp lệ, chỉ nhận 1(còn sử dụng) hoặc 0(Ngưng sử dụng).', 16, 1);
        RETURN;
    END;

    -- Cập nhật thông tin vật tư trong bảng VatTu
    UPDATE VatTu
    SET DonGia = @DonGia,
        DacTa = @DacTa,
        LoaiVT = @LoaiVT,
        TrangThaiVT = COALESCE(@TrangThaiVT, TrangThaiVT)
    WHERE MaVT = @MaVT;

END;
GO
/****** Object:  StoredProcedure [dbo].[SP_CreateHospitalLogin]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CreateHospitalLogin]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(50),
  @ROLE VARCHAR(50)
AS
BEGIN
  SET NOCOUNT ON;

  -- Kiểm tra trùng lặp của login
  IF EXISTS (SELECT 1 FROM sys.syslogins WHERE name = @LGNAME)
  BEGIN
    --PRINT N'Tên đăng nhập đã tồn tại.';
	RAISERROR('Tên đăng nhập đã tồn tại.', 16, 1)
    RETURN;
  END;

  -- Kiểm tra trùng lặp của username
  IF EXISTS (SELECT 1 FROM sys.sysusers WHERE name = @USERNAME)
  BEGIN
   -- PRINT N'Username đã tồn tại.';
	RAISERROR('Username đã tồn tại.', 16, 1)
    RETURN;
  END;

  -- Thêm login
  EXEC SP_ADDLOGIN @LGNAME, @PASS, 'HOSPITAL';

  -- Kiểm tra thành công thêm login
  IF (@@ERROR <> 0)
  BEGIN
    --PRINT N'Thêm tên đăng nhập không thành công.';
	RAISERROR('Thêm tên đăng nhập không thành công.', 16, 1)
    RETURN;
  END;

  -- Thêm user vào cơ sở dữ liệu
  EXEC SP_GRANTDBACCESS @LGNAME, @USERNAME;

  -- Kiểm tra thành công thêm user
  IF (@@ERROR <> 0)
  BEGIN
    -- Xóa login đã tạo nếu thất bại
    EXEC SP_DROPLOGIN @LGNAME;
    --PRINT N'Thêm user không thành công.';
	RAISERROR('Thêm user không thành công.', 16, 1)
    RETURN;
  END;

  -- Thêm vai trò cho user
  EXEC sp_addrolemember @ROLE, @USERNAME;

  -- Thêm vai trò 'SecurityAdmin' cho login nếu role là 'Admin_Hospital_Role'
  IF @ROLE = 'Admin_Hospital_Role' 
  BEGIN 
    EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin';
	EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
  END;

  IF @ROLE = 'Head_Nurse_Role'
  BEGIN
	EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin';

  END;
  --PRINT N'Tên đăng nhập và user đã thêm thành công.';
  --RETURN 0;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_RestoreHospitalDatabase]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_RestoreHospitalDatabase]
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @BackupPath NVARCHAR(255) = 'C:\SQLBackups\Hospital.bak';
    DECLARE @DatabaseName NVARCHAR(128) = 'HOSPITAL';

    -- Thực hiện restore database
    RESTORE DATABASE @DatabaseName
    FROM DISK = @BackupPath
    WITH REPLACE;

    -- Hiển thị thông báo khi restore thành công
    PRINT 'Restore database HOSPITAL thành công.';
END
GO
/****** Object:  StoredProcedure [dbo].[SP_RestoreHospitalDatabase2]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_RestoreHospitalDatabase2]
	@BackupPath NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @DatabaseName NVARCHAR(128) = 'HOSPITAL';

    -- Kiểm tra xem tệp backup tồn tại hay không
    IF NOT EXISTS (SELECT 1 FROM sys.sysdevices WHERE name = 'HospitalBackupDevice')
    BEGIN
        -- Thiết bị backup chưa được tạo, thông báo lỗi
        RAISERROR(N'Thiết bị backup HospitalBackupDevice chưa được tạo.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra xem database đã tồn tại hay chưa
    IF DB_ID(@DatabaseName) IS NULL
    BEGIN
        -- Database chưa tồn tại, thông báo lỗi
        RAISERROR(N'Database HOSPITAL chưa tồn tại.', 16, 1);
        RETURN;
    END;

    -- Đóng kết nối đến database nếu đang mở
    IF DB_ID(@DatabaseName) <> DB_ID()
    BEGIN
        ALTER DATABASE HOSPITAL SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    END;

    -- Khôi phục database từ tệp backup
    RESTORE DATABASE HOSPITAL
    FROM DISK = @BackupPath
    WITH REPLACE;

    -- Mở kết nối đến database
    ALTER DATABASE HOSPITAL SET MULTI_USER;
            
    -- Hiển thị thông báo khi khôi phục thành công
    PRINT 'Khôi phục database HOSPITAL thành công.';
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectBacSi]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectBacSi]
    @MaNV varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 FROM vw_ThongTinBacSi WHERE [Mã Bác Sĩ]= @MaNV)
    BEGIN
        -- MaBSi không tồn tại, thông báo lỗi
        RAISERROR('Không có Bác sĩ này', 16, 1);
        RETURN;
    END

    SELECT nv.[Mã Bác Sĩ], nv.[Tên Bác Sĩ], nv.[Chuyên Môn] , nv.Phái, nv.SDT, nv.CCCD
    FROM vw_ThongTinBacSi nv
    WHERE nv.[Mã Bác Sĩ] = @MaNV;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectBenhNhan]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectBenhNhan]
    @MaBN varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 FROM vw_ThongTinBenhNhanDangDieuTri WHERE [Mã BN]= @MaBN)
    BEGIN
        -- MaBSi không tồn tại, thông báo lỗi
        RAISERROR('Không có bệnh nhân này', 16, 1);
        RETURN;
    END

    SELECT *
    FROM vw_ThongTinBenhNhanDangDieuTri bn
    WHERE bn.[Mã BN] = @MaBN;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectBenhNhan_All]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectBenhNhan_All]
    @MaBN varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 FROM BenhNhan WHERE MaBN= @MaBN)
    BEGIN
        -- MaBSi không tồn tại, thông báo lỗi
        RAISERROR('Không có bệnh nhân này', 16, 1);
        RETURN;
    END

    SELECT *
    FROM BenhNhan bn
    WHERE bn.MaBN = @MaBN;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectBenhNhanNgoaiTru]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_SelectBenhNhanNgoaiTru]
    @MaBN varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 FROM vw_ThongTinBenhNhanNgoaiTru WHERE [Mã BN] = @MaBN)
    BEGIN
        -- MaBSi không tồn tại, thông báo lỗi
        RAISERROR('Không có bệnh nhân này', 16, 1);
        RETURN;
    END

    SELECT *
    FROM vw_ThongTinBenhNhanNgoaiTru bn
    WHERE bn.[Mã BN] = @MaBN;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectBenhNhanNoiTru]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectBenhNhanNoiTru]
    @MaBN varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 FROM vw_ThongTinBenhNhanNoiTru WHERE [Mã BN] = @MaBN)
    BEGIN
        -- MaBSi không tồn tại, thông báo lỗi
        RAISERROR('Không có bệnh nhân này', 16, 1);
        RETURN;
    END

    SELECT *
    FROM vw_ThongTinBenhNhanNoiTru bn
    WHERE bn.[Mã BN] = @MaBN;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectCuocDieuTri]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_SelectCuocDieuTri]
	@ID_CDT varchar(10)
AS
BEGIN
	SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 FROM vw_CuocDieuTri_All WHERE ID_CDT = @ID_CDT )
	BEGIN
		
        -- ID_CDT không tồn tại, thông báo lỗi
        RAISERROR('Không có cuộc điều trị này', 16, 1);
        RETURN;
    END

    SELECT *
    FROM vw_CuocDieuTri_All cdt
    WHERE cdt.ID_CDT = @ID_CDT;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectGiuong]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectGiuong]
    @MaGiuong varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 FROM vw_Giuong WHERE [Mã Giường] = @MaGiuong)
    BEGIN
        -- MaGiuong không tồn tại, thông báo lỗi
        RAISERROR('MaGiuong này không đúng', 16, 1);
        RETURN;
    END

    SELECT *
    FROM vw_Giuong g
    WHERE g.[Mã Giường] = @MaGiuong;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectKhuChuaTri]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectKhuChuaTri]
    @MaKhuCT varchar(10)
AS
BEGIN
    -- Kiểm tra MaKhuCT có tồn tại trong bảng KhuChuaTri
    IF NOT EXISTS (
        SELECT 1
        FROM KhuChuaTri
        WHERE MaKhuCT = @MaKhuCT
    )
    BEGIN
        -- MaKhuCT không tồn tại trong bảng KhuChuaTri, thông báo lỗi
        RAISERROR('Mã Khu Chữa Trị không tồn tại', 16, 1);
        RETURN;
    END

    -- Lấy thông tin Khu Chữa Trị
    SELECT *
    FROM KhuChuaTri
    WHERE MaKhuCT = @MaKhuCT;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectNV]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectNV]
    @MaNV varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT nv.[Mã Nhân Viên], nv.[Họ tên], nv.[Chức vụ], nv.[Phái], nv.SDT, nv.CCCD
    FROM vw_ThongTinNhanVien nv
    WHERE nv.[Mã Nhân Viên] = @MaNV;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectPhong_CHD]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectPhong_CHD]
    @MaPhong varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 FROM vw_Phong_ConHoatDong WHERE [Mã Phòng] = @MaPhong)
    BEGIN
        -- MaPhong không tồn tại, thông báo lỗi
        RAISERROR('Không có Phòng này', 16, 1);
        RETURN;
    END

    SELECT *
    FROM vw_Phong_ConHoatDong p
    WHERE p.[Mã Phòng] = @MaPhong;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectPhong_NHD]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectPhong_NHD]
    @MaPhong varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 FROM vw_Phong_DaNgungHoatDong WHERE [Mã Phòng] = @MaPhong)
    BEGIN
        -- MaPhong không tồn tại, thông báo lỗi
        RAISERROR('Không có Phòng này', 16, 1);
        RETURN;
    END

    SELECT *
    FROM vw_Phong_DaNgungHoatDong p
    WHERE p.[Mã Phòng] = @MaPhong;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectSDVT_All]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_SelectSDVT_All]
    @ID_SDVT varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 FROM vw_SDVT_All WHERE ID_SDVT= @ID_SDVT)
    BEGIN
        -- ID_SDVT không tồn tại, thông báo lỗi
        RAISERROR('Không tồn tại ID_SDVT này', 16, 1);
        RETURN;
    END

    SELECT *
    FROM vw_SDVT_All sdvt
    WHERE sdvt.ID_SDVT = @ID_SDVT;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectSDVT_BN_ChuaXuatVien]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectSDVT_BN_ChuaXuatVien]
    @ID_SDVT varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 FROM vw_SDVT_BN_ChuaXuatVien WHERE ID_SDVT= @ID_SDVT)
    BEGIN
        -- ID_SDVT không tồn tại, thông báo lỗi
        RAISERROR('Không có ID_SDVT này', 16, 1);
        RETURN;
    END

    SELECT *
    FROM vw_SDVT_BN_ChuaXuatVien sdvt
    WHERE sdvt.ID_SDVT = @ID_SDVT;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectSuChuaTri]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectSuChuaTri]
	@MaCT varchar(10)
AS
BEGIN
	SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 FROM vw_SuChuaTri WHERE [Mã sự chữa trị] = @MaCT)
	BEGIN
		
        -- MaBSi không tồn tại, thông báo lỗi
        RAISERROR('Không có sự chữa trị này', 16, 1);
        RETURN;
    END

    SELECT sct.[Mã sự chữa trị], sct.[Tên sự chữa trị]
    FROM vw_SuChuaTri sct
    WHERE sct.[Mã sự chữa trị] = @MaCT;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectSuChuaTri_Deleted]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectSuChuaTri_Deleted]
	@MaCT varchar(10)
AS
BEGIN
	SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 FROM vw_SuChuaTri_Deleted WHERE [Mã sự chữa trị] = @MaCT)
	BEGIN
		
        -- MaBSi không tồn tại, thông báo lỗi
        RAISERROR('Không có sự chữa trị này', 16, 1);
        RETURN;
    END

    SELECT sct.[Mã sự chữa trị], sct.[Tên sự chữa trị]
    FROM vw_SuChuaTri_Deleted sct
    WHERE sct.[Mã sự chữa trị] = @MaCT;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectTKGL]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------
CREATE PROCEDURE [dbo].[sp_SelectTKGL]
    @MaNV varchar(10),
	@MaKhu varchar(10)
AS
BEGIN
    IF NOT EXISTS (
        SELECT 1
        FROM NhanVien
        WHERE MaNV = @MaNV
    )
    BEGIN
        -- MaNV không tồn tại trong bảng NhanVien, thông báo lỗi
        RAISERROR('Mã Nhân Viên không tồn tại', 16, 1);
        RETURN;
    END

    -- Kiểm tra MaKhu có tồn tại trong bảng KhuChuaTri
    IF NOT EXISTS (
        SELECT 1
        FROM KhuChuaTri
        WHERE MaKhuCT = @MaKhu
    )
    BEGIN
        -- MaKhu không tồn tại trong bảng KhuChuaTri, thông báo lỗi
        RAISERROR('Mã Khu không tồn tại', 16, 1);
        RETURN;
    END

	IF NOT EXISTS (
        SELECT 1
        FROM ThongKeGioLam
        WHERE MaNV = @MaNV AND MaKhu = @MaKhu
    )
    BEGIN
        -- Cặp giá trị MaNV và MaKhu đã tồn tại, thông báo lỗi
        RAISERROR('Cặp MaNV và MaKhu không tồn tại trong bảng ThongKeGioLam', 16, 1);
        RETURN;
    END

    -- Lấy thông tin Khu Chữa Trị
    SELECT *
    FROM ThongKeGioLam
    WHERE MaNV = @MaNV AND MaKhu = @MaKhu;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_SelectVatTu]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectVatTu]
    @MaVT varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra MaVT có tồn tại trong bảng VatTu
    IF NOT EXISTS (
        SELECT 1
        FROM VatTu
        WHERE MaVT = @MaVT
    )
    BEGIN
        RAISERROR('Mã vật tư không tồn tại trong bảng VatTu.', 16, 1);
        RETURN;
    END;

    -- Truy vấn dữ liệu
    SELECT *
    FROM vw_VatTuDangDuocSuDung vt
    WHERE vt.[Mã Vật Tư] = @MaVT;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_SelectYTa]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectYTa]
    @MaNV varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 FROM vw_ThongTinYTa WHERE [Mã Y Tá]= @MaNV)
    BEGIN
        -- MaBSi không tồn tại, thông báo lỗi
        RAISERROR('Không có Y Tá này', 16, 1);
        RETURN;
    END

    SELECT nv.[Mã Y Tá], nv.[Tên Y Tá], nv.[Vị trí công việc] , nv.Phái, nv.SDT, nv.CCCD
    FROM vw_ThongTinYTa nv
    WHERE nv.[Mã Y Tá] = @MaNV;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemMoiBenhNhan]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ThemMoiBenhNhan]
    @TenBN nvarchar(30),
    @NgSinh date,
	@CCCD nvarchar(30),
    @MaBSiTheoDoi varchar(10),
    @MaBSiTiepNhan varchar(10),
    @HinhThucKham nvarchar(20)
AS
BEGIN
    DECLARE @MaBN varchar(10);

    -- Tạo mã bệnh nhân tự động
    SET @MaBN = 'BN' + RIGHT('000' + CAST((ISNULL((SELECT MAX(CAST(RIGHT(MaBN, 3) AS int)) FROM BenhNhan), 0) + 1) AS varchar(3)), 3);

    -- Kiểm tra ngày sinh hợp lệ
    IF @NgSinh >= GETDATE()
    BEGIN
        -- Ngày sinh không hợp lệ, thông báo lỗi
        RAISERROR('Ngày sinh không hợp lệ', 16, 1);
        RETURN;
    END

    -- Kiểm tra xem MaBSiTheoDoi có tồn tại và hợp lệ hay không
    IF NOT EXISTS (
        SELECT 1
        FROM NhanVien
        WHERE MaNV = @MaBSiTheoDoi AND ChucVu = N'Bác Sĩ' AND isActive = 1
    )
    BEGIN
        -- MaBSiTheoDoi không tồn tại hoặc không hợp lệ, thông báo lỗi
        RAISERROR('Mã Bác sĩ theo dõi không tồn tại hoặc không hợp lệ', 16, 1);
        RETURN;
    END

    -- Kiểm tra xem MaBSiTiepNhan có tồn tại và hợp lệ hay không
    IF NOT EXISTS (
        SELECT 1
        FROM NhanVien
        WHERE MaNV = @MaBSiTiepNhan AND ChucVu = N'Bác Sĩ' AND isActive = 1
    )
    BEGIN
        -- MaBSiTiepNhan không tồn tại hoặc không hợp lệ, thông báo lỗi
        RAISERROR('Mã Bác sĩ tiếp nhận không tồn tại hoặc không hợp lệ', 16, 1);
        RETURN;
    END

    -- Kiểm tra hình thức khám hợp lệ
    IF @HinhThucKham NOT IN (N'Nội Trú', N'Ngoại Trú')
    BEGIN
        -- Hình thức khám không hợp lệ, thông báo lỗi
        RAISERROR('Hình thức khám chỉ được là Nội Trú hoặc Ngoại Trú', 16, 1);
        RETURN;
    END


    -- Kiểm tra CCCD
    IF (LEN(@CCCD) <> 12 OR @CCCD NOT LIKE REPLICATE('[0-9]', 12))
    BEGIN
        RAISERROR('CCCD không hợp lệ.', 16, 1);
        RETURN;
    END;


	IF EXISTS (
        SELECT 1
        FROM BenhNhan
        WHERE CCCD = @CCCD
    )
    BEGIN
        -- MaYTaTruong đã tồn tại trong bảng KhuChuaTri, thông báo lỗi
        RAISERROR('CCCD này đã tồn tại', 16, 1);
        RETURN;
    END


    -- Thêm mới bệnh nhân vào bảng BenhNhan
    INSERT INTO BenhNhan (MaBN, TenBN, NgSinh, CCCD, MaBSiTheoDoi, MaBSiTiepNhan, HinhThucKham)
    VALUES (@MaBN, @TenBN, @NgSinh, @CCCD, @MaBSiTheoDoi, @MaBSiTiepNhan, @HinhThucKham);

END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemMoiCuocDieuTri]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ThemMoiCuocDieuTri]
    @MaBSi varchar(10),
    @MaBN varchar(10),
    @MaCT varchar(20),
    @ThGian int,
    @Ngay date,
    @KetQua nvarchar(100)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ID_CDT varchar(10);
    -- Sinh tự động ID_CDT
	SET @ID_CDT = 'CDT' + RIGHT('000' +CAST((ISNULL((SELECT MAX(CAST(RIGHT(ID_CDT, 3) AS int)) FROM CuocDieuTri), 0) + 1) AS varchar(3)),3);

    -- Kiểm tra MaBSi có là Bác Sĩ và isActive = 1
    IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaNV = @MaBSi)
	BEGIN
		RAISERROR('Không tồn tại MaBSi này.', 16, 1);
		RETURN;
	END;
	ELSE
	BEGIN
		IF (SELECT ChucVu FROM NhanVien WHERE MaNV = @MaBSi) <> N'Bác Sĩ'
		BEGIN
			RAISERROR('Đây không phải là Bác sĩ.', 16, 1);
			RETURN;
		END;
		ELSE IF (SELECT isActive FROM NhanVien WHERE MaNV = @MaBSi) = 0
		BEGIN
			RAISERROR('Bác Sĩ này không còn làm việc.', 16, 1);
			RETURN;
		END;
	END;


    -- Kiểm tra MaBN và TrangThai của bệnh nhân
	IF NOT EXISTS (SELECT 1 FROM BenhNhan WHERE MaBN = @MaBN)
	BEGIN
		RAISERROR('Mã bệnh nhân không tồn tại.', 16, 1);
		RETURN;
	END;
	ELSE
	BEGIN
		IF (SELECT TrangThai FROM BenhNhan WHERE MaBN = @MaBN) = 0
		BEGIN
			RAISERROR('Bệnh nhân đã xuất viện.', 16, 1);
			RETURN;
		END;
	END;


    -- Kiểm tra MaCT và TrangThai của sự chữa trị
	IF NOT EXISTS (SELECT 1 FROM SuChuaTri WHERE MaCT = @MaCT)
	BEGIN
		RAISERROR('Mã sự chữa trị không tồn tại.', 16, 1);
		RETURN;
	END;
	ELSE
	BEGIN
		IF (SELECT TrangThai FROM SuChuaTri WHERE MaCT = @MaCT) = 0
		BEGIN
			RAISERROR('Sự chữa trị đã ngừng.', 16, 1);
			RETURN;
		END;
	END;


    -- Kiểm tra ngày hợp lệ (trước ngày hiện tại)
    IF @Ngay >= CONVERT(date, GETDATE())
    BEGIN
        RAISERROR('Ngày không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Thêm mới cuộc điều trị
    INSERT INTO CuocDieuTri (ID_CDT, MaBSi, MaBN, MaCT, ThGian, Ngay, KetQua)
    VALUES (@ID_CDT, @MaBSi, @MaBN, @MaCT, @ThGian, @Ngay, @KetQua);
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemMoiGiuong]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ThemMoiGiuong]
    @MaPhong varchar(10),
    @MaKhu varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

	-- Tạo MaGiuong mới
    DECLARE @MaGiuong varchar(10);
    SET @MaGiuong = 'G' + RIGHT('000' + CAST((SELECT MAX(RIGHT(MaGiuong, 3)) FROM Giuong) + 1 AS varchar(3)), 3);

	-- Kiểm tra MaPhong có tồn tại trong bảng Phong và có TrangThaiP là 1
	IF NOT EXISTS (
		SELECT 1
		FROM Phong
		WHERE MaPhong = @MaPhong
	)
	BEGIN
		RAISERROR('Phòng này không tồn tại.', 16, 1);
		RETURN;
	END;

	IF EXISTS (
		SELECT 1
		FROM Phong
		WHERE MaPhong = @MaPhong AND TrangThaiP = 0
	)
	BEGIN
		RAISERROR('Phòng này hiện đã ngừng hoạt động.', 16, 1);
		RETURN;
	END;


    -- Kiểm tra MaKhu có tồn tại trong bảng KhuChuaTri
    IF NOT EXISTS (
        SELECT 1
        FROM KhuChuaTri
        WHERE MaKhuCT = @MaKhu
    )
    BEGIN
        RAISERROR('Mã khu chữa trị không tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra MaPhong và MaKhu có tồn tại trong bảng Phong
	IF NOT EXISTS (
        SELECT 1
        FROM Phong
        WHERE MaPhong = @MaPhong AND MaKhuCT = @MaKhu
    )
    BEGIN
        RAISERROR('Phòng vừa nhập không nằm trong Khu chữa trị vừa nhập. Hãy kiểm tra lại.', 16, 1);
        RETURN;
    END;
    -- Thêm mới giường vào bảng Giuong
    INSERT INTO Giuong (MaGiuong, MaPhong, MaKhu)
    VALUES (@MaGiuong, @MaPhong, @MaKhu);

END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemMoiKhuChuaTri]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ThemMoiKhuChuaTri]
    @TenKhuCT nvarchar(20),
    @MaYTaTruong varchar(10)
AS
BEGIN
	--Kiểm tra Tên khu chữa trị
	IF EXISTS (
        SELECT 1
        FROM KhuChuaTri
        WHERE TenKhuCT = @TenKhuCT
    )
    BEGIN
        -- MaYTaTruong đã tồn tại trong bảng KhuChuaTri, thông báo lỗi
        RAISERROR('Tên Khu Chữa Trị này đã tồn tại', 16, 1);
        RETURN;
    END

    -- Kiểm tra MaYTaTruong có tồn tại trong bảng KhuChuaTri
    IF EXISTS (
        SELECT 1
        FROM KhuChuaTri
        WHERE MaYTaTruong = @MaYTaTruong
    )
    BEGIN
        -- MaYTaTruong đã tồn tại trong bảng KhuChuaTri, thông báo lỗi
        RAISERROR('Mã Y Tá Trưởng này đã tồn tại', 16, 1);
        RETURN;
    END
    -- Kiểm tra MaYTaTruong có trùng với MaYTa trong bảng YTa
    IF NOT EXISTS (
        SELECT 1
        FROM YTa
        WHERE MaYTa = @MaYTaTruong
    )
    BEGIN
        -- MaYTaTruong không tồn tại trong bảng YTa, thông báo lỗi
        RAISERROR('Đây không phải Y Tá', 16, 1);
        RETURN;
    END

    -- Kiểm tra MaYTaTruong có ViTriCongViec là 'Y Tá Chính' hay không
    IF NOT EXISTS (
        SELECT 1
        FROM YTa
        WHERE MaYTa = @MaYTaTruong AND ViTriCongViec = 'Y Tá Chính'
    )
    BEGIN
        -- MaYTaTruong không có ViTriCongViec là 'Y Tá Chính', thông báo lỗi
        RAISERROR('Đây không phải Y Tá Chính', 16, 1);
        RETURN;
    END

    -- Lấy giá trị lớn nhất của MaKhuCT trong bảng KhuChuaTri
    DECLARE @MaxMaKhuCT varchar(10);
    SELECT @MaxMaKhuCT = MAX(MaKhuCT)
    FROM KhuChuaTri;

    -- Sinh mã mới cho MaKhuCT
    DECLARE @NewMaKhuCT varchar(10);
    SET @NewMaKhuCT = 'KCT' + RIGHT('00' + CAST(RIGHT(@MaxMaKhuCT, 2) + 1 AS varchar(2)), 2);

    -- Thêm mới khu chữa trị vào bảng KhuChuaTri
    INSERT INTO KhuChuaTri (MaKhuCT, TenKhuCT, MaYTaTruong)
    VALUES (@NewMaKhuCT, @TenKhuCT, @MaYTaTruong);
  
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemMoiNV]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ThemMoiNV]
    @TenNV nvarchar(30),
    @ChucVu nvarchar(20),
    @Phai nvarchar(5),
    @SDT varchar(30),
    @CCCD varchar(30)
AS
BEGIN
    DECLARE @NewMaNV varchar(10);
    DECLARE @IsSuccess bit = 0; -- Biến tạm để kiểm tra trạng thái thêm mới nhân viên

    -- Kiểm tra chức vụ
    IF (@ChucVu <> N'Bác Sĩ' AND @ChucVu <> N'Y Tá')
    BEGIN
        RAISERROR('Chức vụ không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra số điện thoại
    IF (LEN(@SDT) <> 10 OR @SDT NOT LIKE '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
    BEGIN
        RAISERROR('Số điện thoại không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra CCCD
    IF (LEN(@CCCD) <> 12 OR @CCCD NOT LIKE REPLICATE('[0-9]', 12))
    BEGIN
        RAISERROR('CCCD không hợp lệ.', 16, 1);
        RETURN;
    END;


	IF EXISTS (
        SELECT 1
        FROM NhanVien
        WHERE CCCD = @CCCD
    )
    BEGIN
        -- MaYTaTruong đã tồn tại trong bảng KhuChuaTri, thông báo lỗi
        RAISERROR('CCCD này đã tồn tại', 16, 1);
        RETURN;
    END




    -- Tìm giá trị lớn nhất của MaNV trong bảng NhanVien
    SELECT @NewMaNV = MAX(MaNV) FROM NhanVien;

    -- Tăng MaNV lên 1 đơn vị
    SET @NewMaNV = 'NV' + RIGHT('000' + CAST((RIGHT(@NewMaNV, LEN(@NewMaNV) - 2) + 1) AS varchar(3)), 3);

    -- Thêm mới nhân viên vào bảng NhanVien
    BEGIN TRY
        BEGIN TRANSACTION;
        INSERT INTO NhanVien (MaNV, TenNV, ChucVu, Phai, SDT, CCCD)
        VALUES (@NewMaNV, @TenNV, @ChucVu, @Phai, @SDT, @CCCD);
        SET @IsSuccess = 1; -- Gán giá trị thành công cho biến tạm
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrorMessage, 16, 1);
        RETURN;
    END CATCH;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemMoiPhong]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ThemMoiPhong]
    @MaKhuCT varchar(10),
    @TenPhong nvarchar(100)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @MaPhong varchar(10);

    -- Sinh tự động MaPhong
    SET @MaPhong = 'P' + RIGHT('000' + CAST((ISNULL((SELECT MAX(CAST(RIGHT(MaPhong, 3) AS int)) FROM Phong), 0) + 1) AS varchar(3)), 3);

    -- Kiểm tra MaKhuCT có tồn tại trong bảng KhuChuaTri
    IF NOT EXISTS (SELECT 1 FROM KhuChuaTri WHERE MaKhuCT = @MaKhuCT)
    BEGIN
        RAISERROR('Mã khu chữa trị không tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra TenPhong không trùng với tên đã có trong bảng Phong
    IF EXISTS (SELECT 1 FROM Phong WHERE TenPhong = @TenPhong)
    BEGIN
        RAISERROR('Tên phòng đã tồn tại.', 16, 1);
        RETURN;
    END;

    -- Thêm mới phòng
    INSERT INTO Phong (MaPhong, MaKhuCT, TenPhong)
    VALUES (@MaPhong, @MaKhuCT, @TenPhong);
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemMoiThongKeGioLam]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ThemMoiThongKeGioLam]
    @MaNV varchar(10),
    @MaKhu varchar(10),
    @SoGioLV int
AS
BEGIN
    -- Kiểm tra MaNV có tồn tại trong bảng NhanVien
	IF NOT EXISTS (
		SELECT 1
		FROM NhanVien
		WHERE MaNV = @MaNV
	)
	BEGIN
		-- MaNV không tồn tại, thông báo lỗi
		RAISERROR('Mã Nhân Viên không tồn tại', 16, 1);
		RETURN;
	END
	ELSE
	BEGIN
		-- MaNV tồn tại, kiểm tra trạng thái isActive
		IF EXISTS (
			SELECT 1
			FROM NhanVien
			WHERE MaNV = @MaNV AND isActive = 0
		)
		BEGIN
			-- Nhân viên đã nghỉ việc, thông báo lỗi
			RAISERROR('Nhân viên đã nghỉ việc', 16, 1);
			RETURN;
		END
	END


    -- Kiểm tra MaKhu có tồn tại trong bảng KhuChuaTri
    IF NOT EXISTS (
        SELECT 1
        FROM KhuChuaTri
        WHERE MaKhuCT = @MaKhu
    )
    BEGIN
        -- MaKhu không tồn tại trong bảng KhuChuaTri, thông báo lỗi
        RAISERROR('Mã Khu không tồn tại', 16, 1);
        RETURN;
    END

    -- Kiểm tra xem cặp giá trị MaNV và MaKhu đã tồn tại trong bảng ThongKeGioLam chưa
    IF EXISTS (
        SELECT 1
        FROM ThongKeGioLam
        WHERE MaNV = @MaNV AND MaKhu = @MaKhu
    )
    BEGIN
        -- Cặp giá trị MaNV và MaKhu đã tồn tại, thông báo lỗi
        RAISERROR('Cặp MaNV và MaKhu đã tồn tại trong bảng ThongKeGioLam', 16, 1);
        RETURN;
    END

    -- Thêm mới dữ liệu vào bảng ThongKeGioLam
    INSERT INTO ThongKeGioLam (MaNV, MaKhu, SoGioLV)
    VALUES (@MaNV, @MaKhu, @SoGioLV);

END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemSuChuaTri]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------------------
CREATE PROCEDURE [dbo].[sp_ThemSuChuaTri]
    @Ten nvarchar(100)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @MaxMaCT varchar(20);
    DECLARE @NewMaCT varchar(20);

    -- Lấy giá trị MaCT lớn nhất từ bảng
    SELECT @MaxMaCT = MAX(MaCT)
    FROM SuChuaTri;

    -- Tạo giá trị MaCT mới
    SET @NewMaCT = 'CT' + RIGHT('00' + CAST(CAST(SUBSTRING(@MaxMaCT, 3, LEN(@MaxMaCT)) AS int) + 1 AS varchar(2)), 2);

    -- Thêm mới sự chữa trị vào bảng SuChuaTri
    INSERT INTO SuChuaTri (MaCT, Ten)
    VALUES (@NewMaCT, @Ten);

END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemSuDungVatTu]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ThemSuDungVatTu]
    @MaBN varchar(10),
    @MaVT varchar(10),
    @NgaySD date,
    @ThGian int,
    @SoLuong int
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @MaxID_SDVT int;
    DECLARE @NewID_SDVT varchar(10);

    -- Kiểm tra MaBN có tồn tại trong bảng BenhNhan
    IF NOT EXISTS (
        SELECT 1
        FROM BenhNhan
        WHERE MaBN = @MaBN
    )
    BEGIN
        RAISERROR('Mã bệnh nhân không tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra TrangThai của bệnh nhân
    DECLARE @TrangThaiBN bit;
    SET @TrangThaiBN = (
        SELECT TrangThai
        FROM BenhNhan
        WHERE MaBN = @MaBN
    );

    IF @TrangThaiBN = 0
    BEGIN
        RAISERROR('Bệnh nhân đã xuất viện, không thể thêm sử dụng vật tư.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra MaVT có tồn tại trong bảng VatTu
    IF NOT EXISTS (
        SELECT 1
        FROM VatTu
        WHERE MaVT = @MaVT
    )
    BEGIN
        RAISERROR('Mã vật tư không tồn tại', 16, 1);
        RETURN;
    END;

    -- Kiểm tra TrangThaiVT của vật tư
    DECLARE @TrangThaiVT bit;
    SET @TrangThaiVT = (
        SELECT TrangThaiVT
        FROM VatTu
        WHERE MaVT = @MaVT
    );

    IF @TrangThaiVT = 0
    BEGIN
        RAISERROR('Vật tư này đã ngừng sử dụng.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra NgaySD hợp lệ
    IF @NgaySD > GETDATE()
    BEGIN
        RAISERROR('Ngày sử dụng không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Lấy giá trị lớn nhất của ID_SDVT
    SET @MaxID_SDVT = (
        SELECT MAX(CAST(RIGHT(ID_SDVT, 3) AS int))
        FROM SuDungVatTu
    );

    -- Tạo mã mới cho ID_SDVT
    SET @NewID_SDVT = 'SDVT' + RIGHT('000' + CAST(ISNULL(@MaxID_SDVT, 0) + 1 AS varchar(3)), 3);

    -- Thêm mới vào bảng SuDungVatTu
    INSERT INTO SuDungVatTu (ID_SDVT, MaBN, MaVT, NgaySD, ThGian, SoLuong)
    VALUES (@NewID_SDVT, @MaBN, @MaVT, @NgaySD, @ThGian, @SoLuong);
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemVatTu]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ThemVatTu]
    @DonGia int,
    @DacTa nvarchar(100),
    @LoaiVT nvarchar(20)
AS
BEGIN
    -- Khai báo biến để lưu MaVT mới
    DECLARE @MaVT varchar(10);

    -- Tìm MaVT lớn nhất trong bảng VatTu
    SELECT @MaVT = MAX(MaVT)
    FROM VatTu;

    -- Kiểm tra nếu không có MaVT trong bảng, gán giá trị mặc định là 'VT01'
    IF @MaVT IS NULL
        SET @MaVT = 'VT01';
    ELSE
    BEGIN
        -- Tách lấy phần số cuối cùng của MaVT
        DECLARE @SoTuDong int;
        SET @SoTuDong = CAST(RIGHT(@MaVT, 2) AS int);

        -- Tăng số tự động lên 1
        SET @SoTuDong = @SoTuDong + 1;

        -- Định dạng lại số tự động thành chuỗi 2 ký tự
        SET @MaVT = 'VT' + RIGHT('00' + CAST(@SoTuDong AS varchar(2)), 2);
    END;

    -- Kiểm tra LoaiVT
    IF @LoaiVT NOT IN (N'Dụng Cụ', N'Thuốc Men')
    BEGIN
        RAISERROR('LoaiVT chỉ được là Dụng Cụ hoặc Thuốc Men.', 16, 1);
        RETURN;
    END;

    -- Thêm mới vật tư vào bảng VatTu
    INSERT INTO VatTu (MaVT, DonGia, DacTa, LoaiVT)
    VALUES (@MaVT, @DonGia, @DacTa, @LoaiVT);

END;
GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemBacSi]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimKiemBacSi]
	@keyword NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM vw_ThongTinBacSi bs
    WHERE ( bs.[Mã Bác Sĩ] LIKE '%' + @keyword + '%'
           OR bs.[Tên Bác Sĩ] LIKE '%' + @keyword + '%'
		   OR bs.[Chức vụ]LIKE '%' + @keyword + '%'
		   OR bs.[Phái] LIKE '%' + @keyword + '%'
		   OR bs.SDT LIKE '%' + @keyword + '%'
		   OR bs.[Chuyên Môn] LIKE '%' + @keyword + '%'
		   OR bs.[CCCD] LIKE '%' + @keyword + '%')
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemBenhNhan]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimKiemBenhNhan]
	@keyword NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM vw_ThongTinBenhNhanDangDieuTri bn
    WHERE ( bn.[Mã BN] LIKE '%' + @keyword + '%'
           OR bn.[Tên BN] LIKE '%' + @keyword + '%'
		   OR bn.[Ngày sinh] LIKE '%' + @keyword + '%'
		   OR bn.[Mã BSi Theo Dõi] LIKE '%' + @keyword + '%'
		   OR bn.[Mã BSi Tiếp Nhận] LIKE '%' + @keyword + '%'
		   OR bn.[Hình thức khám] LIKE '%' + @keyword + '%'
		   OR bn.[CCCD] LIKE '%' + @keyword + '%')
END

GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemBenhNhanNgoaiTru]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimKiemBenhNhanNgoaiTru]
	@keyword NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM vw_ThongTinBenhNhanNgoaiTru bn
    WHERE ( bn.[Mã BN] LIKE '%' + @keyword + '%'
           OR bn.[Tên BN] LIKE '%' + @keyword + '%'
		   OR bn.[Ngày sinh] LIKE '%' + @keyword + '%'
		   OR bn.[Mã BSi Theo Dõi] LIKE '%' + @keyword + '%'
		   OR bn.[Mã BSi Tiếp Nhận] LIKE '%' + @keyword + '%'
		   OR bn.[Mô tả bệnh] LIKE '%' + @keyword + '%'
		   OR bn.[CCCD] LIKE '%' + @keyword + '%')
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemBenhNhanNoiTru]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimKiemBenhNhanNoiTru]
	@keyword NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM vw_ThongTinBenhNhanNoiTru bn
    WHERE ( bn.[Mã BN] LIKE '%' + @keyword + '%'
           OR bn.[Tên BN] LIKE '%' + @keyword + '%'
		   OR bn.[Ngày sinh] LIKE '%' + @keyword + '%'
		   OR bn.[Mã BSi Theo Dõi] LIKE '%' + @keyword + '%'
		   OR bn.[Mã BSi Tiếp Nhận] LIKE '%' + @keyword + '%'
		   OR bn.[Mô tả bệnh] LIKE '%' + @keyword + '%'
		   OR bn.[CCCD] LIKE '%' + @keyword + '%'
		    OR bn.[Mã giường] LIKE '%' + @keyword + '%')
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemCuocDieuTri]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_TimKiemCuocDieuTri]
	@keyword NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM vw_CuocDieuTri_All cdt
    WHERE ( cdt.ID_CDT LIKE '%' + @keyword + '%'
           OR cdt.[Kết quả] LIKE '%' + @keyword + '%'
		   OR cdt.[Mã bác sĩ] LIKE '%' + @keyword + '%'
		   OR cdt.[Mã bệnh nhân] LIKE '%' + @keyword + '%'
		   OR cdt.[Mã sự chữa trị] LIKE '%' + @keyword + '%'
		   OR cdt.[Ngày điều trị] LIKE '%' + @keyword + '%'
		   OR cdt.[Tên Bác Sĩ] LIKE '%' + @keyword + '%'
		   OR cdt.[Tên bệnh nhân] LIKE '%' + @keyword + '%'
		   OR cdt.[Thời gian điều trị] LIKE '%' + @keyword + '%'
		   OR cdt.[Trạng thái điều trị] LIKE '%' + @keyword + '%'
		   OR cdt.[Tên sự chữa trị]  LIKE '%' + @keyword + '%' )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemGiuong]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimKiemGiuong]
	@keyword NVARCHAR(100)
AS
BEGIN
    SELECT g.[Mã Giường], g.[Mã Khu], g.[Mã phòng], g.[Tên Khu chữa trị], g.[Tên Phòng]
    FROM vw_Giuong g
    WHERE ( g.[Mã Giường] LIKE '%' + @keyword + '%'
           OR g.[Mã Khu] LIKE '%' + @keyword + '%'
           OR  g.[Mã phòng] LIKE '%' + @keyword + '%'
           OR g.[Tên Khu chữa trị] LIKE '%' + @keyword + '%'
		   OR g.[Tên Phòng] LIKE '%' + @keyword + '%')
END

GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemKCT]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimKiemKCT]
    @keyword NVARCHAR(100)
AS
BEGIN
    SELECT kct.[Mã Khu], kct.[Mã Y Tá Trưởng], kct.SDT, kct.[Tên Khu Chữa Trị], kct.[Tên Y Tá Trưởng]
    FROM vw_ThongTinKhuChuaTri kct
    WHERE ( kct.[Mã Khu] LIKE '%' + @keyword + '%'
           OR kct.[Mã Y Tá Trưởng] LIKE '%' + @keyword + '%'
           OR kct.SDT LIKE '%' + @keyword + '%'
           OR kct.[Tên Khu Chữa Trị] LIKE '%' + @keyword + '%'
           OR kct.[Tên Y Tá Trưởng] LIKE '%' + @keyword + '%')
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemNhanVien]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimKiemNhanVien]
    @keyword NVARCHAR(100)
AS
BEGIN
    SELECT nv.MaNV AS 'Mã Nhân Viên',
           nv.TenNV AS 'Họ tên',
           nv.ChucVu AS 'Chức vụ',
           nv.Phai AS 'Phái',
           nv.SDT,
           nv.CCCD
    FROM NhanVien nv
    WHERE nv.isActive = 1
      AND (nv.MaNV LIKE '%' + @keyword + '%'
           OR nv.TenNV LIKE '%' + @keyword + '%'
           OR nv.ChucVu LIKE '%' + @keyword + '%'
           OR nv.Phai LIKE '%' + @keyword + '%'
           OR nv.SDT LIKE '%' + @keyword + '%'
           OR nv.CCCD LIKE '%' + @keyword + '%')
END

GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemPhong]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimKiemPhong]
	@keyword NVARCHAR(100)
AS
BEGIN
    SELECT p.[Mã Phòng], p.[Mã Khu chữa trị], p.[Tên Khu chữa trị], p.[Tên phòng]
    FROM vw_Phong_ConHoatDong p
    WHERE ( p.[Mã Phòng] LIKE '%' + @keyword + '%'
           OR p.[Mã Khu chữa trị] LIKE '%' + @keyword + '%'
           OR p.[Tên Khu chữa trị] LIKE '%' + @keyword + '%'
           OR p.[Tên phòng] LIKE '%' + @keyword + '%')
END

GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemSDVT]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimKiemSDVT]
	@keyword NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM vw_SDVT_All sdvt
    WHERE ( sdvt.ID_SDVT LIKE '%' + @keyword + '%'
           OR sdvt.[Mã Vật Tư] LIKE '%' + @keyword + '%'
		   OR sdvt.[Đặc tả vật tư] LIKE '%' + @keyword + '%'
		   OR sdvt.[Mã Bệnh Nhân] LIKE '%' + @keyword + '%'
		   OR sdvt.[Tên bệnh nhân] LIKE '%' + @keyword + '%'
		   OR sdvt.[Ngày sử dụng] LIKE '%' + @keyword + '%'
		   OR sdvt.[Thời gian sử dụng] LIKE '%' + @keyword + '%'
		   OR sdvt.[Số lượng] LIKE '%' + @keyword + '%')
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemSuChuaTri]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimKiemSuChuaTri]
	@keyword NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM vw_SuChuaTri sct
    WHERE ( sct.[Mã sự chữa trị] LIKE '%' + @keyword + '%'
           OR sct.[Tên sự chữa trị]LIKE '%' + @keyword + '%')
END

GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemTKGL]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimKiemTKGL]
	@keyword NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM vw_ThongTinGioLamNV tkgl
    WHERE ( tkgl.[Mã NV] LIKE '%' + @keyword + '%'
           OR tkgl.[Tên Nhân Viên] LIKE '%' + @keyword + '%'
		   OR tkgl.[Mã Khu] LIKE '%' + @keyword + '%'
		   OR tkgl.[Tên Khu làm việc] LIKE '%' + @keyword + '%'
		   OR tkgl.[Số giờ làm việc] LIKE '%' + @keyword + '%')
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemVatTu]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimKiemVatTu]
	@keyword NVARCHAR(100)
AS
BEGIN
    SELECT vt.[Mã Vật Tư], vt.[Đơn giá], vt.[Đặc tả vật tư], vt.[Loại Vật Tư]
    FROM vw_VatTuDangDuocSuDung vt
    WHERE ( vt.[Mã Vật Tư] LIKE '%' + @keyword + '%'
           OR vt.[Đơn giá] LIKE '%' + @keyword + '%'
           OR vt.[Đặc tả vật tư] LIKE '%' + @keyword + '%'
           OR vt.[Loại Vật Tư] LIKE '%' + @keyword + '%')
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemYTa]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimKiemYTa]
	@keyword NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM vw_ThongTinYTa yt
    WHERE ( yt.[Mã Y Tá] LIKE '%' + @keyword + '%'
           OR yt.[Tên Y Tá] LIKE '%' + @keyword + '%'
		   OR yt.[Chức vụ]LIKE '%' + @keyword + '%'
		   OR yt.[Phái] LIKE '%' + @keyword + '%'
		   OR yt.SDT LIKE '%' + @keyword + '%'
		   OR yt.[Vị trí công việc] LIKE '%' + @keyword + '%'
		   OR yt.[CCCD] LIKE '%' + @keyword + '%')
END

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateBacSi]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateBacSi]
    @MaBSi VARCHAR(10),
    @ChuyenMon NVARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem MaBSi có tồn tại trong bảng BacSi không
    IF NOT EXISTS (SELECT 1 FROM BacSi WHERE MaBSi = @MaBSi)
    BEGIN
        -- MaBSi không tồn tại, thông báo lỗi
        RAISERROR('Không có Bác sĩ này', 16, 1);
        RETURN;
    END

    -- Cập nhật thông tin Bác sĩ
    UPDATE BacSi
    SET ChuyenMon = @ChuyenMon
    WHERE MaBSi = @MaBSi;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateYTa]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateYTa]
    @MaYTa VARCHAR(10),
    @ViTriCongViec NVARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem MaBSi có tồn tại trong bảng BacSi không
    IF NOT EXISTS (SELECT 1 FROM YTa WHERE MaYTa = @MaYTa)
    BEGIN
        -- MaBSi không tồn tại, thông báo lỗi
        RAISERROR('Không có Y Tá này', 16, 1);
        RETURN;
    END

    -- Cập nhật thông tin Bác sĩ
    UPDATE YTa
    SET ViTriCongViec = @ViTriCongViec
    WHERE MaYTa = @MaYTa;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaBenhNhan]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaBenhNhan]
    @MaBN varchar(10)
AS
BEGIN
    -- Đặt TrangThai của bệnh nhân từ 1 về 0
    UPDATE BenhNhan
    SET TrangThai = 0
    WHERE MaBN = @MaBN
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaCuocDieuTri]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaCuocDieuTri]
    @ID_CDT varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra ID_CDT có tồn tại
    IF NOT EXISTS (SELECT 1 FROM CuocDieuTri WHERE ID_CDT = @ID_CDT)
    BEGIN
        RAISERROR('Mã cuộc điều trị không tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra MaBN và TrangThai của bệnh nhân
    IF (SELECT TrangThai FROM BenhNhan WHERE MaBN = (SELECT MaBN FROM CuocDieuTri WHERE ID_CDT = @ID_CDT)) = 0
    BEGIN
        RAISERROR('Bệnh nhân đã xuất viện. Không thể xóa cuộc điều trị.', 16, 1);
        RETURN;
    END;

    -- Xóa cuộc điều trị
    DELETE FROM CuocDieuTri WHERE ID_CDT = @ID_CDT;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaGiuong]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaGiuong]
    @MaGiuong varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra MaGiuong có tồn tại trong bảng Giuong
    IF NOT EXISTS (
        SELECT 1
        FROM Giuong
        WHERE MaGiuong = @MaGiuong
    )
    BEGIN
        RAISERROR('Không có giường này.', 16, 1);
        RETURN;
    END;

    -- Xóa giường từ bảng Giuong
    DELETE FROM Giuong
    WHERE MaGiuong = @MaGiuong;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_XoaKhuChuaTri]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_XoaKhuChuaTri]
    @MaKhuCT varchar(10)
AS
BEGIN
    -- Kiểm tra MaKhuCT có tồn tại trong bảng KhuChuaTri
    IF NOT EXISTS (
        SELECT 1
        FROM KhuChuaTri
        WHERE MaKhuCT = @MaKhuCT
    )
    BEGIN
        -- MaKhuCT không tồn tại trong bảng KhuChuaTri, thông báo lỗi
        RAISERROR('Mã Khu Chữa Trị không tồn tại', 16, 1);
        RETURN;
    END

 
	UPDATE KhuChuaTri
    SET TrangThaiKCT = 0
    WHERE MaKhuCT = @MaKhuCT;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_XoaNhanVien]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaNhanVien]
    @MaNV varchar(10)
AS
BEGIN
    -- Kiểm tra MaNV có trùng với MaYTaTruong trong bảng KhuChuaTri hay không
    IF EXISTS (
        SELECT 1
        FROM KhuChuaTri
        WHERE MaYTaTruong = @MaNV
    )
    BEGIN
        -- Đặt MaYTaTruong về NULL
        UPDATE KhuChuaTri
        SET MaYTaTruong = NULL
        WHERE MaYTaTruong = @MaNV
    END

    -- Đặt isActive của nhân viên từ 1 về 0
    UPDATE NhanVien
    SET isActive = 0
    WHERE MaNV = @MaNV

END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaPhong]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaPhong]
    @MaPhong varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra MaPhong có tồn tại trong bảng Phong
    IF NOT EXISTS (SELECT 1 FROM Phong WHERE MaPhong = @MaPhong)
    BEGIN
        RAISERROR('Mã phòng không tồn tại.', 16, 1);
        RETURN;
    END;

	IF EXISTS (
        SELECT 1
        FROM Giuong
        WHERE MaPhong = @MaPhong
    )
    BEGIN
        -- Đặt MaYTaTruong về NULL
        UPDATE Giuong
        SET MaGiuong = NULL, MaKhu = NULL
        WHERE MaPhong = @MaPhong
    END

    -- Cập nhật TrangThaiP từ 1 về 0 để xóa phòng
    UPDATE Phong
    SET TrangThaiP = 0
    WHERE MaPhong = @MaPhong;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaSuChuaTri]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaSuChuaTri]
    @MaCT varchar(10)
AS
BEGIN
    -- Đặt TrangThai của bệnh nhân từ 1 về 0
    UPDATE SuChuaTri
    SET TrangThai = 0
    WHERE MaCT = @MaCT
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaSuDungVatTu]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaSuDungVatTu]
    @ID_SDVT varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra ID_SDVT có tồn tại trong bảng SuDungVatTu
    IF NOT EXISTS (
        SELECT 1
        FROM SuDungVatTu
        WHERE ID_SDVT = @ID_SDVT
    )
    BEGIN
        RAISERROR('Mã lần sử dụng vật tư không tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra trạng thái của bệnh nhân
    DECLARE @MaBN varchar(10);
    SET @MaBN = (
        SELECT MaBN
        FROM SuDungVatTu
        WHERE ID_SDVT = @ID_SDVT
    );

    DECLARE @TrangThai bit;
    SET @TrangThai = (
        SELECT TrangThai
        FROM BenhNhan
        WHERE MaBN = @MaBN
    );

    IF @TrangThai = 0
    BEGIN
        RAISERROR('Bệnh nhân đã xuất viện, không thể xóa.', 16, 1);
        RETURN;
    END;

    -- Xóa thông tin lần sử dụng vật tư trong bảng SuDungVatTu
    DELETE FROM SuDungVatTu
    WHERE ID_SDVT = @ID_SDVT;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaTKGL]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaTKGL]
    @MaNV varchar(10),
    @MaKhu varchar(10)
AS
BEGIN
    -- Kiểm tra xem cặp giá trị MaNV và MaKhu đã tồn tại trong bảng ThongKeGioLam chưa
    IF NOT EXISTS (
        SELECT 1
        FROM ThongKeGioLam
        WHERE MaNV = @MaNV AND MaKhu = @MaKhu
    )
    BEGIN
        -- Cặp giá trị MaNV và MaKhu không tồn tại, thông báo lỗi
        RAISERROR('Cặp MaNV và MaKhu không tồn tại trong bảng ThongKeGioLam', 16, 1);
        RETURN;
    END

    -- Xóa bản ghi từ bảng ThongKeGioLam
    DELETE FROM ThongKeGioLam
    WHERE MaNV = @MaNV AND MaKhu = @MaKhu;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_XoaVatTu]    Script Date: 7/10/2023 1:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_XoaVatTu]
    @MaVT varchar(10)
AS
BEGIN
    -- Kiểm tra MaVT có tồn tại trong bảng VatTu
    IF NOT EXISTS (
        SELECT 1
        FROM VatTu
        WHERE MaVT = @MaVT
    )
    BEGIN
        RAISERROR('Mã vật tư không tồn tại trong bảng VatTu.', 16, 1);
        RETURN;
    END;

    -- Chuyển TrangThaiVT từ 1 về 0
    UPDATE VatTu
    SET TrangThaiVT = 0
    WHERE MaVT = @MaVT;

END;
GO
USE [master]
GO
ALTER DATABASE [HOSPITAL] SET  READ_WRITE 
GO
