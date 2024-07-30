using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using gluten_free_br;
using gluten_free_br.Services;
using gluten_free_br.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

if (builder.HostEnvironment.IsDevelopment())
{
    builder.Services.AddScoped<IRecipesService, MockRecipesService>();
}
else
{
    builder.Services.AddScoped<IRecipesService, RecipesService>();
}

await builder.Build().RunAsync();
