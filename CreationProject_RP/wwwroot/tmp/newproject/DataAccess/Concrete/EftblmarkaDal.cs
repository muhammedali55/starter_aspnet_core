using Core.DataAccess;
using Core.Entities;
using DataAccess.Abstract;;
namespace DataAccess.Concrete
{
  public class EftblmarkaDal : EfEntityRepositoryBase<tblmarka, DBMusteri>, ItblmarkaDal
  {
  }
}
