using Infrastructure.Database.Tables;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database;

public class YvaDbContext : DbContext
{
    public YvaDbContext(DbContextOptions<YvaDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(YvaDbContext).Assembly);

        RoleSeed.Seed(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }
}
