USE [master]
GO
/****** Object:  Database [LIMS]    Script Date: 09.04.2021 19:47:10 ******/
CREATE DATABASE [LIMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LIMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\LIMS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LIMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\LIMS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [LIMS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LIMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LIMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LIMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LIMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LIMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LIMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [LIMS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LIMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LIMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LIMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LIMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LIMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LIMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LIMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LIMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LIMS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LIMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LIMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LIMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LIMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LIMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LIMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LIMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LIMS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LIMS] SET  MULTI_USER 
GO
ALTER DATABASE [LIMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LIMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LIMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LIMS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LIMS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LIMS] SET QUERY_STORE = OFF
GO
USE [LIMS]
GO
/****** Object:  User [test]    Script Date: 09.04.2021 19:47:10 ******/
CREATE USER [test] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[xxx]
GO
/****** Object:  DatabaseRole [TestG]    Script Date: 09.04.2021 19:47:10 ******/
CREATE ROLE [TestG]
GO
ALTER ROLE [TestG] ADD MEMBER [test]
GO
/****** Object:  Schema [xxx]    Script Date: 09.04.2021 19:47:10 ******/
CREATE SCHEMA [xxx]
GO
/****** Object:  Table [dbo].[AnalyticalServiceAttrs]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnalyticalServiceAttrs](
	[AnalyticalServiceId] [int] NOT NULL,
	[AttrId] [int] NOT NULL,
 CONSTRAINT [PK_AnalyticalServiceAttrs] PRIMARY KEY CLUSTERED 
(
	[AnalyticalServiceId] ASC,
	[AttrId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnalyticalServices]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnalyticalServices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[CategoryId] [int] NULL,
	[UnitId] [int] NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_Аналетические сервисы] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attrs]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attrs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
	[Type] [int] NULL,
	[Options] [varchar](max) NULL,
 CONSTRAINT [PK_Атрибуты] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_Категория испытаний] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[FullName] [varchar](100) NULL,
	[PhoneNumber] [varchar](50) NULL,
	[Organization] [varchar](50) NULL,
 CONSTRAINT [PK_Клиенты] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FinalResults]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinalResults](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SampleId] [int] NOT NULL,
	[AnalyticalServiceId] [int] NOT NULL,
	[InstrumentId] [int] NOT NULL,
	[ValueNo] [varchar](50) NULL,
	[Value] [float] NULL,
	[IsFinal] [int] NULL,
	[Note] [text] NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	[CreateUser] [varchar](50) NULL,
	[UpdateUser] [varchar](50) NULL,
 CONSTRAINT [PK_FinalResults_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gosts]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gosts](
	[Gost] [varchar](50) NOT NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_Gosts] PRIMARY KEY CLUSTERED 
(
	[Gost] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InstrumentAnalyticals]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InstrumentAnalyticals](
	[InstrumentId] [int] NOT NULL,
	[AnalyticalServiceId] [int] NOT NULL,
	[LabId] [int] NOT NULL,
 CONSTRAINT [PK_InstrumentAnalyticals] PRIMARY KEY CLUSTERED 
(
	[InstrumentId] ASC,
	[AnalyticalServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Instruments]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instruments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[InstrumentTypeId] [int] NULL,
	[SerialNumber] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
	[LabId] [int] NOT NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Инструменты] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InstrumentTypeAnalyticals]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InstrumentTypeAnalyticals](
	[InstrumentTypeId] [int] NOT NULL,
	[AnalyticalServiceId] [int] NOT NULL,
 CONSTRAINT [PK_InstrumentTypeAnaliticals] PRIMARY KEY CLUSTERED 
(
	[InstrumentTypeId] ASC,
	[AnalyticalServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InstrumentTypes]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InstrumentTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_Типы испытатедьных машин] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Labs]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Labs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[LocId] [int] NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_Лабаротории] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Locs]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](150) NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_Места взятия пробы] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResultAttrs]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResultAttrs](
	[SampleId] [int] NOT NULL,
	[AnalyticalServiceId] [int] NOT NULL,
	[AttrId] [int] NOT NULL,
	[Value] [varchar](100) NULL,
	[CreateTime] [date] NULL,
	[UpdateTime] [date] NULL,
	[CreateUser] [varchar](50) NULL,
	[UpdateUser] [varchar](50) NULL,
 CONSTRAINT [PK_ResultAttrs] PRIMARY KEY CLUSTERED 
(
	[SampleId] ASC,
	[AnalyticalServiceId] ASC,
	[AttrId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Results]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Results](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SampleId] [int] NOT NULL,
	[AnalyticalServiceId] [int] NOT NULL,
	[InstrumentId] [int] NULL,
	[ValueNo] [int] NULL,
	[Value] [float] NULL,
	[IsFinal] [int] NULL,
	[Note] [text] NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	[CreateUser] [varchar](50) NULL,
	[UpdateUser] [varchar](50) NULL,
 CONSTRAINT [PK_Результаты испытаний] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SampleAnalyticals]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SampleAnalyticals](
	[SampleId] [int] NOT NULL,
	[AnalyticalServiceId] [int] NOT NULL,
 CONSTRAINT [PK_SampleAnaliticals] PRIMARY KEY CLUSTERED 
(
	[SampleId] ASC,
	[AnalyticalServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SampleAttrs]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SampleAttrs](
	[SampleId] [int] NOT NULL,
	[AttrId] [int] NOT NULL,
	[Value] [varchar](100) NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	[CreateUser] [varchar](50) NULL,
	[UpdateUser] [varchar](50) NULL,
 CONSTRAINT [PK_SampleAttrs] PRIMARY KEY CLUSTERED 
(
	[SampleId] ASC,
	[AttrId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Samples]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Samples](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RecieveTime] [datetime] NULL,
	[TestTime] [datetime] NULL,
	[ClientId] [int] NULL,
	[LabId] [int] NULL,
	[SampleTypeId] [int] NULL,
	[NumSamples] [int] NULL,
	[Status] [int] NULL,
	[IsFinal] [bit] NULL,
	[Note] [text] NULL,
	[LocationId] [int] NULL,
	[LastEditComment] [varchar](500) NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	[CreateUser] [varchar](50) NULL,
	[UpdateUser] [varchar](50) NULL,
	[FinalizeUser] [varchar](50) NULL,
	[FinalizeTime] [datetime] NULL,
 CONSTRAINT [PK_Пробы] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SampleSpecAnalyticals]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SampleSpecAnalyticals](
	[SampleSpecId] [int] NOT NULL,
	[AnalyticalServiceId] [int] NOT NULL,
	[MinValue] [float] NULL,
	[MaxValue] [float] NULL,
 CONSTRAINT [PK_SampleSpecAnaliticals] PRIMARY KEY CLUSTERED 
(
	[SampleSpecId] ASC,
	[AnalyticalServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SampleSpecs]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SampleSpecs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
	[Version] [varchar](50) NULL,
 CONSTRAINT [PK_Спецификация типа пробы] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SampleTypeAttrs]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SampleTypeAttrs](
	[SampleTypeId] [int] NOT NULL,
	[AttrId] [int] NOT NULL,
 CONSTRAINT [PK_SampleTypeAttrs] PRIMARY KEY CLUSTERED 
(
	[SampleTypeId] ASC,
	[AttrId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SampleTypes]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SampleTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_Тип пробы] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Units]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Units](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Scale] [varchar](50) NULL,
	[BaseUnitId] [int] NULL,
 CONSTRAINT [PK_Единицы измерения] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[LabId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[LabId] ASC,
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[FullName] [varchar](100) NULL,
	[PhoneNumber] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_Пользователи] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AnalyticalServiceAttrs]  WITH CHECK ADD  CONSTRAINT [FK_AnalyticalServiceAttrs_Attrs] FOREIGN KEY([AttrId])
REFERENCES [dbo].[Attrs] ([Id])
GO
ALTER TABLE [dbo].[AnalyticalServiceAttrs] CHECK CONSTRAINT [FK_AnalyticalServiceAttrs_Attrs]
GO
ALTER TABLE [dbo].[AnalyticalServiceAttrs]  WITH CHECK ADD  CONSTRAINT [FK_Шаблон испытаний_Аналетические сервисы] FOREIGN KEY([AnalyticalServiceId])
REFERENCES [dbo].[AnalyticalServices] ([Id])
GO
ALTER TABLE [dbo].[AnalyticalServiceAttrs] CHECK CONSTRAINT [FK_Шаблон испытаний_Аналетические сервисы]
GO
ALTER TABLE [dbo].[AnalyticalServices]  WITH CHECK ADD  CONSTRAINT [FK_Аналетические сервисы_Единицы измерения] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Units] ([Id])
GO
ALTER TABLE [dbo].[AnalyticalServices] CHECK CONSTRAINT [FK_Аналетические сервисы_Единицы измерения]
GO
ALTER TABLE [dbo].[AnalyticalServices]  WITH CHECK ADD  CONSTRAINT [FK_Аналетические сервисы_Категория испытаний] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[AnalyticalServices] CHECK CONSTRAINT [FK_Аналетические сервисы_Категория испытаний]
GO
ALTER TABLE [dbo].[FinalResults]  WITH CHECK ADD  CONSTRAINT [FK_FinalResult_AnalyticalServices] FOREIGN KEY([AnalyticalServiceId])
REFERENCES [dbo].[AnalyticalServices] ([Id])
GO
ALTER TABLE [dbo].[FinalResults] CHECK CONSTRAINT [FK_FinalResult_AnalyticalServices]
GO
ALTER TABLE [dbo].[FinalResults]  WITH CHECK ADD  CONSTRAINT [FK_FinalResult_Samples] FOREIGN KEY([SampleId])
REFERENCES [dbo].[Samples] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FinalResults] CHECK CONSTRAINT [FK_FinalResult_Samples]
GO
ALTER TABLE [dbo].[InstrumentAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_InstrumentAnalyticals_Instruments] FOREIGN KEY([InstrumentId])
REFERENCES [dbo].[Instruments] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InstrumentAnalyticals] CHECK CONSTRAINT [FK_InstrumentAnalyticals_Instruments]
GO
ALTER TABLE [dbo].[InstrumentAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_InstrumentAnalyticals_Labs] FOREIGN KEY([LabId])
REFERENCES [dbo].[Labs] ([Id])
GO
ALTER TABLE [dbo].[InstrumentAnalyticals] CHECK CONSTRAINT [FK_InstrumentAnalyticals_Labs]
GO
ALTER TABLE [dbo].[InstrumentAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_Инструменты_Сервисы_Аналетические сервисы] FOREIGN KEY([AnalyticalServiceId])
REFERENCES [dbo].[AnalyticalServices] ([Id])
GO
ALTER TABLE [dbo].[InstrumentAnalyticals] CHECK CONSTRAINT [FK_Инструменты_Сервисы_Аналетические сервисы]
GO
ALTER TABLE [dbo].[Instruments]  WITH CHECK ADD  CONSTRAINT [FK_Instruments_InstrumentTypes] FOREIGN KEY([InstrumentTypeId])
REFERENCES [dbo].[InstrumentTypes] ([Id])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Instruments] CHECK CONSTRAINT [FK_Instruments_InstrumentTypes]
GO
ALTER TABLE [dbo].[Instruments]  WITH CHECK ADD  CONSTRAINT [FK_Инструменты_Лабаротории] FOREIGN KEY([LabId])
REFERENCES [dbo].[Labs] ([Id])
GO
ALTER TABLE [dbo].[Instruments] CHECK CONSTRAINT [FK_Инструменты_Лабаротории]
GO
ALTER TABLE [dbo].[InstrumentTypeAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_InstrumentTypeAnaliticals_AnalyticalServices] FOREIGN KEY([AnalyticalServiceId])
REFERENCES [dbo].[AnalyticalServices] ([Id])
GO
ALTER TABLE [dbo].[InstrumentTypeAnalyticals] CHECK CONSTRAINT [FK_InstrumentTypeAnaliticals_AnalyticalServices]
GO
ALTER TABLE [dbo].[InstrumentTypeAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_InstrumentTypeAnaliticals_InstrumentTypes] FOREIGN KEY([InstrumentTypeId])
REFERENCES [dbo].[InstrumentTypes] ([Id])
GO
ALTER TABLE [dbo].[InstrumentTypeAnalyticals] CHECK CONSTRAINT [FK_InstrumentTypeAnaliticals_InstrumentTypes]
GO
ALTER TABLE [dbo].[Labs]  WITH CHECK ADD  CONSTRAINT [FK_Labs_Locs] FOREIGN KEY([LocId])
REFERENCES [dbo].[Locs] ([Id])
GO
ALTER TABLE [dbo].[Labs] CHECK CONSTRAINT [FK_Labs_Locs]
GO
ALTER TABLE [dbo].[ResultAttrs]  WITH CHECK ADD  CONSTRAINT [FK_ResultAttrs_AnalyticalServices] FOREIGN KEY([AnalyticalServiceId])
REFERENCES [dbo].[AnalyticalServices] ([Id])
GO
ALTER TABLE [dbo].[ResultAttrs] CHECK CONSTRAINT [FK_ResultAttrs_AnalyticalServices]
GO
ALTER TABLE [dbo].[ResultAttrs]  WITH CHECK ADD  CONSTRAINT [FK_ResultAttrs_Attrs] FOREIGN KEY([AttrId])
REFERENCES [dbo].[Attrs] ([Id])
GO
ALTER TABLE [dbo].[ResultAttrs] CHECK CONSTRAINT [FK_ResultAttrs_Attrs]
GO
ALTER TABLE [dbo].[ResultAttrs]  WITH CHECK ADD  CONSTRAINT [FK_ResultAttrs_Samples] FOREIGN KEY([SampleId])
REFERENCES [dbo].[Samples] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ResultAttrs] CHECK CONSTRAINT [FK_ResultAttrs_Samples]
GO
ALTER TABLE [dbo].[Results]  WITH CHECK ADD  CONSTRAINT [FK_Results_Samples] FOREIGN KEY([SampleId])
REFERENCES [dbo].[Samples] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Results] CHECK CONSTRAINT [FK_Results_Samples]
GO
ALTER TABLE [dbo].[Results]  WITH CHECK ADD  CONSTRAINT [FK_Результаты испытаний_Аналетические сервисы] FOREIGN KEY([AnalyticalServiceId])
REFERENCES [dbo].[AnalyticalServices] ([Id])
GO
ALTER TABLE [dbo].[Results] CHECK CONSTRAINT [FK_Результаты испытаний_Аналетические сервисы]
GO
ALTER TABLE [dbo].[SampleAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_SampleAnaliticals_AnalyticalServices] FOREIGN KEY([AnalyticalServiceId])
REFERENCES [dbo].[AnalyticalServices] ([Id])
GO
ALTER TABLE [dbo].[SampleAnalyticals] CHECK CONSTRAINT [FK_SampleAnaliticals_AnalyticalServices]
GO
ALTER TABLE [dbo].[SampleAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_SampleAnaliticals_Samples] FOREIGN KEY([SampleId])
REFERENCES [dbo].[Samples] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SampleAnalyticals] CHECK CONSTRAINT [FK_SampleAnaliticals_Samples]
GO
ALTER TABLE [dbo].[SampleAttrs]  WITH CHECK ADD  CONSTRAINT [FK_SampleAttrs_Attrs] FOREIGN KEY([AttrId])
REFERENCES [dbo].[Attrs] ([Id])
GO
ALTER TABLE [dbo].[SampleAttrs] CHECK CONSTRAINT [FK_SampleAttrs_Attrs]
GO
ALTER TABLE [dbo].[SampleAttrs]  WITH CHECK ADD  CONSTRAINT [FK_SampleAttrs_Samples] FOREIGN KEY([SampleId])
REFERENCES [dbo].[Samples] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SampleAttrs] CHECK CONSTRAINT [FK_SampleAttrs_Samples]
GO
ALTER TABLE [dbo].[Samples]  WITH CHECK ADD  CONSTRAINT [FK_Samples_Labs] FOREIGN KEY([LabId])
REFERENCES [dbo].[Labs] ([Id])
GO
ALTER TABLE [dbo].[Samples] CHECK CONSTRAINT [FK_Samples_Labs]
GO
ALTER TABLE [dbo].[Samples]  WITH CHECK ADD  CONSTRAINT [FK_Пробы_Клиенты] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([Id])
GO
ALTER TABLE [dbo].[Samples] CHECK CONSTRAINT [FK_Пробы_Клиенты]
GO
ALTER TABLE [dbo].[Samples]  WITH CHECK ADD  CONSTRAINT [FK_Пробы_Места взятия пробы] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Locs] ([Id])
GO
ALTER TABLE [dbo].[Samples] CHECK CONSTRAINT [FK_Пробы_Места взятия пробы]
GO
ALTER TABLE [dbo].[Samples]  WITH CHECK ADD  CONSTRAINT [FK_Пробы_Тип пробы] FOREIGN KEY([SampleTypeId])
REFERENCES [dbo].[SampleTypes] ([Id])
GO
ALTER TABLE [dbo].[Samples] CHECK CONSTRAINT [FK_Пробы_Тип пробы]
GO
ALTER TABLE [dbo].[SampleSpecAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_SampleSpecAnaliticals_AnalyticalServices] FOREIGN KEY([AnalyticalServiceId])
REFERENCES [dbo].[AnalyticalServices] ([Id])
GO
ALTER TABLE [dbo].[SampleSpecAnalyticals] CHECK CONSTRAINT [FK_SampleSpecAnaliticals_AnalyticalServices]
GO
ALTER TABLE [dbo].[SampleSpecAnalyticals]  WITH CHECK ADD  CONSTRAINT [FK_SampleSpecAnaliticals_SampleSpecs] FOREIGN KEY([SampleSpecId])
REFERENCES [dbo].[SampleSpecs] ([Id])
GO
ALTER TABLE [dbo].[SampleSpecAnalyticals] CHECK CONSTRAINT [FK_SampleSpecAnaliticals_SampleSpecs]
GO
ALTER TABLE [dbo].[SampleTypeAttrs]  WITH CHECK ADD  CONSTRAINT [FK_Атрибуты_Типов_Проб_Атрибуты] FOREIGN KEY([AttrId])
REFERENCES [dbo].[Attrs] ([Id])
GO
ALTER TABLE [dbo].[SampleTypeAttrs] CHECK CONSTRAINT [FK_Атрибуты_Типов_Проб_Атрибуты]
GO
ALTER TABLE [dbo].[SampleTypeAttrs]  WITH CHECK ADD  CONSTRAINT [FK_Атрибуты_Типов_Проб_Тип пробы] FOREIGN KEY([SampleTypeId])
REFERENCES [dbo].[SampleTypes] ([Id])
GO
ALTER TABLE [dbo].[SampleTypeAttrs] CHECK CONSTRAINT [FK_Атрибуты_Типов_Проб_Тип пробы]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Labs] FOREIGN KEY([LabId])
REFERENCES [dbo].[Labs] ([Id])
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Labs]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Roles] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Roles]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Users]
GO
/****** Object:  StoredProcedure [dbo].[spAnalyticalServiceAttrs_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAnalyticalServiceAttrs_Delete]
	-- Add the parameters for the stored procedure here
	@AnalyticalServiceId int,
	@AttrId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM AnalyticalServiceAttrs
WHERE (AnalyticalServiceId = @AnalyticalServiceId and AttrId = @AttrId)
END
GO
/****** Object:  StoredProcedure [dbo].[spAnalyticalServiceAttrs_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAnalyticalServiceAttrs_GetAll]
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        AnalyticalServiceId, AttrId
FROM            AnalyticalServiceAttrs
WHERE (AnalyticalServiceId = @AnalyticalServiceId)
END
GO
/****** Object:  StoredProcedure [dbo].[spAnalyticalServiceAttrs_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAnalyticalServiceAttrs_GetOne]
	-- Add the parameters for the stored procedure here
	@AnalyticalServiceId int,
	@AttrId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        AnalyticalServiceId, AttrId
FROM            AnalyticalServiceAttrs
WHERE		  (AnalyticalServiceId = @AnalyticalServiceId and AttrId = @AttrId)
END
GO
/****** Object:  StoredProcedure [dbo].[spAnalyticalServiceAttrs_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAnalyticalServiceAttrs_Insert]
	@AnalyticalServiceId int,
	@AttrId int
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO AnalyticalServiceAttrs (AnalyticalServiceId, AttrId) VALUES (@AnalyticalServiceId, @AttrId)
END
GO
/****** Object:  StoredProcedure [dbo].[spAnalyticalServiceAttrs_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAnalyticalServiceAttrs_Update]
	-- Add the parameters for the stored procedure here
	@AnalyticalServiceId int,
	@AttrId int,
	@OldAttrId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE AnalyticalServiceAttrs  SET AnalyticalServiceId = @AnalyticalServiceId, AttrId = @AttrId
	WHERE (AnalyticalServiceId = @AnalyticalServiceId and AttrId = @OldAttrId)
END
GO
/****** Object:  StoredProcedure [dbo].[spAnalyticalServices_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAnalyticalServices_Delete]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.	 
	SET NOCOUNT ON;

    DELETE FROM AnalyticalServices
WHERE (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spAnalyticalServices_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAnalyticalServices_GetAll]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        Id, Name, CategoryId, UnitId, Description
FROM            AnalyticalServices
END
GO
/****** Object:  StoredProcedure [dbo].[spAnalyticalServices_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAnalyticalServices_GetOne]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        Id, Name, CategoryId, UnitId, Description
FROM            AnalyticalServices
WHERE		  (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spAnalyticalServices_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAnalyticalServices_Insert]
	-- Add the parameters for the stored procedure here
	@Name varchar(50),
	@CategoryId int,
	@UnitId int,
	@Description varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO AnalyticalServices (Name, CategoryId, UnitId, Description) VALUES (@Name, @CategoryId, @UnitId, @Description)
END
GO
/****** Object:  StoredProcedure [dbo].[spAnalyticalServices_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAnalyticalServices_Update]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(50),
	@CategoryId int,
	@UnitId int,
	@Description varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE AnalyticalServices  SET Name = @Name, CategoryId = @CategoryId, UnitId = @UnitId, Description = @Description WHERE (id=@Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spAttrs_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAttrs_Delete]
	
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

DELETE FROM Attrs
WHERE (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spAttrs_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAttrs_GetAll]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT        Id, Name, Description, Type, Options
FROM            Attrs
END
GO
/****** Object:  StoredProcedure [dbo].[spAttrs_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAttrs_GetOne]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        Id, Name, Description, Type, Options
FROM            Attrs
WHERE        (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spAttrs_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAttrs_Insert]
	-- Add the parameters for the stored procedure here
	@Name varchar(50),
	@Description varchar(550),
	@Type int,
	@Options varchar(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO Attrs
                         (Name, Description, Type, Options)
VALUES        (@Name, @Description, @Type, @Options)
END
GO
/****** Object:  StoredProcedure [dbo].[spAttrs_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAttrs_Update]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(50),
	@Description varchar(500),
	@Type int,
	@Options varchar(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Attrs  SET Name = @Name, Description = @Description, Type = @Type, Options = @Options WHERE (Id=@Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spCategories_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spCategories_Delete]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM Categories
WHERE (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spCategories_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spCategories_GetAll]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        Id, Name, Description
FROM            Categories
END
GO
/****** Object:  StoredProcedure [dbo].[spCategories_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spCategories_GetOne]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        Id, Name, Description
FROM            Categories
WHERE		  (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spCategories_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spCategories_Insert]
	-- Add the parameters for the stored procedure here
	@Name varchar(50),
	@Description varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Categories (Name, Description) VALUES (@Name, @Description)
END
GO
/****** Object:  StoredProcedure [dbo].[spCategories_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spCategories_Update]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(50),
	@Description varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Categories  SET Name = @Name, Description = @Description WHERE (id=@Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spClis_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spClis_Delete]
	
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

DELETE FROM Clients
WHERE (Id = @Id)

END
GO
/****** Object:  StoredProcedure [dbo].[spClis_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spClis_GetAll]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT        Id, Name, FullName, PhoneNumber, Organization
FROM            Clients
END
GO
/****** Object:  StoredProcedure [dbo].[spClis_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spClis_GetOne]
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT Id, Name, FullName, PhoneNumber, Organization
FROM Clients
WHERE (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spClis_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spClis_Insert]
	-- Add the parameters for the stored procedure here
	@Name varchar(50),
	@FullName varchar(100),
	@PhoneNumber varchar(50),
	@Organization varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Clients (Name, FullName, PhoneNumber, Organization) VALUES (@Name, @FullName, @PhoneNumber, @Organization)
END
GO
/****** Object:  StoredProcedure [dbo].[spClis_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spClis_Update]

	@Id int,
	@Name varchar(50),
	@FullName varchar(100),
	@PhoneNumber varchar(50),
	@Organization varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

UPDATE       Clients
SET                Name = @Name, FullName = @FullName, PhoneNumber = @PhoneNumber, Organization = @Organization
WHERE (Id = @Id)

END
GO
/****** Object:  StoredProcedure [dbo].[spFinalResults_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spFinalResults_Delete]
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

DELETE FROM FinalResults
WHERE (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spFinalResults_DeleteAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spFinalResults_DeleteAll]
	@SampleId int,
	@AnalyticalServiceId int,
	@ValueNo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

DELETE FROM FinalResults
WHERE (SampleId = @SampleId and AnalyticalServiceId = @AnalyticalServiceId and ValueNo = @ValueNo)
END
GO
/****** Object:  StoredProcedure [dbo].[spFinalResults_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spFinalResults_GetAll]
	@SampleId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT        FinalResults.Id, FinalResults.SampleId, FinalResults.AnalyticalServiceId, FinalResults.InstrumentId, AnalyticalServices.Name, AnalyticalServices.UnitId, FinalResults.InstrumentId, FinalResults.ValueNo, FinalResults.Value, FinalResults.IsFinal, FinalResults.Note, FinalResults.CreateTime, FinalResults.UpdateTime, FinalResults.CreateUser, FinalResults.UpdateUser
FROM            FinalResults JOIN AnalyticalServices ON FinalResults.AnalyticalServiceId = AnalyticalServices.Id
WHERE (FinalResults.SampleId = @SampleId)
ORDER BY AnalyticalServices.Name, ValueNo
END
GO
/****** Object:  StoredProcedure [dbo].[spFinalResults_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spFinalResults_GetOne]
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT FinalResults.Id, FinalResults.SampleId, FinalResults.AnalyticalServiceId, FinalResults.InstrumentId, AnalyticalServices.UnitId, FinalResults.InstrumentId, FinalResults.ValueNo, FinalResults.Value, FinalResults.IsFinal, FinalResults.Note, FinalResults.CreateTime, FinalResults.UpdateTime, FinalResults.CreateUser, FinalResults.UpdateUser
FROM FinalResults JOIN AnalyticalServices ON FinalResults.AnalyticalServiceId = AnalyticalServices.Id
WHERE (FinalResults.Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spFinalResults_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spFinalResults_Insert]
	-- Add the parameters for the stored procedure here
	@SampleId int,
	@AnalyticalServiceId int,
	@InstrumentId int,
	@ValueNo varchar(50),
	@Value float,
	@IsFinal int,
	@Note text,
	@CreateTime datetime,
	@UpdateTime datetime,
	@CreateUser varchar(50),
	@UpdateUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO FinalResults (SampleId, AnalyticalServiceId, InstrumentId, ValueNo, Value, IsFinal, Note, CreateTime, UpdateTime, CreateUser, UpdateUser) 
	VALUES (@SampleId, @AnalyticalServiceId, @InstrumentId, @ValueNo, @Value, @IsFinal, @Note, @CreateTime, @UpdateTime, @CreateUser, @UpdateUser)
END
GO
/****** Object:  StoredProcedure [dbo].[spFinalResults_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spFinalResults_Update]
	@Id int,
	@SampleId int,
	@AnalyticalServiceId int,
	@InstrumentId int,
	@ValueNo varchar(50),
	@Value float,
	@IsFinal int,
	@Note text,
	@CreateTime datetime,
	@UpdateTime datetime,
	@CreateUser varchar(50),
	@UpdateUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

UPDATE       FinalResults
SET                SampleId = @SampleId, AnalyticalServiceId = @AnalyticalServiceId, InstrumentId = @InstrumentId, ValueNo = @ValueNo, Value = @Value, IsFinal = @IsFinal, Note = @Note, CreateTime = @CreateTime, UpdateTime = @UpdateTime, CreateUser = @CreateUser, UpdateUser = @UpdateUser
WHERE (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spInstrumentAnalyticals_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstrumentAnalyticals_Delete]
	-- Add the parameters for the stored procedure here
	@InstrumentId int,
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM InstrumentAnalyticals
WHERE (InstrumentId = @InstrumentId and AnalyticalServiceId = @AnalyticalServiceId)
END
GO
/****** Object:  StoredProcedure [dbo].[spInstrumentAnalyticals_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstrumentAnalyticals_GetAll]
	@SampleId int,
	@LabId int = null
AS
BEGIN
	SET NOCOUNT ON;

	--Получаем лабораторию испытания
	SET @LabId = (SELECT LabId FROM Samples	WHERE Id = @SampleId)

	-- Получаем необходимы данные
	SELECT        InstrumentId, AnalyticalServiceId, LabId
	FROM            InstrumentAnalyticals
	WHERE LabId = @LabId
END
GO
/****** Object:  StoredProcedure [dbo].[spInstrumentAnalyticals_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstrumentAnalyticals_GetOne]
	-- Add the parameters for the stored procedure here
	@InstrumentId int,
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        InstrumentId, AnalyticalServiceId
FROM            InstrumentAnalyticals
WHERE		  (InstrumentId = @InstrumentId and AnalyticalServiceId = @AnalyticalServiceId)
END
GO
/****** Object:  StoredProcedure [dbo].[spInstrumentAnalyticals_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstrumentAnalyticals_Insert]
	-- Add the parameters for the stored procedure here
	@InstrumentId int,
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO InstrumentAnalyticals (InstrumentId, AnalyticalServiceId) 
	VALUES (@InstrumentId, @AnalyticalServiceId)
END
GO
/****** Object:  StoredProcedure [dbo].[spInstrumentAnalyticals_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstrumentAnalyticals_Update]
	-- Add the parameters for the stored procedure here
	@InstrumentId int,
	@OldAnalyticalServiceId int,
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE InstrumentAnalyticals  SET InstrumentId = @InstrumentId,  AnalyticalServiceId = @AnalyticalServiceId 
	WHERE (InstrumentId = @InstrumentId and AnalyticalServiceId = @OldAnalyticalServiceId)
END
GO
/****** Object:  StoredProcedure [dbo].[spInstruments_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstruments_Delete]
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

DELETE FROM Instruments
WHERE (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spInstruments_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstruments_GetAll]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT        Id, Name, InstrumentTypeId, SerialNumber, Description, LabId, Status
FROM            Instruments
END
GO
/****** Object:  StoredProcedure [dbo].[spInstruments_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstruments_GetOne]
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT Id, Name, InstrumentTypeId, SerialNumber, Description, LabId, Status
FROM Instruments
WHERE (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spInstruments_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstruments_Insert]
	@Name varchar(50),
	@InstrumentTypeId int,
	@SerialNumber varchar(50),
	@Description varchar(500),
	@LabId int,
	@Status int,
	@Id int out
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Instruments (Name, InstrumentTypeId, SerialNumber, Description, LabId, Status) 
	VALUES (@Name, @InstrumentTypeId, @SerialNumber, @Description, @LabId, @Status)

	--Вернём Новый ID
	SET @Id = @@Identity

	-- Заолним таблицу InstrumentAnaliticals
	IF @Status = 1
		INSERT INTO InstrumentAnalyticals(InstrumentId, AnalyticalServiceId, LabId)
		SELECT @Id, [AnalyticalServiceId], @LabId FROM [dbo].[InstrumentTypeAnalyticals] WHERE InstrumentTypeId = @InstrumentTypeId
END
GO
/****** Object:  StoredProcedure [dbo].[spInstruments_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstruments_Update]
	@Id int,
	@Name varchar(50),
	@InstrumentTypeId int,
	@SerialNumber varchar(50),
	@Description varchar(500),
	@LabId int,
	@Status int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

UPDATE       Instruments
SET                Name = @Name, InstrumentTypeId = @InstrumentTypeId, SerialNumber = @SerialNumber, Description = @Description, LabId = @LabId, Status = @Status
WHERE (Id = @Id)

--Удалим старые значения
DELETE FROM InstrumentAnalyticals WHERE InstrumentId = @Id

-- Заолним таблицу InstrumentAnaliticals
IF @Status = 1
	INSERT INTO InstrumentAnalyticals(InstrumentId, AnalyticalServiceId, LabId)
	SELECT @Id, [AnalyticalServiceId], @LabId FROM [dbo].[InstrumentTypeAnalyticals] WHERE InstrumentTypeId = @InstrumentTypeId
END
GO
/****** Object:  StoredProcedure [dbo].[spInstrumentTypeAnalyticals_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstrumentTypeAnalyticals_Delete]
	-- Add the parameters for the stored procedure here
	@InstrumentTypeId int,
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM InstrumentTypeAnalyticals
WHERE (InstrumentTypeId = @InstrumentTypeId and AnalyticalServiceId = @AnalyticalServiceId)
END
GO
/****** Object:  StoredProcedure [dbo].[spInstrumentTypeAnalyticals_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstrumentTypeAnalyticals_GetAll]
	@InstrumentTypeId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        InstrumentTypeId, AnalyticalServiceId
FROM            InstrumentTypeAnalyticals
WHERE (InstrumentTypeId = @InstrumentTypeId)
END
GO
/****** Object:  StoredProcedure [dbo].[spInstrumentTypeAnalyticals_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstrumentTypeAnalyticals_GetOne]
	-- Add the parameters for the stored procedure here
	@InstrumentTypeId int,
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        InstrumentTypeId, AnalyticalServiceId
FROM            InstrumentTypeAnalyticals
WHERE		  (InstrumentTypeId = @InstrumentTypeId and AnalyticalServiceId = @AnalyticalServiceId)
END
GO
/****** Object:  StoredProcedure [dbo].[spInstrumentTypeAnalyticals_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstrumentTypeAnalyticals_Insert]
	@InstrumentTypeId int,
	@AnalyticalServiceId int
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO InstrumentTypeAnalyticals (InstrumentTypeId, AnalyticalServiceId) 
	VALUES (@InstrumentTypeId, @AnalyticalServiceId)
END
GO
/****** Object:  StoredProcedure [dbo].[spInstrumentTypeAnalyticals_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstrumentTypeAnalyticals_Update]
	-- Add the parameters for the stored procedure here
	@InstrumentTypeId int,
	@OldAnalyticalServiceId int,
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE InstrumentTypeAnalyticals  SET InstrumentTypeId = @InstrumentTypeId,  AnalyticalServiceId = @AnalyticalServiceId 
	WHERE (InstrumentTypeId = @InstrumentTypeId and AnalyticalServiceId = @OldAnalyticalServiceId)
END
GO
/****** Object:  StoredProcedure [dbo].[spInstrumentTypes_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstrumentTypes_Delete]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM InstrumentTypes
WHERE (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spInstrumentTypes_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstrumentTypes_GetAll]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        Id, Name, Description
FROM            InstrumentTypes
END
GO
/****** Object:  StoredProcedure [dbo].[spInstrumentTypes_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstrumentTypes_GetOne]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        Id, Name, Description
FROM            InstrumentTypes
WHERE		  (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spInstrumentTypes_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstrumentTypes_Insert]
	-- Add the parameters for the stored procedure here
	@Name varchar(50),
	@Description varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO InstrumentTypes (Name, Description) VALUES (@Name, @Description)
END
GO
/****** Object:  StoredProcedure [dbo].[spInstrumentTypes_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstrumentTypes_Update]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(50),
	@Description varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE InstrumentTypes  SET Name = @Name, Description = @Description WHERE (id=@Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spLabs_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spLabs_Delete]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

DELETE FROM Labs
WHERE        (Id = @Id)

END
GO
/****** Object:  StoredProcedure [dbo].[spLabs_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spLabs_GetAll]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT       Id, Code, Name, LocId, Description
FROM            Labs

END
GO
/****** Object:  StoredProcedure [dbo].[spLabs_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spLabs_GetOne]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
SELECT        Id, Code, Name, LocId, Description
FROM            Labs
WHERE        (Id = @id)

END
GO
/****** Object:  StoredProcedure [dbo].[spLabs_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spLabs_Insert]
	-- Add the parameters for the stored procedure here
	@Code varchar(50),
	@Name varchar(50),
	@LocId int,
	@Description varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
INSERT INTO Labs (Code, Name, LocId, Description) VALUES (@Code, @Name, @LocId, @Description)

END
GO
/****** Object:  StoredProcedure [dbo].[spLabs_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spLabs_Update]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Code varchar(50),
	@Name varchar(50),
	@LocId int,
	@Description varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
UPDATE       Labs
SET                Code = @Code, Name = @Name, LocId = @LocId, Description = @Description
WHERE        (Id = @Id)

END
GO
/****** Object:  StoredProcedure [dbo].[spLocs_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spLocs_Delete]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM Locs
WHERE (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spLocs_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spLocs_GetAll]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        Id, Name, Description
FROM            Locs

END
GO
/****** Object:  StoredProcedure [dbo].[spLocs_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spLocs_GetOne]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        Id, Name, Description
FROM            Locs
WHERE        (Id = @Id)

END
GO
/****** Object:  StoredProcedure [dbo].[spLocs_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spLocs_Insert]
	-- Add the parameters for the stored procedure here
	@Name varchar(150),
	@Description varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO Locs
                         (Name, Description)
VALUES        (@Name, @Description)
END
GO
/****** Object:  StoredProcedure [dbo].[spLocs_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spLocs_Update]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(150),
	@Description varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Locs  SET Name = @Name, Description = @Description WHERE (Id=@Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spResultAttrs_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spResultAttrs_Delete]
	-- Add the parameters for the stored procedure here
	@SampleId int,
	@AnalyticalServiceId int,
	@AttrId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM ResultAttrs
WHERE (SampleId = @SampleId and AnalyticalServiceId = @AnalyticalServiceId and AttrId = @AttrId)
END
GO
/****** Object:  StoredProcedure [dbo].[spResultAttrs_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spResultAttrs_GetAll]
	@SampleId int,
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        SampleId, AnalyticalServiceId, AttrId, Value, CreateTime, UpdateTime, CreateUser, UpdateUser
FROM            ResultAttrs
WHERE (SampleId = @SampleId and AnalyticalServiceId = @AnalyticalServiceId)
END
GO
/****** Object:  StoredProcedure [dbo].[spResultAttrs_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spResultAttrs_GetOne]
	-- Add the parameters for the stored procedure here
	@SampleId int,
	@AnalyticalServiceId int,
	@AttrId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        SampleId, AnalyticalServiceId, AttrId, Value, CreateTime, UpdateTime, CreateUser, UpdateUser
FROM            ResultAttrs
WHERE		  (SampleId = @SampleId and AnalyticalServiceId = @AnalyticalServiceId and AttrId = @AttrId)
END
GO
/****** Object:  StoredProcedure [dbo].[spResultAttrs_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spResultAttrs_Insert]
	-- Add the parameters for the stored procedure here
	@SampleId int,
	@AnalyticalServiceId int,
	@AttrId int,
	@Value varchar(100),
	@CreateTime datetime,
	@UpdateTime datetime,
	@CreateUser varchar(50),
	@UpdateUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO ResultAttrs (SampleId, AnalyticalServiceId, AttrId, Value, CreateTime, UpdateTime, CreateUser, UpdateUser) 
	VALUES (@SampleId, @AnalyticalServiceId, @AttrId, @Value, @CreateTime, @UpdateTime, @CreateUser, @UpdateUser)
END
GO
/****** Object:  StoredProcedure [dbo].[spResultAttrs_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spResultAttrs_Update]
	-- Add the parameters for the stored procedure here
	@SampleId int,
	@AnalyticalServiceId int,
	@AttrId int,
	@Value varchar(100),
	@UpdateTime datetime,
	@UpdateUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	UPDATE ResultAttrs 
	SET Value = @Value, UpdateTime = @UpdateTime, UpdateUser = @UpdateUser
	WHERE (SampleId = @SampleId and AnalyticalServiceId = @AnalyticalServiceId and AttrId = @AttrId)
END
GO
/****** Object:  StoredProcedure [dbo].[spResultInstruments_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spResultInstruments_GetOne]
	@SampleId int,
	@AnalyticalServiceId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM ResultInstruments
	WHERE SampleId = @SampleId and AnalyticalServiceId = @AnalyticalServiceId
END
GO
/****** Object:  StoredProcedure [dbo].[spResults_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spResults_Delete]
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

DELETE FROM Results
WHERE (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spResults_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spResults_GetAll]
	@SampleId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT        Results.Id, Results.SampleId, Results.AnalyticalServiceId, AnalyticalServices.Name, AnalyticalServices.UnitId, Results.InstrumentId, Results.ValueNo, Results.Value, Results.IsFinal, Results.Note, Results.CreateTime, Results.UpdateTime, Results.CreateUser, Results.UpdateUser
FROM            Results JOIN AnalyticalServices ON Results.AnalyticalServiceId = AnalyticalServices.Id
WHERE (Results.SampleId = @SampleId)
ORDER BY AnalyticalServices.Name, ValueNo
END
GO
/****** Object:  StoredProcedure [dbo].[spResults_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spResults_GetOne]
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT Results.Id, Results.SampleId, Results.AnalyticalServiceId, AnalyticalServices.UnitId, Results.InstrumentId, Results.ValueNo, Results.Value, Results.IsFinal, Results.Note, Results.CreateTime, Results.UpdateTime, Results.CreateUser, Results.UpdateUser
FROM Results JOIN AnalyticalServices ON Results.AnalyticalServiceId = AnalyticalServices.Id
WHERE (Results.Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spResults_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spResults_Insert]
	@SampleId int,
	@AnalyticalServiceId int,
	@InstrumentId int,
	@ValueNo int,
	@Value float,
	@IsFinal int,
	@Note text,
	@CreateTime datetime,
	@UpdateTime datetime,
	@CreateUser varchar(50),
	@UpdateUser varchar(50),
	@InstrumId int = null
AS
BEGIN
	SET NOCOUNT ON;

	-- Если в таблице Results есть запись то взять InstrumentId
	IF EXISTS( SELECT *	FROM Results WHERE SampleId = @SampleId and AnalyticalServiceId = @AnalyticalServiceId)
		SET @InstrumId = (SELECT top 1 InstrumentId FROM Results
		WHERE SampleId = @SampleId and AnalyticalServiceId = @AnalyticalServiceId)

	-- Добавление данных в Results
	INSERT INTO Results (SampleId, AnalyticalServiceId, InstrumentId, ValueNo, Value, IsFinal, Note, CreateTime, UpdateTime, CreateUser, UpdateUser) 
	VALUES (@SampleId, @AnalyticalServiceId, @InstrumId, @ValueNo, @Value, @IsFinal, @Note, @CreateTime, @UpdateTime, @CreateUser, @UpdateUser)

	-- Заполним таблицу ResultAttrs если нет записей
	IF NOT EXISTS( SELECT *	FROM ResultAttrs WHERE SampleId = @SampleId and AnalyticalServiceId = @AnalyticalServiceId)
		INSERT INTO ResultAttrs (SampleId, AnalyticalServiceId, AttrId, CreateTime, CreateUser)
		SELECT @SampleId, AnalyticalServiceId, AttrId, @CreateTime, @CreateUser
		FROM AnalyticalServiceAttrs
END
GO
/****** Object:  StoredProcedure [dbo].[spResults_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spResults_Update]
	@Id int,
	@SampleId int,
	@AnalyticalServiceId int,
	@InstrumentId int,
	@ValueNo int,
	@Value float,
	@IsFinal int,
	@Note text,
	@CreateTime datetime,
	@UpdateTime datetime,
	@CreateUser varchar(50),
	@UpdateUser varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	-- Обновить строку по Id
	UPDATE       Results
	SET                SampleId = @SampleId, AnalyticalServiceId = @AnalyticalServiceId, InstrumentId = @InstrumentId, ValueNo = @ValueNo, Value = @Value, IsFinal = @IsFinal, Note = @Note, CreateTime = @CreateTime, UpdateTime = @UpdateTime, CreateUser = @CreateUser, UpdateUser = @UpdateUser
	WHERE (Id = @Id)

	-- Обновить строкам инструменты с соответствующими SampleId и AnalyticalServiceId
	UPDATE       Results
	SET                InstrumentId = @InstrumentId, UpdateTime = @UpdateTime, UpdateUser = @UpdateUser
	WHERE (SampleId = @SampleId and AnalyticalServiceId = @AnalyticalServiceId)
END
GO
/****** Object:  StoredProcedure [dbo].[spRoles_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spRoles_Delete]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM Roles
WHERE (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spRoles_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spRoles_GetAll]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        Id, Name, Description
FROM            Roles
END
GO
/****** Object:  StoredProcedure [dbo].[spRoles_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spRoles_GetOne]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        Id, Name, Description
FROM            Roles
WHERE		  (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spRoles_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spRoles_Insert]
	-- Add the parameters for the stored procedure here
	@Name varchar(50),
	@Description varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Roles (Name, Description) VALUES (@Name, @Description)
END
GO
/****** Object:  StoredProcedure [dbo].[spRoles_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spRoles_Update]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(50),
	@Description varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Roles  SET Name = @Name, Description = @Description WHERE (id=@Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleAnalyticals_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleAnalyticals_Delete]
	-- Add the parameters for the stored procedure here
	@SampleId int,
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM SampleAnalyticals
WHERE (SampleId = @SampleId and AnalyticalServiceId = @AnalyticalServiceId)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleAnalyticals_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleAnalyticals_GetAll]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        SampleId, AnalyticalServiceId
FROM            SampleAnalyticals
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleAnalyticals_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleAnalyticals_GetOne]
	-- Add the parameters for the stored procedure here
	@SampleId int,
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        SampleId, AnalyticalServiceId
FROM            SampleAnalyticals
WHERE		  (SampleId = @SampleId and AnalyticalServiceId = @AnalyticalServiceId)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleAnalyticals_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleAnalyticals_Insert]
	-- Add the parameters for the stored procedure here
	@SampleId int,
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO SampleAnalyticals (SampleId, AnalyticalServiceId) VALUES (@SampleId, @AnalyticalServiceId)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleAnalyticals_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleAnalyticals_Update]
	-- Add the parameters for the stored procedure here
	@SampleId int,
	@OldAnalyticalServiceId int,
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE SampleAnalyticals  SET SampleId = @SampleId, AnalyticalServiceId = @AnalyticalServiceId 
	WHERE (SampleId = @SampleId and AnalyticalServiceId = @OldAnalyticalServiceId)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleAttrs_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleAttrs_Delete]
	-- Add the parameters for the stored procedure here
	@SampleId int,
	@AttrId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM SampleAttrs
WHERE (SampleId = @SampleId and AttrId = @AttrId)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleAttrs_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleAttrs_GetAll]
	@SampleId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        SampleId, AttrId, Value, CreateTime, UpdateTime, CreateUser, UpdateUser
FROM            SampleAttrs
WHERE (SampleId = @SampleId)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleAttrs_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleAttrs_GetOne]
	-- Add the parameters for the stored procedure here
	@SampleId int, 
	@AttrId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        SampleId, AttrId, Value, CreateTime, UpdateTime, CreateUser, UpdateUser
FROM            SampleAttrs
WHERE		  (SampleId = @SampleId and AttrId = @AttrId)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleAttrs_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleAttrs_Insert]
	-- Add the parameters for the stored procedure here
	@SampleId int, 
	@AttrId int,
	@Value varchar(100), 
	@CreateTime datetime, 
	@UpdateTime datetime, 
	@CreateUser varchar(50), 
	@UpdateUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO SampleAttrs (SampleId, AttrId, Value, CreateTime, UpdateTime, CreateUser, UpdateUser) VALUES (@SampleId, @AttrId, @Value, @CreateTime, @UpdateTime, @CreateUser, @UpdateUser)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleAttrs_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleAttrs_Update]
	-- Add the parameters for the stored procedure here
	@SampleId int, 
	@AttrId int,
	@Value varchar(100), 
	@CreateTime datetime, 
	@UpdateTime datetime, 
	@CreateUser varchar(50), 
	@UpdateUser varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE SampleAttrs  SET AttrId = @AttrId, Value = @Value, CreateTime = @CreateTime, UpdateTime = @UpdateTime, CreateUser = @CreateUser, UpdateUser = @UpdateUser
	WHERE (SampleId = @SampleId and AttrId = @AttrId)
END
GO
/****** Object:  StoredProcedure [dbo].[spSamples_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSamples_Delete]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

DELETE FROM Samples
WHERE        (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spSamples_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSamples_GetAll]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT       Id, RecieveTime, TestTime, ClientId, LabId, SampleTypeId, NumSamples, Status, IsFinal, Note, LocationId, LastEditComment, CreateTime, UpdateTime, CreateUser, UpdateUser, FinalizeUser, FinalizeTime
FROM            Samples
END
GO
/****** Object:  StoredProcedure [dbo].[spSamples_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSamples_GetOne]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        Id, RecieveTime, TestTime, ClientId, LabId, SampleTypeId, NumSamples, Status, IsFinal, Note, LocationId, LastEditComment, CreateTime, UpdateTime, CreateUser, UpdateUser, FinalizeUser, FinalizeTime
FROM            Samples
WHERE        (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spSamples_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSamples_Insert]
	-- Add the parameters for the stored procedure here
	@RecieveTime datetime,
	@TestTime datetime,
	@ClientId int,
	@LabId int,
	@SampleTypeId int,
	@NumSamples int,
	@Status int,
	@IsFinal bit,
	@Note text,
	@LocationId int,
	@LastEditComment varchar(500),
	@CreateTime datetime,
	@UpdateTime datetime,
	@CreateUser varchar(50),
	@UpdateUser varchar(50),
	@FinalizeUser varchar(50),
	@FinalizeTime datetime,
	@I int = null,
	@Id int out
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO Samples
                         (RecieveTime, TestTime, ClientId, LabId, SampleTypeId, NumSamples, Status, IsFinal, Note, LocationId, LastEditComment, CreateTime, UpdateTime, CreateUser, UpdateUser, FinalizeUser, FinalizeTime)
VALUES        (@RecieveTime, @TestTime, @ClientId, @LabId, @SampleTypeId, @NumSamples, @Status, @IsFinal, @Note, @LocationId, @LastEditComment, @CreateTime, @UpdateTime, @CreateUser, @UpdateUser, @FinalizeUser, @FinalizeTime)
	--Вернём Новый ID
	SET @Id = @@Identity

	-- Заолним таблицу SampleAttrs
	INSERT INTO SampleAttrs(SampleId, AttrId)
	SELECT @Id, [AttrId] FROM [dbo].[SampleTypeAttrs] WHERE SampleTypeId = @SampleTypeId

	-- Заолним таблицу Results
	--SET @I = 1
	--WHILE @NumSamples >= @I
	--	BEGIN
	--		INSERT INTO Results(SampleId, AnalyticalServiceId, ValueNo, Value, IsFinal)
	--		SELECT @Id, [AnalyticalServiceId], @I, null, 1 FROM [dbo].[SampleAnalyticals] WHERE @Id = [SampleId]
	--		SET @I = @I + 1
	--	END
END
GO
/****** Object:  StoredProcedure [dbo].[spSamples_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSamples_Update]
	-- Add the parameters for the stored procedure here
	@Id int,
	@RecieveTime datetime,
	@TestTime datetime,
	@ClientId int,
	@LabId int,
	@SampleTypeId int,
	@NumSamples int,
	@Status int,
	@IsFinal bit,
	@Note text,
	@LocationId int,
	@LastEditComment varchar(500),
	@CreateTime datetime,
	@UpdateTime datetime,
	@CreateUser varchar(50),
	@UpdateUser varchar(50),
	@FinalizeUser varchar(50),
	@FinalizeTime datetime,
	@I int = null,
	@STypeId int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
UPDATE       Samples
SET                RecieveTime = @RecieveTime, TestTime = @TestTime, ClientId = @ClientId, LabId = @LabId, @STypeId = SampleTypeId, SampleTypeId = @SampleTypeId, NumSamples = @NumSamples, Status = @Status, IsFinal = @IsFinal, Note = @Note, LocationId = @LocationId, LastEditComment = @LastEditComment, CreateTime = @CreateTime, UpdateTime = @UpdateTime, CreateUser = @CreateUser, UpdateUser = @UpdateUser, FinalizeUser = @FinalizeUser, FinalizeTime = @FinalizeTime
WHERE        (Id = @Id)

--Удалим старые значения
DELETE FROM SampleAttrs WHERE SampleId = @Id
IF @SampleTypeId <> @STypeId 
	DELETE FROM Results WHERE SampleId = @Id

-- Заолним таблицу SampleAttrs
INSERT INTO SampleAttrs(SampleId, AttrId)
SELECT @Id, [AttrId] FROM [dbo].[SampleTypeAttrs] WHERE SampleTypeId = @SampleTypeId

-- Заолним таблицу Results
	--SET @I = 1
	--IF @SampleTypeId <> @STypeId 
	--WHILE @NumSamples >= @I
	--	BEGIN
	--		INSERT INTO Results(SampleId, AnalyticalServiceId, ValueNo, Value, IsFinal)
	--		SELECT @Id, [AnalyticalServiceId], @I, null, 1 FROM [dbo].[SampleAnalyticals] WHERE @Id = [SampleId]
	--		SET @I = @I + 1
	--	END

END
GO
/****** Object:  StoredProcedure [dbo].[spSampleSpecAnalyticals_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleSpecAnalyticals_Delete]
	-- Add the parameters for the stored procedure here
	@SampleSpecId int,
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM SampleSpecAnalyticals
WHERE (SampleSpecId = @SampleSpecId and AnalyticalServiceId = @AnalyticalServiceId)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleSpecAnalyticals_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleSpecAnalyticals_GetAll]
	@SampleSpecId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        SampleSpecId, AnalyticalServiceId, MinValue, MaxValue
FROM            SampleSpecAnalyticals
WHERE SampleSpecId = @SampleSpecId
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleSpecAnalyticals_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleSpecAnalyticals_GetOne]
	-- Add the parameters for the stored procedure here
	@SampleSpecId int,
	@AnalyticalServiceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        SampleSpecId, AnalyticalServiceId, MinValue, MaxValue
FROM            SampleSpecAnalyticals
WHERE		  (SampleSpecId = @SampleSpecId and AnalyticalServiceId = @AnalyticalServiceId)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleSpecAnalyticals_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleSpecAnalyticals_Insert]
	-- Add the parameters for the stored procedure here
	@SampleSpecId int,
	@AnalyticalServiceId int,
	@MinValue float,
	@MaxValue float
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO SampleSpecAnalyticals (SampleSpecId, AnalyticalServiceId, MinValue, MaxValue) 
	VALUES (@SampleSpecId, @AnalyticalServiceId, @MinValue, @MaxValue)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleSpecAnalyticals_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleSpecAnalyticals_Update]
	-- Add the parameters for the stored procedure here
	@SampleSpecId int,
	@OldSampleSpecId int,
	@AnalyticalServiceId int,
	@OldAnalyticalServiceId int,
	@MinValue float,
	@MaxValue float
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE SampleSpecAnalyticals  SET SampleSpecId = @SampleSpecId, AnalyticalServiceId = @AnalyticalServiceId, MinValue = @MinValue, MaxValue = @MaxValue 
	WHERE (SampleSpecId = @OldSampleSpecId and AnalyticalServiceId = @OldAnalyticalServiceId)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleSpecs_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleSpecs_Delete]
	
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

DELETE FROM SampleSpecs
WHERE (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleSpecs_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleSpecs_GetAll]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT        Id, Name, Description, Version
FROM            SampleSpecs
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleSpecs_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleSpecs_GetOne]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        Id, Name, Description, Version
FROM            SampleSpecs
WHERE        (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleSpecs_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleSpecs_Insert]
	-- Add the parameters for the stored procedure here
	@Name varchar(50),
	@Description varchar(550),
	@Version varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO SampleSpecs
                         (Name, Description, Version)
VALUES        (@Name, @Description, @Version)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleSpecs_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleSpecs_Update]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(50),
	@Description varchar(500),
	@Version varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE SampleSpecs  SET Name = @Name, Description = @Description, Version = @Version WHERE (Id=@Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleTypeAttrs_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleTypeAttrs_Delete]
	-- Add the parameters for the stored procedure here
	@SampleTypeId int,
	@AttrId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM SampleTypeAttrs
WHERE (SampleTypeId = @SampleTypeId and AttrId = @AttrId)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleTypeAttrs_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleTypeAttrs_GetAll]
	@SampleTypeId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        SampleTypeId, AttrId
FROM            SampleTypeAttrs
WHERE (SampleTypeId = @SampleTypeId)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleTypeAttrs_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleTypeAttrs_GetOne]
	-- Add the parameters for the stored procedure here
	@SampleTypeId int,
	@AttrId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        SampleTypeId, AttrId
FROM            SampleTypeAttrs
WHERE		  (SampleTypeId = @SampleTypeId and AttrId = @AttrId)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleTypeAttrs_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleTypeAttrs_Insert]
	-- Add the parameters for the stored procedure here
	@SampleTypeId int,
	@AttrId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO SampleTypeAttrs (SampleTypeId, AttrId) VALUES (@SampleTypeId, @AttrId)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleTypeAttrs_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleTypeAttrs_Update]
	-- Add the parameters for the stored procedure here
	@SampleTypeId int,
	@OldAttrId int,
	@AttrId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE SampleTypeAttrs  SET SampleTypeId = @SampleTypeId, AttrId = @AttrId 
	WHERE (SampleTypeId = @SampleTypeId and AttrId = @OldAttrId)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleTypes_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleTypes_Delete]
	
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

DELETE FROM SampleTypes
WHERE (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleTypes_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleTypes_GetAll]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT        Id, Name, Description
FROM            SampleTypes
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleTypes_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleTypes_GetOne]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        Id, Name, Description
FROM            SampleTypes
WHERE        (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleTypes_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleTypes_Insert]
	-- Add the parameters for the stored procedure here
	@Name varchar(50),
	@Description varchar(550)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO SampleTypes
                         (Name, Description)
VALUES        (@Name, @Description)
END
GO
/****** Object:  StoredProcedure [dbo].[spSampleTypes_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSampleTypes_Update]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(50),
	@Description varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE SampleTypes  SET Name = @Name, Description = @Description WHERE (Id=@Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spUnits_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUnits_Delete]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM Units
WHERE (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spUnits_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUnits_GetAll]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        Id, Name, Scale, BaseUnitId
FROM            Units
END
GO
/****** Object:  StoredProcedure [dbo].[spUnits_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUnits_GetOne]
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        Id, Name, Scale, BaseUnitId
FROM            Units
WHERE		  (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spUnits_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUnits_Insert]
	-- Add the parameters for the stored procedure here
	@Name varchar(50),
	@Scale varchar(50),
	@BaseUnitId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Units (Name, Scale, BaseUnitId) VALUES (@Name, @Scale, @BaseUnitId)
END
GO
/****** Object:  StoredProcedure [dbo].[spUnits_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUnits_Update]
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(50),
	@Scale varchar(50),
	@BaseUnitId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Units  SET Name = @Name, Scale = @Scale, BaseUnitId = @BaseUnitId WHERE (id=@Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spUserRoles_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUserRoles_Delete]
	-- Add the parameters for the stored procedure here
	@LabId int,
	@UserId int,
	@RoleId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM UserRoles
WHERE (LabId = @LabId and UserId = @UserId and RoleId = @RoleId)
END
GO
/****** Object:  StoredProcedure [dbo].[spUserRoles_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUserRoles_GetAll]
	@UserId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        LabId, UserId, RoleId
FROM            UserRoles
WHERE (UserId = @UserId)
END
GO
/****** Object:  StoredProcedure [dbo].[spUserRoles_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUserRoles_GetOne]
	-- Add the parameters for the stored procedure here
	@LabId int,
	@UserId int,
	@RoleId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT        LabId, UserId, RoleId
FROM            UserRoles
WHERE		  (LabId = @LabId and UserId = @UserId and RoleId = @RoleId)
END
GO
/****** Object:  StoredProcedure [dbo].[spUserRoles_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUserRoles_Insert]
	-- Add the parameters for the stored procedure here
	@LabId int,
	@UserId int,
	@RoleId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO UserRoles (LabId, UserId, RoleId) 
	VALUES (@LabId, @UserId, @RoleId)
END
GO
/****** Object:  StoredProcedure [dbo].[spUserRoles_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUserRoles_Update]
	-- Add the parameters for the stored procedure here
	@LabId int,
	@UserId int,
	@RoleId int,
	@OldLabId int,
	@OldRoleId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE UserRoles  SET LabId = @LabId,  UserId = @UserId,  RoleId = @RoleId
	WHERE (LabId = @OldLabId and UserId = @UserId and RoleId = @OldRoleId)
END
GO
/****** Object:  StoredProcedure [dbo].[spUsers_Delete]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUsers_Delete]
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

DELETE FROM Users
WHERE (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spUsers_GetAll]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUsers_GetAll]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT        Id, Name, FullName, PhoneNumber, Password
FROM            Users
END
GO
/****** Object:  StoredProcedure [dbo].[spUsers_GetOne]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUsers_GetOne]
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT Id, Name, FullName, PhoneNumber, Password
FROM Users
WHERE (Id = @Id)
END
GO
/****** Object:  StoredProcedure [dbo].[spUsers_Insert]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUsers_Insert]
	-- Add the parameters for the stored procedure here
	@Name varchar(50),
	@FullName varchar(100),
	@PhoneNumber varchar(50),
	@Password varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Users (Name, FullName, PhoneNumber, Password) VALUES (@Name, @FullName, @PhoneNumber, @Password)
END
GO
/****** Object:  StoredProcedure [dbo].[spUsers_Update]    Script Date: 09.04.2021 19:47:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUsers_Update]

	@Id int,
	@Name varchar(50),
	@FullName varchar(100),
	@PhoneNumber varchar(50),
	@Password varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

UPDATE       Users
SET                Name = @Name, FullName = @FullName, PhoneNumber = @PhoneNumber, Password = @Password
WHERE (Id = @Id)
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Labs', @level2type=N'COLUMN',@level2name=N'Code'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Краткое наименование' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Labs', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Место расположения' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Labs', @level2type=N'COLUMN',@level2name=N'LocId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Описание' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Labs', @level2type=N'COLUMN',@level2name=N'Description'
GO
USE [master]
GO
ALTER DATABASE [LIMS] SET  READ_WRITE 
GO
