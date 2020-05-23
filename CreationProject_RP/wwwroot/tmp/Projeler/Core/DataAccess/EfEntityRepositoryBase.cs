using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace Core.DataAccess
{
  public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
  {
      public void Delete(TEntity entity)
      {
          using (var context = new TContext() ) {
              var delete = context.Entry(entity);
              delete.State = EntityState.Deleted;
              context.SaveChanges();
          }
      }
      public TEntity Get(Expression<Func<TEntity, bool>> filter)
      {
          using (var context = new TContext()) {
              return context.Set<TEntity>().SingleOrDefaultAsync(filter).Result;
          }
      }
      public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
      {
          using (var context = new TContext()) {
              return filter == null
                  ? context.Set<TEntity>().ToListAsync().Result
                  : context.Set<TEntity>().Where(filter).ToList();
          }
      }
      public void Insert(TEntity entity)
      {
          using (var context = new TContext() ) {
              var insert = context.Entry(entity);
              insert.State = EntityState.Added;
              context.SaveChanges();
          }
      }
      public void Update(TEntity entity)
      {
          using (var context = new TContext() ) {
              var update = context.Entry(entity);
              update.State = EntityState.Modified;
              context.SaveChanges();
          }
      }
  }
}
