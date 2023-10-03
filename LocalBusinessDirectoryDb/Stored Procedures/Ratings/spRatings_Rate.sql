CREATE PROCEDURE [dbo].[spRatings_Rate]
	@RelatedTo VARCHAR(36), 
    @UserId INT, 
    @Rating INT
AS
	IF NOT EXISTS (SELECT * FROM [dbo].[Ratings] WHERE RelatedTo = @RelatedTo)
       INSERT INTO [dbo].[Ratings] ([RelatedTo], [UserId], [Rating])
       VALUES (@RelatedTo, @UserId, @Rating)
    ELSE
       UPDATE [dbo].[Ratings] set
           UserId = @UserId,
           Rating = @Rating
       WHERE RelatedTo = @RelatedTo
RETURN 0
