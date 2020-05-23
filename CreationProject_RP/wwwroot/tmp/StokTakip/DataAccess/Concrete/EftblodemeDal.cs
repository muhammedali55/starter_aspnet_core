using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;;
namespace DataAccess.Concrete
{
  public class EftblodemeDal : EfEntityRepositoryBase<tblodeme, DBStokContext>, ItblodemeDal
  {
  }
}
