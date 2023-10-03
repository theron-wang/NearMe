CREATE PROCEDURE [dbo].[spUsers_FindByName]
    @Name NVARCHAR(MAX)
AS
BEGIN
    SELECT * FROM [dbo].[Users]
    WHERE [Name] = @Name;
END;
