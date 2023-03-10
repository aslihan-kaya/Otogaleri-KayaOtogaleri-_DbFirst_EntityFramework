USE [master]
GO
/****** Object:  Database [Galeri]    Script Date: 7.11.2022 19:01:46 ******/
CREATE DATABASE [Galeri]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Galeri', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Galeri.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Galeri_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Galeri_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Galeri] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Galeri].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Galeri] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Galeri] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Galeri] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Galeri] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Galeri] SET ARITHABORT OFF 
GO
ALTER DATABASE [Galeri] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Galeri] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Galeri] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Galeri] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Galeri] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Galeri] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Galeri] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Galeri] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Galeri] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Galeri] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Galeri] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Galeri] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Galeri] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Galeri] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Galeri] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Galeri] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Galeri] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Galeri] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Galeri] SET  MULTI_USER 
GO
ALTER DATABASE [Galeri] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Galeri] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Galeri] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Galeri] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Galeri] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Galeri] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Galeri] SET QUERY_STORE = OFF
GO
USE [Galeri]
GO
/****** Object:  Table [dbo].[AracBilgileri]    Script Date: 7.11.2022 19:01:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AracBilgileri](
	[AracNo] [int] IDENTITY(1,1) NOT NULL,
	[AracFiyat] [money] NULL,
	[AracAdet] [int] NULL,
	[AracMarka] [varchar](50) NULL,
	[AracModel] [varchar](50) NULL,
	[AracYil] [varchar](50) NULL,
	[AracOzellik] [varchar](50) NULL,
	[AracMotor] [varchar](50) NULL,
	[AracPaket] [varchar](50) NULL,
	[AracRenk] [varchar](50) NULL,
	[SubeNo] [int] NULL,
 CONSTRAINT [PK_AracBilgileri] PRIMARY KEY CLUSTERED 
(
	[AracNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 7.11.2022 19:01:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[KullaniciNo] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [varchar](50) NULL,
	[Sifre] [varchar](50) NULL,
	[Telefon] [nchar](11) NULL,
	[Mail] [varchar](50) NULL,
 CONSTRAINT [PK_Kullanicilar] PRIMARY KEY CLUSTERED 
(
	[KullaniciNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriBilgileri]    Script Date: 7.11.2022 19:01:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriBilgileri](
	[MusteriNo] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAdSoyad] [varchar](50) NULL,
	[MusteriTelefon] [nchar](11) NULL,
	[MusteriYas] [int] NULL,
	[MusteriBakiye] [money] NULL,
 CONSTRAINT [PK_MusteriBilgileri] PRIMARY KEY CLUSTERED 
(
	[MusteriNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubeBilgileri]    Script Date: 7.11.2022 19:01:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubeBilgileri](
	[SubeNo] [int] IDENTITY(1,1) NOT NULL,
	[SubeAdi] [varchar](50) NULL,
	[CalisanSayisi] [int] NULL,
	[SubeCiro] [money] NULL,
	[MusteriNo] [int] NULL,
 CONSTRAINT [PK_SubeBilgileri] PRIMARY KEY CLUSTERED 
(
	[SubeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AracBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_AracBilgileri_SubeBilgileri] FOREIGN KEY([SubeNo])
REFERENCES [dbo].[SubeBilgileri] ([SubeNo])
GO
ALTER TABLE [dbo].[AracBilgileri] CHECK CONSTRAINT [FK_AracBilgileri_SubeBilgileri]
GO
ALTER TABLE [dbo].[SubeBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_SubeBilgileri_MusteriBilgileri] FOREIGN KEY([MusteriNo])
REFERENCES [dbo].[MusteriBilgileri] ([MusteriNo])
GO
ALTER TABLE [dbo].[SubeBilgileri] CHECK CONSTRAINT [FK_SubeBilgileri_MusteriBilgileri]
GO
USE [master]
GO
ALTER DATABASE [Galeri] SET  READ_WRITE 
GO
