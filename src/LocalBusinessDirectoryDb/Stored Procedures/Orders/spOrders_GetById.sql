CREATE PROCEDURE [dbo].[spOrders_GetById]
    @OrderId int
AS
BEGIN
 
     
Select 
	ord.*,
	b.Name as BusinessName,
	ofe.*
From Orders ord
	inner Join [dbo].[Offers] ofe
		on ord.OfferId = ofe.Id
	inner join [dbo].[Businesses] b
		on b.Id=ofe.BusinessId
where ord.Id = @OrderId;
END;
