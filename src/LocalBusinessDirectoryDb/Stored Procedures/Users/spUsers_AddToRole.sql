CREATE PROCEDURE [dbo].[spUsers_AddToRole]
	@Id int,
	@RoleName varchar(max)
AS
	insert into [dbo].[UserRoles]
	(UserId, RoleId)
	values
	(@Id, (select Id from [dbo].[Roles] where Name=@RoleName));
RETURN 0
