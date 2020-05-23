using Microsoft.EntityFrameworkCore;
namespace Entity.Entities
{
  public partial class DBMusteriContext : DbContext
  {
      public DBMusteriContext()
      {
      }
      public DBMusteriContext(DbContextOptions<DBMusteriContext> options): base(options)
      {
      }

       public virtual DbSet<tblmusteri> tblmusteri { get; set; }
       public virtual DbSet<tblurun> tblurun { get; set; }
       public virtual DbSet<tblfirma> tblfirma { get; set; }
       public virtual DbSet<tblarac> tblarac { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
          if (!optionsBuilder.IsConfigured)
          {
              optionsBuilder.UseSqlServer("Server=.; Database=DBMusteri; Trusted_Connection = True; ");
          }
      }
  }
}
