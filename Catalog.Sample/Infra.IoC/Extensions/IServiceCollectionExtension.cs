using Catalog.Sample.Domain.Core.Entity;
using Catalog.Sample.Infra.Repository.EntityFramework;
using Liquid.Repository.EntityFramework.Extensions;
using Microsoft.EntityFrameworkCore;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IServiceCollectionExtension
    {
        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            Action<DbContextOptionsBuilder> options = (opt) => opt.UseInMemoryDatabase("CRUD");

            services.AddLiquidEntityFramework<MyDbContext, Product, int>(options);

            return services;
        }

        private static IServiceCollection AddEventProducers(this IServiceCollection services)
        {
            return services;
        }

        private static IServiceCollection AddEventConsumers(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .AddDomainServices()
                .AddRepositories()
                .AddEventConsumers()
                .AddEventProducers();
        }
    }
}