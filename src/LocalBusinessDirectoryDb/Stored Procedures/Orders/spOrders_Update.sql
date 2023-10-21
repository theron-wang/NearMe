CREATE PROCEDURE [dbo].[spOrders_Update]
    @Id VARCHAR(36),
    @OffersId VARCHAR(36),
	@Quantity INT,
	@UserId INT,
	@BusinessesId VARCHAR(36),
	@CategoriesId INT,
	@PriceWhenBought decimal(7,2),
	@IsDiscounted bit
AS
BEGIN
    update [dbo].[Orders]
    set
        [OffersId] = @OffersId,
		[Quantity] = @Quantity,
		[CategoriesId] = @CategoriesId,
		[PriceWhenBought] = @PriceWhenBought,
		[IsDiscounted]=@IsDiscounted
    where
        [Id] = @Id and [UserId] = @UserId;
END;
