CREATE PROCEDURE [dbo].[spRatings_RemoveRating]
	@RelatedTo VARCHAR(36)
AS
	delete from [dbo].[Ratings]
	where RelatedTo=@RelatedTo;
RETURN 0
