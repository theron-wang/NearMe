CREATE PROCEDURE [dbo].[spOrders_GetByUser]
    @Username nvarchar(max)
AS
BEGIN
 
 declare @UserId int = (select Id from [dbo].[Users] where Name=@Username);
     
Select 
	ord.*,
	ofe.*
From Orders ord
	Left Join [dbo].[Offers] ofe
		on ord.OfferId = ofe.Id
where ord.UserId = @UserId;
END;
