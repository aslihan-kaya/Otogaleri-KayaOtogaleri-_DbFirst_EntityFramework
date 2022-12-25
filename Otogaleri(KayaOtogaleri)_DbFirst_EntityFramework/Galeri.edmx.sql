
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/21/2022 19:21:57
-- Generated from EDMX file: C:\Users\Aslihan\Desktop\OtogaleriOtomasyonu\Otogaleri(KayaOtogaleri)_DbFirst_EntityFramework\Otogaleri(KayaOtogaleri)_DbFirst_EntityFramework\Galeri.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Galeri];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AracBilgileri_SubeBilgileri]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AracBilgileri] DROP CONSTRAINT [FK_AracBilgileri_SubeBilgileri];
GO
IF OBJECT_ID(N'[dbo].[FK_SubeBilgileri_MusteriBilgileri]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SubeBilgileri] DROP CONSTRAINT [FK_SubeBilgileri_MusteriBilgileri];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AracBilgileri]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AracBilgileri];
GO
IF OBJECT_ID(N'[dbo].[Kullanicilar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kullanicilar];
GO
IF OBJECT_ID(N'[dbo].[MusteriBilgileri]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MusteriBilgileri];
GO
IF OBJECT_ID(N'[dbo].[SubeBilgileri]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SubeBilgileri];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AracBilgileris'
CREATE TABLE [dbo].[AracBilgileris] (
    [AracNo] int IDENTITY(1,1) NOT NULL,
    [AracFiyat] decimal(19,4)  NULL,
    [AracAdet] int  NULL,
    [AracMarka] varchar(50)  NULL,
    [AracModel] varchar(50)  NULL,
    [AracYil] varchar(50)  NULL,
    [AracOzellik] varchar(50)  NULL,
    [AracMotor] varchar(50)  NULL,
    [AracPaket] varchar(50)  NULL,
    [AracRenk] varchar(50)  NULL,
    [SubeNo] int  NULL
);
GO

-- Creating table 'Kullanicilars'
CREATE TABLE [dbo].[Kullanicilars] (
    [KullaniciNo] int IDENTITY(1,1) NOT NULL,
    [KullaniciAdi] varchar(50)  NULL,
    [Sifre] varchar(50)  NULL,
    [Telefon] nchar(11)  NULL,
    [Mail] varchar(50)  NULL
);
GO

-- Creating table 'MusteriBilgileris'
CREATE TABLE [dbo].[MusteriBilgileris] (
    [MusteriNo] int IDENTITY(1,1) NOT NULL,
    [MusteriAdSoyad] varchar(50)  NULL,
    [MusteriTelefon] nchar(11)  NULL,
    [MusteriYas] int  NULL,
    [MusteriBakiye] decimal(19,4)  NULL
);
GO

-- Creating table 'SubeBilgileris'
CREATE TABLE [dbo].[SubeBilgileris] (
    [SubeNo] int IDENTITY(1,1) NOT NULL,
    [SubeAdi] varchar(50)  NULL,
    [CalisanSayisi] int  NULL,
    [SubeCiro] decimal(19,4)  NULL,
    [MusteriNo] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AracNo] in table 'AracBilgileris'
ALTER TABLE [dbo].[AracBilgileris]
ADD CONSTRAINT [PK_AracBilgileris]
    PRIMARY KEY CLUSTERED ([AracNo] ASC);
GO

-- Creating primary key on [KullaniciNo] in table 'Kullanicilars'
ALTER TABLE [dbo].[Kullanicilars]
ADD CONSTRAINT [PK_Kullanicilars]
    PRIMARY KEY CLUSTERED ([KullaniciNo] ASC);
GO

-- Creating primary key on [MusteriNo] in table 'MusteriBilgileris'
ALTER TABLE [dbo].[MusteriBilgileris]
ADD CONSTRAINT [PK_MusteriBilgileris]
    PRIMARY KEY CLUSTERED ([MusteriNo] ASC);
GO

-- Creating primary key on [SubeNo] in table 'SubeBilgileris'
ALTER TABLE [dbo].[SubeBilgileris]
ADD CONSTRAINT [PK_SubeBilgileris]
    PRIMARY KEY CLUSTERED ([SubeNo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SubeNo] in table 'AracBilgileris'
ALTER TABLE [dbo].[AracBilgileris]
ADD CONSTRAINT [FK_AracBilgileri_SubeBilgileri]
    FOREIGN KEY ([SubeNo])
    REFERENCES [dbo].[SubeBilgileris]
        ([SubeNo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AracBilgileri_SubeBilgileri'
CREATE INDEX [IX_FK_AracBilgileri_SubeBilgileri]
ON [dbo].[AracBilgileris]
    ([SubeNo]);
GO

-- Creating foreign key on [MusteriNo] in table 'SubeBilgileris'
ALTER TABLE [dbo].[SubeBilgileris]
ADD CONSTRAINT [FK_SubeBilgileri_MusteriBilgileri]
    FOREIGN KEY ([MusteriNo])
    REFERENCES [dbo].[MusteriBilgileris]
        ([MusteriNo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SubeBilgileri_MusteriBilgileri'
CREATE INDEX [IX_FK_SubeBilgileri_MusteriBilgileri]
ON [dbo].[SubeBilgileris]
    ([MusteriNo]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------