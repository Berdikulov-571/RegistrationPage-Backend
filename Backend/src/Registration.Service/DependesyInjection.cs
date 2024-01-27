using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Registration.Service
{
    public static class DependesyInjection 
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}