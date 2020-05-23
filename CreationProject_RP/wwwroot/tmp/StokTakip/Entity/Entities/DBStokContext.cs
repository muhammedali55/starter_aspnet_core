using Microsoft.EntityFrameworkCore;
namespace Entity.Entities
{
  public partial class DBStokContext : DbContext
  {
      public DBStokContext()
      {
      }
      public DBStokContext(DbContextOptions<DBStokContext> options): base(options)
      {
      }

       public virtual DbSet<tblstok> tblstok { get; set; }
       public virtual DbSet<tblmusteri> tblmusteri { get; set; }
       public virtual DbSet<tblurun> tblurun { get; set; }
       public virtual DbSet<tblfirma> tblfirma { get; set; }
       public virtual DbSet<tblmuhasebe> tblmuhasebe { get; set; }
       public virtual DbSet<tblpersonel> tblpersonel { get; set; }
       public virtual DbSet<tblsatis> tblsatis { get; set; }
       public virtual DbSet<tblodeme> tblodeme { get; set; }
       public virtual DbSet<tblkasa> tblkasa { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
          if (!optionsBuilder.IsConfigured)
          {
              optionsBuilder.UseSqlServer("Server=.; Database=DBStok; Trusted_Connection = True; ");
          }
      }
  }
}
