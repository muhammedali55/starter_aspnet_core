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
           builder.RegisterType<tblpersonelManager>().As<ItblpersonelService>();
           builder.RegisterType<EftblpersonelDal>().As<ItblpersonelDal>();
           builder.RegisterType<tblmodelManager>().As<ItblmodelService>();
           builder.RegisterType<EftblmodelDal>().As<ItblmodelDal>();
           builder.RegisterType<tblmarkaManager>().As<ItblmarkaService>();
           builder.RegisterType<EftblmarkaDal>().As<ItblmarkaDal>();
      }
  }
}
