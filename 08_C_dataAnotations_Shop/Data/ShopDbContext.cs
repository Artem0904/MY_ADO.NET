using _08_C_dataAnotations_Shop.Data.Configurations;
using _08_C_dataAnotations_Shop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_C_dataAnotations_Shop
{

    internal class ShopDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string conn = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Shop; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            optionsBuilder.UseSqlServer(conn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CategoryConfigs());
            modelBuilder.ApplyConfiguration(new CityConfigs());
            modelBuilder.ApplyConfiguration(new CountryConfigs());
            modelBuilder.ApplyConfiguration(new PositionConfigs());
            modelBuilder.ApplyConfiguration(new ProductConfigs());
            modelBuilder.ApplyConfiguration(new ShopConfigs());
            modelBuilder.ApplyConfiguration(new WorkerConfigs());


            // data initialization
            modelBuilder.SeedData();


        }

        public DbSet<Position> Positions { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
