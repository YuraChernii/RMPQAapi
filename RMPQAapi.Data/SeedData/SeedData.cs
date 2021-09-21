using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMPQAapi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMPQAapi.Data.SeedData
{
    internal static class SeedData
    {
        internal static void Seed(this ModelBuilder builder)
        {
            SeedProducts(builder.Entity<Product>());
        }

        internal static void SeedProducts(EntityTypeBuilder<Product> builder) =>
            builder.HasData(
                new Product()
                {
                    Id = 1,
                    OwnerId = 123,
                    Number = "Yura",
                    Image = "lala"
                },
                new Product()
                {
                    Id = 2,
                    OwnerId = 321,
                    Number = "Yura2",
                    Image = "lala2"
                });
                
    }
}
