CREATE PROCEDURE [dbo].[spOrders_Delete]
    @Id VARCHAR(36)
AS
BEGIN
    delete from [dbo].[Orders]
    where [Id] = @Id;
END;
