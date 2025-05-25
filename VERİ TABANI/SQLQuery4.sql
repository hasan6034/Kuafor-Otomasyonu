USE [master]
GO
/****** Object:  Database [Kuafor]    Script Date: 25.05.2025 18:27:50 ******/
CREATE DATABASE [Kuafor]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Kuafor', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Kuafor.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Kuafor_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Kuafor_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Kuafor] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Kuafor].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Kuafor] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Kuafor] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Kuafor] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Kuafor] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Kuafor] SET ARITHABORT OFF 
GO
ALTER DATABASE [Kuafor] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Kuafor] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Kuafor] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Kuafor] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Kuafor] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Kuafor] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Kuafor] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Kuafor] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Kuafor] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Kuafor] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Kuafor] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Kuafor] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Kuafor] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Kuafor] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Kuafor] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Kuafor] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Kuafor] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Kuafor] SET RECOVERY FULL 
GO
ALTER DATABASE [Kuafor] SET  MULTI_USER 
GO
ALTER DATABASE [Kuafor] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Kuafor] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Kuafor] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Kuafor] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Kuafor] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Kuafor] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Kuafor', N'ON'
GO
ALTER DATABASE [Kuafor] SET QUERY_STORE = ON
GO
ALTER DATABASE [Kuafor] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Kuafor]
GO
/****** Object:  Schema [log]    Script Date: 25.05.2025 18:27:50 ******/
CREATE SCHEMA [log]
GO
/****** Object:  UserDefinedDataType [dbo].[barkod_str]    Script Date: 25.05.2025 18:27:50 ******/
CREATE TYPE [dbo].[barkod_str] FROM [nvarchar](50) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[belgeno_str]    Script Date: 25.05.2025 18:27:50 ******/
CREATE TYPE [dbo].[belgeno_str] FROM [nvarchar](50) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[cihazseri_str]    Script Date: 25.05.2025 18:27:50 ******/
CREATE TYPE [dbo].[cihazseri_str] FROM [nvarchar](50) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[evrakseri_str]    Script Date: 25.05.2025 18:27:50 ******/
CREATE TYPE [dbo].[evrakseri_str] FROM [nvarchar](20) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[nvarchar_maxhesapisimno]    Script Date: 25.05.2025 18:27:50 ******/
CREATE TYPE [dbo].[nvarchar_maxhesapisimno] FROM [nvarchar](90) NULL
GO
/****** Object:  UserDefinedFunction [dbo].[fnCountRoldekiUser]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hasan Basri OY
-- Create date: 2023-10-05
-- Description:	Role Kayıtlı Kullanıcı Sayısını Döner
-- =============================================
CREATE FUNCTION [dbo].[fnCountRoldekiUser] 
(
	@RolID int
)
RETURNS int
AS
BEGIN
	
	declare @Result int

	select @Result = count(*) from dbo.Kullanicilar k where k.RolID = @RolID

	RETURN @Result

END
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetKulTamIsimByID]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fnGetKulTamIsimByID](@KulID int) RETURNS nvarchar(150)
AS
BEGIN
	RETURN isnull((select u.Adi + ' ' + u.Soyadi from dbo.Kullanicilar u where u.KulID = @KulID), '');
END;
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetModulAdiBySayfaID]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hasan Basri OY
-- Create date: 2024-10-05
-- Description:	SayfaID den ModulAdi Döner
-- =============================================
CREATE FUNCTION [dbo].[fnGetModulAdiBySayfaID]
(
	@SayfaID int
)
RETURNS nvarchar(255)
AS
BEGIN
declare @ModulID int = (select ModulID from dbo.stSayfalar where SayfaID = @SayfaID)
	RETURN (select ModulAdi from dbo.stModuller where ModulID = @ModulID)

END
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetRolAdiByID]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hasan Basri OY
-- Create date: 2024-10-05
-- Description:	RolID den RolAdi Döner
-- =============================================
CREATE FUNCTION [dbo].[fnGetRolAdiByID]
(
	@RolID int
)
RETURNS nvarchar(255)
AS
BEGIN
	RETURN (select RolAdi from dbo.Roller where RolID = @RolID)

END
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetSayfaAdiByID]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hasan Basri OY
-- Create date: 2024-10-05
-- Description:	SayfaID den SayfaAdi Döner
-- =============================================
CREATE FUNCTION [dbo].[fnGetSayfaAdiByID]
(
	@SayfaID int
)
RETURNS nvarchar(255)
AS
BEGIN
	RETURN (select SayfaAdi from dbo.stSayfalar where SayfaID = @SayfaID)

END
GO
/****** Object:  UserDefinedFunction [dbo].[fnGetYetkiKontrol]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hasan Basri OY
-- Create date: 2024-10-04
-- Description:	Kullanıcı Yetkisi Döner
-- =============================================
CREATE FUNCTION [dbo].[fnGetYetkiKontrol] 
(
	@SayfaID int,
	@YetkiTuru int,/* 0: Okuma / 1: Yazma / 2: Düzenleme / 3: Silme */
	@KulID int
)
RETURNS int
AS
BEGIN
	
	declare @Result int = 0;
	declare @RolID int = 0;

	select @RolID = k.RolID from Kullanicilar k where k.KulID = @KulID

	set @Result = isnull(( select 
						case when @YetkiTuru = 0 then y.Okuma else
							case when @YetkiTuru = 1 then y.Yazma else
								case when @YetkiTuru = 2 then y.Duzenleme else
									case when @YetkiTuru = 3 then y.Silme else 
										0
						end
							end
								end
									end
					from
						dbo.RolYetkileri y
					where
						y.RolID = @RolID and y.SayfaID = @SayfaID),0)
	

	
	RETURN @Result

