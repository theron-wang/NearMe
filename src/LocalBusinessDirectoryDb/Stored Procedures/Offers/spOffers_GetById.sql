CREATE PROCEDURE [dbo].[spOffers_GetById]
    @Id VARCHAR(36)
AS
BEGIN
    with RatingsAggregated as (
        select
            r.RelatedTo,
            AVG(CAST(r.Rating as decimal(3, 1))) as Rating,
            COUNT(*) as NumberOfRatings
        from [dbo].[Ratings] as r
        group by r.RelatedTo
    )

    select o.*, r.Rating, r.NumberOfRatings
    from [dbo].[Offers] as o
	inner join RatingsAggregated as r on r.RelatedTo=o.Id
    where o.Id = @Id;
END;
