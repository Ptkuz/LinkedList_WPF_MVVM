using Microsoft.Extensions.DependencyInjection;
using LinkedList.Services.Interfaces;

namespace LinkedList.Services
{
    internal static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
            => services
            .AddTransient<IListCompletion<string>, ListCompletion<string>>()
            ;
            
    }
}
