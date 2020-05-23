using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblfiyatManager : ItblfiyatService
  {
      ItblfiyatDal _tblfiyatDal;
      public tblfiyatManager(ItblfiyatDal tblfiyatService)
      {
          _tblfiyatDal = tblfiyatService;
      }
      public void Add(tblfiyat entity)
      {
           _tblfiyatDal.Insert(entity);
      }
       public void Delete(tblfiyat entity)
      {
           _tblfiyatDal.Delete(entity);
      }
      public List<tblfiyat> GetAll()
      {
          return _tblfiyatDal.GetList();
      }
      public tblfiyat GetById(int id)
      {
          return _tblfiyatDal.Get(x => x.Id == id);
      }
      public void Update(tblfiyat entity)
      {
          _tblfiyatDal.Update(entity);
      }
  }
}
