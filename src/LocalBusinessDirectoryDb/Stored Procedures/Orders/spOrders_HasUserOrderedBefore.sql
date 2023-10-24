CREATE PROCEDURE [dbo].[spOrders_HasUserOrderedBefore]
	@Username nvarchar(max),
	@OfferId varchar(36)
AS
    declare @UserId int = (select Id from [dbo].[Users] where Name=@Username);

	SELECT CASE WHEN EXISTS
    (
        SELECT * FROM [dbo].[Orders] WHERE OfferId=@OfferId and UserId=@UserId
    )
    THEN 1 ELSE 0
END;
