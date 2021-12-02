using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EFGrid.app.Data;
using Syncfusion.Blazor;

namespace EFGrid
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddSyncfusionBlazor();


            // - get port# from efgrid.api.properties.launchsettings.json in the API proj
            var TmpEnv = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            string sURI = "";
            if (TmpEnv == "Production")
            {
                //PROD
                sURI = "https://datacatadminblzapi20210907103238.azurewebsites.net/";
            }
            else
            {
                //DEV
                sURI = "https://localhost:44370/";
            }

            services.AddHttpClient<IRegionDataService, RegionDataService>(client => client.BaseAddress = new Uri(sURI));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTA5MzU2QDMxMzkyZTMzMmUzMGJNazlrbDZraVp6UW1zaGNHRVpBZVZ1Y01jVmwzZ2UwRnY2dmhoZUlpRWs9;NTA5MzU3QDMxMzkyZTMzMmUzMGllRWZHN0NjQmd1MVF3OXVXNzNvcExCMXhJcjNFNHRrTEtjdXhUQlNxS009;NTA5MzU4QDMxMzkyZTMzMmUzMFpKM2RuOHVVU1Y0dXJ3L3BOem0wQVMrMmN6OWUvWnR4QlNQQmwwWXM2OGM9;NTA5MzU5QDMxMzkyZTMzMmUzMGJqbmNtY3ZwdTJ4WDgwamJVME16T3NQN0EyeDVuVVlkalZVWGJpL0NWbGs9;NTA5MzYwQDMxMzkyZTMzMmUzMFRGN00wcExXNEFxUDQ0MVltYTFqVVg5eEZkdkxlQWFFeWV3RzBkMGFEc3c9;NTA5MzYxQDMxMzkyZTMzMmUzMFhmZGV2aWNOTjNvMVdDalpOLzNjNWNkMTJxcURnRkh5TEZhcFVCS2dHSDQ9;NTA5MzYyQDMxMzkyZTMzMmUzMGlZNEtjOXh2R1luNVhJU0Y3N1Jrb2hDcE9HUGcwVmRGYUI4ektoRnd0QVU9;NTA5MzYzQDMxMzkyZTMzMmUzMEFkTmFGVEp1NGxVMWxlUmRLalZVNWxMbzJ0SjlpcmJnUThMN0lzM1JqMXM9;NTA5MzY0QDMxMzkyZTMzMmUzMG44ZjI4djkyVWcyMDU5dlIwcXVseTZaRjRqTjdWNjdtaUNHcElmMFhwRW89;NTA5MzY1QDMxMzkyZTMzMmUzMEw2R2RkYVdXcWMwaUZmNDVjVVh0b0Z5OXl1ZUY2ZExBbHhGcnA3Y1VXUXc9;NTA5MzY2QDMxMzkyZTMzMmUzMFE3cW1XSHVjMTNIL2RzcUI5N3B6N2JVbU1RRCtOSkI5SHRwdGFreUYya2M9");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
