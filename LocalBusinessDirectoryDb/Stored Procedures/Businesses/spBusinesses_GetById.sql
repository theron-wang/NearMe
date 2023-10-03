CREATE PROCEDURE [dbo].[spBusinesses_GetById]
	@Id varchar(max)
AS
	select
		AVG(CAST(r.Rating AS DECIMAL(3, 1))) AS Rating,
		SUM(1) AS NumberOfRatings,
		c.Name as CategoryName,
		b.*
	from [dbo].[Businesses] as b
	inner join [dbo].[Ratings] as r on r.RelatedTo=b.Id
	inner join [dbo].[Categories] as c on c.Id=b.CategoryId
	where b.Id=@Id;
RETURN 0
