CREATE PROCEDURE [dbo].[spUsers_GetUsersInRole]
	@RoleName varchar(max)
AS
	select u.* from [dbo].[Users] as u
	inner join [dbo].[UserRoles] as ur on ur.UserId=u.Id
	inner join [dbo].[Roles] as r on r.Id=ur.Id
	where r.Name=@RoleName;
RETURN 0
