using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblstokManager : ItblstokService
  {
      ItblstokDal _tblstokDal;
      public tblstokManager(ItblstokDal tblstokService)
      {
          _tblstokDal = tblstokService;
      }
      public void Add(tblstok entity)
      {
           _tblstokDal.Insert(entity);
      }
       public void Delete(tblstok entity)
      {
           _tblstokDal.Delete(entity);
      }
      public List<tblstok> GetAll()
      {
          return _tblstokDal.GetList();
      }
      public tblstok GetById(int id)
      {
          return _tblstokDal.Get(x => x.Id == id);
      }
      public void Update(tblstok entity)
      {
          _tblstokDal.Update(entity);
      }
  }
}
