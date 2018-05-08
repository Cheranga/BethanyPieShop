using System;
using BethanyPieShop.Web.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BethanyPieShop.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            using (var scope = host.Services.CreateScope())
            {
                try
                {
                    var serviceProvider = scope.ServiceProvider;
                    var context = serviceProvider.GetRequiredService<AppDbContext>();
                    DbInitializer.Seed(context);
                }
                catch (Exception exception)
                {
                }
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}