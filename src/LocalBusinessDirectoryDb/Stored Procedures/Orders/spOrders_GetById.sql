CREATE PROCEDURE [dbo].[spOrders_GetById]
    @OrderId varchar(36)
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
where ord.Id = @OrderId;
END;
