using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;;
namespace DataAccess.Concrete
{
  public class EftblmusteriDal : EfEntityRepositoryBase<tblmusteri, DBMusteriContext>, ItblmusteriDal
  {
  }
}
