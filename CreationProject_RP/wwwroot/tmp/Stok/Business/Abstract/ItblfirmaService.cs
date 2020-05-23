using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblfirmaService
  {
      List<tblfirma> GetAll();
      tblfirma GetById(int id);
      void Add(tblfirma entity);
      void Update(tblfirma entity);
      void Delete(tblfirma entity);
  }
}
