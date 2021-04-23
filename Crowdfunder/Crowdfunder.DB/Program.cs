using System;
using System.Threading;
using System.Threading.Tasks;
using Crowdfunder.DAL.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Crowdfunder.DB
{
    class Program
    {
        private static Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using var host = CreateHostBuilder(args).Build();

            var cts = new CancellationTokenSource();
            cts.CancelAfter(5000);
            
            return host.RunAsync(cts.Token);
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                {
                    services.AddCrowdfunderContext(_.Configuration.GetConnectionString("CrowdfunderContext"));
                });
    }
}