END
GO
/****** Object:  UserDefinedFunction [dbo].[fnValueParser]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fnValueParser](@TamText varchar(max), @Ayrac varchar(max), @SiraNo int) returns int
AS
BEGIN
	declare @vSonuc int;
	
	select @vSonuc = isnull((select "Deger" 
							   from (select row_number() over (order by (select 1)) as "SiraNo", value as "Deger" from string_split(@TamText, @Ayrac)) as tbl
							  where tbl."SiraNo" = @SiraNo), -1);

	RETURN @vSonuc;
END;
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[KulID] [int] IDENTITY(1,1) NOT NULL,
	[KulAdi] [varchar](50) NOT NULL,
	[KulSifre] [varchar](50) NOT NULL,
	[RolID] [int] NOT NULL,
	[Adi] [varchar](50) NOT NULL,
	[Soyadi] [varchar](50) NOT NULL,
	[DurumID] [int] NOT NULL,
	[Maas] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[KulID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[tfKullanicilar]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hasan Basri OY
-- Create date: 2024-10-05
-- Description:	KulID değeri gelirse Tek Kullanıcı gelmezse Kullanıcı Listesi dönen fonksiyon
-- =============================================
CREATE FUNCTION [dbo].[tfKullanicilar]
(	
	@KulID int = -1
)
RETURNS TABLE 
AS
RETURN 
(	
	select 
		k.KulID		as "KulID",
		k.KulAdi	as "KulAdi",
		k.RolID		as "RolID",
		dbo.fnGetRolAdiByID(k.RolID) as "RolAdi",
		k.Adi		as "Adi",
		k.Soyadi	as "Soyadi",
		dbo.fnGetKulTamIsimByID(k.KulID) as "AdSoyad",
		k.KulSifre	as "KulSifre",
		k.DurumID	as "DurumID"
	from 
		dbo.Kullanicilar k
	where 
		k.KulID = case when @KulID = -1 then k.KulID else @KulID end
)
GO
/****** Object:  Table [dbo].[Roller]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roller](
	[RolID] [int] IDENTITY(1,1) NOT NULL,
	[RolAdi] [nvarchar](255) NULL,
	[OlusturanKulID] [int] NULL,
	[OlusturmaTarihi] [datetime] NULL,
	[GuncelleyenKulID] [int] NULL,
	[GuncellemeTarihi] [datetime] NULL,
 CONSTRAINT [PK_Roller] PRIMARY KEY CLUSTERED 
(
	[RolID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[tfRoller]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hasan Basri OY
-- Create date: 2024-10-05
-- Description:	RolID değeri gelirse Tek Rol gelmezse Rol Listesi dönen fonksiyon
-- =============================================
CREATE FUNCTION [dbo].[tfRoller]
(	
	@RolID int = -1
)
RETURNS TABLE 
AS
RETURN 
(
	select 
		-1 as "RolID",
		'Yeni Rol Ekle' as "RolAdi",
		'' as "KullaniciSayisi"
		union all
	select 
		r.RolID					as "RolID",
		r.RolAdi				as "RolAdi",
		'Kullanıcı Sayısı: '+cast(dbo.fnCountRoldekiUser(r.RolID) as nvarchar(32)) as "KullaniciSayisi"
	from
		dbo.Roller r
	where 
		r.RolID = case when @RolID = -1 then r.RolID else @RolID end
)
GO
/****** Object:  Table [dbo].[RolYetkileri]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolYetkileri](
	[RolID] [int] NOT NULL,
	[SayfaID] [int] NOT NULL,
	[Okuma] [int] NOT NULL,
	[Yazma] [int] NOT NULL,
	[Duzenleme] [int] NOT NULL,
	[Silme] [int] NOT NULL,
	[OlusturanKulID] [int] NOT NULL,
	[OlusturmaTarihi] [datetime] NULL,
 CONSTRAINT [PK_RolYetkileri] PRIMARY KEY CLUSTERED 
(
	[RolID] ASC,
	[SayfaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stSayfalar]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stSayfalar](
	[SayfaID] [int] NOT NULL,
	[ModulID] [int] NULL,
	[SayfaAdi] [varchar](50) NOT NULL,
 CONSTRAINT [PK_stSayfalar] PRIMARY KEY CLUSTERED 
(
	[SayfaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[tfRolYetkileriByRolID]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hasan Basri OY
-- Create date: 2024-10-05
-- Description:	Role Tanımlı Yetkileri Döner
-- =============================================
CREATE FUNCTION [dbo].[tfRolYetkileriByRolID]
(	
	@RoleID int = -1
)
RETURNS TABLE 
AS
RETURN 
(
	select top 10000
		isnull(y.RolID, -1)			as "RolID",
		isnull(dbo.fnGetRolAdiByID(y.RolID),'') as "RolAdi",
		s.SayfaID			as "SayfaID",
		dbo.fnGetSayfaAdiByID(s.SayfaID) as "SayfaAdi",
		dbo.fnGetModulAdiBySayfaID(s.SayfaID) as "ModulAdi",
		isnull(y.Okuma, 0)			as "Okuma",
		isnull(y.Yazma, 0)			as "Yazma",
		isnull(y.Duzenleme, 0)		as "Duzenleme",
		isnull(y.Silme, 0)			as "Silme",
		isnull(y.OlusturanKulID, -1)	as "OlusturanKulID",
		isnull(y.OlusturmaTarihi, GETDATE())	as "OlusturmaTarihi"
	from 
		dbo.stSayfalar s
	left join
		dbo.RolYetkileri y on s.SayfaID = y.SayfaID and y.RolID = @RoleID
	order by
		s.SayfaID
)
GO
/****** Object:  Table [dbo].[stModuller]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stModuller](
	[ModulID] [int] NOT NULL,
	[ModulAdi] [varchar](50) NULL,
 CONSTRAINT [PK_stModuller] PRIMARY KEY CLUSTERED 
(
	[ModulID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[tfMenuGetir]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hasan Basri OY
-- Create date: 2024-10-08
-- Description:	Menü Listesi dönen fonksiyon
-- =============================================
CREATE FUNCTION [dbo].[tfMenuGetir](@RolID int)
RETURNS TABLE 
AS
RETURN 
(
	select 
		 s.SayfaID			as "SayfaID",
		 s.SayfaAdi			as "SayfaAdi",
		 s.ModulID			as "ModulID",
		 m.ModulAdi			as "ModulAdi"
	from 
		dbo.stSayfalar s
	inner join
		dbo.stModuller m on s.ModulID = m.ModulID
	where
		s.SayfaID in (select y.SayfaID from dbo.RolYetkileri y where y.RolID = @RolID and y.Okuma = 1)

)
GO
/****** Object:  Table [dbo].[Subeler]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subeler](
	[SubeID] [int] IDENTITY(1,1) NOT NULL,
	[SubeAdi] [varchar](50) NOT NULL,
	[TelefonNo] [varchar](11) NULL,
	[Adres] [varchar](max) NULL,
	[Durum] [int] NULL,
	[ToplamGelir] [int] NULL,
 CONSTRAINT [PK_Subeler] PRIMARY KEY CLUSTERED 
(
	[SubeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[tfSubeler]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hasan Basri OY
-- Create date: 2024-10-05
-- Description:	SubeID değeri gelirse Tek Şube gelmezse Şube Listesi dönen fonksiyon
-- =============================================
CREATE FUNCTION [dbo].[tfSubeler]
(	
	@SubeID int = -1
)
RETURNS TABLE 
AS
RETURN 
(	
	select 
		s.SubeID		as "SubeID",
		s.SubeAdi		as "SubeAdi",
		s.TelefonNo		as "TelefonNo",
		s.Adres			as "Adres"
	from 
		dbo.Subeler s
	where 
		s.SubeID = case when @SubeID = -1 then s.SubeID else @SubeID end and
		s.Durum = 1
)
GO
/****** Object:  Table [log].[Hatalar]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [log].[Hatalar](
	[HataKodu] [int] NOT NULL,
	[HataMesaji] [nvarchar](255) NOT NULL,
	[HataAciklamasi] [nvarchar](255) NULL,
 CONSTRAINT [PK_Hatalar] PRIMARY KEY CLUSTERED 
(
	[HataKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [log].[UygulamaHatalari]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [log].[UygulamaHatalari](
	[HataID] [int] IDENTITY(1,1) NOT NULL,
	[HataKodu] [int] NOT NULL,
	[HataMesaji] [nvarchar](max) NOT NULL,
	[MetodAdi] [nvarchar](255) NOT NULL,
	[KulID] [int] NOT NULL,
	[HataTarihi] [datetime] NOT NULL,
 CONSTRAINT [PK_UygulamaHatalari] PRIMARY KEY CLUSTERED 
(
	[HataID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kullanicilar] ON 
GO
INSERT [dbo].[Kullanicilar] ([KulID], [KulAdi], [KulSifre], [RolID], [Adi], [Soyadi], [DurumID], [Maas]) VALUES (-1, N'', N'', -1, N'Yeni Kullanıcı Ekle', N'', -1, NULL)
GO
INSERT [dbo].[Kullanicilar] ([KulID], [KulAdi], [KulSifre], [RolID], [Adi], [Soyadi], [DurumID], [Maas]) VALUES (24, N'Hasan', N'1234', 2, N'Hasan Basri', N'OY', 1, CAST(57846 AS Decimal(18, 0)))
GO
INSERT [dbo].[Kullanicilar] ([KulID], [KulAdi], [KulSifre], [RolID], [Adi], [Soyadi], [DurumID], [Maas]) VALUES (28, N'caner', N'1234', 2, N'Caner', N'ORAK', 1, CAST(57964 AS Decimal(18, 0)))
GO
INSERT [dbo].[Kullanicilar] ([KulID], [KulAdi], [KulSifre], [RolID], [Adi], [Soyadi], [DurumID], [Maas]) VALUES (29, N'Melih', N'1234', 6, N'Melih', N'Tatlıpınar', 1, CAST(32104 AS Decimal(18, 0)))
GO
INSERT [dbo].[Kullanicilar] ([KulID], [KulAdi], [KulSifre], [RolID], [Adi], [Soyadi], [DurumID], [Maas]) VALUES (30, N'Burak', N'1234', 5, N'Burak', N'Çeçen', 0, CAST(22104 AS Decimal(18, 0)))
GO
INSERT [dbo].[Kullanicilar] ([KulID], [KulAdi], [KulSifre], [RolID], [Adi], [Soyadi], [DurumID], [Maas]) VALUES (31, N'Kürşat', N'1234', 7, N'Kürşat', N'Kutluyer', 1, CAST(30104 AS Decimal(18, 0)))
GO
INSERT [dbo].[Kullanicilar] ([KulID], [KulAdi], [KulSifre], [RolID], [Adi], [Soyadi], [DurumID], [Maas]) VALUES (32, N'Zafer', N'1234', 5, N'Zafer', N'Şimşek', 1, CAST(22104 AS Decimal(18, 0)))
GO
INSERT [dbo].[Kullanicilar] ([KulID], [KulAdi], [KulSifre], [RolID], [Adi], [Soyadi], [DurumID], [Maas]) VALUES (33, N'İlyas', N'1234', 5, N'İlyas', N'Civcik', 1, CAST(22104 AS Decimal(18, 0)))
GO
INSERT [dbo].[Kullanicilar] ([KulID], [KulAdi], [KulSifre], [RolID], [Adi], [Soyadi], [DurumID], [Maas]) VALUES (34, N'Ruhi', N'ruhi1234', 5, N'Ruhi', N'Çenet', 1, CAST(22104 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[Kullanicilar] OFF
GO
SET IDENTITY_INSERT [dbo].[Roller] ON 
GO
INSERT [dbo].[Roller] ([RolID], [RolAdi], [OlusturanKulID], [OlusturmaTarihi], [GuncelleyenKulID], [GuncellemeTarihi]) VALUES (2, N'Admin', 24, CAST(N'2024-10-05T15:06:28.273' AS DateTime), 24, CAST(N'2024-10-05T15:17:37.007' AS DateTime))
GO
INSERT [dbo].[Roller] ([RolID], [RolAdi], [OlusturanKulID], [OlusturmaTarihi], [GuncelleyenKulID], [GuncellemeTarihi]) VALUES (5, N'Personel', 24, CAST(N'2024-10-05T16:35:51.407' AS DateTime), 28, CAST(N'2025-05-25T16:14:33.523' AS DateTime))
GO
INSERT [dbo].[Roller] ([RolID], [RolAdi], [OlusturanKulID], [OlusturmaTarihi], [GuncelleyenKulID], [GuncellemeTarihi]) VALUES (6, N'Müdür', 28, CAST(N'2025-05-25T16:15:13.700' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Roller] ([RolID], [RolAdi], [OlusturanKulID], [OlusturmaTarihi], [GuncelleyenKulID], [GuncellemeTarihi]) VALUES (7, N'Müdür Yardımcısı', 28, CAST(N'2025-05-25T16:15:44.880' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Roller] OFF
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (2, 1001, 1, 1, 1, 1, 24, CAST(N'2024-10-05T15:17:37.007' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (2, 1002, 1, 1, 1, 1, 24, CAST(N'2024-10-05T15:17:37.007' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (2, 2001, 1, 1, 1, 1, 24, CAST(N'2024-10-05T15:17:37.007' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (2, 2002, 1, 1, 1, 1, 24, CAST(N'2024-10-05T15:17:37.007' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (2, 3001, 1, 1, 1, 1, 24, CAST(N'2024-10-05T15:17:37.007' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (2, 3002, 1, 1, 1, 1, 24, CAST(N'2024-10-05T15:17:37.007' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (2, 4001, 1, 1, 1, 1, 24, CAST(N'2024-10-05T15:17:37.007' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (2, 4002, 1, 1, 1, 1, 24, CAST(N'2024-10-05T15:17:37.007' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (2, 4003, 1, 1, 1, 1, 24, CAST(N'2024-10-05T15:17:37.007' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (5, 1001, 0, 0, 0, 0, 28, CAST(N'2025-05-25T16:14:33.523' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (5, 1002, 0, 0, 0, 0, 28, CAST(N'2025-05-25T16:14:33.523' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (5, 2001, 1, 1, 1, 0, 28, CAST(N'2025-05-25T16:14:33.523' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (5, 2002, 1, 1, 1, 0, 28, CAST(N'2025-05-25T16:14:33.523' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (5, 3001, 0, 0, 0, 0, 28, CAST(N'2025-05-25T16:14:33.523' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (5, 3002, 0, 0, 0, 0, 28, CAST(N'2025-05-25T16:14:33.523' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (5, 4001, 0, 0, 0, 0, 28, CAST(N'2025-05-25T16:14:33.523' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (5, 4002, 0, 0, 0, 0, 28, CAST(N'2025-05-25T16:14:33.523' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (5, 4003, 0, 0, 0, 0, 28, CAST(N'2025-05-25T16:14:33.523' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (6, 1001, 1, 1, 1, 1, 28, CAST(N'2025-05-25T16:15:13.700' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (6, 1002, 1, 1, 1, 1, 28, CAST(N'2025-05-25T16:15:13.700' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (6, 2001, 1, 1, 1, 1, 28, CAST(N'2025-05-25T16:15:13.700' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (6, 2002, 1, 1, 1, 1, 28, CAST(N'2025-05-25T16:15:13.700' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (6, 3001, 1, 1, 1, 1, 28, CAST(N'2025-05-25T16:15:13.700' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (6, 3002, 1, 1, 1, 1, 28, CAST(N'2025-05-25T16:15:13.700' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (6, 4001, 1, 1, 1, 1, 28, CAST(N'2025-05-25T16:15:13.700' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (6, 4002, 1, 1, 1, 1, 28, CAST(N'2025-05-25T16:15:13.700' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (6, 4003, 1, 1, 1, 1, 28, CAST(N'2025-05-25T16:15:13.700' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (7, 1001, 0, 0, 0, 0, 28, CAST(N'2025-05-25T16:15:44.880' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (7, 1002, 0, 0, 0, 0, 28, CAST(N'2025-05-25T16:15:44.880' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (7, 2001, 1, 1, 1, 1, 28, CAST(N'2025-05-25T16:15:44.880' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (7, 2002, 1, 1, 1, 1, 28, CAST(N'2025-05-25T16:15:44.880' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (7, 3001, 0, 0, 0, 0, 28, CAST(N'2025-05-25T16:15:44.880' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (7, 3002, 0, 0, 0, 0, 28, CAST(N'2025-05-25T16:15:44.880' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (7, 4001, 1, 1, 1, 1, 28, CAST(N'2025-05-25T16:15:44.880' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (7, 4002, 0, 0, 0, 0, 28, CAST(N'2025-05-25T16:15:44.880' AS DateTime))
GO
INSERT [dbo].[RolYetkileri] ([RolID], [SayfaID], [Okuma], [Yazma], [Duzenleme], [Silme], [OlusturanKulID], [OlusturmaTarihi]) VALUES (7, 4003, 0, 0, 0, 0, 28, CAST(N'2025-05-25T16:15:44.880' AS DateTime))
GO
INSERT [dbo].[stModuller] ([ModulID], [ModulAdi]) VALUES (1000, N'Kullanıcı')
GO
INSERT [dbo].[stModuller] ([ModulID], [ModulAdi]) VALUES (2000, N'İşletme Ayarları')
GO
INSERT [dbo].[stModuller] ([ModulID], [ModulAdi]) VALUES (3000, N'Müşteri')
GO
INSERT [dbo].[stModuller] ([ModulID], [ModulAdi]) VALUES (4000, N'Rapor')
GO
INSERT [dbo].[stSayfalar] ([SayfaID], [ModulID], [SayfaAdi]) VALUES (1001, 1000, N'Kullanıcı İşlemleri')
GO
INSERT [dbo].[stSayfalar] ([SayfaID], [ModulID], [SayfaAdi]) VALUES (1002, 1000, N'Kullanıcı Rol Tanımları')
GO
INSERT [dbo].[stSayfalar] ([SayfaID], [ModulID], [SayfaAdi]) VALUES (2001, 2000, N'Şube İşlemleri')
GO
INSERT [dbo].[stSayfalar] ([SayfaID], [ModulID], [SayfaAdi]) VALUES (2002, 2000, N'Hizmet İşlemleri')
GO
INSERT [dbo].[stSayfalar] ([SayfaID], [ModulID], [SayfaAdi]) VALUES (3001, 3000, N'Müşteri İşlemleri')
GO
INSERT [dbo].[stSayfalar] ([SayfaID], [ModulID], [SayfaAdi]) VALUES (3002, 3000, N'Randevu İşlemleri')
GO
INSERT [dbo].[stSayfalar] ([SayfaID], [ModulID], [SayfaAdi]) VALUES (4001, 4000, N'Müşteri Bazlı Rapor')
GO
INSERT [dbo].[stSayfalar] ([SayfaID], [ModulID], [SayfaAdi]) VALUES (4002, 4000, N'Personel Bazlı Rapor')
GO
INSERT [dbo].[stSayfalar] ([SayfaID], [ModulID], [SayfaAdi]) VALUES (4003, 4000, N'Şube Bazlı Rapor')
GO
SET IDENTITY_INSERT [dbo].[Subeler] ON 
GO
INSERT [dbo].[Subeler] ([SubeID], [SubeAdi], [TelefonNo], [Adres], [Durum], [ToplamGelir]) VALUES (-1, N'Yeni Şube Ekle', N'', N'', 1, NULL)
GO
INSERT [dbo].[Subeler] ([SubeID], [SubeAdi], [TelefonNo], [Adres], [Durum], [ToplamGelir]) VALUES (3, N'ÖZ ORAK KUAFÖR', N'05528439530', N'Yeşilbayı.Mah/Sağduyu.Cad/NO:6 MAMA/ANKARA', 1, 10566)
GO
INSERT [dbo].[Subeler] ([SubeID], [SubeAdi], [TelefonNo], [Adres], [Durum], [ToplamGelir]) VALUES (4, N'OY GÜZELLİK MERKEZİ', N'05380758134', N'Hamidiye.mah/100.yıl Bulvarı/NO:8 MERKEZ/KARAMAN', 1, 5165)
GO
INSERT [dbo].[Subeler] ([SubeID], [SubeAdi], [TelefonNo], [Adres], [Durum], [ToplamGelir]) VALUES (5, N'ELDEM SAÇ VE TIRNAK BAKIM MERKEZİ', N'05554443322', N'Yunus Emre.mah/Türk Dili sokağı/NO:12 MERKEZ/KARAMAN', 1, 1243)
GO
INSERT [dbo].[Subeler] ([SubeID], [SubeAdi], [TelefonNo], [Adres], [Durum], [ToplamGelir]) VALUES (6, N'DİLAN POLAT GÜZELLİK MERKEZİ', N'03124561235', N'SARI GAZİ.MAH/FIRTINA.SK/NO:9 SANCAKTEPE/İSTANBUL', 1, 8850)
GO
INSERT [dbo].[Subeler] ([SubeID], [SubeAdi], [TelefonNo], [Adres], [Durum], [ToplamGelir]) VALUES (7, N'DİLEK TANRIVERDİ GÜZELLİK MERKEZİ', N'05554443322', N'KURTULUŞ.SK/ŞEHİTLER.CAD/NO:3 BEBEK/İSTANBUL', 0, NULL)
GO
SET IDENTITY_INSERT [dbo].[Subeler] OFF
GO
INSERT [log].[Hatalar] ([HataKodu], [HataMesaji], [HataAciklamasi]) VALUES (50010, N'Kullanıcı Adı ve/veya Şifre Hatalı.', N'Kullanıcı Bulunamadı.')
GO
INSERT [log].[Hatalar] ([HataKodu], [HataMesaji], [HataAciklamasi]) VALUES (50011, N'Kullanıcı Durumu Pasif. Lütfen Yetkilinizle Görüşün.', N'Kullanıcı Durumu 1 değil.')
GO
INSERT [log].[Hatalar] ([HataKodu], [HataMesaji], [HataAciklamasi]) VALUES (50012, N'Kullanıcı Kaydı Bulunamadı', N'UserID -1 Değil ve Kullanıcı Tablosunda yok')
GO
INSERT [log].[Hatalar] ([HataKodu], [HataMesaji], [HataAciklamasi]) VALUES (50013, N'Kullanıcı Adını Kullanan Aktif Bir Kullanıcı Var.', N'Tabloda Kullanıcı Adina kayıtlı kullanıcı var.')
GO
INSERT [log].[Hatalar] ([HataKodu], [HataMesaji], [HataAciklamasi]) VALUES (50020, N'Rol Kaydı Bulunamadı', N'RolID Tabloda Yok')
GO
INSERT [log].[Hatalar] ([HataKodu], [HataMesaji], [HataAciklamasi]) VALUES (50021, N'Rol Adı Daha Önce Kullanıldı. Lütfen Değiştirip Tekrar Deneyin.', N'Aynı Rol Adı Var.')
GO
INSERT [log].[Hatalar] ([HataKodu], [HataMesaji], [HataAciklamasi]) VALUES (50022, N'Kullanıcıya Tanımlı Rol Silinenmez', N'Kullanıcılar tablosunda olan RolID')
GO
INSERT [log].[Hatalar] ([HataKodu], [HataMesaji], [HataAciklamasi]) VALUES (54000, N'Kayıt Görüntüleme Yetkiniz Bulunamadı. Lütfen Yetkinizle Görüşün.', N'Okuma Yetkisi Yok')
GO
INSERT [log].[Hatalar] ([HataKodu], [HataMesaji], [HataAciklamasi]) VALUES (54001, N'Kayıt Ekleme Yetkiniz Bulunamadı. Lütfen Yetkilinizle Görüşün.', N'Yazma Yetkisi Yok')
GO
INSERT [log].[Hatalar] ([HataKodu], [HataMesaji], [HataAciklamasi]) VALUES (54002, N'Kayıt Düzenleme Yetkiniz Bulunamadı. Lütfen Yetkilinizle Görüşün.', N'Düzenleme Yetkisi Yok')
GO
INSERT [log].[Hatalar] ([HataKodu], [HataMesaji], [HataAciklamasi]) VALUES (54003, N'Kayıt Silme Yetkiniz Bulunamadı. Lütfen Yetkilinizle Görüşün', N'Silme Yetkisi Yok')
GO
INSERT [log].[Hatalar] ([HataKodu], [HataMesaji], [HataAciklamasi]) VALUES (55001, N'Şube Bulunamadı', NULL)
GO
SET IDENTITY_INSERT [log].[UygulamaHatalari] ON 
GO
INSERT [log].[UygulamaHatalari] ([HataID], [HataKodu], [HataMesaji], [MetodAdi], [KulID], [HataTarihi]) VALUES (1, -2147467261, N'Değer null olamaz.
Parametre adı: source', N'simpleButton_RolKaydet_Click', 1, CAST(N'2024-10-05T14:56:28.237' AS DateTime))
GO
SET IDENTITY_INSERT [log].[UygulamaHatalari] OFF
GO
ALTER TABLE [dbo].[RolYetkileri] ADD  CONSTRAINT [DF_RolYetkileri_Okuma]  DEFAULT ((0)) FOR [Okuma]
GO
ALTER TABLE [dbo].[RolYetkileri] ADD  CONSTRAINT [DF_RolYetkileri_Yazma]  DEFAULT ((0)) FOR [Yazma]
GO
ALTER TABLE [dbo].[RolYetkileri] ADD  CONSTRAINT [DF_RolYetkileri_Düzenleme]  DEFAULT ((0)) FOR [Duzenleme]
GO
ALTER TABLE [dbo].[RolYetkileri] ADD  CONSTRAINT [DF_RolYetkileri_OlusturanKulID]  DEFAULT ((-1)) FOR [OlusturanKulID]
GO
/****** Object:  StoredProcedure [dbo].[GirisKontrol]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hasan Basri OY
-- Create date: 2024-10-05
-- Description:	Giriş Kontrol
-- =============================================
CREATE PROCEDURE [dbo].[GirisKontrol]
	@KulAdi nvarchar(255),
	@KulSifre nvarchar(15)

AS
BEGIN
	declare @KulID int
	declare @Durum int 
	select 
		@KulID = k.KulID,
		@Durum = k.DurumID
	from 
		dbo.Kullanicilar k 
	where 
		k.KulAdi = @KulAdi and k.KulSifre = @KulSifre

	if isnull(@KulID,-1) = -1
		begin
			exec log.sysHataGonder 50010, -2;
		end
	else if @Durum = 1
			begin
				select
					k.KulID as "KulID",
					k.KulAdi as "KulAdi",
					k.RolID as "RolID",
					k.RolAdi as "RolAdi",
					k.Adi as "Adi",
					k.Soyadi as "Soyadi",
					k.AdSoyad as "AdSoyad",
					k.KulSifre as KulSifre,
					k.DurumID as "DurumID"
				from 
					tfKullanicilar(@KulID) k
			end
		 else
			begin
				exec log.sysHataGonder 50011, @KulID;
			end
END
GO
/****** Object:  StoredProcedure [dbo].[KullaniciDELETE]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hasan Basri OY
-- Create date: 2024-10-05
-- Description:	Kullanıcı Silme veya Pasife Alma
-- =============================================
CREATE PROCEDURE [dbo].[KullaniciDELETE]
	@KulID int,

	@SayfaID int,
	@OlusturanKulID int
AS
BEGIN
	declare @TransactionName varchar(20) = 'Transaction1';
	declare @ErpPerKod nvarchar(25);
	declare @RowCount int = 0;
	declare @UseCount int = 0;

	select @RowCount = count(*) from dbo.Kullanicilar k where k.KulID = @KulID;
		
	if @RowCount = 0
		begin
			exec log.sysHataGonder 50012, @OlusturanKulID;
		end

	begin try
	
		begin tran @TransactionName;
			if(dbo.fnGetYetkiKontrol(@SayfaID, 3, @OlusturanKulID) = 0) begin exec log.sysHataGonder 54003, @OlusturanKulID; end
			if @UseCount > 0
				begin
					update dbo.Kullanicilar set DurumID = 0 where KulID = @KulID
				end
			else
				begin
					delete dbo.Kullanicilar where KulID = @KulID
				end
		
		commit;
		select @KulID
	end try

	begin catch
		if @@trancount > 0 rollback tran @TransactionName;/*Transaction varsa rollback at*/		
		/*	   Hata Loglanıyor     */
		declare @vErrorNumber int, @vErrorMessage nvarchar(500), @LogID varchar(50), @vCustomMessage varchar(100);
		SELECT @vErrorNumber = ERROR_NUMBER(), @vErrorMessage = ERROR_MESSAGE();
		exec log.sysHataKaydet @vErrorNumber, @vErrorMessage, @OlusturanKulID, @LogID output;	-- Hatayı Logla...
		select @vCustomMessage = 'Veritabanı Hatası!' + ' [' + @LogID + ']';
		if @vErrorNumber > 50000 begin; throw; end else begin; throw 50005, @vCustomMessage, 1; end; 	-- Hatayı geri döndür...		
	end catch;
