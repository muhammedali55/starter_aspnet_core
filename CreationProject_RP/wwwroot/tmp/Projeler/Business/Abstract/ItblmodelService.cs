using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblmodelService
  {
      List<tblmodel> GetAll();
      tblmodel GetById(int id);
      void Add(tblmodel entity);
      void Update(tblmodel entity);
      void Delete(tblmodel entity);
      void DeleteList(List<tblmodel> list);
  }
}
