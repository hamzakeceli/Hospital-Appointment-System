USE [master]
GO
/****** Object:  Database [Hospital_Automation]    Script Date: 4.11.2019 14:46:27 ******/
CREATE DATABASE [Hospital_Automation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hospital_Automation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Hospital_Automation.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Hospital_Automation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Hospital_Automation_log.ldf' , SIZE = 1856KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Hospital_Automation] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hospital_Automation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hospital_Automation] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hospital_Automation] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hospital_Automation] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hospital_Automation] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hospital_Automation] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hospital_Automation] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Hospital_Automation] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hospital_Automation] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hospital_Automation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hospital_Automation] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hospital_Automation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hospital_Automation] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hospital_Automation] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hospital_Automation] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hospital_Automation] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hospital_Automation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hospital_Automation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hospital_Automation] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hospital_Automation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hospital_Automation] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hospital_Automation] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hospital_Automation] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hospital_Automation] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Hospital_Automation] SET  MULTI_USER 
GO
ALTER DATABASE [Hospital_Automation] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hospital_Automation] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hospital_Automation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hospital_Automation] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Hospital_Automation] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hospital_Automation] SET QUERY_STORE = OFF
GO
USE [Hospital_Automation]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[DepartmentId] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [nvarchar](max) NOT NULL,
	[HospitalId] [int] NOT NULL,
	[PolyclinicStatu] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diagnosis]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnosis](
	[DiagnosisId] [int] IDENTITY(1,1) NOT NULL,
	[DiagnosisName] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DiagnosisId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[DoctorId] [int] IDENTITY(1,1) NOT NULL,
	[DoctorFirstName] [nvarchar](max) NOT NULL,
	[DoctorLastName] [nvarchar](max) NOT NULL,
	[DepartmentId] [int] NOT NULL,
	[PolyclinicId] [int] NULL,
	[DoctorEmail] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DoctorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drugs]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drugs](
	[DrugId] [int] IDENTITY(1,1) NOT NULL,
	[DrugName] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DrugId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Examinations]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examinations](
	[ExaminationId] [int] IDENTITY(1,1) NOT NULL,
	[SessionId] [int] NOT NULL,
	[PatientId] [int] NOT NULL,
	[DiagnosisId] [int] NOT NULL,
	[RecipeId] [int] NULL,
	[ExaminationStatu] [bit] NOT NULL,
	[TestStatu] [bit] NOT NULL,
 CONSTRAINT [PK__Examinat__C4A924201D17A3C4] PRIMARY KEY CLUSTERED 
(
	[ExaminationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hospitals]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospitals](
	[HospitalId] [int] IDENTITY(1,1) NOT NULL,
	[HospitalName] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HospitalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[MemberEmail] [nvarchar](50) NOT NULL,
	[MemberPassword] [nvarchar](max) NOT NULL,
	[RoleId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[PatientId] [int] IDENTITY(1,1) NOT NULL,
	[PatientFirstName] [nvarchar](max) NOT NULL,
	[PatientLastName] [nvarchar](max) NOT NULL,
	[PatientEmail] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PatientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pharmacist]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pharmacist](
	[PharmacistId] [int] IDENTITY(1,1) NOT NULL,
	[PharmacistFirstName] [nvarchar](max) NOT NULL,
	[PharmacistLastName] [nvarchar](max) NOT NULL,
	[PharmacistEmail] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PharmacistId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Polyclinics]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Polyclinics](
	[PolyclinicId] [int] IDENTITY(1,1) NOT NULL,
	[PolyclinicName] [nvarchar](max) NOT NULL,
	[DepartmentId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PolyclinicId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recipe]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recipe](
	[RecipeId] [int] IDENTITY(1,1) NOT NULL,
	[RecipeNumber] [nvarchar](max) NOT NULL,
	[PatientId] [int] NULL,
 CONSTRAINT [PK__Recipe__FDD988B0B94DBED9] PRIMARY KEY CLUSTERED 
(
	[RecipeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecipeDetails]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecipeDetails](
	[RecipeId] [int] NOT NULL,
	[DrugId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rendezvous]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rendezvous](
	[RendezvousId] [int] IDENTITY(1,1) NOT NULL,
	[SessionId] [int] NOT NULL,
	[PatientId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RendezvousId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RendezvousTimes]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RendezvousTimes](
	[RendezvousTimeId] [int] IDENTITY(1,1) NOT NULL,
	[RendezvousTime] [nvarchar](8) NOT NULL,
 CONSTRAINT [PK__Rendezvo__7B00BF0292E87084] PRIMARY KEY CLUSTERED 
(
	[RendezvousTimeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sessions]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sessions](
	[SessionId] [int] IDENTITY(1,1) NOT NULL,
	[RendezvousTimeId] [int] NOT NULL,
	[DoctorId] [int] NOT NULL,
	[SessionDate] [date] NOT NULL,
 CONSTRAINT [PK__Sessions__C9F49290A4915206] PRIMARY KEY CLUSTERED 
(
	[SessionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD FOREIGN KEY([HospitalId])
REFERENCES [dbo].[Hospitals] ([HospitalId])
GO
ALTER TABLE [dbo].[Doctors]  WITH CHECK ADD FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([DepartmentId])
GO
ALTER TABLE [dbo].[Doctors]  WITH CHECK ADD FOREIGN KEY([DoctorEmail])
REFERENCES [dbo].[Members] ([MemberEmail])
GO
ALTER TABLE [dbo].[Doctors]  WITH CHECK ADD FOREIGN KEY([PolyclinicId])
REFERENCES [dbo].[Polyclinics] ([PolyclinicId])
GO
ALTER TABLE [dbo].[Examinations]  WITH CHECK ADD  CONSTRAINT [FK__Examinati__Diagn__1CBC4616] FOREIGN KEY([DiagnosisId])
REFERENCES [dbo].[Diagnosis] ([DiagnosisId])
GO
ALTER TABLE [dbo].[Examinations] CHECK CONSTRAINT [FK__Examinati__Diagn__1CBC4616]
GO
ALTER TABLE [dbo].[Examinations]  WITH CHECK ADD  CONSTRAINT [FK__Examinati__Patie__1BC821DD] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([PatientId])
GO
ALTER TABLE [dbo].[Examinations] CHECK CONSTRAINT [FK__Examinati__Patie__1BC821DD]
GO
ALTER TABLE [dbo].[Examinations]  WITH CHECK ADD  CONSTRAINT [FK__Examinati__Recip__1DB06A4F] FOREIGN KEY([RecipeId])
REFERENCES [dbo].[Recipe] ([RecipeId])
GO
ALTER TABLE [dbo].[Examinations] CHECK CONSTRAINT [FK__Examinati__Recip__1DB06A4F]
GO
ALTER TABLE [dbo].[Examinations]  WITH CHECK ADD  CONSTRAINT [FK__Examinati__Sessi__1AD3FDA4] FOREIGN KEY([SessionId])
REFERENCES [dbo].[Sessions] ([SessionId])
GO
ALTER TABLE [dbo].[Examinations] CHECK CONSTRAINT [FK__Examinati__Sessi__1AD3FDA4]
GO
ALTER TABLE [dbo].[Members]  WITH CHECK ADD FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([RoleId])
GO
ALTER TABLE [dbo].[Patients]  WITH CHECK ADD FOREIGN KEY([PatientEmail])
REFERENCES [dbo].[Members] ([MemberEmail])
GO
ALTER TABLE [dbo].[Pharmacist]  WITH CHECK ADD FOREIGN KEY([PharmacistEmail])
REFERENCES [dbo].[Members] ([MemberEmail])
GO
ALTER TABLE [dbo].[Polyclinics]  WITH CHECK ADD FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([DepartmentId])
GO
ALTER TABLE [dbo].[Recipe]  WITH CHECK ADD  CONSTRAINT [FK__Recipe__PatientI__00AA174D] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([PatientId])
GO
ALTER TABLE [dbo].[Recipe] CHECK CONSTRAINT [FK__Recipe__PatientI__00AA174D]
GO
ALTER TABLE [dbo].[RecipeDetails]  WITH CHECK ADD FOREIGN KEY([DrugId])
REFERENCES [dbo].[Drugs] ([DrugId])
GO
ALTER TABLE [dbo].[RecipeDetails]  WITH CHECK ADD FOREIGN KEY([DrugId])
REFERENCES [dbo].[Drugs] ([DrugId])
GO
ALTER TABLE [dbo].[RecipeDetails]  WITH CHECK ADD  CONSTRAINT [FK__RecipeDet__Recip__160F4887] FOREIGN KEY([RecipeId])
REFERENCES [dbo].[Recipe] ([RecipeId])
GO
ALTER TABLE [dbo].[RecipeDetails] CHECK CONSTRAINT [FK__RecipeDet__Recip__160F4887]
GO
ALTER TABLE [dbo].[Rendezvous]  WITH CHECK ADD FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([PatientId])
GO
ALTER TABLE [dbo].[Rendezvous]  WITH CHECK ADD  CONSTRAINT [FK__Rendezvou__Sessi__01142BA1] FOREIGN KEY([SessionId])
REFERENCES [dbo].[Sessions] ([SessionId])
GO
ALTER TABLE [dbo].[Rendezvous] CHECK CONSTRAINT [FK__Rendezvou__Sessi__01142BA1]
GO
ALTER TABLE [dbo].[Sessions]  WITH CHECK ADD  CONSTRAINT [FK__Sessions__Doctor__7D439ABD] FOREIGN KEY([DoctorId])
REFERENCES [dbo].[Doctors] ([DoctorId])
GO
ALTER TABLE [dbo].[Sessions] CHECK CONSTRAINT [FK__Sessions__Doctor__7D439ABD]
GO
ALTER TABLE [dbo].[Sessions]  WITH CHECK ADD  CONSTRAINT [FK__Sessions__Sessio__7C4F7684] FOREIGN KEY([RendezvousTimeId])
REFERENCES [dbo].[RendezvousTimes] ([RendezvousTimeId])
GO
ALTER TABLE [dbo].[Sessions] CHECK CONSTRAINT [FK__Sessions__Sessio__7C4F7684]
GO
/****** Object:  StoredProcedure [dbo].[IsExistDoctorEmail]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IsExistDoctorEmail] (@doctorEmail NVARCHAR(max)) AS
BEGIN
SELECT count(DoctorEmail) FROM Doctors WHERE DoctorEmail = @doctorEmail
END
GO
/****** Object:  StoredProcedure [dbo].[IsExistMemberEmail]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IsExistMemberEmail] (@memberEmail NVARCHAR(max)) AS
BEGIN
SELECT count(MemberEmail) FROM Members WHERE MemberEmail = @memberEmail
END
GO
/****** Object:  StoredProcedure [dbo].[IsExistPatientMail]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[IsExistPatientMail] (@patientEmail NVARCHAR(max)) AS
BEGIN
SELECT count(PatientEmail) FROM Patients WHERE PatientEmail = @patientEmail
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AddDoctorAndMembers]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AddDoctorAndMembers] (
	@FirstName nvarchar(max),
	@LastName nvarchar(max),
	@Email nvarchar(50),
	@Password nvarchar(max),
	@DepartmantId int,
	@PolyclinicId int = NULL
	)
		AS 
			BEGIN				
				INSERT INTO Members(MemberEmail,MemberPassword,RoleId)  VALUES(@Email,@Password,2) 
				INSERT INTO Doctors(DoctorFirstName,DoctorLastName,DepartmentId,PolyclinicId,DoctorEmail) 
							VALUES (@FirstName,@LastName,@DepartmantId,@PolyclinicId,@Email)
			END
GO
/****** Object:  StoredProcedure [dbo].[SP_AddPatientAndMembers]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AddPatientAndMembers] (
	@FirstName nvarchar(max),
	@LastName nvarchar(max),
	@Email nvarchar(50),
	@Password nvarchar(max))
		AS 
			BEGIN				
				INSERT INTO Members(MemberEmail,MemberPassword,RoleId)  VALUES(@Email,@Password,4) 
				INSERT INTO Patients(PatientFirstName,PatientLastName,PatientEmail) VALUES (@FirstName,@LastName,@Email)
			END
GO
/****** Object:  StoredProcedure [dbo].[SP_AddPharmacistAndMembers]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AddPharmacistAndMembers] (
	@FirstName nvarchar(max),
	@LastName nvarchar(max),
	@Email nvarchar(50),
	@Password nvarchar(max))
		AS 
			BEGIN				
				INSERT INTO Members(MemberEmail,MemberPassword,RoleId)  VALUES(@Email,@Password,3) 
				INSERT INTO Pharmacist(PharmacistFirstName,PharmacistLastName,PharmacistEmail) VALUES (@FirstName,@LastName,@Email)
			END
GO
/****** Object:  StoredProcedure [dbo].[SP_AddRendezvous]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AddRendezvous] @SessionDate Date,@RendezvousTimeId int,@DoctorId int,@PatientId int AS 
BEGIN
		INSERT INTO Sessions(RendezvousTimeId,DoctorId,SessionDate) VALUES(@RendezvousTimeId,@DoctorId,@SessionDate)
		DECLARE @lastSessionId int = (IDENT_CURRENT('Sessions'))
		INSERT INTO Rendezvous(SessionId,PatientId) VALUES(@lastSessionId,@PatientId)
END	
GO
/****** Object:  StoredProcedure [dbo].[SP_CreateTableDepartment]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----DEPARTMAN TABLE OLUŞTURAN PROCEDURS
CREATE PROCEDURE [dbo].[SP_CreateTableDepartment](@tableName NVARCHAR(MAX)) AS
BEGIN
     IF NOT EXISTS( SELECT name FROM sys.tables WHERE name=@tableName)  	 
	   BEGIN
           CREATE TABLE Departments
		   (
		      DepartmentId INT PRIMARY KEY IDENTITY(1,1)
			  ,DepartmentName NVARCHAR(MAX) NOT NULL
			  ,HospitalId INT FOREIGN KEY REFERENCES Hospitals(HospitalId) NOT NULL		 
			  ,PolyclinicStatu BIT 
		   )
	   END	   
	 ELSE
	   PRINT (@tableName+' Adında tablo zaten mevcut')
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CreateTableDiagnosis]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CreateTableDiagnosis](@tableName NVARCHAR(MAX)) AS
BEGIN
     IF NOT EXISTS( SELECT name FROM sys.tables WHERE name=@tableName)  	 
	   BEGIN
           CREATE TABLE Diagnosis
		   (
		       DiagnosisId INT PRIMARY KEY IDENTITY(1,1)			  			  
			  ,DiagnosisName NVARCHAR(MAX)  NOT NULL		  
			 

		   )
	   END	   
	 ELSE
	   PRINT (@tableName+' Adında tablo zaten mevcut')
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CreateTableDoctors]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CreateTableDoctors](@tableName NVARCHAR(MAX)) AS
BEGIN
     IF NOT EXISTS( SELECT name FROM sys.tables WHERE name=@tableName)  	 
	   BEGIN
           CREATE TABLE Doctors
		   (
		       DoctorId INT PRIMARY KEY IDENTITY(1,1)
			  ,DoctorFirstName NVARCHAR(MAX) NOT NULL
			  ,DoctorLastName NVARCHAR(MAX) NOT NULL
			  ,DepartmentId INT FOREIGN KEY REFERENCES Departments(DepartmentId) NOT NULL		 
			  ,PolyclinicId INT FOREIGN KEY REFERENCES Polyclinics(PolyclinicId) 
			  ,DoctorEmail NVARCHAR(50)  FOREIGN KEY REFERENCES Members(MemberEmail)  NOT NULL
		   )
	   END	   
	 ELSE
	   PRINT (@tableName+' Adında tablo zaten mevcut')
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CreateTableDrugs]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----ilaç TABLOSU OLUŞTURAN PROCEDURS
CREATE PROCEDURE [dbo].[SP_CreateTableDrugs](@tableName NVARCHAR(MAX)) AS
BEGIN
     IF NOT EXISTS( SELECT name FROM sys.tables WHERE name=@tableName)  	 
	   BEGIN
           CREATE TABLE Drugs
		   (
		       DrugId INT PRIMARY KEY IDENTITY(1,1)			  			  
			  ,DrugName NVARCHAR(MAX)  NOT NULL		  
			 

		   )
	   END	   
	 ELSE
	   PRINT (@tableName+' Adında tablo zaten mevcut')
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CreateTableExaminations]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----seanslar TABLOSU OLUŞTURAN PROCEDURS
CREATE PROCEDURE [dbo].[SP_CreateTableExaminations](@tableName NVARCHAR(MAX)) AS
BEGIN
     IF NOT EXISTS( SELECT name FROM sys.tables WHERE name=@tableName)  	 
	   BEGIN
           CREATE TABLE Examinations
		   (
		       ExaminationId INT PRIMARY KEY IDENTITY(1,1) 			  
			  ,SessionId INT  FOREIGN KEY REFERENCES Sessions(SessionId)  NOT NULL
			  ,PatientId INT  FOREIGN KEY REFERENCES Patients(PatientId)  NOT NULL
			  ,DiagnosisId INT  FOREIGN KEY REFERENCES Diagnosis(DiagnosisId) 
			  ,RecipeId INT  FOREIGN KEY REFERENCES Recipe(RecipeId)  NOT NULL
			  ,ExaminationStatu BIT NOT NULL
			  ,TestStatu BIT NOT NULL		  

		   )
	   END	   
	 ELSE
	   PRINT (@tableName+' Adında tablo zaten mevcut')
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CreateTableHospitals]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----Hastane TABLE OLUŞTURAN PROCEDURS
CREATE PROCEDURE [dbo].[SP_CreateTableHospitals](@tableName NVARCHAR(MAX)) AS
BEGIN
     IF NOT EXISTS( SELECT name FROM sys.tables WHERE name=@tableName)  	 
	   BEGIN
           CREATE TABLE Hospitals
		   (
		      HospitalId INT PRIMARY KEY IDENTITY(1,1)
			  ,HospitalName NVARCHAR(MAX) NOT NULL			   
		   )
	   END
	   
	 ELSE
	   PRINT (@tableName+' Adında tablo zaten mevcut')
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CreateTableMembers]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----  ÜYELER TASBLOSUNU OLUŞTURAN PROCEDURS
CREATE PROCEDURE [dbo].[SP_CreateTableMembers](@tableName NVARCHAR(MAX)) AS
BEGIN
     IF NOT EXISTS( SELECT name FROM sys.tables WHERE name=@tableName)  	 
	   BEGIN
           CREATE TABLE Members
		   (
		      MemberEmail NVARCHAR(50) PRIMARY KEY       --NVARCHAR(MAX) PRİMARY KEY KABUL ETMİYOR
			  ,MemberPassword NVARCHAR(MAX) NOT NULL 
			  ,RoleId INT FOREIGN KEY REFERENCES Roles(RoleId) NOT NULL		 
		   )
	   END	   
	 ELSE
	   PRINT (@tableName+' Adında tablo zaten mevcut')
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CreateTablePatients]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----HASTA TABLOSU OLUŞTURAN PROCEDURS
CREATE PROCEDURE [dbo].[SP_CreateTablePatients](@tableName NVARCHAR(MAX)) AS
BEGIN
     IF NOT EXISTS( SELECT name FROM sys.tables WHERE name=@tableName)  	 
	   BEGIN
           CREATE TABLE Patients
		   (
		      PatientId INT PRIMARY KEY IDENTITY(1,1)
			  ,PatientFirstName NVARCHAR(MAX) NOT NULL
			  ,PatientLastName NVARCHAR(MAX) NOT NULL			  
			  ,DoctorEmail NVARCHAR(50)  FOREIGN KEY REFERENCES Members(MemberEmail)  NOT NULL
		   )
	   END	   
	 ELSE
	   PRINT (@tableName+' Adında tablo zaten mevcut')
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CreateTablePharmacists]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----ECZACI TABLOSU OLUŞTURAN PROCEDURS
CREATE PROCEDURE [dbo].[SP_CreateTablePharmacists](@tableName NVARCHAR(MAX)) AS
BEGIN
     IF NOT EXISTS( SELECT name FROM sys.tables WHERE name=@tableName)  	 
	   BEGIN
           CREATE TABLE Pharmacist
		   (
		       PharmacistId INT PRIMARY KEY IDENTITY(1,1)
			  ,PharmacistFirstName NVARCHAR(MAX) NOT NULL
			  ,PharmacistLastName NVARCHAR(MAX) NOT NULL			 
			  ,PharmacistEmail NVARCHAR(50)  FOREIGN KEY REFERENCES Members(MemberEmail)  NOT NULL
		   )
	   END	   
	 ELSE
	   PRINT (@tableName+' Adında tablo zaten mevcut')
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CreateTablePolyclinic]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CreateTablePolyclinic](@tableName NVARCHAR(MAX)) AS
BEGIN
     IF NOT EXISTS( SELECT name FROM sys.tables WHERE name=@tableName)  	 
	   BEGIN
           CREATE TABLE Polyclinics
		   (
		       PolyclinicId INT PRIMARY KEY IDENTITY(1,1)
			  ,PolyclinicName NVARCHAR(MAX) NOT NULL
			  ,DepartmentId INT FOREIGN KEY REFERENCES Departments(DepartmentId) NOT NULL		 
			  
		   )
	   END	   
	 ELSE
	   PRINT (@tableName+' Adında tablo zaten mevcut')
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CreateTableRecipe]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----Reçete TABLOSU OLUŞTURAN PROCEDURS
CREATE PROCEDURE [dbo].[SP_CreateTableRecipe](@tableName NVARCHAR(MAX)) AS
BEGIN
     IF NOT EXISTS( SELECT name FROM sys.tables WHERE name=@tableName)  	 
	   BEGIN
           CREATE TABLE Recipe
		   (
		       RecipeId INT PRIMARY KEY IDENTITY(1,1)			  			  
			  ,RecipeNumber INT  NOT NULL		  
			 

		   )
	   END	   
	 ELSE
	   PRINT (@tableName+' Adında tablo zaten mevcut')
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CreateTableRecipeDetails]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CreateTableRecipeDetails](@tableName NVARCHAR(MAX)) AS
BEGIN
     IF NOT EXISTS( SELECT name FROM sys.tables WHERE name=@tableName)  	 
	   BEGIN
           CREATE TABLE RecipeDetails
		   (		      
			   RecipeId INT  FOREIGN KEY REFERENCES Recipe(RecipeId)  NOT NULL
			  ,DrugId INT  FOREIGN KEY REFERENCES Drugs(DrugId) NOT NULL	 
			 

		   )
	   END	   
	 ELSE
	   PRINT (@tableName+' Adında tablo zaten mevcut')
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CreateTableRendezvous]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----RANDEVU TABLOSU OLUŞTURAN PROCEDURS
CREATE PROCEDURE [dbo].[SP_CreateTableRendezvous](@tableName NVARCHAR(MAX)) AS
BEGIN
     IF NOT EXISTS( SELECT name FROM sys.tables WHERE name=@tableName)  	 
	   BEGIN
           CREATE TABLE Rendezvous
		   (
		       RendezvousId INT PRIMARY KEY IDENTITY(1,1)			  			  
			  ,SessionId INT  FOREIGN KEY REFERENCES Sessions(SessionId)  NOT NULL
			  ,PatientId INT  FOREIGN KEY REFERENCES Patients(PatientId)  NOT NULL
			  

		   )
	   END	   
	 ELSE
	   PRINT (@tableName+' Adında tablo zaten mevcut')
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CreateTableRendezvousTimes]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CreateTableRendezvousTimes](@tableName NVARCHAR(MAX)) AS
BEGIN
     IF NOT EXISTS( SELECT name FROM sys.tables WHERE name=@tableName)  	 
	   BEGIN
           CREATE TABLE RendezvousTimes
		   (
		       RendezvousTimeId INT PRIMARY KEY IDENTITY(1,1)
			  ,RendezvousTime DATETIME NOT NULL	  
		   )
			  
	   END	   
	 ELSE
	   PRINT (@tableName+' Adında tablo zaten mevcut')
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CreateTableRoles]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----  ROLE TASBLOSUNU OLUŞTURAN PROCEDURS
CREATE PROCEDURE [dbo].[SP_CreateTableRoles](@tableName NVARCHAR(MAX)) AS
BEGIN
     IF NOT EXISTS( SELECT name FROM sys.tables WHERE name=@tableName)  	 
	   BEGIN
           CREATE TABLE Roles
		   (
		      RoleId INT PRIMARY KEY IDENTITY(1,1)
			  ,RoleName NVARCHAR(MAX)  NOT NULL			 			 
		   )
	   END	   
	 ELSE
	   PRINT (@tableName+' Adında tablo zaten mevcut')
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CreateTableSessions]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CreateTableSessions](@tableName NVARCHAR(MAX)) AS
BEGIN
     IF NOT EXISTS( SELECT name FROM sys.tables WHERE name=@tableName)  	 
	   BEGIN
           CREATE TABLE Sessions
		   (
		       SessionId INT PRIMARY KEY IDENTITY(1,1)			  			  
			  ,SessionsTimeId INT  FOREIGN KEY REFERENCES RendezvousTimes(RendezvousTimeId)  NOT NULL
			  ,DoctorId INT  FOREIGN KEY REFERENCES Doctors(DoctorId)  NOT NULL
			  ,SessionDate DATETIME NOT NULL

		   )
	   END	   
	 ELSE
	   PRINT (@tableName+' Adında tablo zaten mevcut')
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DeletePatientAppointment]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DeletePatientAppointment] @PatientId int, @SessionId int AS
BEGIN
	DELETE FROM Rendezvous WHERE PatientId=@PatientId and SessionId=@SessionId
	DELETE FROM Sessions WHERE SessionId = @SessionId
END
	
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllCompleteExaminations]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetAllCompleteExaminations] (@doctorId int) AS
BEGIN
SELECT P.PatientFirstName+' '+P.PatientLastName AS [Hasta Adı],
D.DiagnosisName AS [Teşhis],
R.RecipeNumber AS [Reçete Numarası],
S.SessionDate AS [Randevu Tarihi],
RT.RendezvousTime AS [Randevu Saati]
FROM Examinations AS E INNER JOIN Sessions AS S ON E.SessionId=S.SessionId
INNER JOIN Patients AS P ON E.PatientId = P.PatientId
INNER JOIN RendezvousTimes AS RT ON RT.RendezvousTimeId=S.RendezvousTimeId
INNER JOIN Diagnosis AS D ON D.DiagnosisId=E.DiagnosisId
INNER JOIN Recipe R ON R.RecipeId=E.RecipeId
WHERE S.DoctorId = @doctorId AND E.ExaminationStatu=1
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllDiagnosis]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetAllDiagnosis] AS
BEGIN
SELECT * FROM Diagnosis
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllMedicine]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetAllMedicine] AS 
BEGIN
SELECT * FROM Drugs
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllPatientAppointment]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetAllPatientAppointment] (@PatientId int) AS 
BEGIN
SELECT 
	S.SessionDate AS [TARİH],
	RT.RendezvousTime AS [SAAT],
	D.DoctorFirstName + ' ' + DoctorLastName AS [DOKTOR],
	De.DepartmentName AS [DEPARTMAN],
	Re.PatientId,
	S.SessionId

		FROM Rendezvous AS [Re] INNER JOIN Sessions AS [S] 
		ON [Re].SessionId = [S].SessionId 
				INNER JOIN RendezvousTimes AS [RT] ON 
						[S].RendezvousTimeId = [RT].RendezvousTimeId
							INNER JOIN Doctors AS [D] ON
								[S].[DoctorId] = [D].DoctorId  
									INNER JOIN Departments AS [De] ON
										[D].DepartmentId = [De].DepartmentId 
											WHERE PatientId = @PatientId 
										ORDER BY [TARİH]
										DESC
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllRendezvousTimes]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetAllRendezvousTimes] AS 
BEGIN

SELECT * FROM RendezvousTimes

END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllSessions]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetAllSessions] (@DoctorId int) AS
BEGIN
SELECT * FROM Sessions WHERE DoctorId = @DoctorId 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetDepartment]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetDepartment] AS
BEGIN
SELECT * FROM Departments 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetDoctor]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetDoctor] (@memberEmail NVARCHAR(max)) AS
BEGIN
SELECT * FROM Doctors WHERE DoctorEmail = @memberEmail
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetDoctors]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetDoctors] (@DepartmanId int,@PolyclinicId int=NULL ) AS
BEGIN
		SELECT  
			DoctorFirstName AS [AD],
			DoctorLastName AS [SOYAD],
			DoctorId,
			DepartmentId,
			PolyclinicId
			FROM Doctors AS [D] 
			WHERE D.DepartmentId = @DepartmanId and D.PolyclinicId = @PolyclinicId
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetDoctorsPolyclinicIsNull]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetDoctorsPolyclinicIsNull] (@DepartmanId int ) AS
BEGIN
		SELECT 
			DoctorFirstName AS [AD],
			DoctorLastName AS [SOYAD],
			DoctorId,
			DepartmentId,
			PolyclinicId		
		 FROM Doctors AS [D] 
			WHERE D.DepartmentId = @DepartmanId 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetHospitals]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetHospitals] AS
BEGIN
SELECT * FROM Hospitals 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetMember]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetMember] (@Email nvarchar(50)) AS 
BEGIN
	SELECT * FROM Members WHERE MemberEmail = @Email
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetPatient]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetPatient] (@patientEmail NVARCHAR(max)) AS
BEGIN
SELECT * FROM Patients WHERE PatientEmail = @patientEmail
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetPolyclinics]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetPolyclinics](@DepartmentId NVARCHAR(MAX) ) AS
BEGIN
SELECT * FROM Polyclinics WHERE DepartmentId=@DepartmentId
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetRecipe]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetRecipe](@recipeNumber nvarchar(max)) AS
BEGIN
SELECT * FROM Recipe WHERE Recipe.RecipeNumber=@recipeNumber
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GETRecipeDetail]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GETRecipeDetail](@recipeId int) AS
BEGIN
SELECT RecipeDetails.RecipeId,
	RecipeDetails.DrugId,
	Drugs.DrugName AS [İlaç Adı],
	PatientFirstName+ ' '+PatientLastName AS fullname 
		FROM Recipe INNER JOIN RecipeDetails 
			ON Recipe.RecipeId=RecipeDetails.RecipeId 
				INNER JOIN Drugs 
					ON RecipeDetails.DrugId=Drugs.DrugId 
						INNER JOIN Patients ON Patients.PatientId=Recipe.PatientId
							WHERE Recipe.RecipeId=@recipeId
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetRecipeList]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetRecipeList] (@recipeNumber nvarchar(max)) AS
BEGIN
SELECT * FROM Recipe WHERE Recipe.PatientId = (SELECT PatientId FROM Recipe WHERE Recipe.RecipeNumber=@recipeNumber)
ORDER BY RecipeId DESC
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetRendezvousPatient]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetRendezvousPatient] (@rendezvousTimeId int , @doctorId int , @sessionDate date) AS
BEGIN
SELECT * FROM Patients AS P WHERE P.PatientId= 
(SELECT PatientId FROM Rendezvous WHERE SessionId = 
(SELECT S.SessionId FROM Sessions AS S 
WHERE S.RendezvousTimeId = @rendezvousTimeId 
AND S.DoctorId = @doctorId 
AND S.SessionDate = @sessionDate ))
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetRendezvousTimeId]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetRendezvousTimeId] (@DoctorId int,@SessionDate date) AS
BEGIN
SELECT * FROM Sessions WHERE DoctorId = @DoctorId and SessionDate = @SessionDate
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetRendezvousTimeIdForExamination]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetRendezvousTimeIdForExamination] (@doctorId int,@sessionDate date) AS
BEGIN
SELECT RT.RendezvousTimeId FROM Examinations AS E INNER JOIN Sessions AS S ON E.SessionId=S.SessionId 
INNER JOIN RendezvousTimes AS RT ON S.RendezvousTimeId=RT.RendezvousTimeId
WHERE E.ExaminationStatu=1 AND S.DoctorId =@doctorId AND S.SessionDate=@sessionDate
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetSessionId]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetSessionId] (@rendezvousTimeId int , @doctorId int , @sessionDate date) AS
BEGIN
SELECT S.SessionId FROM Sessions AS S 
WHERE S.RendezvousTimeId = @rendezvousTimeId 
AND S.DoctorId = @doctorId 
AND S.SessionDate = @sessionDate 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertExaminations]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertExaminations] 
(@sessionId int , @patientId int , @diognosisId int ,@recipeId int,@exaStatu int) AS
BEGIN
INSERT INTO Examinations(SessionId,PatientId,DiagnosisId,RecipeId,ExaminationStatu,TestStatu)
VALUES (@sessionId,@patientId,@diognosisId,@recipeId,@exaStatu,0)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertExaminationsForExaStatuZero]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertExaminationsForExaStatuZero] 
(@sessionId int , @patientId int , @diognosisId int ,@exaStatu int) AS
BEGIN
INSERT INTO Examinations(SessionId,PatientId,DiagnosisId,ExaminationStatu,TestStatu)
VALUES (@sessionId,@patientId,@diognosisId,@exaStatu,0)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertRecipe]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertRecipe] (@recipeNumber nvarchar(50), @patientId int ) AS
BEGIN
INSERT INTO Recipe(RecipeNumber,PatientId) VALUES(@recipeNumber,@patientId)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertRecipeDetails]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertRecipeDetails] (@recipeId int, @medicineId int ) AS
BEGIN
INSERT INTO RecipeDetails(RecipeId,DrugId) VALUES(@recipeId,@medicineId)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_IsExistRecipe]    Script Date: 4.11.2019 14:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_IsExistRecipe](@recipeNumber nvarchar(max)) AS
BEGIN
SELECT COUNT(RecipeNumber) FROM Recipe WHERE Recipe.RecipeNumber=@recipeNumber
END
GO
USE [master]
GO
ALTER DATABASE [Hospital_Automation] SET  READ_WRITE 
GO
