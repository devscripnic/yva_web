using Microsoft.EntityFrameworkCore;

namespace Yva.Infrastructure
{
    public class YvaDbContext : DbContext
    {
        public YvaDbContext(DbContextOptions<YvaDbContext> options)
            : base(options)
        {
        }
    }
}