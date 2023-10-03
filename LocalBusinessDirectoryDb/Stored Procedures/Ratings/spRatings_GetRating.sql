CREATE PROCEDURE [dbo].[spRatings_GetRating]
	@RelatedTo VARCHAR(36), 
    @UserId INT
AS
	select Rating from [dbo].[Ratings]
	where
	UserId=@UserId and
	RelatedTo=@RelatedTo;
RETURN 0
