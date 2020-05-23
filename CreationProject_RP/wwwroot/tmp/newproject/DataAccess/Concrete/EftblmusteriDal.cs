using Core.DataAccess;
using Core.Entities;
using DataAccess.Abstract;;
namespace DataAccess.Concrete
{
  public class EftblmusteriDal : EfEntityRepositoryBase<tblmusteri, DBMusteri>, ItblmusteriDal
  {
  }
}
