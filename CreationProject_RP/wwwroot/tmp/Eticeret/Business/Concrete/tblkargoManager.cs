using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblkargoManager : ItblkargoService
  {
      ItblkargoDal _tblkargoDal;
      public tblkargoManager(ItblkargoDal tblkargoService)
      {
          _tblkargoDal = tblkargoService;
      }
      public void Add(tblkargo entity)
      {
           _tblkargoDal.Insert(entity);
      }
       public void Delete(tblkargo entity)
      {
           _tblkargoDal.Delete(entity);
      }
      public List<tblkargo> GetAll()
      {
          return _tblkargoDal.GetList();
      }
      public tblkargo GetById(int id)
      {
          return _tblkargoDal.Get(x => x.Id == id);
      }
      public void Update(tblkargo entity)
      {
          _tblkargoDal.Update(entity);
      }
  }
}
