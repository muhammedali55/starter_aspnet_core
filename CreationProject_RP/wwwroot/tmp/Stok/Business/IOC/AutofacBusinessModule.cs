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
           builder.RegisterType<tblmusteriManager>().As<ItblmusteriService>();
           builder.RegisterType<EftblmusteriDal>().As<ItblmusteriDal>();
           builder.RegisterType<tblurunManager>().As<ItblurunService>();
           builder.RegisterType<EftblurunDal>().As<ItblurunDal>();
           builder.RegisterType<tblfiyatManager>().As<ItblfiyatService>();
           builder.RegisterType<EftblfiyatDal>().As<ItblfiyatDal>();
           builder.RegisterType<tblfirmaManager>().As<ItblfirmaService>();
           builder.RegisterType<EftblfirmaDal>().As<ItblfirmaDal>();
           builder.RegisterType<tblkategoriManager>().As<ItblkategoriService>();
           builder.RegisterType<EftblkategoriDal>().As<ItblkategoriDal>();
      }
  }
}
