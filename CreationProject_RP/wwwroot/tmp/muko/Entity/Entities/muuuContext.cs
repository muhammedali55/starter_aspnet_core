using Microsoft.EntityFrameworkCore;
namespace Entity.Entities
{
  public partial class muuuContext : DbContext
  {
      public muuuContext()
      {
      }
      public muuuContext(DbContextOptions<muuuContext> options): base(options)
      {
      }

       public virtual DbSet<muhteri> muhteri { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
          if (!optionsBuilder.IsConfigured)
          {
              optionsBuilder.UseSqlServer("Server=.; Database=muk; Trusted_Connection = True; ");
          }
      }
  }
}
