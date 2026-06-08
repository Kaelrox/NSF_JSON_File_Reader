-- Lookup Tables

CREATE TABLE Institution (
    InstitutionId INT AUTO_INCREMENT PRIMARY KEY,
    InstitutionName VARCHAR(255),
    StreetAddress VARCHAR(255),
    StreetAddress2 VARCHAR(255),
    CityName VARCHAR(100),
    StateCode VARCHAR(10),
    StateName VARCHAR(100),
    PhoneNum VARCHAR(50),
    ZipCode VARCHAR(20),
    CountryName VARCHAR(100),
    CongressionalDistrictCode VARCHAR(20),
    StateCongressionalDistCode VARCHAR(20),
    PerformanceCountryName VARCHAR(100),
    PerformanceCountryFlag VARCHAR(10),
    UeiNumber VARCHAR(100) UNIQUE,
    ParentUeiNumber VARCHAR(100) 
);

CREATE TABLE Person (
    PersonId INT AUTO_INCREMENT PRIMARY KEY,
    Role VARCHAR(50),
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    MidInit VARCHAR(10),
    SufxName VARCHAR(10),
    FullName VARCHAR(200),
    EmailAddress VARCHAR(200),
    PhoneNumber VARCHAR(50),
    NsfId VARCHAR(50),
    StartDate DATE,
    EndDate DATE
);

CREATE TABLE ProgramElement (
    ProgramElementId INT AUTO_INCREMENT PRIMARY KEY,
    ProgramElementCode VARCHAR(50),
    ProgramElementName VARCHAR(255)
);

CREATE TABLE ProgramReference (
    ProgramReferenceId INT AUTO_INCREMENT PRIMARY KEY,
    ProgramReferenceCode VARCHAR(50),
    ProgramReferenceName VARCHAR(255)
);

CREATE TABLE PrimaryProgramFundingSource (
    FundingSourceId INT AUTO_INCREMENT PRIMARY KEY,
    ApplicationCode VARCHAR(50),
    ApplicationName VARCHAR(255),
    ApplicationSymbId VARCHAR(50),
    FundingCode VARCHAR(50),
    FundingName VARCHAR(255),
    FundingSymbId VARCHAR(50)
);

-- Main Table

CREATE TABLE Award (
    AwardId INT AUTO_INCREMENT PRIMARY KEY,
    NSFAwdId VARCHAR(50) UNIQUE,
    AgencyId VARCHAR(50),
    TranType VARCHAR(50),
    OrgCode VARCHAR(50),
    CfdaNumber VARCHAR(1000),
    Title TEXT,
    AwardInstrumentText TEXT,
    IntendedAmount DECIMAL(18,2),
    AwardAmount DECIMAL(18,2),
    StartDate DATE,
    EndDate DATE,
    AbstractNarration TEXT,
    DirectorateAbbreviation VARCHAR(50),
    OrgDirectorateLongName VARCHAR(255),
    DivisionAbbreviation VARCHAR(50),
    OrgDivisionLongName VARCHAR(255),
    AwdAgcyCode VARCHAR(50),
    FundAgcyCode VARCHAR(50),
    ProjectOutcomesReport TEXT,
    ProgramManagerId INT,
    InstitutionId INT,
    PerfInstitutionId INT,
    AwardeeName VARCHAR(255),
    AwardeeStateCode VARCHAR(50),
    FOREIGN KEY (ProgramManagerId) REFERENCES Person(PersonId),
    FOREIGN KEY (InstitutionId) REFERENCES Institution(InstitutionId),
    FOREIGN KEY (PerfInstitutionId) REFERENCES Institution(InstitutionId)
);

-- Join Tables

CREATE TABLE Award_ProgramElement (
    AwardId INT NOT NULL,
    ProgramElementId INT NOT NULL,
    PRIMARY KEY (AwardId, ProgramElementId),
    FOREIGN KEY (AwardId) REFERENCES Award(AwardId),
    FOREIGN KEY (ProgramElementId) REFERENCES ProgramElement(ProgramElementId)
);

CREATE TABLE Award_ProgramReference (
    AwardId INT NOT NULL,
    ProgramReferenceId INT NOT NULL,
    PRIMARY KEY (AwardId, ProgramReferenceId),
    FOREIGN KEY (AwardId) REFERENCES Award(AwardId) ON DELETE CASCADE,
    FOREIGN KEY (ProgramReferenceId) REFERENCES ProgramReference(ProgramReferenceId) ON DELETE CASCADE
);

CREATE TABLE Award_FundingSource (
    AwardId INT NOT NULL,
    FundingSourceId INT NOT NULL,
    PRIMARY KEY (AwardId, FundingSourceId),
    FOREIGN KEY (AwardId) REFERENCES Award(AwardId) ON DELETE CASCADE ,
    FOREIGN KEY (FundingSourceId) REFERENCES PrimaryProgramFundingSource(FundingSourceId) ON DELETE CASCADE
);

CREATE TABLE Award_Person (
    AwardId INT NOT NULL,
    PersonId INT NOT NULL,
    PRIMARY KEY (AwardId, PersonId),
    FOREIGN KEY (AwardId) REFERENCES Award(AwardId) ON DELETE CASCADE,
    FOREIGN KEY (PersonId) REFERENCES Person(PersonId) ON DELETE CASCADE
);

CREATE TABLE Award_Institution (
    AwardId INT NOT NULL,
    InstitutionId INT NOT NULL,
    PRIMARY KEY (AwardId, InstitutionId),
    FOREIGN KEY (AwardId) REFERENCES award(AwardId) ON DELETE CASCADE,
    FOREIGN KEY (InstitutionId) REFERENCES institution(InstitutionId) ON DELETE CASCADE
);

CREATE TABLE FinancialObligationYear (
    ObligationId INT AUTO_INCREMENT PRIMARY KEY,
    AwardId INT,
    FiscalYear INT,
    ObligatedAmount DECIMAL(18,2),
    FOREIGN KEY (AwardId) REFERENCES Award(AwardId)
);