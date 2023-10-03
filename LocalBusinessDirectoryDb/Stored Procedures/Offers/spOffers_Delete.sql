CREATE PROCEDURE [dbo].[spOffers_Delete]
    @Id VARCHAR(36)
AS
BEGIN
    delete from [dbo].[Offers]
    where [Id] = @Id;
END;
