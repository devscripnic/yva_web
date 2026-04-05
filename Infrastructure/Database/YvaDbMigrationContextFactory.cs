using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Yva.Infrastructure;

public class YvaDbMigrationContextFactory : IDesignTimeDbContextFactory<YvaDbContext>
{
    public YvaDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<YvaDbContext>();
        optionsBuilder.UseNpgsql(DatabaseSettings.FromEnvironment("Development").GetConnectionString());

        return new YvaDbContext(optionsBuilder.Options);
    }
}