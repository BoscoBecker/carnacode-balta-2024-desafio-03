//using IMC.Client.Pages;
using IMC.Components;
using IMC.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents()
    .AddInteractiveServerComponents();
builder.Services.AddRazorComponents();
builder.Services.AddSingleton<ServicesIMC>(); 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    app.UseWebAssemblyDebugging();
else
    app.UseExceptionHandler("/Error", createScopeForErrors: true);

app.UseStaticFiles();
app.UseAntiforgery();
app.MapRazorComponents<App>()
   .AddInteractiveWebAssemblyRenderMode()
   .AddInteractiveServerRenderMode();
app.Run();
