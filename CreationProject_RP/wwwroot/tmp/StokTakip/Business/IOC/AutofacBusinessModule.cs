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
           builder.RegisterType<tblstokManager>().As<ItblstokService>();
           builder.RegisterType<EftblstokDal>().As<ItblstokDal>();
           builder.RegisterType<tblmusteriManager>().As<ItblmusteriService>();
           builder.RegisterType<EftblmusteriDal>().As<ItblmusteriDal>();
           builder.RegisterType<tblurunManager>().As<ItblurunService>();
           builder.RegisterType<EftblurunDal>().As<ItblurunDal>();
           builder.RegisterType<tblfirmaManager>().As<ItblfirmaService>();
           builder.RegisterType<EftblfirmaDal>().As<ItblfirmaDal>();
           builder.RegisterType<tblmuhasebeManager>().As<ItblmuhasebeService>();
           builder.RegisterType<EftblmuhasebeDal>().As<ItblmuhasebeDal>();
           builder.RegisterType<tblpersonelManager>().As<ItblpersonelService>();
           builder.RegisterType<EftblpersonelDal>().As<ItblpersonelDal>();
           builder.RegisterType<tblsatisManager>().As<ItblsatisService>();
           builder.RegisterType<EftblsatisDal>().As<ItblsatisDal>();
           builder.RegisterType<tblodemeManager>().As<ItblodemeService>();
           builder.RegisterType<EftblodemeDal>().As<ItblodemeDal>();
           builder.RegisterType<tblkasaManager>().As<ItblkasaService>();
           builder.RegisterType<EftblkasaDal>().As<ItblkasaDal>();
      }
  }
}
