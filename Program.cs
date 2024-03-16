using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Http;
using System.Configuration;

namespace NBA_Stats_Browser
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Create service collection and configure our services
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(ConfigureServices)
                .Build();

            var form1 = host.Services.GetRequiredService<Form1>();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.Run(form1);
        }
        private static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
        {
            services.AddTransient<Form1>();
            services.AddTransient<TeamService>();
            services.AddTransient<PlayerService>();
            services.AddMemoryCache();
            services.AddHttpClient("APIClient",client =>
            {
                client.BaseAddress = new Uri("https://api.balldontlie.io/v1/");
                client.DefaultRequestHeaders.Add("Authorization", "API-KEY");
            });

        }
    }
}
