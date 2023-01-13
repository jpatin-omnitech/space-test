using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace space_test_front
{
    public class HostBuilderHelper
    {
        public static IHostBuilder BuildWebSite(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        }
    }
}
