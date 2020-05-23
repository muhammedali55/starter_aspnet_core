using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblkategoriService
  {
      List<tblkategori> GetAll();
      tblkategori GetById(int id);
      void Add(tblkategori entity);
      void Update(tblkategori entity);
      void Delete(tblkategori entity);
  }
}
