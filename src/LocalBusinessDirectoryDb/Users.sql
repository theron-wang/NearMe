CREATE TABLE [dbo].[Users]
(
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(MAX) NOT NULL,
    [Email] VARCHAR(MAX) NOT NULL,
    [PasswordHash] CHAR(60) NOT NULL,
    [BusinessId] varchar(36)
);
