using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;;
namespace DataAccess.Concrete
{
  public class EftblkasaDal : EfEntityRepositoryBase<tblkasa, DBStokContext>, ItblkasaDal
  {
  }
}
