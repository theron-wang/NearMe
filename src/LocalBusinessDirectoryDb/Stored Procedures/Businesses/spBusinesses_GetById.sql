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
    ), 
    PricingPlansAggregated as (
        select 
            u.BusinessId,
            CAST(CASE WHEN u.PricingPlan = 2 THEN 1 ELSE 0 END AS BIT) as IsPartnered
        from [dbo].[Users] as u
        where u.BusinessId is not null
        group by u.BusinessId, u.PricingPlan
    )

    select
        u.IsPartnered,
        r.Rating,
        r.NumberOfRatings,
        c.Name as CategoryName,
        b.*
    from [dbo].[Businesses] as b
    inner join [dbo].[Categories] as c on c.Id = b.CategoryId
    left join PricingPlansAggregated as u on u.BusinessId=b.Id
    left join RatingsAggregated as r on r.RelatedTo = b.Id
    where b.Id = @Id;
RETURN 0
