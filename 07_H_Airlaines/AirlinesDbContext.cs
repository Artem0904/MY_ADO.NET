using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _07_H_Airlaines.AirlinesDbContext;

namespace _07_H_Airlaines
{
    internal class AirlinesDbContext : DbContext
    {
        public class Airplane
        {
            public int Id { get; set; }
            public string Type { get; set; }
            public int CountPassengers { get; set; }
            public string Country { get; set; }

            public virtual ICollection<Flight> Flightrs { get; set; } = new HashSet<Flight>();
            
        }
        //Відправлення(Flights) - номер, літак, клієнти, дата відправки/прибуття, місце
        //відправлення/прибуття
        //• Клієнти(Clients) - ім'я, прізвище, пошта, стать, акаунт
        //• Акаунти(Accounts) - логін, пароль

        public class Flight
        {
            public int Id { get; set; }
            public string Number { get; set; }
            public int AirplaneId { get; set; }
            public DateTime DepartureDate { get; set; }
            public DateTime ArrivalDate { get; set; }
            public string DeparturePlace { get; set; }
            public string ArrivalPlace { get; set; }

            public Airplane Airplane { get; set; }

        }

        public class Account
        {
            public int Id { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
            public int ClientId { get; set; }

            public Client Client { get; set; }
        }

        public class Client
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Gmail { get; set; }
            public bool isMale { get; set; }
            public int AccountId { get; set; }
            
            public Account Account { get; set; } 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string conn = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Shop; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            optionsBuilder.UseSqlServer(conn);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new CategoryConfigs());
            //modelBuilder.ApplyConfiguration(new CityConfigs());
            //modelBuilder.ApplyConfiguration(new CountryConfigs());
            //modelBuilder.ApplyConfiguration(new PositionConfigs());



            //// data initialization
            //modelBuilder.SeedData();


        }

        //public DbSet<>  { get; set; }
        //public DbSet<>  { get; set; }
        //public DbSet<>  { get; set; }
        //public DbSet<>  { get; set; }
    }
}
