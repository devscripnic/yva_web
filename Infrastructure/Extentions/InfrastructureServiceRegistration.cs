
using Domain.Repository;
using Infrastructure.Database;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extentions;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "";

        services.AddDbContext<YvaDbContext>(options =>
        options.UseNpgsql(DatabaseSettings.FromEnvironment(env).GetConnectionString()));

        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}
