using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblurunService
  {
      List<tblurun> GetAll();
      tblurun GetById(int id);
      void Add(tblurun entity);
      void Update(tblurun entity);
      void Delete(tblurun entity);
  }
}
