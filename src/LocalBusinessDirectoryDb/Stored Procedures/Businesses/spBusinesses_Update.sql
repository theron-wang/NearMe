CREATE PROCEDURE [dbo].[spBusinesses_Update]
	@Id VARCHAR(36),
	@Name NVARCHAR(MAX),
	@Description NVARCHAR(MAX),
	@ImageUrl VARCHAR(MAX),
	@CategoryName VARCHAR(MAX),
	@IsPartnered bit,
	@AddressNumber int,
    @AddressStreet VARCHAR(MAX),
    @AddressSuite VARCHAR(MAX),
    @AddressCity VARCHAR(MAX),
    @AddressState VARCHAR(MAX),
    @AddressZipCode VARCHAR(MAX)
AS
	declare @CategoryId int = (select Id from [dbo].[Categories] where Name=@CategoryName);

	UPDATE [dbo].[Businesses]
    SET
        [Name] = @Name,
        [Description] = @Description,
        [ImageUrl] = @ImageUrl,
        [CategoryId] = @CategoryId,
        [IsPartnered] = @IsPartnered,
        [AddressNumber] = @AddressNumber,
        [AddressStreet] = @AddressStreet,
        [AddressSuite] = @AddressSuite,
        [AddressCity] = @AddressCity,
        [AddressState] = @AddressState,
        [AddressZipCode] = @AddressZipCode
    WHERE
        [Id] = @Id;
RETURN 0
