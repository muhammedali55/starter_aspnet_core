using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;;
namespace DataAccess.Concrete
{
  public class EftblsatisDal : EfEntityRepositoryBase<tblsatis, DBStokContext>, ItblsatisDal
  {
  }
}
