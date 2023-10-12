using LocalBusinessDirectory.Helpers;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddControllers();
builder.Services.AddSingleton<ISqlAccess, SqlAccess>();
builder.Services.AddSingleton<IBusinessData, BusinessData>();
builder.Services.AddSingleton<ICategoryData, CategoryData>();
builder.Services.AddSingleton<IOfferData, OfferData>();
builder.Services.AddSingleton<IRater, Rater>();
builder.Services.AddSingleton<IPasswordHasher, PasswordHasher>();
builder.Services.AddSingleton<IUserStore<User>, UserData>();

builder.Services.AddScoped<IDataPersist, DataPersist>();

builder.Services.AddOptions();
builder.Services.AddAuthentication()
    .AddCookie(IdentityConstants.ApplicationScheme);
builder.Services.AddAuthorization();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/join";
    options.LogoutPath = "/sign-out";
    options.SlidingExpiration = true;
    options.ExpireTimeSpan = TimeSpan.FromDays(3);
    options.Cookie.IsEssential = true;
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
});

builder.Services.AddIdentityCore<User>()
    .AddUserStore<UserData>()
    .AddSignInManager<SignInManager<User>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
           Path.Combine(builder.Environment.ContentRootPath, "images")),
    RequestPath = "/images"
});

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