END
GO
/****** Object:  StoredProcedure [dbo].[KullaniciSAVE]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hasan Basri OY
-- Create date: 2024-10-05
-- Description:	Kullanıcı Oluşturma Güncelleme
-- =============================================
CREATE PROCEDURE [dbo].[KullaniciSAVE]
	@KulID int,
	@KulAdi nvarchar(255),
	@RolID int,
	@Adi nvarchar(255),
	@Soyadi	nvarchar(255),
	@KulSifre nvarchar(15),
	@DurumID int,

	@SayfaID int,
	@OlusturanKulID int
AS
BEGIN
	declare @TransactionName varchar(20) = 'Transaction1';
	declare @Result int =-1;
	declare @vRowCount int = 0;
	declare @vErrorCount int = 0;

	select @vRowCount = count(*) from dbo.Kullanicilar u where u.KulID = @KulID and u.DurumID = 1;
		
		if @vRowCount = 0 and @KulID <> -1 
			begin 
				exec log.sysHataGonder 50012, @OlusturanKulID; 
			end;

		select @vErrorCount = count(*) from dbo.Kullanicilar u where u.KulID <> @KulID and u.DurumID = 1 and u.KulAdi = @KulAdi;

		if @vErrorCount = 1 
			begin 
				exec log.sysHataGonder 50013, @OlusturanKulID; 
			end;

	begin try
			
		begin tran @TransactionName;

			if @vRowCount = 0
				begin
					if(dbo.fnGetYetkiKontrol(@SayfaID, 1, @OlusturanKulID) = 0) begin exec log.sysHataGonder 54001, @OlusturanKulID; end
					insert into dbo.Kullanicilar
						(KulAdi, RolID, Adi, Soyadi, KulSifre, DurumID)
					values
						(@KulAdi, @RolID, @Adi, @Soyadi, @KulSifre, @DurumID)

					set @Result = scope_identity()
				end
			else
				begin
					if(dbo.fnGetYetkiKontrol(@SayfaID, 2, @OlusturanKulID) = 0) begin exec log.sysHataGonder 54002, @OlusturanKulID; end
					update dbo.Kullanicilar
					set 
						KulAdi = @KulAdi,
						RolID = @RolID,
						Adi = @Adi,
						Soyadi = @Soyadi,
						KulSifre = @KulSifre,
						DurumID = @DurumID
					where
						KulID = @KulID

					set @Result = @KulID
				end		
		commit;
		select @Result as "Sonuc";
	end try

	begin catch
		if @@trancount > 0 rollback tran @TransactionName;/*Transaction varsa rollback at*/		
		/*	   Hata Loglanıyor     */
		declare @vErrorNumber int, @vErrorMessage nvarchar(500), @LogID varchar(50), @vCustomMessage varchar(100);
		SELECT @vErrorNumber = ERROR_NUMBER(), @vErrorMessage = ERROR_MESSAGE();
		exec log.sysHataKaydet @vErrorNumber, @vErrorMessage, @OlusturanKulID, @LogID output;	-- Hatayı Logla...
		select @vCustomMessage = 'Veritabanı Hatası!' + ' [' + @LogID + ']';
		if @vErrorNumber > 50000 begin; throw; end else begin; throw 50005, @vCustomMessage, 1; end; 	-- Hatayı geri döndür...		
	end catch;
