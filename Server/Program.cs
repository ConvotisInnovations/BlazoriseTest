#pragma warning disable SA1200
using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using Microsoft.Extensions.Localization;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;
using Server;
using Server.States;

#pragma warning restore SA1200

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddMicrosoftIdentityUI();

builder.Services.AddRazorPages(options => { options.RootDirectory = "/Layout"; });
builder.Services.AddServerSideBlazor().AddMicrosoftIdentityConsentHandler();

// Localization
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddSingleton<IStringLocalizer<App>, StringLocalizer<App>>();

// Session Wide
builder.Services.AddScoped<HeaderMenuState>();
builder.Services.AddScoped<HeaderNavigationState>();

// Theme
builder.Services.AddBlazorise(options => { options.Immediate = true; }).AddBootstrap5Providers().AddFontAwesomeIcons();

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

app.UseRouting();

// Authorization
app.UseAuthentication();
app.UseAuthorization();

// Localization
var localizeOptions = new RequestLocalizationOptions().AddSupportedCultures("en-US", "de-DE").AddSupportedUICultures("en-US", "de-DE");
app.UseRequestLocalization(localizeOptions);

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();