using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace BrainWorks.ATM.Web
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var hostBuilder = CreateHostBuilder(args);
			var host = hostBuilder.Build();
			host.Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args)
		{
			return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(builder =>
			{
				builder.UseStartup<Startup>();
			});
		}
	}
}
