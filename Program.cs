using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcolatoreCFWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                //.ConfigureLogging((context, logging) =>
                //{
                    //logging.ClearProviders();
                    //logging.AddConfiguration(context.Configuration.GetSection("Logging"));
                    //logging.AddDebug(); Commentando vedremo solo la console non il log del Debugger
                    //logging.AddConsole();
                //})
                        .ConfigureWebHostDefaults(webBuilder =>
                         {
                         webBuilder.UseStartup<Startup>();
                         });
        }
    }
}
