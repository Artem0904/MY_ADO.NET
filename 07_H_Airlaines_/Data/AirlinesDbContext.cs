using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _07_H_Airlines.Data
{

    internal class AirlinesDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string conn = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AirlinesDb; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            optionsBuilder.UseSqlServer(conn);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new CategoryConfigs());
            //modelBuilder.ApplyConfiguration(new CityConfigs());
            //modelBuilder.ApplyConfiguration(new CountryConfigs());
            //modelBuilder.ApplyConfiguration(new PositionConfigs());
            //modelBuilder.ApplyConfiguration(new ProductConfigs());
            //modelBuilder.ApplyConfiguration(new ShopConfigs());
            //modelBuilder.ApplyConfiguration(new WorkerConfigs());


            // data initialization
            //modelBuilder.SeedData();


        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Flight> Flights { get; set; }
    }
}
