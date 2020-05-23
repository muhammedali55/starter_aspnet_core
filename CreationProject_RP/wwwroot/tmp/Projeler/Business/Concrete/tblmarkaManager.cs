using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblmarkaManager : ItblmarkaService
  {
      ItblmarkaDal _tblmarkaDal;
      public tblmarkaManager(ItblmarkaDal tblmarkaService)
      {
          _tblmarkaDal = tblmarkaService;
      }
      public void Add(tblmarka entity)
      {
           _tblmarkaDal.Insert(entity);
      }
       public void Delete(tblmarka entity)
      {
           _tblmarkaDal.Delete(entity);
      }
      public List<tblmarka> GetAll()
      {
          return _tblmarkaDal.GetList();
      }
      public tblmarka GetById(int id)
      {
          return _tblmarkaDal.Get(x => x.Id == id);
      }
      public void Update(tblmarka entity)
      {
          _tblmarkaDal.Update(entity);
      }
  }
}
