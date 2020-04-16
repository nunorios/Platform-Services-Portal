using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Platform_Services_Portal.Models;
using System;

namespace Platform_Services_Portal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            var host = BuildWebHost(args);
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var serviceProvider = services.GetRequiredService<IServiceProvider>();
                    var configuration = services.GetRequiredService<IConfiguration>();
                    Seed.CreateRoles(serviceProvider, configuration).Wait();

                }
                catch (Exception exception)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(exception, "An error occurred while creating roles");
                }
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static IWebHost BuildWebHost(string[] args) =>
            Microsoft.AspNetCore.WebHost.CreateDefaultBuilder(args)
            .SuppressStatusMessages(true)
             .ConfigureLogging((hostingContext, builder) =>
             {
                 builder.AddFile("Logs/DailyLog-{Date}.txt",LogLevel.Information,null,false,null,10, "{Timestamp:o};{RequestId,13};[{Level:u3}];{Message};({EventId:x8}){NewLine}{Exception}");
                 //builder.AddFile("Logs/myapp-{Date}.txt");
                 builder.AddFilter(null, LogLevel.Warning);
             })
                .UseStartup<Startup>()
                .Build();
    }
}
