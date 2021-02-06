using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using GECP.API;

namespace GECP
{
    public class Program
    {
        public async void get()
        {

            var http = HttpClientFactory.Create();
            string url = "https://microgonode.azurewebsites.net/";
            var data = await http.GetStringAsync(url);

            Console.WriteLine(data);

        }

        public static void Main(string[] args)
        {
            //AboutUsAPI aboutUsAPI = new AboutUsAPI();
            //aboutUsAPI.getAboutUS();
            CreateHostBuilder(args).Build().Run();
        }

        
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
