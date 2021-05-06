
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/06/2021 16:29:40
-- Generated from EDMX file: C:\Users\Paul\source\repos\Digitalisierung in der Pflege\programm\DataManager\DataManager\DatabaseModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AmbulantCareDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PatientBio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonSet_Patient] DROP CONSTRAINT [FK_PatientBio];
GO
IF OBJECT_ID(N'[dbo].[FK_HomePatient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonSet_Patient] DROP CONSTRAINT [FK_HomePatient];
GO
IF OBJECT_ID(N'[dbo].[FK_PatientHealthData]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonSet_Patient] DROP CONSTRAINT [FK_PatientHealthData];
GO
IF OBJECT_ID(N'[dbo].[FK_HealthDataHospitaliations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HospitaliationsSet] DROP CONSTRAINT [FK_HealthDataHospitaliations];
GO
IF OBJECT_ID(N'[dbo].[FK_HealthDataVitalParameters]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VitalParametersSet] DROP CONSTRAINT [FK_HealthDataVitalParameters];
GO
IF OBJECT_ID(N'[dbo].[FK_HealthDataRiskValues]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RiskValuesSet] DROP CONSTRAINT [FK_HealthDataRiskValues];
GO
IF OBJECT_ID(N'[dbo].[FK_HealthDataMedication]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MedicationSet] DROP CONSTRAINT [FK_HealthDataMedication];
GO
IF OBJECT_ID(N'[dbo].[FK_PatientCaregiver_Patient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PatientCaregiver] DROP CONSTRAINT [FK_PatientCaregiver_Patient];
GO
IF OBJECT_ID(N'[dbo].[FK_PatientCaregiver_Caregiver]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PatientCaregiver] DROP CONSTRAINT [FK_PatientCaregiver_Caregiver];
GO
IF OBJECT_ID(N'[dbo].[FK_PatientDoctor_Patient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PatientDoctor] DROP CONSTRAINT [FK_PatientDoctor_Patient];
GO
IF OBJECT_ID(N'[dbo].[FK_PatientDoctor_Doctor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PatientDoctor] DROP CONSTRAINT [FK_PatientDoctor_Doctor];
GO
IF OBJECT_ID(N'[dbo].[FK_PatientCareReport_Patient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PatientCareReport] DROP CONSTRAINT [FK_PatientCareReport_Patient];
GO
IF OBJECT_ID(N'[dbo].[FK_PatientCareReport_CareReport]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PatientCareReport] DROP CONSTRAINT [FK_PatientCareReport_CareReport];
GO
IF OBJECT_ID(N'[dbo].[FK_PatientActionPlan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ActionPlanSet] DROP CONSTRAINT [FK_PatientActionPlan];
GO
IF OBJECT_ID(N'[dbo].[FK_CaregiverActionPlan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ActionPlanSet] DROP CONSTRAINT [FK_CaregiverActionPlan];
GO
IF OBJECT_ID(N'[dbo].[FK_CaregiverCareReport]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CareReportSet] DROP CONSTRAINT [FK_CaregiverCareReport];
GO
IF OBJECT_ID(N'[dbo].[FK_PatientCaringRelatives]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CaringRelativesSet] DROP CONSTRAINT [FK_PatientCaringRelatives];
GO
IF OBJECT_ID(N'[dbo].[FK_Patient_inherits_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonSet_Patient] DROP CONSTRAINT [FK_Patient_inherits_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_Worker_inherits_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonSet_Worker] DROP CONSTRAINT [FK_Worker_inherits_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_Caregiver_inherits_Worker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonSet_Caregiver] DROP CONSTRAINT [FK_Caregiver_inherits_Worker];
GO
IF OBJECT_ID(N'[dbo].[FK_Doctor_inherits_Worker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonSet_Doctor] DROP CONSTRAINT [FK_Doctor_inherits_Worker];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PersonSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonSet];
GO
IF OBJECT_ID(N'[dbo].[BioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BioSet];
GO
IF OBJECT_ID(N'[dbo].[HomeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HomeSet];
GO
IF OBJECT_ID(N'[dbo].[CaringRelativesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CaringRelativesSet];
GO
IF OBJECT_ID(N'[dbo].[HealthDataSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HealthDataSet];
GO
IF OBJECT_ID(N'[dbo].[HospitaliationsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HospitaliationsSet];
GO
IF OBJECT_ID(N'[dbo].[VitalParametersSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VitalParametersSet];
GO
IF OBJECT_ID(N'[dbo].[RiskValuesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RiskValuesSet];
GO
IF OBJECT_ID(N'[dbo].[MedicationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MedicationSet];
GO
IF OBJECT_ID(N'[dbo].[CareReportSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CareReportSet];
GO
IF OBJECT_ID(N'[dbo].[ActionPlanSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ActionPlanSet];
GO
IF OBJECT_ID(N'[dbo].[PersonSet_Patient]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonSet_Patient];
GO
IF OBJECT_ID(N'[dbo].[PersonSet_Worker]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonSet_Worker];
GO
IF OBJECT_ID(N'[dbo].[PersonSet_Caregiver]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonSet_Caregiver];
GO
IF OBJECT_ID(N'[dbo].[PersonSet_Doctor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonSet_Doctor];
GO
IF OBJECT_ID(N'[dbo].[PatientCaregiver]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PatientCaregiver];
GO
IF OBJECT_ID(N'[dbo].[PatientDoctor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PatientDoctor];
GO
IF OBJECT_ID(N'[dbo].[PatientCareReport]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PatientCareReport];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PersonSet'
CREATE TABLE [dbo].[PersonSet] (
    [PersonID] int IDENTITY(1,1) NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BioSet'
CREATE TABLE [dbo].[BioSet] (
    [BioID] int IDENTITY(1,1) NOT NULL,
    [School] nvarchar(max)  NOT NULL,
    [Training] nvarchar(max)  NOT NULL,
    [University] nvarchar(max)  NOT NULL,
    [Job] nvarchar(max)  NOT NULL,
    [Partnership] nvarchar(max)  NOT NULL,
    [Children] nvarchar(max)  NOT NULL,
    [Leisure] nvarchar(max)  NOT NULL,
    [Family_Members] nvarchar(max)  NOT NULL,
    [Languages] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HomeSet'
CREATE TABLE [dbo].[HomeSet] (
    [HomeID] int IDENTITY(1,1) NOT NULL,
    [Tools] nvarchar(max)  NOT NULL,
    [Barrier_Free_Kitchen] bit  NOT NULL,
    [Barrier_Free_Bath] bit  NOT NULL,
    [Barrier_Free_Living_Area] bit  NOT NULL,
    [Barrier_Free_Stairlift] bit  NOT NULL,
    [Barrier_Free_Elevator] bit  NOT NULL
);
GO

-- Creating table 'CaringRelativesSet'
CREATE TABLE [dbo].[CaringRelativesSet] (
    [CaringRelativesID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [LivesInHousehold] bit  NOT NULL,
    [VisitFrequency] nvarchar(max)  NOT NULL,
    [Activity] nvarchar(max)  NOT NULL,
    [PatientPersonID] int  NOT NULL
);
GO

-- Creating table 'HealthDataSet'
CREATE TABLE [dbo].[HealthDataSet] (
    [HealthDataID] int IDENTITY(1,1) NOT NULL,
    [MedicalHistory] nvarchar(max)  NOT NULL,
    [ChronicDiseases] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HospitaliationsSet'
CREATE TABLE [dbo].[HospitaliationsSet] (
    [HospitaliationsID] int IDENTITY(1,1) NOT NULL,
    [Reason] nvarchar(max)  NOT NULL,
    [Duration] int  NOT NULL,
    [HealthDataHealthDataID] int  NOT NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'VitalParametersSet'
CREATE TABLE [dbo].[VitalParametersSet] (
    [VitalParametersID] int IDENTITY(1,1) NOT NULL,
    [DateTime] datetime  NOT NULL,
    [TypeOfMeasurement] nvarchar(max)  NOT NULL,
    [Value] float  NOT NULL,
    [Unit] nvarchar(max)  NOT NULL,
    [HealthDataHealthDataID] int  NOT NULL
);
GO

-- Creating table 'RiskValuesSet'
CREATE TABLE [dbo].[RiskValuesSet] (
    [RiskValuesID] int IDENTITY(1,1) NOT NULL,
    [Decubitus] int  NOT NULL,
    [Pain] int  NOT NULL,
    [Falling] int  NOT NULL,
    [Dementia] int  NOT NULL,
    [HealthDataHealthDataID] int  NOT NULL
);
GO

-- Creating table 'MedicationSet'
CREATE TABLE [dbo].[MedicationSet] (
    [MedicationID] int IDENTITY(1,1) NOT NULL,
    [Drug] nvarchar(max)  NOT NULL,
    [Dosage] nvarchar(max)  NOT NULL,
    [Frequency] nvarchar(max)  NOT NULL,
    [AdministeredBy] nvarchar(max)  NOT NULL,
    [HealthDataHealthDataID] int  NOT NULL
);
GO

-- Creating table 'CareReportSet'
CREATE TABLE [dbo].[CareReportSet] (
    [CareReportID] int IDENTITY(1,1) NOT NULL,
    [CreatedOn] datetime  NOT NULL,
    [ActionPlanFulfilled] bit  NOT NULL,
    [Deviations] nvarchar(max)  NOT NULL,
    [CaregiverPersonID] int  NOT NULL
);
GO

-- Creating table 'ActionPlanSet'
CREATE TABLE [dbo].[ActionPlanSet] (
    [ActionPlanID] int IDENTITY(1,1) NOT NULL,
    [CreatedOn] datetime  NOT NULL,
    [Actions_Morning] nvarchar(max)  NOT NULL,
    [Actions_Noon] nvarchar(max)  NOT NULL,
    [Actions_Afternoon] nvarchar(max)  NOT NULL,
    [Actions_Eve] nvarchar(max)  NOT NULL,
    [PatientPersonID] int  NOT NULL,
    [CaregiverPersonID] int  NOT NULL
);
GO

-- Creating table 'PersonSet_Patient'
CREATE TABLE [dbo].[PersonSet_Patient] (
    [BirthDate] datetime  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Contactperson] nvarchar(max)  NOT NULL,
    [ContactpersonPhone] nvarchar(max)  NOT NULL,
    [HealthInsurance] nvarchar(max)  NOT NULL,
    [Height] int  NOT NULL,
    [Weight] float  NOT NULL,
    [DegreeOfCare] int  NOT NULL,
    [PowerOfAttorney] nvarchar(max)  NOT NULL,
    [PersonID] int  NOT NULL,
    [Bio_BioID] int  NOT NULL,
    [Home_HomeID] int  NOT NULL,
    [HealthData_HealthDataID] int  NOT NULL
);
GO

-- Creating table 'PersonSet_Worker'
CREATE TABLE [dbo].[PersonSet_Worker] (
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [PersonID] int  NOT NULL
);
GO

-- Creating table 'PersonSet_Caregiver'
CREATE TABLE [dbo].[PersonSet_Caregiver] (
    [IsSpecialist] bit  NOT NULL,
    [PersonID] int  NOT NULL
);
GO

-- Creating table 'PersonSet_Doctor'
CREATE TABLE [dbo].[PersonSet_Doctor] (
    [MedicalSpecialty] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [PersonID] int  NOT NULL
);
GO

-- Creating table 'PatientCaregiver'
CREATE TABLE [dbo].[PatientCaregiver] (
    [Patient_PersonID] int  NOT NULL,
    [Caregiver_PersonID] int  NOT NULL
);
GO

-- Creating table 'PatientDoctor'
CREATE TABLE [dbo].[PatientDoctor] (
    [Patient_PersonID] int  NOT NULL,
    [Doctor_PersonID] int  NOT NULL
);
GO

-- Creating table 'PatientCareReport'
CREATE TABLE [dbo].[PatientCareReport] (
    [Patient_PersonID] int  NOT NULL,
    [CareReport_CareReportID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PersonID] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [PK_PersonSet]
    PRIMARY KEY CLUSTERED ([PersonID] ASC);
GO

-- Creating primary key on [BioID] in table 'BioSet'
ALTER TABLE [dbo].[BioSet]
ADD CONSTRAINT [PK_BioSet]
    PRIMARY KEY CLUSTERED ([BioID] ASC);
GO

-- Creating primary key on [HomeID] in table 'HomeSet'
ALTER TABLE [dbo].[HomeSet]
ADD CONSTRAINT [PK_HomeSet]
    PRIMARY KEY CLUSTERED ([HomeID] ASC);
GO

-- Creating primary key on [CaringRelativesID] in table 'CaringRelativesSet'
ALTER TABLE [dbo].[CaringRelativesSet]
ADD CONSTRAINT [PK_CaringRelativesSet]
    PRIMARY KEY CLUSTERED ([CaringRelativesID] ASC);
GO

-- Creating primary key on [HealthDataID] in table 'HealthDataSet'
ALTER TABLE [dbo].[HealthDataSet]
ADD CONSTRAINT [PK_HealthDataSet]
    PRIMARY KEY CLUSTERED ([HealthDataID] ASC);
GO

-- Creating primary key on [HospitaliationsID] in table 'HospitaliationsSet'
ALTER TABLE [dbo].[HospitaliationsSet]
ADD CONSTRAINT [PK_HospitaliationsSet]
    PRIMARY KEY CLUSTERED ([HospitaliationsID] ASC);
GO

-- Creating primary key on [VitalParametersID] in table 'VitalParametersSet'
ALTER TABLE [dbo].[VitalParametersSet]
ADD CONSTRAINT [PK_VitalParametersSet]
    PRIMARY KEY CLUSTERED ([VitalParametersID] ASC);
GO

-- Creating primary key on [RiskValuesID] in table 'RiskValuesSet'
ALTER TABLE [dbo].[RiskValuesSet]
ADD CONSTRAINT [PK_RiskValuesSet]
    PRIMARY KEY CLUSTERED ([RiskValuesID] ASC);
GO

-- Creating primary key on [MedicationID] in table 'MedicationSet'
ALTER TABLE [dbo].[MedicationSet]
ADD CONSTRAINT [PK_MedicationSet]
    PRIMARY KEY CLUSTERED ([MedicationID] ASC);
GO

-- Creating primary key on [CareReportID] in table 'CareReportSet'
ALTER TABLE [dbo].[CareReportSet]
ADD CONSTRAINT [PK_CareReportSet]
    PRIMARY KEY CLUSTERED ([CareReportID] ASC);
GO

-- Creating primary key on [ActionPlanID] in table 'ActionPlanSet'
ALTER TABLE [dbo].[ActionPlanSet]
ADD CONSTRAINT [PK_ActionPlanSet]
    PRIMARY KEY CLUSTERED ([ActionPlanID] ASC);
GO

-- Creating primary key on [PersonID] in table 'PersonSet_Patient'
ALTER TABLE [dbo].[PersonSet_Patient]
ADD CONSTRAINT [PK_PersonSet_Patient]
    PRIMARY KEY CLUSTERED ([PersonID] ASC);
GO

-- Creating primary key on [PersonID] in table 'PersonSet_Worker'
ALTER TABLE [dbo].[PersonSet_Worker]
ADD CONSTRAINT [PK_PersonSet_Worker]
    PRIMARY KEY CLUSTERED ([PersonID] ASC);
GO

-- Creating primary key on [PersonID] in table 'PersonSet_Caregiver'
ALTER TABLE [dbo].[PersonSet_Caregiver]
ADD CONSTRAINT [PK_PersonSet_Caregiver]
    PRIMARY KEY CLUSTERED ([PersonID] ASC);
GO

-- Creating primary key on [PersonID] in table 'PersonSet_Doctor'
ALTER TABLE [dbo].[PersonSet_Doctor]
ADD CONSTRAINT [PK_PersonSet_Doctor]
    PRIMARY KEY CLUSTERED ([PersonID] ASC);
GO

-- Creating primary key on [Patient_PersonID], [Caregiver_PersonID] in table 'PatientCaregiver'
ALTER TABLE [dbo].[PatientCaregiver]
ADD CONSTRAINT [PK_PatientCaregiver]
    PRIMARY KEY CLUSTERED ([Patient_PersonID], [Caregiver_PersonID] ASC);
GO

-- Creating primary key on [Patient_PersonID], [Doctor_PersonID] in table 'PatientDoctor'
ALTER TABLE [dbo].[PatientDoctor]
ADD CONSTRAINT [PK_PatientDoctor]
    PRIMARY KEY CLUSTERED ([Patient_PersonID], [Doctor_PersonID] ASC);
GO

-- Creating primary key on [Patient_PersonID], [CareReport_CareReportID] in table 'PatientCareReport'
ALTER TABLE [dbo].[PatientCareReport]
ADD CONSTRAINT [PK_PatientCareReport]
    PRIMARY KEY CLUSTERED ([Patient_PersonID], [CareReport_CareReportID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Bio_BioID] in table 'PersonSet_Patient'
ALTER TABLE [dbo].[PersonSet_Patient]
ADD CONSTRAINT [FK_PatientBio]
    FOREIGN KEY ([Bio_BioID])
    REFERENCES [dbo].[BioSet]
        ([BioID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientBio'
CREATE INDEX [IX_FK_PatientBio]
ON [dbo].[PersonSet_Patient]
    ([Bio_BioID]);
GO

-- Creating foreign key on [Home_HomeID] in table 'PersonSet_Patient'
ALTER TABLE [dbo].[PersonSet_Patient]
ADD CONSTRAINT [FK_HomePatient]
    FOREIGN KEY ([Home_HomeID])
    REFERENCES [dbo].[HomeSet]
        ([HomeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HomePatient'
CREATE INDEX [IX_FK_HomePatient]
ON [dbo].[PersonSet_Patient]
    ([Home_HomeID]);
GO

-- Creating foreign key on [HealthData_HealthDataID] in table 'PersonSet_Patient'
ALTER TABLE [dbo].[PersonSet_Patient]
ADD CONSTRAINT [FK_PatientHealthData]
    FOREIGN KEY ([HealthData_HealthDataID])
    REFERENCES [dbo].[HealthDataSet]
        ([HealthDataID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientHealthData'
CREATE INDEX [IX_FK_PatientHealthData]
ON [dbo].[PersonSet_Patient]
    ([HealthData_HealthDataID]);
GO

-- Creating foreign key on [HealthDataHealthDataID] in table 'HospitaliationsSet'
ALTER TABLE [dbo].[HospitaliationsSet]
ADD CONSTRAINT [FK_HealthDataHospitaliations]
    FOREIGN KEY ([HealthDataHealthDataID])
    REFERENCES [dbo].[HealthDataSet]
        ([HealthDataID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HealthDataHospitaliations'
CREATE INDEX [IX_FK_HealthDataHospitaliations]
ON [dbo].[HospitaliationsSet]
    ([HealthDataHealthDataID]);
GO

-- Creating foreign key on [HealthDataHealthDataID] in table 'VitalParametersSet'
ALTER TABLE [dbo].[VitalParametersSet]
ADD CONSTRAINT [FK_HealthDataVitalParameters]
    FOREIGN KEY ([HealthDataHealthDataID])
    REFERENCES [dbo].[HealthDataSet]
        ([HealthDataID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HealthDataVitalParameters'
CREATE INDEX [IX_FK_HealthDataVitalParameters]
ON [dbo].[VitalParametersSet]
    ([HealthDataHealthDataID]);
GO

-- Creating foreign key on [HealthDataHealthDataID] in table 'RiskValuesSet'
ALTER TABLE [dbo].[RiskValuesSet]
ADD CONSTRAINT [FK_HealthDataRiskValues]
    FOREIGN KEY ([HealthDataHealthDataID])
    REFERENCES [dbo].[HealthDataSet]
        ([HealthDataID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HealthDataRiskValues'
CREATE INDEX [IX_FK_HealthDataRiskValues]
ON [dbo].[RiskValuesSet]
    ([HealthDataHealthDataID]);
GO

-- Creating foreign key on [HealthDataHealthDataID] in table 'MedicationSet'
ALTER TABLE [dbo].[MedicationSet]
ADD CONSTRAINT [FK_HealthDataMedication]
    FOREIGN KEY ([HealthDataHealthDataID])
    REFERENCES [dbo].[HealthDataSet]
        ([HealthDataID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HealthDataMedication'
CREATE INDEX [IX_FK_HealthDataMedication]
ON [dbo].[MedicationSet]
    ([HealthDataHealthDataID]);
GO

-- Creating foreign key on [Patient_PersonID] in table 'PatientCaregiver'
ALTER TABLE [dbo].[PatientCaregiver]
ADD CONSTRAINT [FK_PatientCaregiver_Patient]
    FOREIGN KEY ([Patient_PersonID])
    REFERENCES [dbo].[PersonSet_Patient]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Caregiver_PersonID] in table 'PatientCaregiver'
ALTER TABLE [dbo].[PatientCaregiver]
ADD CONSTRAINT [FK_PatientCaregiver_Caregiver]
    FOREIGN KEY ([Caregiver_PersonID])
    REFERENCES [dbo].[PersonSet_Caregiver]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientCaregiver_Caregiver'
CREATE INDEX [IX_FK_PatientCaregiver_Caregiver]
ON [dbo].[PatientCaregiver]
    ([Caregiver_PersonID]);
GO

-- Creating foreign key on [Patient_PersonID] in table 'PatientDoctor'
ALTER TABLE [dbo].[PatientDoctor]
ADD CONSTRAINT [FK_PatientDoctor_Patient]
    FOREIGN KEY ([Patient_PersonID])
    REFERENCES [dbo].[PersonSet_Patient]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Doctor_PersonID] in table 'PatientDoctor'
ALTER TABLE [dbo].[PatientDoctor]
ADD CONSTRAINT [FK_PatientDoctor_Doctor]
    FOREIGN KEY ([Doctor_PersonID])
    REFERENCES [dbo].[PersonSet_Doctor]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientDoctor_Doctor'
CREATE INDEX [IX_FK_PatientDoctor_Doctor]
ON [dbo].[PatientDoctor]
    ([Doctor_PersonID]);
GO

-- Creating foreign key on [Patient_PersonID] in table 'PatientCareReport'
ALTER TABLE [dbo].[PatientCareReport]
ADD CONSTRAINT [FK_PatientCareReport_Patient]
    FOREIGN KEY ([Patient_PersonID])
    REFERENCES [dbo].[PersonSet_Patient]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CareReport_CareReportID] in table 'PatientCareReport'
ALTER TABLE [dbo].[PatientCareReport]
ADD CONSTRAINT [FK_PatientCareReport_CareReport]
    FOREIGN KEY ([CareReport_CareReportID])
    REFERENCES [dbo].[CareReportSet]
        ([CareReportID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientCareReport_CareReport'
CREATE INDEX [IX_FK_PatientCareReport_CareReport]
ON [dbo].[PatientCareReport]
    ([CareReport_CareReportID]);
GO

-- Creating foreign key on [PatientPersonID] in table 'ActionPlanSet'
ALTER TABLE [dbo].[ActionPlanSet]
ADD CONSTRAINT [FK_PatientActionPlan]
    FOREIGN KEY ([PatientPersonID])
    REFERENCES [dbo].[PersonSet_Patient]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientActionPlan'
CREATE INDEX [IX_FK_PatientActionPlan]
ON [dbo].[ActionPlanSet]
    ([PatientPersonID]);
GO

-- Creating foreign key on [CaregiverPersonID] in table 'ActionPlanSet'
ALTER TABLE [dbo].[ActionPlanSet]
ADD CONSTRAINT [FK_CaregiverActionPlan]
    FOREIGN KEY ([CaregiverPersonID])
    REFERENCES [dbo].[PersonSet_Caregiver]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CaregiverActionPlan'
CREATE INDEX [IX_FK_CaregiverActionPlan]
ON [dbo].[ActionPlanSet]
    ([CaregiverPersonID]);
GO

-- Creating foreign key on [CaregiverPersonID] in table 'CareReportSet'
ALTER TABLE [dbo].[CareReportSet]
ADD CONSTRAINT [FK_CaregiverCareReport]
    FOREIGN KEY ([CaregiverPersonID])
    REFERENCES [dbo].[PersonSet_Caregiver]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CaregiverCareReport'
CREATE INDEX [IX_FK_CaregiverCareReport]
ON [dbo].[CareReportSet]
    ([CaregiverPersonID]);
GO

-- Creating foreign key on [PatientPersonID] in table 'CaringRelativesSet'
ALTER TABLE [dbo].[CaringRelativesSet]
ADD CONSTRAINT [FK_PatientCaringRelatives]
    FOREIGN KEY ([PatientPersonID])
    REFERENCES [dbo].[PersonSet_Patient]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientCaringRelatives'
CREATE INDEX [IX_FK_PatientCaringRelatives]
ON [dbo].[CaringRelativesSet]
    ([PatientPersonID]);
GO

-- Creating foreign key on [PersonID] in table 'PersonSet_Patient'
ALTER TABLE [dbo].[PersonSet_Patient]
ADD CONSTRAINT [FK_Patient_inherits_Person]
    FOREIGN KEY ([PersonID])
    REFERENCES [dbo].[PersonSet]
        ([PersonID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PersonID] in table 'PersonSet_Worker'
ALTER TABLE [dbo].[PersonSet_Worker]
ADD CONSTRAINT [FK_Worker_inherits_Person]
    FOREIGN KEY ([PersonID])
    REFERENCES [dbo].[PersonSet]
        ([PersonID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PersonID] in table 'PersonSet_Caregiver'
ALTER TABLE [dbo].[PersonSet_Caregiver]
ADD CONSTRAINT [FK_Caregiver_inherits_Worker]
    FOREIGN KEY ([PersonID])
    REFERENCES [dbo].[PersonSet_Worker]
        ([PersonID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PersonID] in table 'PersonSet_Doctor'
ALTER TABLE [dbo].[PersonSet_Doctor]
ADD CONSTRAINT [FK_Doctor_inherits_Worker]
    FOREIGN KEY ([PersonID])
    REFERENCES [dbo].[PersonSet_Worker]
        ([PersonID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------