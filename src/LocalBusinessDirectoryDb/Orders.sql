CREATE TABLE [dbo].[Orders](
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
	[OffersId] [varchar](36) NULL,
	[Quantity] [int] NULL,
	[UserId] [int] NULL,
	[BusinessesId] [varchar](36) NULL,
	[CategoriesId] [int] NULL,
	[PriceWhenBought] decimal(7,2),
	[IsDiscounted] bit
)

