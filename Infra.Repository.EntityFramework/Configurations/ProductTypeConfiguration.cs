using Catalog.Sample.Domain.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Sample.Infra.Repository.EntityFramework.Configurations
{
    class ProductTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(o => o.Name).HasMaxLength(50).IsRequired();
            builder.Property(o => o.Price).IsRequired();
        }
    }
}
