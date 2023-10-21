CREATE PROCEDURE [dbo].[spOrders_Create]
	
	@Id	varchar(36),
	@OffersId	varchar(36),
	@Quantity	int,
	@UserId	int,
	@BusinessesId	varchar(36),
	@CategoriesId	int,
	@PriceWhenBought decimal(7,2),
	@IsDiscounted bit
AS
BEGIN
INSERT INTO [dbo].[Orders]
           ([Id]
           ,[OffersId]
           ,[Quantity]
           ,[UserId]
           ,[BusinessesId]
           ,[CategoriesId]
		   ,[PriceWhenBought]
		   ,[IsDiscounted])
VALUES 	(
			@Id	,
			@OffersId,
			@Quantity,
			@UserId	,
			@BusinessesId,
			@CategoriesId,
			@PriceWhenBought,
			@IsDiscounted
	);
END
