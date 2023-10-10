using LocalBusinessDirectory.Helpers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LocalBusinessDirectory.Controllers;
[ApiController]
public class SignOutController : ControllerBase
{
    private readonly SignInManager<User> _signInManager;
    private readonly IUserStore<User> _userStore;

    public SignOutController(SignInManager<User> signInManager, IUserStore<User> userStore)
    {
        _signInManager = signInManager;
        _userStore = userStore;
    }

    [HttpGet("/sign-out")]
    public async Task<IActionResult> SignOutAsync()
    {
        await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);

        return LocalRedirect("~/");
    }

    [HttpGet("/refresh")]
    [Authorize]
    public async Task<IActionResult> RefreshAsync()
    {
        var user = await _userStore.FindByNameAsync(User.Identity!.Name!, default);

        var auth = await HttpContext.AuthenticateAsync(IdentityConstants.ApplicationScheme);

        var claims = new List<Claim>()
        {
            new(DirectoryClaimTypes.BusinessOwnerOf, user!.BusinessId ?? ""),
            new(DirectoryClaimTypes.Plan, ((int)user!.PricingPlan).ToString())
        };

        await _signInManager.SignInWithClaimsAsync(user, auth?.Properties, claims);

        return LocalRedirect("~/");
    }
}
