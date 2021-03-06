USE [master]
GO
/****** Object:  Database [FashionBoutique]    Script Date: 9/13/2020 11:40:46 AM ******/
CREATE DATABASE [FashionBoutique]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FashionBoutique_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\FashionBoutique.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FashionBoutique_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\FashionBoutique.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FashionBoutique] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FashionBoutique].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FashionBoutique] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FashionBoutique] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FashionBoutique] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FashionBoutique] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FashionBoutique] SET ARITHABORT OFF 
GO
ALTER DATABASE [FashionBoutique] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FashionBoutique] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FashionBoutique] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FashionBoutique] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FashionBoutique] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FashionBoutique] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FashionBoutique] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FashionBoutique] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FashionBoutique] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FashionBoutique] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FashionBoutique] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FashionBoutique] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FashionBoutique] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FashionBoutique] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FashionBoutique] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FashionBoutique] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FashionBoutique] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FashionBoutique] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FashionBoutique] SET  MULTI_USER 
GO
ALTER DATABASE [FashionBoutique] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FashionBoutique] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FashionBoutique] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FashionBoutique] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FashionBoutique] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FashionBoutique] SET QUERY_STORE = OFF
GO
USE [FashionBoutique]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 9/13/2020 11:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Mobile] [varchar](50) NULL,
	[Product_Type] [varchar](50) NULL,
	[Size] [nvarchar](50) NULL,
	[Price] [varchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Design]    Script Date: 9/13/2020 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Design](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DesignName] [varchar](50) NULL,
	[DesignPic] [nvarchar](50) NULL,
 CONSTRAINT [PK_Design] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 9/13/2020 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Mobile] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Skills] [varchar](50) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 9/13/2020 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[LoginName] [varchar](50) NULL,
	[LoginPassword] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Query]    Script Date: 9/13/2020 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Query](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Subject] [varchar](50) NULL,
	[Message] [varchar](50) NULL,
 CONSTRAINT [PK_Query] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salary]    Script Date: 9/13/2020 11:40:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Mobile] [varchar](50) NULL,
	[Salary] [varchar](50) NULL,
 CONSTRAINT [PK_Salary] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [FashionBoutique] SET  READ_WRITE 
GO
