using Microsoft.EntityFrameworkCore;
namespace Entity.Entities
{
  public partial class DbMusteriContext : DbContext
  {
      public DbMusteriContext()
      {
      }
      public DbMusteriContext(DbContextOptions<DbMusteriContext> options): base(options)
      {
      }

       public virtual DbSet<tblmusteri> tblmusteri { get; set; }
       public virtual DbSet<tblurun> tblurun { get; set; }
       public virtual DbSet<tblfiyat> tblfiyat { get; set; }
       public virtual DbSet<tblfirma> tblfirma { get; set; }
       public virtual DbSet<tblkategori> tblkategori { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
          if (!optionsBuilder.IsConfigured)
          {
              optionsBuilder.UseSqlServer("Server=.; Database=DbMusteri; Trusted_Connection = True; ");
          }
      }
  }
}
