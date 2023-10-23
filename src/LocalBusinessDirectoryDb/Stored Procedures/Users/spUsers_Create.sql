CREATE PROCEDURE [dbo].[spUsers_Create]
    @Name NVARCHAR(MAX),
    @Email NVARCHAR(MAX),
    @PasswordHash CHAR(60),
    @PricingPlan INT,
    @BusinessId VARCHAR(36)
AS
BEGIN
    INSERT INTO [dbo].[Users] ([Name], [Email], [PasswordHash], [PricingPlan], [BusinessId])
    VALUES (@Name, @Email, @PasswordHash, @PricingPlan, @BusinessId);

    select SCOPE_IDENTITY();
END;
