USE UniversityDB
GO

-- Create table "Faculty"
IF NOT EXISTS
	(SELECT 1 FROM sys.objects s WHERE s.name = 'Faculty' and s.type = 'U')
	
	CREATE TABLE [dbo].[Faculty]
	(
		[Id] INT IDENTITY(1,1)  NOT NULL,
		[Name] NVARCHAR(50) NOT NULL,
		CONSTRAINT [pk_Faculty] PRIMARY KEY ([Id]),
		CONSTRAINT [uq_Faculty_Name] UNIQUE ([Name]) 
	)
GO

-- Create table "Department"
IF NOT EXISTS
	(SELECT 1 FROM sys.objects s WHERE s.name = 'Department' and s.type = 'U')

	CREATE TABLE [dbo].[Department]
	(
		[Id] INT IDENTITY(1,1)  NOT NULL,
		[Name] NVARCHAR(50) NOT NULL,
		[IdFaculty] INT NOT NULL,
		CONSTRAINT [pk_Department] PRIMARY KEY ([Id]),
		CONSTRAINT [uq_Department_Name] UNIQUE ([Name]),
		CONSTRAINT [fk_Id_Faculty] FOREIGN KEY ([IdFaculty]) REFERENCES [dbo].[Faculty] ([Id]) ON DELETE CASCADE
	)
GO

-- Create table "Specialty"
IF NOT EXISTS
	(SELECT 1 FROM sys.objects s WHERE s.name = 'Specialty' and s.type = 'U')

	CREATE TABLE [dbo].[Specialty]
	(
		[Id] INT IDENTITY(1,1) NOT NULL,
		[Name] NVARCHAR(50) NOT NULL,
		[IdDepartment] INT NOT NULL,
		CONSTRAINT [pk_Specialty] PRIMARY KEY ([Id]),
		CONSTRAINT [uq_Specialty_Name] UNIQUE ([Name]),
		CONSTRAINT [fk_Id_Department] FOREIGN KEY ([IdDepartment]) REFERENCES [dbo].[Department] ([Id]) ON DELETE CASCADE
	)
GO

-- Create table "Groupe"
IF NOT EXISTS
	(SELECT 1 FROM sys.objects s WHERE s.name = 'Groupe' and s.type = 'U')

	CREATE TABLE [dbo].[Groupe]
	(
		[Id] INT IDENTITY(1,1) NOT NULL,
		[Name] NVARCHAR(10) NOT NULL,
		[IdSpecialty] INT NOT NULL,
		CONSTRAINT [pk_Groupe] PRIMARY KEY ([Id]),
		CONSTRAINT [uq_Groupe_Name] UNIQUE ([Name]),
		CONSTRAINT [fk_Id_Specialty] FOREIGN KEY ([IdSpecialty]) REFERENCES [dbo].[Specialty] ([Id]) ON DELETE CASCADE
	)
GO

-- Create table "Student" !!!!! доробити ключі щоб не було путанини у групах з різних факультетів
IF NOT EXISTS
	(SELECT 1 FROM sys.objects s WHERE s.name = 'Student' and s.type = 'U')

	CREATE TABLE [dbo].[Student]
	(
		[Id] INT IDENTITY(1,1) NOT NULL,
		[Surname] NVARCHAR(50) NOT NULL,
		[Name] NVARCHAR(50) NOT NULL,
		[MiddleName] NVARCHAR(50) NOT NULL,
		[IdGroupe] INT NOT NULL,
		CONSTRAINT [pk_Student] PRIMARY KEY ([Id]),
		CONSTRAINT [uq_Student_Name] UNIQUE ([Name]),
		CONSTRAINT [fk_Id_Groupe] FOREIGN KEY ([IdGroupe]) REFERENCES [dbo].[Groupe] ([Id]) ON DELETE CASCADE
	)
GO