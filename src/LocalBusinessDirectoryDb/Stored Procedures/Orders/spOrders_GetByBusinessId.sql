CREATE PROCEDURE [dbo].[spOrders_GetByBusinessId]
    
	@BusinessId VARCHAR(36)

AS
Begin
    Select
    ord.*,
    b.Name as BusinessName,
    ofe.*,
    u.*
    From [dbo].[Orders] ord
    inner join [dbo].[Offers] ofe
	on ord.OfferId = ofe.Id
    inner join [dbo].[Businesses] b
    on ofe.BusinessId = b.Id
    inner join [dbo].[Users] u
    on ord.UserId = u.Id
   
    where ofe.BusinessId = @BusinessId
    order by ord.Status, ord.OfferId, ord.Id desc;
END;