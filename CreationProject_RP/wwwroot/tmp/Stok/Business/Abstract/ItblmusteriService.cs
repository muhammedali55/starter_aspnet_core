using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblmusteriService
  {
      List<tblmusteri> GetAll();
      tblmusteri GetById(int id);
      void Add(tblmusteri entity);
      void Update(tblmusteri entity);
      void Delete(tblmusteri entity);
  }
}
