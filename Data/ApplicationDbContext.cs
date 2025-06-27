using Microsoft.EntityFrameworkCore;
using RecordStoreWebApi.Entities;

namespace RecordStoreWebApi.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions options): base(options)
    {
    }

    public DbSet<Vinyl> vinyls { get; set; }
  }
}
