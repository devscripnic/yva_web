
using Microsoft.Extensions.DependencyInjection;

namespace Application.ApplicationServiceRegistration;

    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }