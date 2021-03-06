USE [master]
GO
/****** Object:  Database [dbQLTS]    Script Date: 2018-01-21 03:57:13 ******/
CREATE DATABASE [dbQLTS]
-- CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'dbQLTS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\dbQLTS.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
-- LOG ON 
--( NAME = N'dbQLTS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\dbQLTS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbQLTS] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbQLTS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbQLTS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbQLTS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbQLTS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbQLTS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbQLTS] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbQLTS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbQLTS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbQLTS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbQLTS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbQLTS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbQLTS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbQLTS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbQLTS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbQLTS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbQLTS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbQLTS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbQLTS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbQLTS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbQLTS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbQLTS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbQLTS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbQLTS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbQLTS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbQLTS] SET  MULTI_USER 
GO
ALTER DATABASE [dbQLTS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbQLTS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbQLTS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbQLTS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbQLTS] SET DELAYED_DURABILITY = DISABLED 
GO
USE [dbQLTS]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 2018-01-21 03:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[IDAccount] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[FullName] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[IDPosition] [int] NULL,
	[Male] [bit] NULL,
	[Status] [bit] NULL,
	[Birthday] [date] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[IDAccount] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTMuonTB]    Script Date: 2018-01-21 03:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTMuonTB](
	[IDCTMuon] [int] IDENTITY(1,1) NOT NULL,
	[IDMuonTB] [int] NOT NULL,
	[IDThietBi] [int] NOT NULL,
	[Note] [nvarchar](max) NULL,
	[Total] [int] NULL,
	[Bad] [int] NULL,
 CONSTRAINT [PK_CTMuonTB_1] PRIMARY KEY CLUSTERED 
(
	[IDCTMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MuonTB]    Script Date: 2018-01-21 03:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MuonTB](
	[IDMuonTB] [int] IDENTITY(1,1) NOT NULL,
	[IDAccount] [int] NULL,
	[CreateTime] [datetime] NULL,
	[TimeStart] [datetime] NULL,
	[TimeEnd] [datetime] NULL,
	[Status] [bit] NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
 CONSTRAINT [PK_MuonPhong] PRIMARY KEY CLUSTERED 
(
	[IDMuonTB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Position]    Script Date: 2018-01-21 03:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[IDPosition] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
(
	[IDPosition] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThietBi]    Script Date: 2018-01-21 03:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThietBi](
	[IDThietBi] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Total] [int] NULL,
	[Price] [int] NULL,
	[CanUse] [int] NULL,
	[Bad] [int] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_ThietBi] PRIMARY KEY CLUSTERED 
(
	[IDThietBi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([IDAccount], [Username], [Password], [FullName], [Phone], [Email], [IDPosition], [Male], [Status], [Birthday]) VALUES (4, N'admin', N'admin', N'Admin', N'0987654321', N'admin@gmail.com', 1, 1, 0, CAST(N'1990-01-01' AS Date))
INSERT [dbo].[Account] ([IDAccount], [Username], [Password], [FullName], [Phone], [Email], [IDPosition], [Male], [Status], [Birthday]) VALUES (5, N'g', NULL, N'g', N'23123123131', N'123123123123123123123', 1, 1, 0, CAST(N'2002-02-01' AS Date))
INSERT [dbo].[Account] ([IDAccount], [Username], [Password], [FullName], [Phone], [Email], [IDPosition], [Male], [Status], [Birthday]) VALUES (6, N'e', NULL, N'e', NULL, NULL, 1, NULL, 0, NULL)
SET IDENTITY_INSERT [dbo].[Account] OFF
SET IDENTITY_INSERT [dbo].[CTMuonTB] ON 

INSERT [dbo].[CTMuonTB] ([IDCTMuon], [IDMuonTB], [IDThietBi], [Note], [Total], [Bad]) VALUES (7, 5, 4, NULL, 9, 9)
SET IDENTITY_INSERT [dbo].[CTMuonTB] OFF
SET IDENTITY_INSERT [dbo].[MuonTB] ON 

INSERT [dbo].[MuonTB] ([IDMuonTB], [IDAccount], [CreateTime], [TimeStart], [TimeEnd], [Status], [Note], [CreateBy]) VALUES (2, 4, CAST(N'2018-01-20 03:50:18.690' AS DateTime), CAST(N'2018-01-20 03:50:18.690' AS DateTime), CAST(N'2018-01-20 03:50:18.690' AS DateTime), 1, N'd', 4)
INSERT [dbo].[MuonTB] ([IDMuonTB], [IDAccount], [CreateTime], [TimeStart], [TimeEnd], [Status], [Note], [CreateBy]) VALUES (4, 4, CAST(N'2018-01-21 00:21:55.843' AS DateTime), CAST(N'2002-01-21 00:00:00.000' AS DateTime), CAST(N'2003-01-21 00:00:00.000' AS DateTime), 1, N'd', 4)
INSERT [dbo].[MuonTB] ([IDMuonTB], [IDAccount], [CreateTime], [TimeStart], [TimeEnd], [Status], [Note], [CreateBy]) VALUES (5, 4, CAST(N'2018-01-21 00:22:12.630' AS DateTime), CAST(N'2002-01-21 00:00:00.000' AS DateTime), CAST(N'2003-01-21 00:00:00.000' AS DateTime), 1, N'd', 4)
SET IDENTITY_INSERT [dbo].[MuonTB] OFF
SET IDENTITY_INSERT [dbo].[Position] ON 

INSERT [dbo].[Position] ([IDPosition], [Name], [IsDelete]) VALUES (1, N'1', 0)
INSERT [dbo].[Position] ([IDPosition], [Name], [IsDelete]) VALUES (2, N'2', 0)
INSERT [dbo].[Position] ([IDPosition], [Name], [IsDelete]) VALUES (3, N'7', 0)
INSERT [dbo].[Position] ([IDPosition], [Name], [IsDelete]) VALUES (4, N'4', 0)
INSERT [dbo].[Position] ([IDPosition], [Name], [IsDelete]) VALUES (5, N'5', 1)
SET IDENTITY_INSERT [dbo].[Position] OFF
SET IDENTITY_INSERT [dbo].[ThietBi] ON 

INSERT [dbo].[ThietBi] ([IDThietBi], [Code], [Name], [Total], [Price], [CanUse], [Bad], [Status]) VALUES (1, N'a', N'100', 100, 20000, 100, 0, 0)
INSERT [dbo].[ThietBi] ([IDThietBi], [Code], [Name], [Total], [Price], [CanUse], [Bad], [Status]) VALUES (2, N's', N'100', 100, 20000, 100, 0, 0)
INSERT [dbo].[ThietBi] ([IDThietBi], [Code], [Name], [Total], [Price], [CanUse], [Bad], [Status]) VALUES (3, N'd', N'100', 100, 20000, 100, 0, 0)
INSERT [dbo].[ThietBi] ([IDThietBi], [Code], [Name], [Total], [Price], [CanUse], [Bad], [Status]) VALUES (4, N'f', N'100', 100, 20000, 91, 9, 0)
INSERT [dbo].[ThietBi] ([IDThietBi], [Code], [Name], [Total], [Price], [CanUse], [Bad], [Status]) VALUES (5, N'g', N'100', 100, 20000, 100, 0, 0)
INSERT [dbo].[ThietBi] ([IDThietBi], [Code], [Name], [Total], [Price], [CanUse], [Bad], [Status]) VALUES (6, N'h', N'100', 100, 20000, 100, 0, 0)
INSERT [dbo].[ThietBi] ([IDThietBi], [Code], [Name], [Total], [Price], [CanUse], [Bad], [Status]) VALUES (7, N'j', N'100', 100, 20000, 100, 0, 0)
INSERT [dbo].[ThietBi] ([IDThietBi], [Code], [Name], [Total], [Price], [CanUse], [Bad], [Status]) VALUES (8, N'k', N'100', 100, 20000, 100, 0, 0)
INSERT [dbo].[ThietBi] ([IDThietBi], [Code], [Name], [Total], [Price], [CanUse], [Bad], [Status]) VALUES (9, N'l', N'100', 100, 20000, 100, 0, 0)
INSERT [dbo].[ThietBi] ([IDThietBi], [Code], [Name], [Total], [Price], [CanUse], [Bad], [Status]) VALUES (10, N'oi', N'100', 100, 20000, 100, 0, 0)
INSERT [dbo].[ThietBi] ([IDThietBi], [Code], [Name], [Total], [Price], [CanUse], [Bad], [Status]) VALUES (11, N'u', N'100', 100, 20000, 100, 0, 0)
INSERT [dbo].[ThietBi] ([IDThietBi], [Code], [Name], [Total], [Price], [CanUse], [Bad], [Status]) VALUES (12, N'y', N'100', 100, 20000, 100, 0, 0)
INSERT [dbo].[ThietBi] ([IDThietBi], [Code], [Name], [Total], [Price], [CanUse], [Bad], [Status]) VALUES (13, N't', N'100', 100, 20000, 100, 0, 0)
INSERT [dbo].[ThietBi] ([IDThietBi], [Code], [Name], [Total], [Price], [CanUse], [Bad], [Status]) VALUES (14, N'r', N'100', 100, 20000, 100, 0, 0)
INSERT [dbo].[ThietBi] ([IDThietBi], [Code], [Name], [Total], [Price], [CanUse], [Bad], [Status]) VALUES (15, N'e', N'100', 100, 20000, 100, 0, 0)
INSERT [dbo].[ThietBi] ([IDThietBi], [Code], [Name], [Total], [Price], [CanUse], [Bad], [Status]) VALUES (16, N'w', N'100', 100, 20000, 100, 0, 0)
INSERT [dbo].[ThietBi] ([IDThietBi], [Code], [Name], [Total], [Price], [CanUse], [Bad], [Status]) VALUES (17, N'e', N'100', 100, 20000, 100, 0, 0)
SET IDENTITY_INSERT [dbo].[ThietBi] OFF
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Position] FOREIGN KEY([IDPosition])
REFERENCES [dbo].[Position] ([IDPosition])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Position]
GO
ALTER TABLE [dbo].[CTMuonTB]  WITH CHECK ADD  CONSTRAINT [FK_CTMuonTB_MuonTB] FOREIGN KEY([IDMuonTB])
REFERENCES [dbo].[MuonTB] ([IDMuonTB])
GO
ALTER TABLE [dbo].[CTMuonTB] CHECK CONSTRAINT [FK_CTMuonTB_MuonTB]
GO
ALTER TABLE [dbo].[CTMuonTB]  WITH CHECK ADD  CONSTRAINT [FK_CTMuonTB_ThietBi] FOREIGN KEY([IDThietBi])
REFERENCES [dbo].[ThietBi] ([IDThietBi])
GO
ALTER TABLE [dbo].[CTMuonTB] CHECK CONSTRAINT [FK_CTMuonTB_ThietBi]
GO
ALTER TABLE [dbo].[MuonTB]  WITH CHECK ADD  CONSTRAINT [FK_MuonTB_Account] FOREIGN KEY([IDAccount])
REFERENCES [dbo].[Account] ([IDAccount])
GO
ALTER TABLE [dbo].[MuonTB] CHECK CONSTRAINT [FK_MuonTB_Account]
GO
USE [master]
GO
ALTER DATABASE [dbQLTS] SET  READ_WRITE 
GO
