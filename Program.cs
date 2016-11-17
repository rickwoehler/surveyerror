using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Survey
{
    public class Program
    {
        public static void Main()
        {
            IWebHost host = new WebHostBuilder()
                .UseIISIntegration()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            host.Run(); 
        }
    }
}
