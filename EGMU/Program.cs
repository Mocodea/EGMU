using EGMU.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Context;
using Serilog.Events;
using System;
using System.IO;

namespace EGMU
{
    public class Program
    {
        public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
            .AddEnvironmentVariables()
            .Build();

        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                      .ReadFrom.Configuration(Configuration)
                      .CreateLogger();

            try
            {
                Log.Information($"Starting EGMU in {Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")} environment...");

                var host = CreateHostBuilder(args).Build();
                ExecuteMigrations(host);
                host.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
                throw;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .UseSerilog();

        private static void ExecuteMigrations(IHost host)
        {
            Log.Information("Starting Migrations...");

            using var scope = host.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetService<ApplicationDbContext>();

            dbContext.Database.Migrate();

            Log.Information("Migrations finished.");
        }
    }
}
