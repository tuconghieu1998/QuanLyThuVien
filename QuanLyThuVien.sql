USE [master]
GO
/****** Object:  Database [LibraryUpdate2]    Script Date: 1/19/2019 3:55:08 PM ******/
CREATE DATABASE [LibraryUpdate2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LibraryUpdate2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\LibraryUpdate2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LibraryUpdate2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\LibraryUpdate2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [LibraryUpdate2] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LibraryUpdate2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LibraryUpdate2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LibraryUpdate2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LibraryUpdate2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LibraryUpdate2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LibraryUpdate2] SET ARITHABORT OFF 
GO
ALTER DATABASE [LibraryUpdate2] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [LibraryUpdate2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LibraryUpdate2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LibraryUpdate2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LibraryUpdate2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LibraryUpdate2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LibraryUpdate2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LibraryUpdate2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LibraryUpdate2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LibraryUpdate2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LibraryUpdate2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LibraryUpdate2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LibraryUpdate2] SET TRUSTWORTHY ON 
GO
ALTER DATABASE [LibraryUpdate2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LibraryUpdate2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LibraryUpdate2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LibraryUpdate2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LibraryUpdate2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LibraryUpdate2] SET  MULTI_USER 
GO
ALTER DATABASE [LibraryUpdate2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LibraryUpdate2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LibraryUpdate2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LibraryUpdate2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [LibraryUpdate2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LibraryUpdate2] SET QUERY_STORE = OFF
GO
USE [LibraryUpdate2]
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
USE [LibraryUpdate2]
GO
/****** Object:  Table [dbo].[DOC_GIA]    Script Date: 1/19/2019 3:55:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOC_GIA](
	[ma_doc_gia] [int] IDENTITY(1,1) NOT NULL,
	[ho_ten] [nvarchar](50) NOT NULL,
	[cmnd] [int] NOT NULL,
	[ngay_sinh] [datetime] NOT NULL,
	[gioi_tinh] [nvarchar](20) NOT NULL,
	[email] [varchar](50) NULL,
	[dia_chi] [nvarchar](100) NOT NULL,
	[ngay_dang_ky] [datetime] NOT NULL,
	[cap_do] [int] NOT NULL,
	[hoat_dong] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_doc_gia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHUYEN_MAI]    Script Date: 1/19/2019 3:55:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHUYEN_MAI](
	[cap_do] [int] IDENTITY(0,1) NOT NULL,
	[phan_tram_khuyen_mai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cap_do] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MUON_SACH]    Script Date: 1/19/2019 3:55:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MUON_SACH](
	[ma_doc_gia] [int] NOT NULL,
	[ma_sach] [varchar](100) NOT NULL,
	[ngay_muon] [datetime] NOT NULL,
	[ma_phieu_muon_sach] [int] NOT NULL,
	[ngay_du_dinh_tra] [datetime] NOT NULL,
	[tinh_trang] [int] NOT NULL,
	[gia_muon] [int] NOT NULL,
	[discount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_doc_gia] ASC,
	[ma_sach] ASC,
	[ngay_muon] ASC,
	[ma_phieu_muon_sach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUY_DINH]    Script Date: 1/19/2019 3:55:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUY_DINH](
	[stt] [int] NOT NULL,
	[tien_phat_moi_ngay] [int] NOT NULL,
	[tien_phat_tren_mot_tuan] [int] NOT NULL,
	[so_ngay_muon_toi_da] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 1/19/2019 3:55:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[ma_sach] [varchar](100) NOT NULL,
	[ten_sach] [nvarchar](100) NOT NULL,
	[tac_gia] [nvarchar](100) NOT NULL,
	[nha_xuat_ban] [nvarchar](100) NULL,
	[nam_xuat_ban] [int] NULL,
	[ma_the_loai] [int] NOT NULL,
	[gia_sach] [float] NOT NULL,
	[gia_muon] [float] NOT NULL,
	[so_sach_con_lai] [int] NOT NULL,
	[so_luong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_sach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THE_LOAI]    Script Date: 1/19/2019 3:55:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THE_LOAI](
	[ma_the_loai] [int] IDENTITY(1,1) NOT NULL,
	[ten_the_loai] [nvarchar](50) NOT NULL,
	[ma_sach_tuong_ung] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_the_loai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRA_SACH]    Script Date: 1/19/2019 3:55:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRA_SACH](
	[ma_doc_gia] [int] NOT NULL,
	[ma_sach] [varchar](100) NOT NULL,
	[ngay_muon] [datetime] NOT NULL,
	[ma_phieu_muon_sach] [int] NOT NULL,
	[ngay_tra] [datetime] NOT NULL,
	[tien_phat] [float] NULL,
	[diem_danh_gia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_doc_gia] ASC,
	[ma_sach] ASC,
	[ngay_muon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DOC_GIA] ON 

INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (6, N'Hoàng Văn Cường', 342345, CAST(N'1999-01-01T00:00:00.000' AS DateTime), N'Nam', N'cuong@gmail', N'dfggf', CAST(N'2019-01-19T00:00:00.000' AS DateTime), 0, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (7, N'Nguyễn Văn B', 115, CAST(N'1999-01-01T00:00:00.000' AS DateTime), N'Nam', N'haha@gmail.com', N'quận 3', CAST(N'2019-01-03T00:00:00.000' AS DateTime), 1, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (8, N'Tôi là Tên Mới', 232145, CAST(N'1999-01-01T00:00:00.000' AS DateTime), N'Nam', N'hopro@gmail.com', N'quận 5', CAST(N'2018-12-28T00:00:00.000' AS DateTime), 10, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (9, N'Nguyễn Thị C', 232134, CAST(N'1997-07-15T00:00:00.000' AS DateTime), N'Nữ', N'sdfadf', N'adsf', CAST(N'2018-12-29T00:00:00.000' AS DateTime), 1, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (10, N'Nguyễn Văn XXX', 847503, CAST(N'1999-01-11T00:00:00.000' AS DateTime), N'Nam', N'd@gmail.com', N'Bình Thạnh', CAST(N'2019-01-19T00:00:00.000' AS DateTime), 1, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (11, N'Nguyễn Văn E', 22232, CAST(N'1999-01-14T00:00:00.000' AS DateTime), N'Nam', N'fdsaf', N'sdfs', CAST(N'2018-12-28T00:00:00.000' AS DateTime), 1, N'Không')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (12, N'Chu Thị Lài', 34234234, CAST(N'1999-01-10T00:00:00.000' AS DateTime), N'Nữ', N'fsdfdsf', N'Quận 10', CAST(N'2018-12-29T00:00:00.000' AS DateTime), 1, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (13, N'Trần Văn Phương', 342344324, CAST(N'1999-01-10T00:00:00.000' AS DateTime), N'Nam', N'dsfdsf', N'fdsaf', CAST(N'2018-12-28T00:00:00.000' AS DateTime), 1, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (14, N'Ngô Thị Vân', 342343, CAST(N'1999-01-11T00:00:00.000' AS DateTime), N'Nữ', N'afdsf', N'fadsf', CAST(N'2018-12-28T00:00:00.000' AS DateTime), 1, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (15, N'Hứa Văn Vũ', 12345, CAST(N'1999-01-11T00:00:00.000' AS DateTime), N'Nam', N'fasdf', N'dsaffg', CAST(N'2018-12-28T00:00:00.000' AS DateTime), 1, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (16, N'Nguyễn Văn Chiến', 4234, CAST(N'1998-12-30T00:00:00.000' AS DateTime), N'Nam', N'afsfsf', N'sdafsfs', CAST(N'2018-12-28T00:00:00.000' AS DateTime), 1, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (17, N'Lưu Thị Hoa', 3423, CAST(N'1999-01-18T00:00:00.000' AS DateTime), N'Nữ', N'sdfaf', N'dsfadf', CAST(N'2018-12-28T00:00:00.000' AS DateTime), 1, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (18, N'Trần Văn Chương', 32423, CAST(N'1999-01-18T00:00:00.000' AS DateTime), N'Nam', N'fsdafs', N'fdafs', CAST(N'2018-12-28T00:00:00.000' AS DateTime), 1, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (19, N'Nguyễn Văn Hiền', 3423432, CAST(N'2018-12-10T00:00:00.000' AS DateTime), N'Nam', N'fsa', N'dsaf', CAST(N'2018-12-28T00:00:00.000' AS DateTime), 1, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (20, N'Hoàng Văn Xuân', 432523, CAST(N'1999-01-12T00:00:00.000' AS DateTime), N'Nam', N'yrty', N'gdsfg', CAST(N'2018-12-28T00:00:00.000' AS DateTime), 2, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (21, N'Ngô Văn Kha', 45436, CAST(N'1998-12-17T00:00:00.000' AS DateTime), N'Nam', N'sfsgfa', N'gfagsagfa', CAST(N'2018-12-30T00:00:00.000' AS DateTime), 2, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (22, N'Lê Văn Nghĩa', 432432, CAST(N'1999-01-07T00:00:00.000' AS DateTime), N'Nam', N'fdsfsa', N'gfag', CAST(N'2018-12-28T00:00:00.000' AS DateTime), 1, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (23, N'Hoàng Văn Cường', 34234, CAST(N'1999-01-01T00:00:00.000' AS DateTime), N'Nam', N'dsfsdf', N'dfggf', CAST(N'2018-12-28T00:00:00.000' AS DateTime), 1, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (24, N'Nguyễn Dân Chơi', 10003454, CAST(N'1998-12-14T00:00:00.000' AS DateTime), N'Nam', N'danchoi@gmail.com', N'quận 8', CAST(N'2018-12-29T00:00:00.000' AS DateTime), 2, N'Không')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (25, N'Nguyễn Thị Ngân', 123435, CAST(N'1999-01-10T00:00:00.000' AS DateTime), N'Nữ', N'fsfsa', N'sfafsaf', CAST(N'2018-12-30T00:00:00.000' AS DateTime), 1, N'Không')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (26, N'fadfsf', 342345, CAST(N'1999-01-01T00:00:00.000' AS DateTime), N'Nam', N'fdasfaf', N'adsf', CAST(N'2018-12-30T00:00:00.000' AS DateTime), 2, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (27, N'Hoàng Văn Cường', 342345, CAST(N'1999-01-01T00:00:00.000' AS DateTime), N'Nam', N'dsfsdf', N'dfggf', CAST(N'2018-12-30T00:00:00.000' AS DateTime), 1, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (28, N'Hoàng Văn Cườn', 32423, CAST(N'1999-01-01T00:00:00.000' AS DateTime), N'Nam', N'dsfsdf', N'dfggf', CAST(N'2018-12-30T00:00:00.000' AS DateTime), 2, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (29, N'Hoàng Văn Cường', 342345, CAST(N'1999-01-01T00:00:00.000' AS DateTime), N'Nam', N'dsfsdf', N'dfggf', CAST(N'2018-12-30T00:00:00.000' AS DateTime), 1, N'Có')
INSERT [dbo].[DOC_GIA] ([ma_doc_gia], [ho_ten], [cmnd], [ngay_sinh], [gioi_tinh], [email], [dia_chi], [ngay_dang_ky], [cap_do], [hoat_dong]) VALUES (30, N'Từ Công Hiếu', 215459564, CAST(N'1998-12-29T00:00:00.000' AS DateTime), N'Nam', N'hieu@gmail.com', N'Quảng Ngãi', CAST(N'2019-01-19T00:00:00.000' AS DateTime), 1, N'Có')
SET IDENTITY_INSERT [dbo].[DOC_GIA] OFF
SET IDENTITY_INSERT [dbo].[KHUYEN_MAI] ON 

INSERT [dbo].[KHUYEN_MAI] ([cap_do], [phan_tram_khuyen_mai]) VALUES (0, 0)
INSERT [dbo].[KHUYEN_MAI] ([cap_do], [phan_tram_khuyen_mai]) VALUES (1, 5)
INSERT [dbo].[KHUYEN_MAI] ([cap_do], [phan_tram_khuyen_mai]) VALUES (2, 6)
INSERT [dbo].[KHUYEN_MAI] ([cap_do], [phan_tram_khuyen_mai]) VALUES (3, 7)
INSERT [dbo].[KHUYEN_MAI] ([cap_do], [phan_tram_khuyen_mai]) VALUES (4, 8)
INSERT [dbo].[KHUYEN_MAI] ([cap_do], [phan_tram_khuyen_mai]) VALUES (5, 9)
INSERT [dbo].[KHUYEN_MAI] ([cap_do], [phan_tram_khuyen_mai]) VALUES (6, 10)
INSERT [dbo].[KHUYEN_MAI] ([cap_do], [phan_tram_khuyen_mai]) VALUES (7, 11)
INSERT [dbo].[KHUYEN_MAI] ([cap_do], [phan_tram_khuyen_mai]) VALUES (8, 12)
INSERT [dbo].[KHUYEN_MAI] ([cap_do], [phan_tram_khuyen_mai]) VALUES (9, 13)
INSERT [dbo].[KHUYEN_MAI] ([cap_do], [phan_tram_khuyen_mai]) VALUES (10, 15)
SET IDENTITY_INSERT [dbo].[KHUYEN_MAI] OFF
INSERT [dbo].[MUON_SACH] ([ma_doc_gia], [ma_sach], [ngay_muon], [ma_phieu_muon_sach], [ngay_du_dinh_tra], [tinh_trang], [gia_muon], [discount]) VALUES (12, N'DSG00001', CAST(N'2019-01-03T00:00:00.000' AS DateTime), 1, CAST(N'2019-01-13T00:00:00.000' AS DateTime), 3, 2000, 5)
INSERT [dbo].[MUON_SACH] ([ma_doc_gia], [ma_sach], [ngay_muon], [ma_phieu_muon_sach], [ngay_du_dinh_tra], [tinh_trang], [gia_muon], [discount]) VALUES (15, N'DSG00001', CAST(N'2019-01-03T00:00:00.000' AS DateTime), 16, CAST(N'2019-01-13T00:00:00.000' AS DateTime), 3, 2000, 5)
INSERT [dbo].[MUON_SACH] ([ma_doc_gia], [ma_sach], [ngay_muon], [ma_phieu_muon_sach], [ngay_du_dinh_tra], [tinh_trang], [gia_muon], [discount]) VALUES (15, N'TTR00001', CAST(N'2019-01-03T00:00:00.000' AS DateTime), 2, CAST(N'2019-01-13T00:00:00.000' AS DateTime), 10, 1000, 5)
INSERT [dbo].[MUON_SACH] ([ma_doc_gia], [ma_sach], [ngay_muon], [ma_phieu_muon_sach], [ngay_du_dinh_tra], [tinh_trang], [gia_muon], [discount]) VALUES (15, N'TTU00001', CAST(N'2019-01-03T00:00:00.000' AS DateTime), 2, CAST(N'2019-01-13T00:00:00.000' AS DateTime), 5, 10000, 5)
INSERT [dbo].[MUON_SACH] ([ma_doc_gia], [ma_sach], [ngay_muon], [ma_phieu_muon_sach], [ngay_du_dinh_tra], [tinh_trang], [gia_muon], [discount]) VALUES (30, N'TTR00001', CAST(N'2019-01-19T00:00:00.000' AS DateTime), 16, CAST(N'2019-01-29T00:00:00.000' AS DateTime), 10, 1000, 5)
INSERT [dbo].[MUON_SACH] ([ma_doc_gia], [ma_sach], [ngay_muon], [ma_phieu_muon_sach], [ngay_du_dinh_tra], [tinh_trang], [gia_muon], [discount]) VALUES (30, N'TTU00003', CAST(N'2019-01-19T00:00:00.000' AS DateTime), 20, CAST(N'2019-01-29T00:00:00.000' AS DateTime), 5, 1000, 5)
INSERT [dbo].[QUY_DINH] ([stt], [tien_phat_moi_ngay], [tien_phat_tren_mot_tuan], [so_ngay_muon_toi_da]) VALUES (1, 6000, 40000, 10)
INSERT [dbo].[SACH] ([ma_sach], [ten_sach], [tac_gia], [nha_xuat_ban], [nam_xuat_ban], [ma_the_loai], [gia_sach], [gia_muon], [so_sach_con_lai], [so_luong]) VALUES (N'DSG00001', N'Đắc Nhân Tâm', N'Dale Carnegie', N'Tổng hợp TPHCM', 2016, 7, 45000, 2000, 1, 3)
INSERT [dbo].[SACH] ([ma_sach], [ten_sach], [tac_gia], [nha_xuat_ban], [nam_xuat_ban], [ma_the_loai], [gia_sach], [gia_muon], [so_sach_con_lai], [so_luong]) VALUES (N'TTR00001', N'Thám tử lừng danh Conan', N'Aoyama Gōshō', N'Kim Đồng', 2010, 6, 16000, 1000, 10, 10)
INSERT [dbo].[SACH] ([ma_sach], [ten_sach], [tac_gia], [nha_xuat_ban], [nam_xuat_ban], [ma_the_loai], [gia_sach], [gia_muon], [so_sach_con_lai], [so_luong]) VALUES (N'TTU00001', N'Harry Potter', N'J. K. Rowling', N'Nhã Nam', 2000, 4, 50000, 10000, 5, 5)
INSERT [dbo].[SACH] ([ma_sach], [ten_sach], [tac_gia], [nha_xuat_ban], [nam_xuat_ban], [ma_the_loai], [gia_sach], [gia_muon], [so_sach_con_lai], [so_luong]) VALUES (N'TTU00002', N'Nhà giả kim', N'Paulo Coelho', N'Nhã Nam', 2016, 4, 40000, 3000, 2, 2)
INSERT [dbo].[SACH] ([ma_sach], [ten_sach], [tac_gia], [nha_xuat_ban], [nam_xuat_ban], [ma_the_loai], [gia_sach], [gia_muon], [so_sach_con_lai], [so_luong]) VALUES (N'TTU00003', N'Mao sơn tróc quỷ nhân', N'Thanh Vân Tử', N'Nhã Nam', 2018, 4, 50000, 1000, 5, 5)
SET IDENTITY_INSERT [dbo].[THE_LOAI] ON 

INSERT [dbo].[THE_LOAI] ([ma_the_loai], [ten_the_loai], [ma_sach_tuong_ung]) VALUES (1, N'Trinh thám', N'TTH')
INSERT [dbo].[THE_LOAI] ([ma_the_loai], [ten_the_loai], [ma_sach_tuong_ung]) VALUES (2, N'Khoa học', N'KHH')
INSERT [dbo].[THE_LOAI] ([ma_the_loai], [ten_the_loai], [ma_sach_tuong_ung]) VALUES (3, N'Văn học cổ điển', N'VHC')
INSERT [dbo].[THE_LOAI] ([ma_the_loai], [ten_the_loai], [ma_sach_tuong_ung]) VALUES (4, N'Tiểu thuyết', N'TTU')
INSERT [dbo].[THE_LOAI] ([ma_the_loai], [ten_the_loai], [ma_sach_tuong_ung]) VALUES (5, N'Sách thiếu nhi', N'STN')
INSERT [dbo].[THE_LOAI] ([ma_the_loai], [ten_the_loai], [ma_sach_tuong_ung]) VALUES (6, N'Truyện tranh', N'TTR')
INSERT [dbo].[THE_LOAI] ([ma_the_loai], [ten_the_loai], [ma_sach_tuong_ung]) VALUES (7, N'Đời sống', N'DSG')
INSERT [dbo].[THE_LOAI] ([ma_the_loai], [ten_the_loai], [ma_sach_tuong_ung]) VALUES (8, N'Hài', N'HAI')
INSERT [dbo].[THE_LOAI] ([ma_the_loai], [ten_the_loai], [ma_sach_tuong_ung]) VALUES (12, N'Mới', N'MOI')
INSERT [dbo].[THE_LOAI] ([ma_the_loai], [ten_the_loai], [ma_sach_tuong_ung]) VALUES (13, N'Kinh dị', N'KDI')
SET IDENTITY_INSERT [dbo].[THE_LOAI] OFF
INSERT [dbo].[TRA_SACH] ([ma_doc_gia], [ma_sach], [ngay_muon], [ma_phieu_muon_sach], [ngay_tra], [tien_phat], [diem_danh_gia]) VALUES (12, N'DSG00001', CAST(N'2019-01-03T00:00:00.000' AS DateTime), 1, CAST(N'2019-01-13T00:00:00.000' AS DateTime), 0, 1)
INSERT [dbo].[TRA_SACH] ([ma_doc_gia], [ma_sach], [ngay_muon], [ma_phieu_muon_sach], [ngay_tra], [tien_phat], [diem_danh_gia]) VALUES (15, N'DSG00001', CAST(N'2019-01-03T00:00:00.000' AS DateTime), 16, CAST(N'2019-01-19T00:00:00.000' AS DateTime), 36000, 1)
INSERT [dbo].[TRA_SACH] ([ma_doc_gia], [ma_sach], [ngay_muon], [ma_phieu_muon_sach], [ngay_tra], [tien_phat], [diem_danh_gia]) VALUES (15, N'TTR00001', CAST(N'2019-01-03T00:00:00.000' AS DateTime), 2, CAST(N'2019-01-19T00:00:00.000' AS DateTime), 36000, 1)
INSERT [dbo].[TRA_SACH] ([ma_doc_gia], [ma_sach], [ngay_muon], [ma_phieu_muon_sach], [ngay_tra], [tien_phat], [diem_danh_gia]) VALUES (15, N'TTU00001', CAST(N'2019-01-03T00:00:00.000' AS DateTime), 2, CAST(N'2019-01-19T00:00:00.000' AS DateTime), 36000, 1)
INSERT [dbo].[TRA_SACH] ([ma_doc_gia], [ma_sach], [ngay_muon], [ma_phieu_muon_sach], [ngay_tra], [tien_phat], [diem_danh_gia]) VALUES (30, N'TTR00001', CAST(N'2019-01-19T00:00:00.000' AS DateTime), 16, CAST(N'2019-01-19T00:00:00.000' AS DateTime), 1000, 1)
INSERT [dbo].[TRA_SACH] ([ma_doc_gia], [ma_sach], [ngay_muon], [ma_phieu_muon_sach], [ngay_tra], [tien_phat], [diem_danh_gia]) VALUES (30, N'TTU00003', CAST(N'2019-01-19T00:00:00.000' AS DateTime), 20, CAST(N'2019-01-19T00:00:00.000' AS DateTime), 1000, 1)
ALTER TABLE [dbo].[DOC_GIA] ADD  DEFAULT (N'Có') FOR [hoat_dong]
GO
ALTER TABLE [dbo].[MUON_SACH]  WITH CHECK ADD FOREIGN KEY([ma_doc_gia])
REFERENCES [dbo].[DOC_GIA] ([ma_doc_gia])
GO
ALTER TABLE [dbo].[MUON_SACH]  WITH CHECK ADD FOREIGN KEY([ma_sach])
REFERENCES [dbo].[SACH] ([ma_sach])
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD FOREIGN KEY([ma_the_loai])
REFERENCES [dbo].[THE_LOAI] ([ma_the_loai])
GO
ALTER TABLE [dbo].[TRA_SACH]  WITH CHECK ADD FOREIGN KEY([ma_doc_gia], [ma_sach], [ngay_muon], [ma_phieu_muon_sach])
REFERENCES [dbo].[MUON_SACH] ([ma_doc_gia], [ma_sach], [ngay_muon], [ma_phieu_muon_sach])
GO
ALTER TABLE [dbo].[DOC_GIA]  WITH CHECK ADD CHECK  (([gioi_tinh]=N'Nam' OR [gioi_tinh]=N'Nữ'))
GO
ALTER TABLE [dbo].[DOC_GIA]  WITH CHECK ADD CHECK  (([hoat_dong]=N'Có' OR [hoat_dong]=N'Không'))
GO
USE [master]
GO
ALTER DATABASE [LibraryUpdate2] SET  READ_WRITE 
GO
