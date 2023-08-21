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

            // data initialization
            modelBuilder.Entity<Position>().HasData(new[]
            {
                new Position() { Id = 1, Name = "Manager" },
                new Position() { Id = 2, Name = "Consultant" },
                new Position() { Id = 3, Name = "Cashier" },
                new Position() { Id = 4, Name = "SecurityGuard" }
            });

            modelBuilder.Entity<Country>().HasData(new Country[]
            {
                new() { Id = 1, Name = "Ukraine" },
                new() { Id = 2, Name = "Germany" },
                new() { Id = 3, Name = "Poland" }
            });

            modelBuilder.Entity<City>().HasData(new City[]
            {
                new() { Id = 1, Name = "Rivne", CountryId = 1 },
                new() { Id = 2, Name = "Berlin", CountryId = 2 },
                new() { Id = 3, Name = "Warsaw", CountryId = 3 }
            });

            modelBuilder.Entity<Shop>().HasData(new Shop[]
            {
                new() { Id = 1, Name = "ATB", Adress = "Bogoyavlenska", CityId = 1, ParkingArea = 20 },
                new() { Id = 2, Name = "Adolfik", Adress = "Germansky 56", CityId = 2 },
                new() { Id = 3, Name = "Lidl", Adress = "Lidlovska 2", CityId = 3, ParkingArea = 50 }
            });

            modelBuilder.Entity<Worker>().HasData(new Worker[]
            {
                new() {Id = 1, Name = "Vitalik", Surname = "Vitaliev", Salary = 3000, Gmail = "vitalka325@gmail.com", PhoneNumber = "+380 68 735 9273", PositionId = 2, ShopId = 1},
                new() {Id = 1, Name = "Vitya", Surname = "Vityovich", Salary = 5000, Gmail = "viktor523@gmail.com", PhoneNumber = "+380 66 734 9273", PositionId = 1, ShopId = 2},
                new() {Id = 1, Name = "Sashka", Surname = "Sanych", Salary = 1500, Gmail = "sasha235@gmail.com", PhoneNumber = "+380 97 435 9273", PositionId = 3, ShopId = 3}
            });

            modelBuilder.Entity<Category>().HasData(new Category[]
            {
                new() { Id = 1, Name = "Products" },
                new() { Id = 2, Name = "Artistic" },
                new() { Id = 3, Name = "Technical" }
            });

            modelBuilder.Entity<Product>().HasData(new Product[]
           {
                new() { Id = 1, Name = "Bread", Price = 30, Discount = 2.5f , Quantity = 50, IsInStock = true, CategoryId = 1   },
                new() { Id = 1, Name = "Easel", Price = 300, Discount = 6.5f , Quantity = 10, IsInStock = true, CategoryId = 2   },
                new() { Id = 1, Name = "Smartphone", Price = 6000, Discount = 3.5f , Quantity = 15, IsInStock = true, CategoryId = 3  }
                
           });
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
