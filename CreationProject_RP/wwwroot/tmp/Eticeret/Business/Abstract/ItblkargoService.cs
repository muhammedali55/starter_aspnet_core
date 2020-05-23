using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblkargoService
  {
      List<tblkargo> GetAll();
      tblkargo GetById(int id);
      void Add(tblkargo entity);
      void Update(tblkargo entity);
      void Delete(tblkargo entity);
      void DeleteList(List<tblkargo> list);
  }
}
