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
           builder.RegisterType<tblurunManager>().As<ItblurunService>();
           builder.RegisterType<EftblurunDal>().As<ItblurunDal>();
           builder.RegisterType<tblmusteriManager>().As<ItblmusteriService>();
           builder.RegisterType<EftblmusteriDal>().As<ItblmusteriDal>();
           builder.RegisterType<tblfirmaManager>().As<ItblfirmaService>();
           builder.RegisterType<EftblfirmaDal>().As<ItblfirmaDal>();
           builder.RegisterType<tblkargoManager>().As<ItblkargoService>();
           builder.RegisterType<EftblkargoDal>().As<ItblkargoDal>();
      }
  }
}
