using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblaracService
  {
      List<tblarac> GetAll();
      tblarac GetById(int id);
      void Add(tblarac entity);
      void Update(tblarac entity);
      void Delete(tblarac entity);
      void DeleteList(List<tblarac> list);
  }
}
