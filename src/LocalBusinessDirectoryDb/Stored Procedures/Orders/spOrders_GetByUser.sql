CREATE PROCEDURE [dbo].[spOrders_GetByUser]
    @UserId int
AS
BEGIN
 
     
Select 
	ord.*,
	ofe.*
From Orders ord
	Left Join [dbo].[Offers] ofe
		on ord.OfferId = ofe.Id
where ord.UserId = @UserId;
END;
