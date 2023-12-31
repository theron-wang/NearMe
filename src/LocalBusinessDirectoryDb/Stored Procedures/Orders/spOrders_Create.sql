CREATE PROCEDURE [dbo].[spOrders_Create]
	@OfferId	varchar(36),
	@UserId	int,
	@PriceWhenBought decimal(7,2),
	@IsDiscounted bit
AS
BEGIN
INSERT INTO [dbo].[Orders]
           ([OfferId],
           [UserId],
		   [PriceWhenBought],
		   [IsDiscounted])
VALUES 	(
			@OfferId,
			@UserId,
			@PriceWhenBought,
			@IsDiscounted
	);
END
