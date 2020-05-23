using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.IOC;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
namespace Web
{
  public class Program
  {
      public static void Main(string[] args)
      {          CreateHostBuilder(args).Build().Run();      }      public static IHostBuilder CreateHostBuilder(string[] args) =>
          Host.CreateDefaultBuilder(args)
          .UseServiceProviderFactory(new AutofacServiceProviderFactory())
          .ConfigureContainer<ContainerBuilder>(builder =>{
          builder.RegisterModule(new AutofacBusinessModule());
          })
              .ConfigureWebHostDefaults(webBuilder =>
              {
                  webBuilder.UseStartup<Startup>();
              });
  }
}
