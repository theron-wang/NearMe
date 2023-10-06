CREATE PROCEDURE [dbo].[spBusinesses_GetById]
	@Id varchar(max)
as
    with RatingsAggregated as (
        select
            r.RelatedTo,
            AVG(CAST(r.Rating as decimal(3, 1))) as Rating,
            COUNT(*) as NumberOfRatings
        from [dbo].[Ratings] as r
        group by r.RelatedTo
    )

    select
        b.*,
        c.Name as CategoryName,
        r.Rating,
        r.NumberOfRatings
    from [dbo].[Businesses] as b
    inner join [dbo].[Categories] as c on c.Id = b.CategoryId
    inner join RatingsAggregated as r on r.RelatedTo = b.Id
    where b.Id = @Id;
RETURN 0
