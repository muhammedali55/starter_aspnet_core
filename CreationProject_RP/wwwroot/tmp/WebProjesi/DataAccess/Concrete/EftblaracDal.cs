using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;;
namespace DataAccess.Concrete
{
  public class EftblaracDal : EfEntityRepositoryBase<tblarac, DBMusteriContext>, ItblaracDal
  {
  }
}
