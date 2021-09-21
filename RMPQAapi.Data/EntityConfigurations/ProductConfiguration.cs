using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMPQAapi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMPQAapi.Data.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(product => product.Id);

            builder.HasIndex(product => product.OwnerId).IsUnique();

            builder.Property(product => product.Number).HasMaxLength(100).IsRequired();
            builder.Property(product => product.Image).HasMaxLength(100);
        }
    }
}
