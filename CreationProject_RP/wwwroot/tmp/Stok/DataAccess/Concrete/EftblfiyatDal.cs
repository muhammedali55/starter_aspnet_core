using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;
namespace DataAccess.Concrete
{
  public class EftblfiyatDal : EfEntityRepositoryBase<tblfiyat, DbMusteriContext>, ItblfiyatDal
  {
  }
}
