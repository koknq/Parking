using DBApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DBApi
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
           :base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Parking> Parking { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            //modelBuilder.Entity<Car>().HasNoKey();
        }

    }
}
