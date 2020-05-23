using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblmodelManager : ItblmodelService
  {
      ItblmodelDal _tblmodelDal;
      public tblmodelManager(ItblmodelDal tblmodelService)
      {
          _tblmodelDal = tblmodelService;
      }
      public void Add(tblmodel entity)
      {
           _tblmodelDal.Insert(entity);
      }
       public void Delete(tblmodel entity)
      {
           _tblmodelDal.Delete(entity);
      }
      public List<tblmodel> GetAll()
      {
          return _tblmodelDal.GetList();
      }
      public tblmodel GetById(int id)
      {
          return _tblmodelDal.Get(x => x.Id == id);
      }
      public void Update(tblmodel entity)
      {
          _tblmodelDal.Update(entity);
      }
  }
}
