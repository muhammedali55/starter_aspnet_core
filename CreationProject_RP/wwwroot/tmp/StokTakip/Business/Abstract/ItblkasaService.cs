using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblkasaService
  {
      List<tblkasa> GetAll();
      TbleniyilerHomedesign GetById(int id);
      void Add(TbleniyilerHomedesign entity);
      void Update(TbleniyilerHomedesign entity);
      void Delete(TbleniyilerHomedesign entity);
      void DeleteList(List<TbleniyilerHomedesign> list);
  }
}
