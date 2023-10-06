CREATE TABLE [dbo].[Offers]
(
	[Id] varchar(36) NOT NULL PRIMARY KEY,
    [BusinessId] varchar(36) not null,
    [Name] VARCHAR(MAX) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [ImageUrl] VARCHAR(MAX) NOT NULL, 
    [Type] INT NOT NULL, 
    [Price] DECIMAL(7, 2) NOT NULL,
)
