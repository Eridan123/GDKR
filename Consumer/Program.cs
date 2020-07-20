using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.WindowsServices;
using Microsoft.Extensions.Hosting;

namespace Gkdr.Consumer
{
    public class Program
    {
        private const string AppUrl = "http://*:5020";

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
                webBuilder.UseStartup<Startup>().UseUrls(AppUrl);
            });

        private static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls(AppUrl);
        
        private static IWebHostBuilder CreateService(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls(AppUrl);
    }
}
