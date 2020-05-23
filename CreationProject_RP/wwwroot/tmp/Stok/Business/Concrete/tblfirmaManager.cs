using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblfirmaManager : ItblfirmaService
  {
      ItblfirmaDal _tblfirmaDal;
      public tblfirmaManager(ItblfirmaDal tblfirmaService)
      {
          _tblfirmaDal = tblfirmaService;
      }
      public void Add(tblfirma entity)
      {
           _tblfirmaDal.Insert(entity);
      }
       public void Delete(tblfirma entity)
      {
           _tblfirmaDal.Delete(entity);
      }
      public List<tblfirma> GetAll()
      {
          return _tblfirmaDal.GetList();
      }
      public tblfirma GetById(int id)
      {
          return _tblfirmaDal.Get(x => x.Id == id);
      }
      public void Update(tblfirma entity)
      {
          _tblfirmaDal.Update(entity);
      }
  }
}
