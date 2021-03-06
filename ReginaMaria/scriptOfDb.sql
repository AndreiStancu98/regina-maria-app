USE [master]
GO
/****** Object:  Database [ReginaMaria]    Script Date: 19/08/2021 01:44:51 ******/
CREATE DATABASE [ReginaMaria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ReginaMaria', FILENAME = N'D:\Programs\Microsoft Sql Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ReginaMaria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ReginaMaria_log', FILENAME = N'D:\Programs\Microsoft Sql Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ReginaMaria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ReginaMaria] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ReginaMaria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ReginaMaria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ReginaMaria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ReginaMaria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ReginaMaria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ReginaMaria] SET ARITHABORT OFF 
GO
ALTER DATABASE [ReginaMaria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ReginaMaria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ReginaMaria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ReginaMaria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ReginaMaria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ReginaMaria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ReginaMaria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ReginaMaria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ReginaMaria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ReginaMaria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ReginaMaria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ReginaMaria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ReginaMaria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ReginaMaria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ReginaMaria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ReginaMaria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ReginaMaria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ReginaMaria] SET RECOVERY FULL 
GO
ALTER DATABASE [ReginaMaria] SET  MULTI_USER 
GO
ALTER DATABASE [ReginaMaria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ReginaMaria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ReginaMaria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ReginaMaria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ReginaMaria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ReginaMaria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ReginaMaria', N'ON'
GO
ALTER DATABASE [ReginaMaria] SET QUERY_STORE = OFF
GO
USE [ReginaMaria]
GO
/****** Object:  Table [dbo].[Drugs]    Script Date: 19/08/2021 01:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drugs](
	[DrugID] [int] NOT NULL,
	[DrugName] [varchar](50) NULL,
	[Quantity] [int] NULL,
	[Dosage] [varchar](50) NULL,
	[PrescriptionID] [int] NOT NULL,
 CONSTRAINT [PK_Drugs] PRIMARY KEY CLUSTERED 
(
	[DrugID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 19/08/2021 01:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[PatientID] [int] NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[BirthDate] [date] NULL,
	[PrescriptionID] [int] NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prescriptions]    Script Date: 19/08/2021 01:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prescriptions](
	[PrescriptionID] [int] NOT NULL,
	[Series] [varchar](50) NULL,
	[Number] [int] NULL,
	[ReleaseDate] [date] NULL,
	[PatientID] [int] NULL,
 CONSTRAINT [PK_Prescriptions] PRIMARY KEY CLUSTERED 
(
	[PrescriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[DeleteDrug]    Script Date: 19/08/2021 01:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteDrug]
@DrugID int
as
begin
Delete Drugs where DrugID= @DrugID
end
GO
/****** Object:  StoredProcedure [dbo].[DeletePatient]    Script Date: 19/08/2021 01:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeletePatient]
@PatientID int
as
begin
Delete Patients where PatientID=@PatientID 
end
GO
/****** Object:  StoredProcedure [dbo].[DeletePrescription]    Script Date: 19/08/2021 01:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeletePrescription]
@PrescriptionID int
as
begin
Delete Prescriptions where PrescriptionID= @PrescriptionID
end
GO
/****** Object:  StoredProcedure [dbo].[GetDrugReport]    Script Date: 19/08/2021 01:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetDrugReport]
@startDate datetime,
@endDate datetime
as
begin
Select Drugs.DrugName, COUNT(Drugs.Quantity) FROM Drugs
INNER join Prescriptions ON Prescriptions.PrescriptionID = Drugs.PrescriptionID
WHERE Prescriptions.ReleaseDate BETWEEN @startDate AND @endDate
Group BY Drugs.DrugName
end
GO
/****** Object:  StoredProcedure [dbo].[GetPatientReport]    Script Date: 19/08/2021 01:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetPatientReport]
@startDate datetime,
@endDate datetime
as
begin
Select Patients.FirstName, Patients.LastName, COUNT(Prescriptions.PrescriptionID) from Patients
INNER join Prescriptions ON Prescriptions.PatientID = Patients.PatientID
WHERE Prescriptions.ReleaseDate BETWEEN @startDate AND @endDate
Group BY Patients.FirstName, Patients.LastName
end
GO
/****** Object:  StoredProcedure [dbo].[GetPatients]    Script Date: 19/08/2021 01:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetPatients]
as
begin
select * from Patients
end
GO
/****** Object:  StoredProcedure [dbo].[InsertDrug]    Script Date: 19/08/2021 01:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertDrug]
@DrugID int,
@DrugName varchar(50),
@Quantity int,
@Dosage varchar(50),
@PrescriptionID int
as
begin
Insert into Drugs(DrugID, DrugName, Quantity, Dosage, PrescriptionID)
values (@DrugID, @DrugName, @Quantity, @Dosage, @PrescriptionID)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertPatient]    Script Date: 19/08/2021 01:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertPatient]
@PatientID int,
@FirstName varchar(50),
@LastName varchar(50),
@BirthDate datetime,
@PrescriptionID int
as
begin
insert into Patients (PatientID, FirstName, LastName, BirthDate, PrescriptionID)
values (@PatientID, @FirstName, @LastName, @BirthDate, @PrescriptionID)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertPrescription]    Script Date: 19/08/2021 01:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertPrescription]
@PrescriptionID int,
@Series varchar(50),
@Number int,
@ReleaseDate datetime,
@PatientID int
as
begin
Insert into Prescriptions (PrescriptionID, Series, Number, ReleaseDate, PatientID)
values (@PrescriptionID, @Series, @Number, @ReleaseDate, @PatientID)
end
GO
/****** Object:  StoredProcedure [dbo].[ListDrugs]    Script Date: 19/08/2021 01:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ListDrugs]
as
begin
select * from Drugs
end
GO
/****** Object:  StoredProcedure [dbo].[ListPrescriptions]    Script Date: 19/08/2021 01:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ListPrescriptions]
as
begin
select * from Prescriptions
end
GO
/****** Object:  StoredProcedure [dbo].[LoadPatient]    Script Date: 19/08/2021 01:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoadPatient]
@PatientID int
as
begin
Select * from Patients where PatientID=@PatientID 
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateDrugs]    Script Date: 19/08/2021 01:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateDrugs]
@DrugID int,
@DrugName varchar(50),
@Quantity int,
@Dosage varchar(50),
@PrescriptionID int
as
begin
Update Drugs set DrugID= @DrugID, DrugName= @DrugName, Quantity= @Quantity, Dosage= @Dosage, PrescriptionID= @PrescriptionID
end
GO
/****** Object:  StoredProcedure [dbo].[UpdatePatient]    Script Date: 19/08/2021 01:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdatePatient]
@PatientID int,
@FirstName varchar(50),
@LastName varchar(50),
@BirthDate datetime,
@PrescriptionID int
as
begin
Update Patients set FirstName=@FirstName, LastName=@LastName, BirthDate=@BirthDate, PrescriptionID=@PrescriptionID where PatientID=@PatientID 
end
GO
/****** Object:  StoredProcedure [dbo].[UpdatePrescription]    Script Date: 19/08/2021 01:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdatePrescription]
@PrescriptionID int,
@Series varchar(50),
@Number int,
@ReleaseDate datetime,
@PatientID int
as
begin
Update Prescriptions set PrescriptionID= @PrescriptionID, Series= @Series, Number= @Number, ReleaseDate= @ReleaseDate, PatientID= @PatientID
end
GO
USE [master]
GO
ALTER DATABASE [ReginaMaria] SET  READ_WRITE 
GO