END
GO
/****** Object:  StoredProcedure [dbo].[Raporla_Personel]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Raporla_Personel]
AS
BEGIN
    SET NOCOUNT ON;

    -- =============================================
-- Author:		CANER ORAK
-- Create date: 25.05.2025
-- Description:	PERSONEL BAZINDA RAPORLAMA, MAAŞ ÜCRETLERİNDE KDV HESAPLAMA
-- =============================================

    DECLARE @SimdikiTarihSaat DATETIME = CAST(CONVERT(VARCHAR(16), GETDATE(), 120) AS DATETIME);

    DECLARE @ToplamMaas MONEY = (SELECT SUM(ISNULL(Maas, 0)) FROM Kullanicilar WHERE DurumID = 1);
    DECLARE @ToplamKDV MONEY = ROUND(@ToplamMaas * 0.20, 2);

    
    SELECT 
        KulID,
        KulAdi,
        KulSifre,
        RolID,
        Adi,
        Soyadi,
        Maas,
        ROUND(Maas * 0.20, 2) AS MaasKDV,
        ROUND(Maas * 1, 2) AS MaasKDVDahil,
        @ToplamMaas AS ToplamMaas,
        @ToplamKDV AS ToplamKDV,
        ROUND(@ToplamMaas, 2) AS ToplamKDVDahil,
        @SimdikiTarihSaat AS SimdikiTarihSaat
    FROM 
        Kullanicilar
    WHERE 
        DurumID = 1
END;
GO
/****** Object:  StoredProcedure [dbo].[Raporla_SubeGelirDurumu]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Raporla_SubeGelirDurumu]
AS
BEGIN
    SET NOCOUNT ON;
-- =============================================
-- Author:		CANER ORAK
-- Create date: 25.05.2025
-- Description:	ŞUBE BAZINDA RAPORLAMA VE RAPOR ZAMANI VERİSİ ALMA
-- =============================================

    DECLARE @SimdikiTarihSaat DATETIME = CAST(CONVERT(VARCHAR(16), GETDATE(), 120) AS DATETIME);

    DECLARE @IlkSubeID INT = (SELECT MIN(SubeID) FROM Subeler);

    DECLARE @ToplamUcret MONEY = (
        SELECT SUM(ISNULL(ToplamGelir, 0)) 
        FROM Subeler 
        WHERE SubeID <> @IlkSubeID
    );
    DECLARE @ToplamKDV MONEY = ROUND(@ToplamUcret * 0.20, 2);
    DECLARE @ToplamKDVDahil MONEY = ROUND(@ToplamUcret + @ToplamKDV, 2);

    SELECT 
        SubeID,
        SubeAdi,
        TelefonNo,
        Adres,
        ISNULL(ToplamGelir, 0) AS ToplamGelir,
        ROUND(ISNULL(ToplamGelir, 0) * 0.20, 2) AS SubeKDV,
        ROUND(ISNULL(ToplamGelir, 0) * 1.20, 2) AS SubeKDVDahilTutar,
        @ToplamUcret AS ToplamUcret,
        @ToplamKDV AS ToplamKDV,
        @ToplamKDVDahil AS ToplamKDVDahilTutar,
        @SimdikiTarihSaat AS SimdikiTarihSaat
    FROM 
        Subeler
    WHERE 
        SubeID <> @IlkSubeID
END;
GO
/****** Object:  StoredProcedure [dbo].[RolDELETE]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hasan Basri OY
-- Create date: 2024-10-05
-- Description:	Kullanılmayan Rolü Silebilen Prosedür
-- =============================================
CREATE PROCEDURE [dbo].[RolDELETE]
	@RolID int,

	@SayfaID int,
	@KulID int
AS
BEGIN
	declare @TransactionName varchar(20) = 'Transaction1';
	declare @vRowCount int = 0;
	declare @vKullananKullCount int = 0;

	select @vRowCount = count(*) from dbo.Roller r where r.RolID = @RolID;
	select @vKullananKullCount = count(*) from dbo.Kullanicilar k where k.RolID = @RolID;

	if @vRowCount = 0
		begin
			exec log.sysHataGonder 50020, @KulID;
		end

	if @vKullananKullCount > 0
		begin
			exec log.sysHataGonder 50022, @KulID;
		end

	begin try
			
		begin tran @TransactionName;
			if(dbo.fnGetYetkiKontrol(@SayfaID, 3, @KulID) = 0) begin exec log.sysHataGonder 54003, @KulID; end
			delete Roller where RolID = @RolID
			delete RolYetkileri where RolID = @RolID
		
		commit;
		select @RolID as "Sonuc"
	end try

	begin catch
		if @@trancount > 0 rollback tran @TransactionName;/*Transaction varsa rollback at*/		
		/*	   Hata Loglanıyor     */
		declare @vErrorNumber int, @vErrorMessage nvarchar(500), @LogID varchar(50), @vCustomMessage varchar(100);
		SELECT @vErrorNumber = ERROR_NUMBER(), @vErrorMessage = ERROR_MESSAGE();
		exec log.sysHataKaydet @vErrorNumber, @vErrorMessage, @KulID, @LogID output;	-- Hatayı Logla...
		select @vCustomMessage = 'Veritabanı Hatası!' + ' [' + @LogID + ']';
		if @vErrorNumber > 50000 begin; throw; end else begin; throw 50005, @vCustomMessage, 1; end; 	-- Hatayı geri döndür...		
	end catch;
