CREATE PROCEDURE [dbo].[spUsers_Update]
    @Id INT,
    @Name NVARCHAR(MAX),
    @Email NVARCHAR(MAX),
    @PasswordHash CHAR(60),
    @PricingPlan INT,
    @BusinessId VARCHAR(36)
AS
BEGIN
    UPDATE [dbo].[Users]
    SET
        [Name] = @Name,
        [Email] = @Email,
        [PasswordHash] = @PasswordHash,
        [PricingPlan] = @PricingPlan,
        [BusinessId] = @BusinessId
    WHERE
        [Id] = @Id;
END;
