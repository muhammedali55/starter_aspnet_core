using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblkasaManager : ItblkasaService
  {
      ItblkasaDal _tblkasaDal;
      public tblkasaManager(ItblkasaDal tblkasaService)
      {
          _tblkasaDal = tblkasaService;
      }
      public void Add(tblkasa entity)
      {
           _tblkasaDal.Insert(entity);
      }
       public void Delete(tblkasa entity)
      {
           _tblkasaDal.Delete(entity);
      }
      public List<tblkasa> GetAll()
      {
          return _tblkasaDal.GetList();
      }
      public tblkasa GetById(int id)
      {
          return _tblkasaDal.Get(x => x.Id == id);
      }
      public void Update(tblkasa entity)
      {
          _tblkasaDal.Update(entity);
      }
  }
}
