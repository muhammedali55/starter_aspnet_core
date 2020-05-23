using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;;
namespace DataAccess.Concrete
{
  public class EftblfirmaDal : EfEntityRepositoryBase<tblfirma, DBEticeretContext>, ItblfirmaDal
  {
  }
}
