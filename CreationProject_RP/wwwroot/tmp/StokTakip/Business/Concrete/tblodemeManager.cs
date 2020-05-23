using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblodemeManager : ItblodemeService
  {
      ItblodemeDal _tblodemeDal;
      public tblodemeManager(ItblodemeDal tblodemeService)
      {
          _tblodemeDal = tblodemeService;
      }
      public void Add(tblodeme entity)
      {
           _tblodemeDal.Insert(entity);
      }
       public void Delete(tblodeme entity)
      {
           _tblodemeDal.Delete(entity);
      }
      public List<tblodeme> GetAll()
      {
          return _tblodemeDal.GetList();
      }
      public tblodeme GetById(int id)
      {
          return _tblodemeDal.Get(x => x.Id == id);
      }
      public void Update(tblodeme entity)
      {
          _tblodemeDal.Update(entity);
      }
  }
}
