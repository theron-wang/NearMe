CREATE PROCEDURE [dbo].[spOrders_GetByUser]
    @UserId int
AS
BEGIN
 
     
Select 
	ord.Id,
	ord.UserId, 
	ord.[Quantity], 
	ord.PriceWhenBought,
	ord.IsDiscounted,
	ofe.Name,
	ofe.Description, 
	ofe.ImageUrl, 
	ofe.Type, 
	Ofe.Price
From Orders ord
	Left Join [dbo].[Offers] ofe
		on ord.OffersId = ofe.Id
where ord.UserId = @UserId;
END;
