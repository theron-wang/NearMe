CREATE PROCEDURE [dbo].[spUsers_GetRoles]
	@Id int
AS
	select [r].[Name] from [dbo].[Roles] as r
	inner join [dbo].[UserRoles] as ur on ur.RoleId=r.Id
	where ur.UserId=@Id;
RETURN 0
