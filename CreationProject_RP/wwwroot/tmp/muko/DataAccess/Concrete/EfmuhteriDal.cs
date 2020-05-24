using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;
namespace DataAccess.Concrete
{
  public class EfmuhteriDal : EfEntityRepositoryBase<muhteri, muuuContext>, ImuhteriDal
  {
  }
}
