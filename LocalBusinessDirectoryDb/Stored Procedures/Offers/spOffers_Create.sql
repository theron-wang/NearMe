CREATE PROCEDURE [dbo].[spOffers_Create]
    @Id VARCHAR(36),
    @BusinessId VARCHAR(36),
    @Name VARCHAR(MAX),
    @Description NVARCHAR(MAX),
    @ImageUrl VARCHAR(MAX),
    @Type INT,
    @Price DECIMAL(7, 2)
AS
BEGIN
    INSERT INTO [dbo].[Offers] ([Id], [BusinessId], [Name], [Description], [ImageUrl], [Type], [Price])
    VALUES (@Id, @BusinessId, @Name, @Description, @ImageUrl, @Type, @Price);
END
