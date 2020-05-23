using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblmusteriManager : ItblmusteriService
  {
      ItblmusteriDal _tblmusteriDal;
      public tblmusteriManager(ItblmusteriDal tblmusteriService)
      {
          _tblmusteriDal = tblmusteriService;
      }
      public void Add(tblmusteri entity)
      {
           _tblmusteriDal.Insert(entity);
      }
       public void Delete(tblmusteri entity)
      {
           _tblmusteriDal.Delete(entity);
      }
      public List<tblmusteri> GetAll()
      {
          return _tblmusteriDal.GetList();
      }
      public tblmusteri GetById(int id)
      {
          return _tblmusteriDal.Get(x => x.Id == id);
      }
      public void Update(tblmusteri entity)
      {
          _tblmusteriDal.Update(entity);
      }
  }
}
