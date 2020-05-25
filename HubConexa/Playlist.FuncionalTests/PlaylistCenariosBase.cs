
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Playlist.API;
using System.IO;
using System.Reflection;

namespace Catalog.FunctionalTests
{
    public class PlaylistCenariosBase
    {

        public TestServer CreateServer()
        {
            var path = Assembly.GetAssembly(typeof(PlaylistCenariosBase))
              .Location;

            var hostBuilder = new WebHostBuilder()
                .UseContentRoot(Path.GetDirectoryName(path))
                .ConfigureAppConfiguration(cb =>
                {
                    cb.AddJsonFile("appsettings.json", optional: false)
                    .AddEnvironmentVariables();
                })
                .UseStartup<Startup>();


            var testServer = new TestServer(hostBuilder);

            //testServer.Host
            //    .MigrateDbContext<CatalogContext>((context, services) =>
            //    {
            //        var env = services.GetService<IWebHostEnvironment>();
            //        var settings = services.GetService<IOptions<CatalogSettings>>();
            //        var logger = services.GetService<ILogger<CatalogContextSeed>>();

            //        new CatalogContextSeed()
            //        .SeedAsync(context, env, settings, logger)
            //        .Wait();
            //    })
            //    .MigrateDbContext<IntegrationEventLogContext>((_, __) => { });

            return testServer;
        }

        public static class Get
        {
            public static string PlaylistByCidade(string nomeCidade)
            {
                return $"api/Playlist/{nomeCidade}";
            }

        }
    }
}
