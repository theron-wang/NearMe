CREATE PROCEDURE [dbo].[spRatings_GetRating]
	@RelatedTo VARCHAR(36), 
    @Username VARCHAR(max)
AS
	declare @UserId int = (select Id from [dbo].[Users] where Name=@Username);

	select Rating from [dbo].[Ratings]
	where UserId=@UserId and RelatedTo=@RelatedTo;
RETURN 0
