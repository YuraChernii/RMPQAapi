using Microsoft.EntityFrameworkCore;
using RMPQAapi.Data.Entities;
using RMPQAapi.Data.EntityConfigurations;
using RMPQAapi.Data.SeedData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMPQAapi.Data.Context
{
    public class RMPQAapiContext : DbContext
    {
        public DbSet<Product>? Products { get; set; }

        public RMPQAapiContext(DbContextOptions<RMPQAapiContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.Seed();
        }
    }
}
