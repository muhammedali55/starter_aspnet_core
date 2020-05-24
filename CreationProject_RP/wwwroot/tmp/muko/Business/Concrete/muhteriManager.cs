using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class muhteriManager : ImuhteriService
  {
      ImuhteriDal _muhteriDal;
      public muhteriManager(ImuhteriDal muhteriService)
      {
          _muhteriDal = muhteriService;
      }
      public void Add(muhteri entity)
      {
           _muhteriDal.Insert(entity);
      }
       public void Delete(muhteri entity)
      {
           _muhteriDal.Delete(entity);
      }
      public List<muhteri> GetAll()
      {
          return _muhteriDal.GetList();
      }
      public muhteri GetById(int id)
      {
          return _muhteriDal.Get(x => x.Id == id);
      }
      public void Update(muhteri entity)
      {
          _muhteriDal.Update(entity);
      }
  }
}
