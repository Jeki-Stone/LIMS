USE [master]
GO
/****** Object:  Database [LIMS]    Script Date: 11.03.2021 19:11:10 ******/
CREATE DATABASE [LIMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LIMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\LIMS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LIMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\LIMS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [LIMS] SET COMPATIBILITY_LEVEL = 140
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
ALTER DATABASE [LIMS] SET  READ_WRITE 
GO
