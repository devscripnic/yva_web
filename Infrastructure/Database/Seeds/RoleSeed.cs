using Microsoft.EntityFrameworkCore;
using Shared.Identity;

public static class RoleSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>().HasData(
            new Role
            {
                Id = RoleDefinitions.Admin.Id,
                Name = RoleDefinitions.Admin.Name
            },
            new Role
            {
                Id = RoleDefinitions.User.Id,
                Name = RoleDefinitions.User.Name
            }
        );
    }
}