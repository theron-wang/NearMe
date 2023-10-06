CREATE TABLE [dbo].[Businesses]
(
	[Id] VARCHAR(36) NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(MAX) NOT NULL,
    [Description] NVARCHAR(MAX) NOT NULL,
    [ImageUrl] VARCHAR(MAX) NOT NULL,
    [CategoryId] int NOT NULL,
    [IsPartnered] bit NOT NULL,
    [AddressNumber] int NOT NULL,
    [AddressStreet] VARCHAR(MAX) NOT NULL,
    [AddressSuite] VARCHAR(MAX),
    [AddressCity] VARCHAR(MAX) NOT NULL,
    [AddressState] VARCHAR(MAX) NOT NULL,
    [AddressZipCode] VARCHAR(MAX) NOT NULL,

)
