using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;
namespace DataAccess.Concrete
{
  public class EftblmodelDal : EfEntityRepositoryBase<tblmodel, DBMusteriContext>, ItblmodelDal
  {
  }
}
