using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblpersonelService
  {
      List<tblpersonel> GetAll();
      tblpersonel GetById(int id);
      void Add(tblpersonel entity);
      void Update(tblpersonel entity);
      void Delete(tblpersonel entity);
      void DeleteList(List<tblpersonel> list);
  }
}