END
GO
/****** Object:  StoredProcedure [dbo].[RolSAVE]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Hasan Basri OY
-- Create date: 2024-10-05
-- Description:	Rol Ekleme Ve Düzenlem
-- =============================================
CREATE PROCEDURE [dbo].[RolSAVE]
	@RolID int,
	@RolAdi nvarchar(255),
	@Yetkiler nvarchar(max),

	@SayfaID int,
	@KulID int
AS
BEGIN
	declare @TransactionName varchar(20) = 'Transaction1';

	declare @vRowCount int = 0;
	declare @vRowNameCount int = 0;
	declare @vToday datetime = getdate();
	DECLARE @vRecordID int;
	
	select @vRowCount = count(*) from dbo.Roller r where r.RolID = @RolID;

	select @vRowNameCount = count(*) from dbo.Roller r where r.RolAdi = @RolAdi
														  and r.RolID <> @RolID;
	if @vRowCount = 0 and @RolID <> -1
		begin
			exec log.sysHataGonder 50020, @KulID;
		end
	if @vRowNameCount > 0
		begin
			exec log.sysHataGonder 50021, @KulID;
		end

	begin try
			
		begin tran @TransactionName;

			if @vRowCount = 0
				begin
					if(dbo.fnGetYetkiKontrol(@SayfaID, 1, @KulID) = 0) begin exec log.sysHataGonder 54001, @KulID; end
					insert into dbo.Roller
						(RolAdi, OlusturanKulID, OlusturmaTarihi)
					values
						(@RolAdi, @KulID, @vToday)

					set @vRecordID = scope_identity()

					if len(@Yetkiler) > 0
						begin
							-- Sayfa Yetkilerini Ekle...
							insert into dbo.RolYetkileri 
								(RolID, SayfaID, Okuma, Yazma, Duzenleme, Silme, 
								 OlusturanKulID, OlusturmaTarihi)
							select @vRecordID as "RoleID",
								   dbo.fnValueParser(value, ',', 1) as "SayfaID",
								   dbo.fnValueParser(value, ',', 2) as "Okuma",
								   dbo.fnValueParser(value, ',', 3) as "Yazma",
								   dbo.fnValueParser(value, ',', 4) as "Duzenleme",
								   dbo.fnValueParser(value, ',', 5) as "Silme",
								   
								   @KulID as "OlusturanKulID",
								   @vToday as "OlusturmaTarihi"
							from string_split(@Yetkiler, '@') as tbl
							where dbo.fnValueParser(value, ',', 1) <> 0
						end
				end
			else
				begin
					if(dbo.fnGetYetkiKontrol(@SayfaID, 2, @KulID) = 0) begin exec log.sysHataGonder 54002, @KulID; end


					update dbo.Roller
					set
						RolAdi = @RolAdi,
						GuncelleyenKulID = @KulID,
						GuncellemeTarihi = @vToday
					where
						RolID = @RolID

					-- Sayfa Yetkilerini Yeniden Ekle...
					delete dbo.RolYetkileri where RolID = @RolID
							
					insert into dbo.RolYetkileri 
						(RolID, SayfaID, Okuma, Yazma, Duzenleme, Silme, 
						 OlusturanKulID, OlusturmaTarihi)
					select @RolID as "RoleID",
						   dbo.fnValueParser(value, ',', 1) as "SayfaID",
						   dbo.fnValueParser(value, ',', 2) as "Okuma",
						   dbo.fnValueParser(value, ',', 3) as "Yazma",
						   dbo.fnValueParser(value, ',', 4) as "Duzenleme",
						   dbo.fnValueParser(value, ',', 5) as "Silme",
						   
						   @KulID as "OlusturanKulID",
						   @vToday as "OlusturmaTarihi"
					from string_split(@Yetkiler, '@') as tbl
					where dbo.fnValueParser(value, ',', 1) <> 0

					set @vRecordID = @RolID
				end		
		commit;
		select @vRecordID as "Sonuc"
	end try

	begin catch
		if @@trancount > 0 rollback tran @TransactionName;/*Transaction varsa rollback at*/		
		/*	   Hata Loglanıyor     */
		declare @vErrorNumber int, @vErrorMessage nvarchar(500), @LogID varchar(50), @vCustomMessage varchar(100);
		SELECT @vErrorNumber = ERROR_NUMBER(), @vErrorMessage = ERROR_MESSAGE();
		exec log.sysHataKaydet @vErrorNumber, @vErrorMessage, @KulID, @LogID output;	-- Hatayı Logla...
		select @vCustomMessage = 'Veritabanı Hatası!' + ' [' + @LogID + ']';
		if @vErrorNumber > 50000 begin; throw; end else begin; throw 50005, @vCustomMessage, 1; end; 	-- Hatayı geri döndür...		
	end catch;
