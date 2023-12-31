USE [master]
GO
/****** Object:  Database [YurtOtomasyonu]    Script Date: 29.06.2023 00:33:21 ******/
CREATE DATABASE [YurtOtomasyonu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'YurtOtomasyonu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\YurtOtomasyonu.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'YurtOtomasyonu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\YurtOtomasyonu_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [YurtOtomasyonu] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [YurtOtomasyonu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [YurtOtomasyonu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET ARITHABORT OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [YurtOtomasyonu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [YurtOtomasyonu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [YurtOtomasyonu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [YurtOtomasyonu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [YurtOtomasyonu] SET  MULTI_USER 
GO
ALTER DATABASE [YurtOtomasyonu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [YurtOtomasyonu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [YurtOtomasyonu] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [YurtOtomasyonu] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [YurtOtomasyonu] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [YurtOtomasyonu] SET QUERY_STORE = ON
GO
ALTER DATABASE [YurtOtomasyonu] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [YurtOtomasyonu]
GO
/****** Object:  Table [dbo].[AdminGiris]    Script Date: 29.06.2023 00:33:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminGiris](
	[YoneticiID] [int] IDENTITY(1,1) NOT NULL,
	[YoneticiAd] [varchar](20) NULL,
	[YoneticiSoyad] [varchar](20) NULL,
	[KullaniciAd] [varchar](20) NULL,
	[Sifre] [varchar](20) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[YoneticiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Borclar]    Script Date: 29.06.2023 00:33:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borclar](
	[OgrID] [int] NOT NULL,
	[Borc] [smallint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Izinler]    Script Date: 29.06.2023 00:33:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Izinler](
	[OgrID] [int] NOT NULL,
	[CikisTarih] [varchar](20) NULL,
	[GirisTarih] [varchar](20) NULL,
	[Adres] [varchar](50) NULL,
	[IzinKabul] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Odalar]    Script Date: 29.06.2023 00:33:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odalar](
	[OdaID] [int] IDENTITY(1,1) NOT NULL,
	[KatNo] [char](1) NULL,
	[OdaNo] [char](3) NULL,
	[KisiSayisi] [char](3) NULL,
	[OdaDurum] [bit] NULL,
 CONSTRAINT [PK_Odalar] PRIMARY KEY CLUSTERED 
(
	[OdaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 29.06.2023 00:33:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[OgrID] [int] IDENTITY(1,1) NOT NULL,
	[OgrAd] [varchar](50) NULL,
	[OgrSoyad] [varchar](50) NULL,
	[OgrTC] [char](11) NULL,
	[OgrTelefon] [varchar](20) NULL,
	[OgrDogum] [varchar](12) NULL,
	[OgrBolum] [varchar](50) NULL,
	[OgrMail] [varchar](50) NULL,
	[OgrAdres] [varchar](50) NULL,
	[VeliAd] [varchar](50) NULL,
	[VeliSoyad] [varchar](50) NULL,
	[VeliTelefon] [varchar](20) NULL,
	[VeliAdres] [varchar](50) NULL,
	[OdaNo] [char](3) NULL,
 CONSTRAINT [PK_Ogrenci] PRIMARY KEY CLUSTERED 
(
	[OgrID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OgrenciGiris]    Script Date: 29.06.2023 00:33:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgrenciGiris](
	[OgrID] [int] NOT NULL,
	[KullaniciAd] [varchar](20) NULL,
	[Sifre] [varchar](20) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AdminGiris] ON 

INSERT [dbo].[AdminGiris] ([YoneticiID], [YoneticiAd], [YoneticiSoyad], [KullaniciAd], [Sifre]) VALUES (1, N'Kubra', N'Unal', N'admin', N'12345')
SET IDENTITY_INSERT [dbo].[AdminGiris] OFF
GO
INSERT [dbo].[Borclar] ([OgrID], [Borc]) VALUES (44, 450)
INSERT [dbo].[Borclar] ([OgrID], [Borc]) VALUES (45, 450)
INSERT [dbo].[Borclar] ([OgrID], [Borc]) VALUES (46, 450)
GO
INSERT [dbo].[Izinler] ([OgrID], [CikisTarih], [GirisTarih], [Adres], [IzinKabul]) VALUES (44, N'28.06.2023 20:21:34', N'1.07.2023 20:21:34', N'ev', 1)
INSERT [dbo].[Izinler] ([OgrID], [CikisTarih], [GirisTarih], [Adres], [IzinKabul]) VALUES (45, N'28.06.2023 20:12:44', N'9.07.2023 20:12:44', N'Ankara', 0)
INSERT [dbo].[Izinler] ([OgrID], [CikisTarih], [GirisTarih], [Adres], [IzinKabul]) VALUES (46, N'28.06.2023 20:19:33', N'22.07.2023 20:19:33', N'Eve gidicem', 0)
GO
SET IDENTITY_INSERT [dbo].[Odalar] ON 

INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (1, N'1', N'101', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (2, N'1', N'102', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (3, N'1', N'103', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (4, N'1', N'104', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (5, N'1', N'105', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (6, N'2', N'201', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (7, N'2', N'202', N'2  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (8, N'2', N'203', N'1  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (9, N'2', N'204', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (10, N'2', N'205', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (11, N'3', N'301', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (12, N'3', N'302', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (13, N'3', N'303', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (14, N'3', N'304', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (15, N'3', N'305', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (16, N'4', N'401', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (17, N'4', N'402', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (18, N'4', N'403', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (19, N'4', N'404', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (20, N'4', N'405', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (21, N'5', N'501', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (22, N'5', N'502', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (23, N'5', N'503', N'0  ', 0)
INSERT [dbo].[Odalar] ([OdaID], [KatNo], [OdaNo], [KisiSayisi], [OdaDurum]) VALUES (24, N'5', N'504', N'0  ', 0)
SET IDENTITY_INSERT [dbo].[Odalar] OFF
GO
SET IDENTITY_INSERT [dbo].[Ogrenci] ON 

INSERT [dbo].[Ogrenci] ([OgrID], [OgrAd], [OgrSoyad], [OgrTC], [OgrTelefon], [OgrDogum], [OgrBolum], [OgrMail], [OgrAdres], [VeliAd], [VeliSoyad], [VeliTelefon], [VeliAdres], [OdaNo]) VALUES (44, N'Ayşe', N'Yılmaz', N'12345678910', N'05556667788', N'02.03.2000', N'Bilgisayar Mühendisliği', N'ayseyilmaz@gmail.com', N'Çankaya/Ankara', N'Mustafa', N'Yılmaz', N'05447678890', N'Çankaya/Ankara', N'202')
INSERT [dbo].[Ogrenci] ([OgrID], [OgrAd], [OgrSoyad], [OgrTC], [OgrTelefon], [OgrDogum], [OgrBolum], [OgrMail], [OgrAdres], [VeliAd], [VeliSoyad], [VeliTelefon], [VeliAdres], [OdaNo]) VALUES (45, N'Elif', N'Aydın', N'11111111111', N'05678902345', N'01.01.1999', N'Mimarlık', N'elifaydin@gmail.com', N'Bursa', N'Yusuf', N'Aydın', N'05234567890', N'Bursa', N'203')
INSERT [dbo].[Ogrenci] ([OgrID], [OgrAd], [OgrSoyad], [OgrTC], [OgrTelefon], [OgrDogum], [OgrBolum], [OgrMail], [OgrAdres], [VeliAd], [VeliSoyad], [VeliTelefon], [VeliAdres], [OdaNo]) VALUES (46, N'Rabia', N'Işık', N'10101010101', N'05345678900', N'05.01.2001', N'İnşaat Mühendisliği', N'rabiaisik@gmail.com', N'Tokat', N'Hamit', N'Işık', N'05742893647', N'Tokat', N'202')
SET IDENTITY_INSERT [dbo].[Ogrenci] OFF
GO
INSERT [dbo].[OgrenciGiris] ([OgrID], [KullaniciAd], [Sifre]) VALUES (44, N'12345678910', N'ayşe')
INSERT [dbo].[OgrenciGiris] ([OgrID], [KullaniciAd], [Sifre]) VALUES (45, N'11111111111', N'elif')
INSERT [dbo].[OgrenciGiris] ([OgrID], [KullaniciAd], [Sifre]) VALUES (46, N'10101010101', N'rabia')
GO
ALTER TABLE [dbo].[Borclar] ADD  CONSTRAINT [DF_Borclar_Borc]  DEFAULT ((450)) FOR [Borc]
GO
ALTER TABLE [dbo].[Izinler] ADD  CONSTRAINT [DF_Izinler_IzinKabul]  DEFAULT ((0)) FOR [IzinKabul]
GO
ALTER TABLE [dbo].[Odalar] ADD  CONSTRAINT [DF_Odalar_KisiSayisi]  DEFAULT ((0)) FOR [KisiSayisi]
GO
ALTER TABLE [dbo].[Odalar] ADD  CONSTRAINT [DF_Odalar_OdaDurum]  DEFAULT ((0)) FOR [OdaDurum]
GO
ALTER TABLE [dbo].[Borclar]  WITH CHECK ADD  CONSTRAINT [FK_Borclar_Ogrenci] FOREIGN KEY([OgrID])
REFERENCES [dbo].[Ogrenci] ([OgrID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Borclar] CHECK CONSTRAINT [FK_Borclar_Ogrenci]
GO
ALTER TABLE [dbo].[Izinler]  WITH CHECK ADD  CONSTRAINT [FK_Izinler_Ogrenci] FOREIGN KEY([OgrID])
REFERENCES [dbo].[Ogrenci] ([OgrID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Izinler] CHECK CONSTRAINT [FK_Izinler_Ogrenci]
GO
ALTER TABLE [dbo].[OgrenciGiris]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciGiris_Ogrenci] FOREIGN KEY([OgrID])
REFERENCES [dbo].[Ogrenci] ([OgrID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OgrenciGiris] CHECK CONSTRAINT [FK_OgrenciGiris_Ogrenci]
GO
USE [master]
GO
ALTER DATABASE [YurtOtomasyonu] SET  READ_WRITE 
GO
