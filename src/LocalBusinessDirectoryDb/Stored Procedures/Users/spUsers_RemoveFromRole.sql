CREATE PROCEDURE [dbo].[spUsers_RemoveFromRole]
	@UserId int,
	@RoleName varchar(max)
AS
	declare @RoleId int = (select [Id] from [dbo].[Roles] where [Name]=@RoleName);

	delete from [dbo].[UserRoles]
	where 
	UserId=@UserId and
	RoleId=@RoleId;
RETURN 0
