
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/05/2021 22:21:26
-- Generated from EDMX file: C:\Users\Dimab\Desktop\universityProject1\UniversityManager\Models\UniversityModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Student05];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Group_Specialty]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Group] DROP CONSTRAINT [FK_Group_Specialty];
GO
IF OBJECT_ID(N'[dbo].[FK_Student_Group]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Student] DROP CONSTRAINT [FK_Student_Group];
GO
IF OBJECT_ID(N'[dbo].[FK_TeacherDiscipline_Discipline]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeacherDiscipline] DROP CONSTRAINT [FK_TeacherDiscipline_Discipline];
GO
IF OBJECT_ID(N'[dbo].[FK_TeacherDiscipline_Group]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeacherDiscipline] DROP CONSTRAINT [FK_TeacherDiscipline_Group];
GO
IF OBJECT_ID(N'[dbo].[FK_TeacherDiscipline_Teacher]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeacherDiscipline] DROP CONSTRAINT [FK_TeacherDiscipline_Teacher];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Discipline]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Discipline];
GO
IF OBJECT_ID(N'[dbo].[Group]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Group];
GO
IF OBJECT_ID(N'[dbo].[Specialty]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Specialty];
GO
IF OBJECT_ID(N'[dbo].[Student]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Student];
GO
IF OBJECT_ID(N'[dbo].[Teacher]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Teacher];
GO
IF OBJECT_ID(N'[dbo].[TeacherDiscipline]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeacherDiscipline];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Disciplines'
CREATE TABLE [dbo].[Disciplines] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Groups'
CREATE TABLE [dbo].[Groups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [YearFormation] int  NOT NULL,
    [SpecialtyId] int  NOT NULL
);
GO

-- Creating table 'Specialties'
CREATE TABLE [dbo].[Specialties] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Info] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Photo] nvarchar(max)  NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL,
    [Birthday] datetime  NOT NULL,
    [GroupId] int  NOT NULL
);
GO

-- Creating table 'Teachers'
CREATE TABLE [dbo].[Teachers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Photo] nvarchar(max)  NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [StartYear] int  NOT NULL
);
GO

-- Creating table 'TeacherDisciplines'
CREATE TABLE [dbo].[TeacherDisciplines] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AcademicYearStart] int  NOT NULL,
    [AcademicYearEnd] int  NOT NULL,
    [TotalHours] int  NOT NULL,
    [GroupId] int  NOT NULL,
    [TeacherId] int  NOT NULL,
    [DisciplineId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Disciplines'
ALTER TABLE [dbo].[Disciplines]
ADD CONSTRAINT [PK_Disciplines]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Groups'
ALTER TABLE [dbo].[Groups]
ADD CONSTRAINT [PK_Groups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Specialties'
ALTER TABLE [dbo].[Specialties]
ADD CONSTRAINT [PK_Specialties]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Teachers'
ALTER TABLE [dbo].[Teachers]
ADD CONSTRAINT [PK_Teachers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TeacherDisciplines'
ALTER TABLE [dbo].[TeacherDisciplines]
ADD CONSTRAINT [PK_TeacherDisciplines]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DisciplineId] in table 'TeacherDisciplines'
ALTER TABLE [dbo].[TeacherDisciplines]
ADD CONSTRAINT [FK_TeacherDiscipline_Discipline]
    FOREIGN KEY ([DisciplineId])
    REFERENCES [dbo].[Disciplines]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeacherDiscipline_Discipline'
CREATE INDEX [IX_FK_TeacherDiscipline_Discipline]
ON [dbo].[TeacherDisciplines]
    ([DisciplineId]);
GO

-- Creating foreign key on [SpecialtyId] in table 'Groups'
ALTER TABLE [dbo].[Groups]
ADD CONSTRAINT [FK_Group_Specialty]
    FOREIGN KEY ([SpecialtyId])
    REFERENCES [dbo].[Specialties]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Group_Specialty'
CREATE INDEX [IX_FK_Group_Specialty]
ON [dbo].[Groups]
    ([SpecialtyId]);
GO

-- Creating foreign key on [GroupId] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_Student_Group]
    FOREIGN KEY ([GroupId])
    REFERENCES [dbo].[Groups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Student_Group'
CREATE INDEX [IX_FK_Student_Group]
ON [dbo].[Students]
    ([GroupId]);
GO

-- Creating foreign key on [GroupId] in table 'TeacherDisciplines'
ALTER TABLE [dbo].[TeacherDisciplines]
ADD CONSTRAINT [FK_TeacherDiscipline_Group]
    FOREIGN KEY ([GroupId])
    REFERENCES [dbo].[Groups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeacherDiscipline_Group'
CREATE INDEX [IX_FK_TeacherDiscipline_Group]
ON [dbo].[TeacherDisciplines]
    ([GroupId]);
GO

-- Creating foreign key on [TeacherId] in table 'TeacherDisciplines'
ALTER TABLE [dbo].[TeacherDisciplines]
ADD CONSTRAINT [FK_TeacherDiscipline_Teacher]
    FOREIGN KEY ([TeacherId])
    REFERENCES [dbo].[Teachers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeacherDiscipline_Teacher'
CREATE INDEX [IX_FK_TeacherDiscipline_Teacher]
ON [dbo].[TeacherDisciplines]
    ([TeacherId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------