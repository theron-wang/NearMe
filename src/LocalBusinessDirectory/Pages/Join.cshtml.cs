using LocalBusinessDirectory.Helpers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace LocalBusinessDirectory.Pages;

[ValidateAntiForgeryToken]
public class JoinModel : PageModel
{
    private readonly IUserStore<User> _userStore;
    private readonly IPasswordHasher _passwordHasher;
    private readonly SignInManager<User> _signInManager;

    public JoinModel(IUserStore<User> userStore, IPasswordHasher passwordHasher, SignInManager<User> signInManager)
    {
        _userStore = userStore;
        _passwordHasher = passwordHasher;
        _signInManager = signInManager;
    }

    [BindProperty]
    public LoginModel LoginModel { get; set; } = new();

    public void OnGet()
    {
    }
    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid == false)
        {
            return Page();
        }

        var user = await _userStore.FindByNameAsync(LoginModel.Username!, default);

        if (user is null)
        {
            ModelState.AddModelError("Error", "Account does not exist");
            return Page();
        }

        var passwordValid = _passwordHasher.VerifyPassword(LoginModel.Password!, user.PasswordHash);

        if (passwordValid == false)
        {
            ModelState.AddModelError("Error", "Password is incorrect");
            return Page();
        }

        await _signInManager.SignInWithClaimsAsync(user, LoginModel.RememberMe, new List<Claim>()
        {
            new(DirectoryClaimTypes.BusinessOwnerOf, user.BusinessId ?? ""),
            new(DirectoryClaimTypes.Plan, ((int)user.PricingPlan).ToString())
        });
        return LocalRedirect("~/");
    }
}
