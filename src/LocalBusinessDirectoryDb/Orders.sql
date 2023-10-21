CREATE TABLE [dbo].[Orders](
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
	[UserId] [int] NOT NULL,
	[OfferId] [varchar](36) NOT NULL,
	[PriceWhenBought] decimal(7,2) NOT NULL,
	[IsDiscounted] bit NOT NULL,
	[Status] int NOT NULL
)

