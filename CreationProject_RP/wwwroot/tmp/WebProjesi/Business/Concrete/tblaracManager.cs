using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblaracManager : ItblaracService
  {
      ItblaracDal _tblaracDal;
      public tblaracManager(ItblaracDal tblaracService)
      {
          _tblaracDal = tblaracService;
      }
      public void Add(tblarac entity)
      {
           _tblaracDal.Insert(entity);
      }
       public void Delete(tblarac entity)
      {
           _tblaracDal.Delete(entity);
      }
      public List<tblarac> GetAll()
      {
          return _tblaracDal.GetList();
      }
      public tblarac GetById(int id)
      {
          return _tblaracDal.Get(x => x.Id == id);
      }
      public void Update(tblarac entity)
      {
          _tblaracDal.Update(entity);
      }
  }
}
