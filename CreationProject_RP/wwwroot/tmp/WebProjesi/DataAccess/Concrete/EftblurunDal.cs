using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;;
namespace DataAccess.Concrete
{
  public class EftblurunDal : EfEntityRepositoryBase<tblurun, DBMusteriContext>, ItblurunDal
  {
  }
}
