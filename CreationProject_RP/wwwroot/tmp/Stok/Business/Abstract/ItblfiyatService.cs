using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblfiyatService
  {
      List<tblfiyat> GetAll();
      tblfiyat GetById(int id);
      void Add(tblfiyat entity);
      void Update(tblfiyat entity);
      void Delete(tblfiyat entity);
  }
}
