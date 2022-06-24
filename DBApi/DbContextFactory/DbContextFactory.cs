using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DBApi
{
    public class DbContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {

        public RepositoryContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RepositoryContext>();
            optionsBuilder.UseSqlServer("Data Source=SV-APP-014\\IMOSSQL2016;Initial Catalog=FirstDB;Integrated Security=True;User ID=;Password=");

            return new RepositoryContext(optionsBuilder.Options);
        }

    }
}
