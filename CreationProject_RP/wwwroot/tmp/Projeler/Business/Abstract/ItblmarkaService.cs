using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblmarkaService
  {
      List<tblmarka> GetAll();
      tblmarka GetById(int id);
      void Add(tblmarka entity);
      void Update(tblmarka entity);
      void Delete(tblmarka entity);
      void DeleteList(List<tblmarka> list);
  }
}
