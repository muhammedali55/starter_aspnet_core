using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblurunManager : ItblurunService
  {
      ItblurunDal _tblurunDal;
      public tblurunManager(ItblurunDal tblurunService)
      {
          _tblurunDal = tblurunService;
      }
      public void Add(tblurun entity)
      {
           _tblurunDal.Insert(entity);
      }
       public void Delete(tblurun entity)
      {
           _tblurunDal.Delete(entity);
      }
      public List<tblurun> GetAll()
      {
          return _tblurunDal.GetList();
      }
      public tblurun GetById(int id)
      {
          return _tblurunDal.Get(x => x.Id == id);
      }
      public void Update(tblurun entity)
      {
          _tblurunDal.Update(entity);
      }
  }
}
