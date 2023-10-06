CREATE PROCEDURE [dbo].[spUsers_Create]
    @Name NVARCHAR(MAX),
    @Email NVARCHAR(MAX),
    @PasswordHash CHAR(60),
    @BusinessId VARCHAR(36)
AS
BEGIN
    INSERT INTO [dbo].[Users] ([Name], [Email], [PasswordHash], [BusinessId])
    VALUES (@Name, @Email, @PasswordHash, @BusinessId);
END;
