using COVID_Data.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace COVID_Data
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services
                .AddScoped<ICountriesDataService, CountriesDataService>()
                .AddScoped<IHttpService, HttpService>()
                .AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["covidUrl"]) });

            await builder.Build().RunAsync();
        }
    }
}