END
GO
/****** Object:  StoredProcedure [dbo].[SubeDELETE]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hasan Basri OY
-- Create date: 2024-10-05
-- Description:	Şube Silme
-- =============================================
CREATE PROCEDURE [dbo].[SubeDELETE]
	@SubeID int,

	@SayfaID int,
	@OlusturanKulID int
AS
BEGIN
	declare @TransactionName varchar(20) = 'Transaction1';
	declare @ErpPerKod nvarchar(25);
	declare @RowCount int = 0;
	declare @UseCount int = 0;

	select @RowCount = count(*) from dbo.Subeler s where s.SubeID = @SubeID;
		
	if @RowCount = 0
		begin
			exec log.sysHataGonder 55001, @OlusturanKulID;
		end

	begin try
	
		begin tran @TransactionName;
			if(dbo.fnGetYetkiKontrol(@SayfaID, 3, @OlusturanKulID) = 0) begin exec log.sysHataGonder 54003, @OlusturanKulID; end
				begin
					update dbo.Subeler set Durum = 0 where SubeID = @SubeID
				end
		
		commit;
		select @SubeID
	end try

	begin catch
		if @@trancount > 0 rollback tran @TransactionName;/*Transaction varsa rollback at*/		
		/*	   Hata Loglanıyor     */
		declare @vErrorNumber int, @vErrorMessage nvarchar(500), @LogID varchar(50), @vCustomMessage varchar(100);
		SELECT @vErrorNumber = ERROR_NUMBER(), @vErrorMessage = ERROR_MESSAGE();
		exec log.sysHataKaydet @vErrorNumber, @vErrorMessage, @OlusturanKulID, @LogID output;	-- Hatayı Logla...
		select @vCustomMessage = 'Veritabanı Hatası!' + ' [' + @LogID + ']';
		if @vErrorNumber > 50000 begin; throw; end else begin; throw 50005, @vCustomMessage, 1; end; 	-- Hatayı geri döndür...		
	end catch;
