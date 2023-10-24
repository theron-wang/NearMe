CREATE PROCEDURE [dbo].[spOrders_GetByBusinessId]
    
	@BusinessId VARCHAR(36)

AS
Begin
   Select
   o.[Id] as OrderId,
   o.OffersId,
   o.Quantity,
   u.Name as UserName,
   b.Name as BusinessName,
   c.Name  as CategoriesName,
   o.PriceWhenBought,
   o.IsDiscounted
   From [dbo].[Orders] o
   Left Join [dbo].[Users] u
   on o.UserId = u.Id
   Left Join [dbo].[Businesses] b
   on o.BusinessesId = b.Id
   Left Join [dbo].[Categories] c
   on o.CategoriesId = c.Id
   
    where o.BusinessesId = @BusinessId;
END;