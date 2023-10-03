CREATE PROCEDURE [dbo].[spOffers_GetById]
    @Id VARCHAR(36)
AS
BEGIN
    select o.*,
        AVG(CAST(r.Rating AS DECIMAL(3, 1))) AS Rating,
		SUM(1) AS NumberOfRatings
    from [dbo].[Offers] as o
	inner join [dbo].[Ratings] as r on r.RelatedTo=o.Id
    where
        o.Id = @Id;
END;
