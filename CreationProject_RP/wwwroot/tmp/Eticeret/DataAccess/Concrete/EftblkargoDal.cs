using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;;
namespace DataAccess.Concrete
{
  public class EftblkargoDal : EfEntityRepositoryBase<tblkargo, DBEticeretContext>, ItblkargoDal
  {
  }
}
