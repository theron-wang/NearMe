CREATE PROCEDURE [dbo].[spRatings_Rate]
	@RelatedTo VARCHAR(36),
    @Username VARCHAR(max), 
    @Rating INT
AS
	declare @UserId int = (select Id from [dbo].[Users] where Name=@Username);

	IF NOT EXISTS (SELECT * FROM [dbo].[Ratings] WHERE RelatedTo = @RelatedTo)
       INSERT INTO [dbo].[Ratings] ([RelatedTo], [UserId], [Rating])
       VALUES (@RelatedTo, @UserId, @Rating)
    ELSE
       UPDATE [dbo].[Ratings] set
           Rating = @Rating
       WHERE RelatedTo=@RelatedTo and UserId=@UserId
RETURN 0
