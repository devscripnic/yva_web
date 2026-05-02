using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Database;

// This factory is used by Entity Framework Core at design time (e.g. when running migrations).
// It allows EF tools to create the DbContext without relying on the application's dependency injection container.
// This is especially useful in Clean Architecture solutions where the DbContext is configured in a separate project.
public class YvaDbMigrationContextFactory : IDesignTimeDbContextFactory<YvaDbContext>
{
    public YvaDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<YvaDbContext>();
        
        var Host = Environment.GetEnvironmentVariable("DB_HOST") ?? throw new Exception("DB_HOST is not set");;
        var Database = Environment.GetEnvironmentVariable("DB_NAME") ?? throw new Exception("DB_NAME is not set");
        var Username = Environment.GetEnvironmentVariable("DB_ADMIN") ?? throw new Exception("DB_ADMIN is not set");
;
        var Password = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? throw new Exception("DB_PASSWORD is not set");;

        optionsBuilder.UseNpgsql($"Host={Host};Database={Database};Username={Username};Password={Password}");

        return new YvaDbContext(optionsBuilder.Options);
    }
}