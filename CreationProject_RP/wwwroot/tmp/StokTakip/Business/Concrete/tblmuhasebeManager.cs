using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblmuhasebeManager : ItblmuhasebeService
  {
      ItblmuhasebeDal _tblmuhasebeDal;
      public tblmuhasebeManager(ItblmuhasebeDal tblmuhasebeService)
      {
          _tblmuhasebeDal = tblmuhasebeService;
      }
      public void Add(tblmuhasebe entity)
      {
           _tblmuhasebeDal.Insert(entity);
      }
       public void Delete(tblmuhasebe entity)
      {
           _tblmuhasebeDal.Delete(entity);
      }
      public List<tblmuhasebe> GetAll()
      {
          return _tblmuhasebeDal.GetList();
      }
      public tblmuhasebe GetById(int id)
      {
          return _tblmuhasebeDal.Get(x => x.Id == id);
      }
      public void Update(tblmuhasebe entity)
      {
          _tblmuhasebeDal.Update(entity);
      }
  }
}
