using LocalBusinessDirectory.Data.Models;
using LocalBusinessDirectory.Data.Sql;
using Microsoft.AspNetCore.Identity;

namespace LocalBusinessDirectory.Data.Users;
public class UserData : IUserStore<User>, IUserRoleStore<User>
{
    private readonly SqlAccess _sql;

    public UserData(SqlAccess sql)
    {
        _sql = sql;
    }

    public async Task AddToRoleAsync(User user, string roleName, CancellationToken cancellationToken)
    {
        await _sql.ExecuteAsync("spUsers_AddToRole", new { user.Id, RoleName = roleName });
    }

    public async Task<IdentityResult> CreateAsync(User user, CancellationToken cancellationToken)
    {
        await _sql.ExecuteAsync("spUsers_Create", new { user.Name, user.BusinessId, user.Email, user.PasswordHash });
        return IdentityResult.Success;
    }

    public Task<IdentityResult> DeleteAsync(User user, CancellationToken cancellationToken)
    {
        return Task.FromResult(IdentityResult.Success);
    }

    public void Dispose()
    {

    }

    public async Task<User?> FindByIdAsync(string userId, CancellationToken cancellationToken)
    {
        return await _sql.GetFirstOrDefaultAsync<User>("spUsers_FindById", new { Id = userId });
    }

    public async Task<User?> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
    {
        return await _sql.GetFirstOrDefaultAsync<User>("spUsers_FindByName", new { Name = normalizedUserName });
    }

    public Task<string?> GetNormalizedUserNameAsync(User user, CancellationToken cancellationToken)
    {
        return GetUserNameAsync(user, cancellationToken);
    }

    public async Task<IList<string>> GetRolesAsync(User user, CancellationToken cancellationToken)
    {
        return await _sql.GetAsync<string>("spUsers_GetRoles", new { user.Id });
    }

    public Task<string> GetUserIdAsync(User user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user.Id.ToString());
    }

    public Task<string?> GetUserNameAsync(User user, CancellationToken cancellationToken)
    {
        return Task.FromResult<string?>(user.Name);
    }

    public async Task<IList<User>> GetUsersInRoleAsync(string roleName, CancellationToken cancellationToken)
    {
        return await _sql.GetAsync<User>("spUsers_GetUsersInRole", new { RoleName = roleName });
    }

    public async Task<bool> IsInRoleAsync(User user, string roleName, CancellationToken cancellationToken)
    {
        var roles = await GetRolesAsync(user, cancellationToken);
        return roles != null && roles.Contains(roleName);
    }

    public async Task RemoveFromRoleAsync(User user, string roleName, CancellationToken cancellationToken)
    {
        await _sql.ExecuteAsync("spUsers_RemoveFromRole", new { UserId = user.Id, RoleName = roleName });
    }

    public Task SetNormalizedUserNameAsync(User user, string? normalizedName, CancellationToken cancellationToken)
    {
        user.Name = normalizedName;
        return Task.CompletedTask;
    }

    public Task SetUserNameAsync(User user, string? userName, CancellationToken cancellationToken)
    {
        user.Name = userName;
        return Task.CompletedTask;
    }

    public async Task<IdentityResult> UpdateAsync(User user, CancellationToken cancellationToken)
    {
        await _sql.ExecuteAsync("spUsers_Update", user);
        return IdentityResult.Success;
    }
}
