using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Gkdr.Producer
{
    public static class Program
    {
        private const string AppUrl = "http://*:5030";

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            // CreateWebHostBuilder(args).Build().Run();
            // CreateService(args).Build().RunAsService();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>()
                    .UseUrls(AppUrl);
            });

        private static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls(AppUrl);
        
        private static IWebHostBuilder CreateServiceBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls(AppUrl);
    }
}
