﻿CREATE PROCEDURE [dbo].[spOffers_Update]
    @Id VARCHAR(36),
    @BusinessId VARCHAR(36),
    @Name VARCHAR(MAX),
    @Description NVARCHAR(MAX),
    @Type INT,
    @Price DECIMAL(7, 2)
AS
BEGIN
    update [dbo].[Offers]
    set
        [Name] = @Name,
        [Description] = @Description,
        [Type] = @Type,
        [Price] = @Price
    where
        [Id] = @Id and [BusinessId] = @BusinessId;
END;
