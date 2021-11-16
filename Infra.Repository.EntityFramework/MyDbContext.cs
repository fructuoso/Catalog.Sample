using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Catalog.Sample.Infra.Repository.EntityFramework{
    public class MyDbContext : DbContext
    {
        protected MyDbContext() : base() { }
        public MyDbContext([NotNull] DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
