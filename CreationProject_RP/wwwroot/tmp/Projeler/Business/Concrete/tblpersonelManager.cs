using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblpersonelManager : ItblpersonelService
  {
      ItblpersonelDal _tblpersonelDal;
      public tblpersonelManager(ItblpersonelDal tblpersonelService)
      {
          _tblpersonelDal = tblpersonelService;
      }
      public void Add(tblpersonel entity)
      {
           _tblpersonelDal.Insert(entity);
      }
       public void Delete(tblpersonel entity)
      {
           _tblpersonelDal.Delete(entity);
      }
      public List<tblpersonel> GetAll()
      {
          return _tblpersonelDal.GetList();
      }
      public tblpersonel GetById(int id)
      {
          return _tblpersonelDal.Get(x => x.Id == id);
      }
      public void Update(tblpersonel entity)
      {
          _tblpersonelDal.Update(entity);
      }
  }
}
