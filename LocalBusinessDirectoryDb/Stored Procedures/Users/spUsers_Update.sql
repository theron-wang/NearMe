CREATE PROCEDURE [dbo].[spUsers_Update]
    @Id INT,
    @Name NVARCHAR(MAX),
    @Email NVARCHAR(MAX),
    @PasswordHash CHAR(60),
    @BusinessId VARCHAR(36)
AS
BEGIN
    UPDATE [dbo].[Users]
    SET
        [Name] = @Name,
        [Email] = @Email,
        [PasswordHash] = @PasswordHash,
        [BusinessId] = @BusinessId
    WHERE
        [Id] = @Id;
END;
