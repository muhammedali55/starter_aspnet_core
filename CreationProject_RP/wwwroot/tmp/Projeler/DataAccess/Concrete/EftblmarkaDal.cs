using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;
namespace DataAccess.Concrete
{
  public class EftblmarkaDal : EfEntityRepositoryBase<tblmarka, DBMusteriContext>, ItblmarkaDal
  {
  }
}