END
GO
/****** Object:  StoredProcedure [dbo].[SubeSAVE]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hasan Basri OY
-- Create date: 2025-05-24
-- Description:	Şube Oluşturma Güncelleme
-- =============================================
CREATE PROCEDURE [dbo].[SubeSAVE]
	@SubeID int,
	@SubeAdi varchar(100),
	@Telefon varchar(11),
	@Adres varchar(max),

	@SayfaID int,
	@OlusturanKulID int
AS
BEGIN
	declare @TransactionName varchar(20) = 'Transaction1';
	declare @Result int =-1;
	declare @vRowCount int = 0;
	declare @vErrorCount int = 0;

	select @vRowCount = count(*) from dbo.Subeler s where s.SubeID = @SubeID and s.Durum = 1 and SubeID <> -1;
		
		if @vRowCount = 0 and @SubeID <> -1 
			begin 
				exec log.sysHataGonder 55001, @OlusturanKulID; 
			end;

	begin try
			
		begin tran @TransactionName;

			if @vRowCount = 0 
				begin
					if(dbo.fnGetYetkiKontrol(@SayfaID, 1, @OlusturanKulID) = 0) begin exec log.sysHataGonder 54001, @OlusturanKulID; end
					insert into dbo.Subeler
						(SubeAdi,TelefonNo,Adres,Durum)
					values
						(@SubeAdi,@Telefon,@Adres,1)

					set @Result = scope_identity()
				end
			else
				begin
					if(dbo.fnGetYetkiKontrol(@SayfaID, 2, @OlusturanKulID) = 0) begin exec log.sysHataGonder 54002, @OlusturanKulID; end
					update dbo.Subeler
					set 
						SubeAdi = @SubeAdi,
						TelefonNo = @Telefon,
						Adres = @Adres
					where
						SubeID = @SubeID

					set @Result = @SubeID
				end		
		commit;
		select @Result as "Sonuc";
	end try

	begin catch
		if @@trancount > 0 rollback tran @TransactionName;/*Transaction varsa rollback at*/		
		/*	   Hata Loglanıyor     */
		declare @vErrorNumber int, @vErrorMessage nvarchar(500), @LogID varchar(50), @vCustomMessage varchar(100);
		SELECT @vErrorNumber = ERROR_NUMBER(), @vErrorMessage = ERROR_MESSAGE();
		exec log.sysHataKaydet @vErrorNumber, @vErrorMessage, @OlusturanKulID, @LogID output;	-- Hatayı Logla...
		select @vCustomMessage = 'Veritabanı Hatası!' + ' [' + @LogID + ']';
		if @vErrorNumber > 50000 begin; throw; end else begin; throw 50005, @vCustomMessage, 1; end; 	-- Hatayı geri döndür...		
	end catch;
