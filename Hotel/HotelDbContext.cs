using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }




    internal class HotelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //optionsBuilder.UseLazyLoadingProxies();

            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(conn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ---------------- FluentAPI Configurations
            //modelBuilder.ApplyConfiguration(new EmployeeConfigs());

            // data initialization
            //DbExtensions.SeedData(modelBuilder);
            //modelBuilder.SeedData();
        }

        // Object Collections (Tables in SQL)
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<Position> Positions { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<Dish> Dishes { get; set; }
        //public DbSet<Resume> Resumes { get; set; }
    }
}
