using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblkategoriManager : ItblkategoriService
  {
      ItblkategoriDal _tblkategoriDal;
      public tblkategoriManager(ItblkategoriDal tblkategoriService)
      {
          _tblkategoriDal = tblkategoriService;
      }
      public void Add(tblkategori entity)
      {
           _tblkategoriDal.Insert(entity);
      }
       public void Delete(tblkategori entity)
      {
           _tblkategoriDal.Delete(entity);
      }
      public List<tblkategori> GetAll()
      {
          return _tblkategoriDal.GetList();
      }
      public tblkategori GetById(int id)
      {
          return _tblkategoriDal.Get(x => x.Id == id);
      }
      public void Update(tblkategori entity)
      {
          _tblkategoriDal.Update(entity);
      }
  }
}
