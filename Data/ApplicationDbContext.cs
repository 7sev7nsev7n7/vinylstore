using Microsoft.EntityFrameworkCore;
using RecordStoreWebApi.Entities;

namespace RecordStoreWebApi.Data
{
  public class ApplicationDbContext : DbContext
  {
    public DbSet<Vinyl> vinyls { get; set; }

    public ApplicationDbContext(DbContextOptions options): base(options)
    {
    }
  }
}
