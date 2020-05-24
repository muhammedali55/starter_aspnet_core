using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ImuhteriService
  {
      List<muhteri> GetAll();
      muhteri GetById(int id);
      void Add(muhteri entity);
      void Update(muhteri entity);
      void Delete(muhteri entity);
  }
}
