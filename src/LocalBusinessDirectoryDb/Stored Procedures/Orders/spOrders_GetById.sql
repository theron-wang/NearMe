CREATE PROCEDURE [dbo].[spOrders_GetById]
    @OrderId varchar(36)
AS
BEGIN
 
     
Select 
	ord.*,
	ofe.*
From Orders ord
	Left Join [dbo].[Offers] ofe
		on ord.OfferId = ofe.Id
where ord.Id = @OrderId;
END;
