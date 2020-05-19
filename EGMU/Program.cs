using EGMU.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EGMU
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            ExecuteMigrations(host);

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static void ExecuteMigrations(IHost host)
        {
            using var scope = host.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetService<ApplicationDbContext>();

            dbContext.Database.Migrate();
        }
    }
}
