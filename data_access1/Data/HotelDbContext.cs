using data_access1.Data;
using HotelDb.Data.Configurations;
using HotelDb.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDb.Data
{

    public class HotelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(conn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

            // ---------------- FluentAPI Configurations
            modelBuilder.ApplyConfiguration(new CityConfigs());
            modelBuilder.ApplyConfiguration(new CountryConfigs());
            modelBuilder.ApplyConfiguration(new EmployeeConfigs());
            modelBuilder.ApplyConfiguration(new HotelConfigs());
            modelBuilder.ApplyConfiguration(new HotelRoomConfigs());
            modelBuilder.ApplyConfiguration(new PositionConfigs());
            modelBuilder.ApplyConfiguration(new VisitorsConfigs());

            // data initialization
            //DbExtensions.SeedData(modelBuilder);
            modelBuilder.SeedData();
        }

        // Object Collections (Tables in SQL)
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
