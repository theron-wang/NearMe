CREATE PROCEDURE [dbo].[spBusinesses_Create]
	@Id VARCHAR(36),
	@Name NVARCHAR(MAX),
	@Description NVARCHAR(MAX),
	@ImageUrl VARCHAR(MAX),
	@CategoryId int,
	@IsPartnered bit,
	@AddressNumber int,
    @AddressStreet VARCHAR(MAX),
    @AddressSuite VARCHAR(MAX),
    @AddressCity VARCHAR(MAX),
    @AddressState VARCHAR(MAX),
    @AddressZipCode VARCHAR(MAX)
AS
	INSERT INTO [dbo].[Businesses]
	([Id], [Name], [Description], [ImageUrl], [CategoryId], [IsPartnered], [AddressNumber], [AddressStreet], [AddressSuite], [AddressCity], [AddressState], [AddressZipCode])
	VALUES
	(@Id, @Name, @Description, @ImageUrl, @CategoryId, @IsPartnered, @AddressNumber, @AddressStreet, @AddressSuite, @AddressCity, @AddressState, @AddressZipCode);
RETURN 0
