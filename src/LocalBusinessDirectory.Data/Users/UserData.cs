﻿using LocalBusinessDirectory.Data.Models;
using LocalBusinessDirectory.Data.Sql;
using Microsoft.AspNetCore.Identity;

namespace LocalBusinessDirectory.Data.Users;
public class UserData : IUserStore<User>
{
    private readonly ISqlAccess _sql;

    public UserData(ISqlAccess sql)
    {
        _sql = sql;
    }

    public async Task<IdentityResult> CreateAsync(User user, CancellationToken cancellationToken)
    {
        user.Id = await _sql.GetFirstOrDefaultAsync<int>("spUsers_Create", new { user.Name, user.BusinessId, user.Email, user.PasswordHash, user.PricingPlan });
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
