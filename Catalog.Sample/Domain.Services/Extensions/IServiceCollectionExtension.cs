using MediatR;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            //RegisterCRUDS
            return services;
        }

        private static Assembly GetAssembly()
        {
            return typeof(IServiceCollectionExtension).Assembly;
        }
    }
}
