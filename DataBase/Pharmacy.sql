USE [master]
GO
/****** Object:  Database [Pharmacy]    Script Date: 1/7/2025 9:43:13 PM ******/
CREATE DATABASE [Pharmacy]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Pharmacy', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Pharmacy.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Pharmacy_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Pharmacy_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Pharmacy] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Pharmacy].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Pharmacy] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Pharmacy] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Pharmacy] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Pharmacy] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Pharmacy] SET ARITHABORT OFF 
GO
ALTER DATABASE [Pharmacy] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Pharmacy] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Pharmacy] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Pharmacy] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Pharmacy] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Pharmacy] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Pharmacy] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Pharmacy] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Pharmacy] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Pharmacy] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Pharmacy] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Pharmacy] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Pharmacy] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Pharmacy] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Pharmacy] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Pharmacy] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Pharmacy] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Pharmacy] SET RECOVERY FULL 
GO
ALTER DATABASE [Pharmacy] SET  MULTI_USER 
GO
ALTER DATABASE [Pharmacy] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Pharmacy] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Pharmacy] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Pharmacy] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Pharmacy] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Pharmacy] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Pharmacy', N'ON'
GO
ALTER DATABASE [Pharmacy] SET QUERY_STORE = ON
GO
ALTER DATABASE [Pharmacy] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Pharmacy]
GO
/****** Object:  Table [dbo].[CurrentTransaction]    Script Date: 1/7/2025 9:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurrentTransaction](
	[Quantity] [int] NULL,
	[Price] [int] NULL,
	[PayPrice] [int] NULL,
	[Item] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer_Phone]    Script Date: 1/7/2025 9:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Phone](
	[Customer-ID] [int] NULL,
	[Phone] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StorageInfo]    Script Date: 1/7/2025 9:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StorageInfo](
	[Item_ID] [int] IDENTITY(1,1) NOT NULL,
	[Item] [nvarchar](50) NULL,
	[Manufacturer] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
	[Price] [int] NULL,
	[MonthOfProduction] [nvarchar](50) NULL,
	[YearOfProduction] [nvarchar](50) NULL,
	[MonthOfExpiration] [nvarchar](50) NULL,
	[YearOfExpiration] [nvarchar](50) NULL,
 CONSTRAINT [PK_StorageInfo] PRIMARY KEY CLUSTERED 
(
	[Item_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 1/7/2025 9:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction](
	[Customer_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[PurchaseDate] [nvarchar](50) NULL,
	[TotalBill] [int] NULL,
	[Phone] [nvarchar](50) NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserDetails]    Script Date: 1/7/2025 9:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDetails](
	[User_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[UserType] [nvarchar](50) NULL,
	[DateOfBirth] [date] NULL,
	[Gender] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pharmcist] PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CurrentTransaction] ([Quantity], [Price], [PayPrice], [Item]) VALUES (1, 5, 5, N'Aspirin')
GO
INSERT [dbo].[Customer_Phone] ([Customer-ID], [Phone]) VALUES (1, N'01000')
GO
SET IDENTITY_INSERT [dbo].[StorageInfo] ON 

INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (1, N'Aspirin', N'ABC Pharma', 84, 5, N'January', N'2023', N'April', N'2025')
INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (2, N'Paracetamol', N'XYZ Pharma', 50, 3, N'March', N'2022', N'June', N'2024')
INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (3, N'Ibuprofen', N'DEF Pharma', 80, 4, N'May', N'2023', N'September', N'2025')
INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (4, N'Omeprazole', N'PQR Pharma', 30, 8, N'February', N'2023', N'May', N'2025')
INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (5, N'Cetirizine', N'LMN Pharma', 120, 2, N'July', N'2022', N'November', N'2023')
INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (6, N'Lipitor', N'GHI Pharma', 60, 12, N'October', N'2023', N'January', N'2026')
INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (7, N'Metformin', N'JKL Pharma', 90, 3, N'April', N'2022', N'August', N'2024')
INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (8, N'Amoxicillin', N'MNO Pharma', 40, 6, N'December', N'2022', N'March', N'2024')
INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (9, N'Simvastatin', N'PQR Pharma', 70, 9, N'June', N'2023', N'October', N'2025')
INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (10, N'Zyrtec', N'ABC Pharma', 110, 4, N'August', N'2022', N'December', N'2023')
INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (11, N'Prozac', N'XYZ Pharma', 25, 7, N'November', N'2022', N'February', N'2024')
INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (12, N'Advil', N'DEF Pharma', 95, 3, N'March', N'2023', N'June', N'2025')
INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (13, N'Nexium', N'GHI Pharma', 35, 10, N'May', N'2022', N'August', N'2023')
INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (14, N'Benadryl', N'JKL Pharma', 75, 2, N'February', N'2023', N'May', N'2025')
INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (15, N'Celebrex', N'MNO Pharma', 55, 11, N'July', N'2022', N'November', N'2023')
INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (16, N'Claritin', N'PQR Pharma', 85, 6, N'September', N'2023', N'December', N'2025')
INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (17, N'Crestor', N'ABC Pharma', 65, 8, N'April', N'2022', N'July', N'2024')
INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (18, N'Prilosec', N'XYZ Pharma', 45, 5, N'January', N'2023', N'April', N'2025')
INSERT [dbo].[StorageInfo] ([Item_ID], [Item], [Manufacturer], [Quantity], [Price], [MonthOfProduction], [YearOfProduction], [MonthOfExpiration], [YearOfExpiration]) VALUES (24, N'mmmmmmmmm', N'aaaaaaaaaaaa', 12, 100, N'may', N'2020', N'may', N'2024')
SET IDENTITY_INSERT [dbo].[StorageInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[Transaction] ON 

INSERT [dbo].[Transaction] ([Customer_ID], [Name], [Gender], [PurchaseDate], [TotalBill], [Phone]) VALUES (1, N'mohamed', N'Male', N'5/6/2024 12:36:30 PM', 22, N'01012345')
INSERT [dbo].[Transaction] ([Customer_ID], [Name], [Gender], [PurchaseDate], [TotalBill], [Phone]) VALUES (2, N'ahmed', N'Male', N'5/6/2024 1:21:21 PM', 94, N'0123456489')
INSERT [dbo].[Transaction] ([Customer_ID], [Name], [Gender], [PurchaseDate], [TotalBill], [Phone]) VALUES (3, N'morales', N'Male', N'5/6/2024 1:30:29 PM', 30, N'010123456')
INSERT [dbo].[Transaction] ([Customer_ID], [Name], [Gender], [PurchaseDate], [TotalBill], [Phone]) VALUES (4, N'mahmoud', N'Male', N'5/6/2024 1:44:35 PM', 40, N'04022558226')
INSERT [dbo].[Transaction] ([Customer_ID], [Name], [Gender], [PurchaseDate], [TotalBill], [Phone]) VALUES (5, N'Morales', N'Male', N'5/6/2024 4:07:27 PM', 12, N'01019297668')
INSERT [dbo].[Transaction] ([Customer_ID], [Name], [Gender], [PurchaseDate], [TotalBill], [Phone]) VALUES (6, N'ali', N'Male', N'5/7/2024 12:47:22 PM', 80, N'010231564')
INSERT [dbo].[Transaction] ([Customer_ID], [Name], [Gender], [PurchaseDate], [TotalBill], [Phone]) VALUES (7, N'elsaid', N'Male', N'5/12/2024 10:07:18 AM', 50, N'012000000')
INSERT [dbo].[Transaction] ([Customer_ID], [Name], [Gender], [PurchaseDate], [TotalBill], [Phone]) VALUES (8, N'ahmed', N'Male', N'5/12/2024 10:38:07 AM', 75, N'1230230')
INSERT [dbo].[Transaction] ([Customer_ID], [Name], [Gender], [PurchaseDate], [TotalBill], [Phone]) VALUES (9, N'ali', N'Male', N'5/12/2024 8:17:48 PM', 20, N'01234567')
INSERT [dbo].[Transaction] ([Customer_ID], [Name], [Gender], [PurchaseDate], [TotalBill], [Phone]) VALUES (10, N'ali', N'Male', N'5/12/2024 8:26:51 PM', 30, N'0123456')
SET IDENTITY_INSERT [dbo].[Transaction] OFF
GO
SET IDENTITY_INSERT [dbo].[UserDetails] ON 

INSERT [dbo].[UserDetails] ([User_ID], [Name], [UserName], [Password], [UserType], [DateOfBirth], [Gender], [Phone]) VALUES (1, N'mohamed', N'admin', N'123', N'Owner', CAST(N'2000-06-01' AS Date), N'Male', N'010123123')
INSERT [dbo].[UserDetails] ([User_ID], [Name], [UserName], [Password], [UserType], [DateOfBirth], [Gender], [Phone]) VALUES (2, N'John Doe', N'johndoe', N'password1', N'Owner', CAST(N'1990-05-15' AS Date), N'Male', N'1234567890')
INSERT [dbo].[UserDetails] ([User_ID], [Name], [UserName], [Password], [UserType], [DateOfBirth], [Gender], [Phone]) VALUES (3, N'Jane Smith', N'janesmith', N'password2', N'Staff', CAST(N'1985-09-20' AS Date), N'Female', N'9876543210')
INSERT [dbo].[UserDetails] ([User_ID], [Name], [UserName], [Password], [UserType], [DateOfBirth], [Gender], [Phone]) VALUES (4, N'Mark Johnson', N'markjohnson', N'password3', N'Staff', CAST(N'1992-03-10' AS Date), N'Male', N'5555555555')
INSERT [dbo].[UserDetails] ([User_ID], [Name], [UserName], [Password], [UserType], [DateOfBirth], [Gender], [Phone]) VALUES (5, N'Emily Brown', N'emilybrown', N'password4', N'Staff', CAST(N'1994-07-25' AS Date), N'Female', N'9999999999')
INSERT [dbo].[UserDetails] ([User_ID], [Name], [UserName], [Password], [UserType], [DateOfBirth], [Gender], [Phone]) VALUES (6, N'Michael Wilson', N'michaelwilson', N'password5', N'Staff', CAST(N'1988-11-05' AS Date), N'Male', N'1111111111')
INSERT [dbo].[UserDetails] ([User_ID], [Name], [UserName], [Password], [UserType], [DateOfBirth], [Gender], [Phone]) VALUES (7, N'Sarah Davis', N'sarahdavis', N'password6', N'Staff', CAST(N'1991-02-18' AS Date), N'Female', N'2222222222')
INSERT [dbo].[UserDetails] ([User_ID], [Name], [UserName], [Password], [UserType], [DateOfBirth], [Gender], [Phone]) VALUES (8, N'Robert Taylor', N'roberttaylor', N'password7', N'Staff', CAST(N'1987-06-30' AS Date), N'Male', N'3333333333')
INSERT [dbo].[UserDetails] ([User_ID], [Name], [UserName], [Password], [UserType], [DateOfBirth], [Gender], [Phone]) VALUES (9, N'Olivia Lee', N'oliviale', N'password8', N'Staff', CAST(N'1993-09-12' AS Date), N'Female', N'4444444444')
INSERT [dbo].[UserDetails] ([User_ID], [Name], [UserName], [Password], [UserType], [DateOfBirth], [Gender], [Phone]) VALUES (10, N'William Clark', N'williamclark', N'password9', N'Staff', CAST(N'1995-01-08' AS Date), N'Male', N'6666666666')
INSERT [dbo].[UserDetails] ([User_ID], [Name], [UserName], [Password], [UserType], [DateOfBirth], [Gender], [Phone]) VALUES (11, N'Sophia Anderson', N'sophiaanderson', N'password10', N'Staff', CAST(N'1989-04-22' AS Date), N'Female', N'7777777777')
SET IDENTITY_INSERT [dbo].[UserDetails] OFF
GO
USE [master]
GO
ALTER DATABASE [Pharmacy] SET  READ_WRITE 
GO
