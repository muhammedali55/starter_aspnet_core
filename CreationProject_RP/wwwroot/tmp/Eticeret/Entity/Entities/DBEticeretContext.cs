using Microsoft.EntityFrameworkCore;
namespace Entity.Entities
{
  public partial class DBEticeretContext : DbContext
  {
      public DBEticeretContext()
      {
      }
      public DBEticeretContext(DbContextOptions<DBEticeretContext> options): base(options)
      {
      }

       public virtual DbSet<tblurun> tblurun { get; set; }
       public virtual DbSet<tblmusteri> tblmusteri { get; set; }
       public virtual DbSet<tblfirma> tblfirma { get; set; }
       public virtual DbSet<tblkargo> tblkargo { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
          if (!optionsBuilder.IsConfigured)
          {
              optionsBuilder.UseSqlServer("Server=.; Database=DBEticaret; Trusted_Connection = True; ");
          }
      }
  }
}
