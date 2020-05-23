using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;;
namespace DataAccess.Concrete
{
  public class EftblmuhasebeDal : EfEntityRepositoryBase<tblmuhasebe, DBStokContext>, ItblmuhasebeDal
  {
  }
}
