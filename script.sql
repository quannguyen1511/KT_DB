USE [master]
GO
/****** Object:  Database [QuanLiQuanTraSua]    Script Date: 11/12/2018 1:54:05 PM ******/
CREATE DATABASE [QuanLiQuanTraSua] ON  PRIMARY 
( NAME = N'QuanLiQuanTraSua', FILENAME = N'D:\QuanLiQuanTraSua.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLiQuanTraSua_log', FILENAME = N'D:\QuanLiQuanTraSua_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLiQuanTraSua].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLiQuanTraSua] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLiQuanTraSua] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLiQuanTraSua] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLiQuanTraSua', N'ON'
GO
USE [QuanLiQuanTraSua]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/12/2018 1:54:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[id] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[PassWord] [nvarchar](50) NULL,
	[DisplayName] [nvarchar](50) NULL,
	[CountDay] [int] NULL,
	[CountMonth] [int] NULL,
	[YesterDay] [datetime] NULL,
	[TotalDay] [bigint] NULL,
	[TotalMonth] [bigint] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DrinkToppingName]    Script Date: 11/12/2018 1:54:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DrinkToppingName](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Price] [float] NULL,
 CONSTRAINT [PK_DrinkToppingName] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([id], [UserName], [PassWord], [DisplayName], [CountDay], [CountMonth], [YesterDay], [TotalDay], [TotalMonth]) VALUES (N'NV1', N'thao', N'3', N'Bi Bò', 0, 0, CAST(N'2018-11-11T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Account] ([id], [UserName], [PassWord], [DisplayName], [CountDay], [CountMonth], [YesterDay], [TotalDay], [TotalMonth]) VALUES (N'NV2', N'duong', N'1', N'Đường Nguyễn', 0, 0, CAST(N'2018-11-11T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Account] ([id], [UserName], [PassWord], [DisplayName], [CountDay], [CountMonth], [YesterDay], [TotalDay], [TotalMonth]) VALUES (N'NV3', N'bang', N'3', N'Băng Nguyễn', 0, 0, CAST(N'2018-11-11T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Account] ([id], [UserName], [PassWord], [DisplayName], [CountDay], [CountMonth], [YesterDay], [TotalDay], [TotalMonth]) VALUES (N'NV4', N'quan', N'quan', N'quan', 1, 1, CAST(N'2018-11-11T00:00:00.000' AS DateTime), 60000, 60000)
INSERT [dbo].[Account] ([id], [UserName], [PassWord], [DisplayName], [CountDay], [CountMonth], [YesterDay], [TotalDay], [TotalMonth]) VALUES (N'NV5', N'ahihi', N'ahihi', N'ahihi', 0, 0, CAST(N'2018-11-11T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Account] ([id], [UserName], [PassWord], [DisplayName], [CountDay], [CountMonth], [YesterDay], [TotalDay], [TotalMonth]) VALUES (N'NV6', N'10', N'10', N'02', 0, 0, CAST(N'2018-11-11T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[DrinkToppingName] ([ID], [Name], [Price]) VALUES (N'D1', N'Trà sữa Thái', 15000)
INSERT [dbo].[DrinkToppingName] ([ID], [Name], [Price]) VALUES (N'D2', N'Trà sữa Matcha', 20000)
INSERT [dbo].[DrinkToppingName] ([ID], [Name], [Price]) VALUES (N'D3', N'Trà sữa Chocolate', 20000)
INSERT [dbo].[DrinkToppingName] ([ID], [Name], [Price]) VALUES (N'D4', N'Trà sữa Truyền Thống', 12000)
INSERT [dbo].[DrinkToppingName] ([ID], [Name], [Price]) VALUES (N'D5', N'Trà sữa Đặc Biệt', 30000)
INSERT [dbo].[DrinkToppingName] ([ID], [Name], [Price]) VALUES (N'D6', N'Trà Đào', 15000)
INSERT [dbo].[DrinkToppingName] ([ID], [Name], [Price]) VALUES (N'D7', N'Cà Phê', 10000)
INSERT [dbo].[DrinkToppingName] ([ID], [Name], [Price]) VALUES (N'D8', N'Cà Phê Sữa', 15000)
INSERT [dbo].[DrinkToppingName] ([ID], [Name], [Price]) VALUES (N'T1', N'Thạch trái cây', 5000)
INSERT [dbo].[DrinkToppingName] ([ID], [Name], [Price]) VALUES (N'T2', N'Trân châu nâu', 5000)
INSERT [dbo].[DrinkToppingName] ([ID], [Name], [Price]) VALUES (N'T3', N'Trân châu trắng', 5000)
INSERT [dbo].[DrinkToppingName] ([ID], [Name], [Price]) VALUES (N'T4', N'Thạch phô mai', 7000)
INSERT [dbo].[DrinkToppingName] ([ID], [Name], [Price]) VALUES (N'T5', N'Flan', 7000)
INSERT [dbo].[DrinkToppingName] ([ID], [Name], [Price]) VALUES (N'T6', N'Thạch thủy tinh', 5000)
INSERT [dbo].[DrinkToppingName] ([ID], [Name], [Price]) VALUES (N'T8', N'Miếng đào', 5000)
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF_Account_CountDay]  DEFAULT ((0)) FOR [CountDay]
GO
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF_Account_CountMonth]  DEFAULT ((0)) FOR [CountMonth]
GO
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF_Account_YesterDay]  DEFAULT ('2018-01-01 00:00:00.000') FOR [YesterDay]
GO
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF_Account_TotalDay]  DEFAULT ((0)) FOR [TotalDay]
GO
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF_Account_TotalMonth]  DEFAULT ((0)) FOR [TotalMonth]
GO
USE [master]
GO
ALTER DATABASE [QuanLiQuanTraSua] SET  READ_WRITE 
GO
