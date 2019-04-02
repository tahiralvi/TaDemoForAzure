using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace TaDemoForAzure
{
    public class Program
    {
		// simple comment
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}