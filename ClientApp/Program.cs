using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ClientApp;
using Home.Core.Models;
using Microsoft.Extensions.DependencyInjection;


foreach (var a in Enum.GetNames(typeof(EModule)))
{
    File.WriteAllText("/home/neerd/RiderProjects/WebApiTest/Home.Core/Modules/" + a + "Module.cs", "");
}


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddAntDesign();
builder.Services.AddHttpClient();


builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder
            .AllowAnyOrigin());
});


builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});


await builder.Build().RunAsync();