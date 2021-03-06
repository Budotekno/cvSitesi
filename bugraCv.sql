USE [cv]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 15.07.2022 12:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Anasayfas]    Script Date: 15.07.2022 12:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Anasayfas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[YetenekIsim] [nvarchar](max) NULL,
	[YetenekDeger] [nvarchar](max) NULL,
	[YetenekDurum] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Anasayfas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Calismalarims]    Script Date: 15.07.2022 12:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calismalarims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FotoUrl] [nvarchar](max) NULL,
	[PopulerFoto] [bit] NOT NULL,
	[Durum] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Calismalarims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hakkimdas]    Script Date: 15.07.2022 12:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hakkimdas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HakkimdaFotoUrl] [nvarchar](max) NULL,
	[HakkimdaYazi] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Hakkimdas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Iletisims]    Script Date: 15.07.2022 12:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Iletisims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KonumLink] [nvarchar](max) NULL,
	[Tel] [nvarchar](max) NULL,
	[Mail] [nvarchar](max) NULL,
	[AdresAdi] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Iletisims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesajs]    Script Date: 15.07.2022 12:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesajs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Isim] [nvarchar](max) NULL,
	[Mail] [nvarchar](max) NULL,
	[Konu] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Mesajs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profils]    Script Date: 15.07.2022 12:51:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profils](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProfilAd] [nvarchar](max) NULL,
	[Unvan] [nvarchar](max) NULL,
	[FotoUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Profils] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Anasayfas] ADD  DEFAULT ((0)) FOR [YetenekDurum]
GO
ALTER TABLE [dbo].[Calismalarims] ADD  DEFAULT ((0)) FOR [Durum]
GO
