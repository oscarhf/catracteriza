using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using AbastFacto.App.Services;

namespace AbastFacto.App
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

             // builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
              builder.Services.AddHttpClient<IFactorDataService, FactorDataService>(client => client.BaseAddress = new Uri("http://localhost:44340/"));

            await builder.Build().RunAsync();
        }
    }
}
