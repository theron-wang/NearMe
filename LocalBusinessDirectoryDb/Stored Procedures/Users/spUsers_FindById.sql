CREATE PROCEDURE [dbo].[spUsers_FindById]
    @Id INT
AS
BEGIN
    SELECT * FROM [dbo].[Users]
    WHERE [Id] = @Id;
END
