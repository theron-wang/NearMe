CREATE PROCEDURE [dbo].[spOrders_Update]
    @Id int,
    @OfferId varchar(36),
	@UserId	int,
	@PriceWhenBought decimal(7,2),
	@IsDiscounted bit
AS
BEGIN
    update [dbo].[Orders]
    set
        [OfferId] = @OfferId,
		[PriceWhenBought] = @PriceWhenBought,
		[IsDiscounted]=@IsDiscounted
    where
        [Id] = @Id and [UserId] = @UserId;
END;
