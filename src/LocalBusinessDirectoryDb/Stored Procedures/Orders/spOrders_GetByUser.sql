CREATE PROCEDURE [dbo].[spOrders_GetByUser]
    @Username nvarchar(max)
AS
BEGIN
 
 declare @UserId int = (select Id from [dbo].[Users] where Name=@Username);
     
Select 
	ord.*,
	b.Name as BusinessName,
	ofe.*
From Orders ord
	inner Join [dbo].[Offers] ofe
		on ord.OfferId = ofe.Id
	inner join [dbo].[Businesses] b
		on b.Id=ofe.BusinessId
where ord.UserId = @UserId
order by ord.Id desc;
END;