END
GO
/****** Object:  StoredProcedure [log].[sysHataGonder]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [log].[sysHataGonder](@HataKodu int, @KulID int)  as
begin
	declare @vAdSoyad varchar(255) = '';
	declare @vLangID int;
	declare @vSonuc varchar(500);
	
	select @vSonuc = isnull(
							(select top 1 h.HataMesaji
							   from log.Hatalar h
							  where h.HataKodu = @HataKodu), 
											   isnull(
													  (select top 1 h.HataMesaji
														 from log.Hatalar h
														where h.HataKodu = 99999), 
																		 'Hata Recursive Oldu...')
							);
	
	select @vAdSoyad = dbo.fnGetKulTamIsimByID(@KulID);
	
	select @vSonuc = case when @vAdSoyad = '' then @vSonuc else 'Sayın ' + @vAdSoyad + ', ' + @vSonuc + ' [' + cast(@HataKodu as nvarchar(20)) +  '] ' end;
	
	throw @HataKodu, @vSonuc, 1;
end;
GO
/****** Object:  StoredProcedure [log].[sysHataKaydet]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [log].[sysHataKaydet]
(
	@HataKodu int,
	@HataMesaji nvarchar(1000),
	@KulID int,
	
	@HataID varchar(10) OUTPUT
)
AS
/*
	Gelen hatalar :
	----------------------------------------------------------------------
	Custom Error  --> CustomErrorLog
	Runtime Error --> ErrorLog
	----------------------------------------------------------------------
*/
BEGIN
	declare @TransactionName varchar(20) = 'Transaction1';
	declare @vToday datetime = getdate();
		
	begin tran @TransactionName;
	
		begin try
			if @HataKodu <= 50000
				begin
					insert into log.HataKayitlari
						( HataKodu, HataMesaji, KulID, HataTarihi ) 
					values 
						( @HataKodu, @HataMesaji, @KulID, @vToday );
					
					select @HataID = 'rt-' + cast(scope_identity() as varchar(50));
				end	
			
			commit;
		end try
		
		begin catch
			rollback tran @TransactionName;
		end catch;
END;
GO
/****** Object:  StoredProcedure [log].[UygulamaHataKaydet]    Script Date: 25.05.2025 18:27:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hasan Basri OY
-- Create date: 2024-10-04
-- Description:	Uygulama RunTime Hataları Loglar
-- =============================================
CREATE PROCEDURE [log].[UygulamaHataKaydet] 
	@HataKodu int,
	@HataMesaji nvarchar(max),
	@MetodAdi nvarchar(255),
	@KulID int
AS
BEGIN
	declare @TransactionName varchar(20) = 'Transaction1';
	declare @Result int = -1;
	begin try
			
		begin tran @TransactionName;

			insert into log.UygulamaHatalari
				(HataKodu, HataMesaji, MetodAdi, KulID, HataTarihi)
			values
				(@HataKodu, @HataMesaji, @MetodAdi, @KulID, getdate())

			set @Result = scope_identity();

		commit;		
			select @Result as "Sonuc"
	end try
	begin catch
		if @@trancount > 0 rollback tran @TransactionName;/*Transaction varsa rollback at*/		
		/*	   Hata Loglanıyor     */
		declare @vErrorNumber int, @vErrorMessage nvarchar(500), @LogID varchar(50), @vCustomMessage varchar(100);
		SELECT @vErrorNumber = ERROR_NUMBER(), @vErrorMessage = ERROR_MESSAGE();
		exec log.sysHataKaydet @vErrorNumber, @vErrorMessage, @KulID, @LogID output;	-- Hatayı Logla...
		select @vCustomMessage = 'Veritabanı Hatası!' + ' [' + @LogID + ']';
		if @vErrorNumber > 50000 begin; throw; end else begin; throw 50005, @vCustomMessage, 1; end; 	-- Hatayı geri döndür...		
	end catch;
END
GO
USE [master]
GO
ALTER DATABASE [Kuafor] SET  READ_WRITE 
GO
