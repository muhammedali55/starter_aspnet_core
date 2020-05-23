using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;;
namespace DataAccess.Concrete
{
  public class EftblpersonelDal : EfEntityRepositoryBase<tblpersonel, DBStokContext>, ItblpersonelDal
  {
  }
}
