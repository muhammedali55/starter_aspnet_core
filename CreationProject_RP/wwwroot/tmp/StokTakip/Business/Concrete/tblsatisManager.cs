using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblsatisManager : ItblsatisService
  {
      ItblsatisDal _tblsatisDal;
      public tblsatisManager(ItblsatisDal tblsatisService)
      {
          _tblsatisDal = tblsatisService;
      }
      public void Add(tblsatis entity)
      {
           _tblsatisDal.Insert(entity);
      }
       public void Delete(tblsatis entity)
      {
           _tblsatisDal.Delete(entity);
      }
      public List<tblsatis> GetAll()
      {
          return _tblsatisDal.GetList();
      }
      public tblsatis GetById(int id)
      {
          return _tblsatisDal.Get(x => x.Id == id);
      }
      public void Update(tblsatis entity)
      {
          _tblsatisDal.Update(entity);
      }
  }
}
