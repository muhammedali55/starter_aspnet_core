using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
namespace Business.IOC
{
  public class AutofacBusinessModule: Module
  {
      protected override void Load(ContainerBuilder builder)
      {
           builder.RegisterType<muhteriManager>().As<ImuhteriService>();
           builder.RegisterType<EfmuhteriDal>().As<ImuhteriDal>();
      }
  }
}
