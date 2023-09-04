using HotelDb.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access1.Data
{
    static class DbExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() { Id = 1, Name = "Ukraine"},
                new Country() { Id = 2, Name = "Germany"},
                new Country() { Id = 3, Name = "France"},
                new Country() { Id = 4, Name = "USA"}
                
            });

            modelBuilder.Entity<City>().HasData(new[]
            {
                new City() { Id = 1, Name = "Rivne", CountryId = 1},
                new City() { Id = 2, Name = "Berlin", CountryId = 2},
                new City() { Id = 3, Name = "Paris", CountryId = 3}
            });


            modelBuilder.Entity<Visitor>().HasData(new[]
            {
                new Visitor() { Id = 1, Name = "Den", Surname = "Deniv", PhoneNumber = "+380 97 354 1278", HotelRoomId = 1},
                new Visitor() { Id = 2, Name = "Vlad", Surname = "Vladov", PhoneNumber = "+380 68 250 2228", HotelRoomId = 2},
                new Visitor() { Id = 3, Name = "Gill", Surname = "Gillov", PhoneNumber = "+380 97 574 2118", HotelRoomId = 3}

            });

            modelBuilder.Entity<HotelRoom>().HasData(new[]
            {
                new HotelRoom() { Id = 1, Number = 1, IsVip = true, CountVisitors = 3, PriceForDay = 100, HotelId = 1},
                new HotelRoom() { Id = 2, Number = 2, IsVip = false, CountVisitors = 2, PriceForDay = 50, HotelId = 1},
                new HotelRoom() { Id = 3, Number = 3, IsVip = false, CountVisitors = 1, PriceForDay = 30, HotelId = 1}

            });
            modelBuilder.Entity<Hotel>().HasData(new[]
            {
                new Hotel() { Id = 1, Name = "SunSet", Adress = "Sun 12a", ContactNumber = "+380 97 234 1267", Description = "Cool hotel, 5 stars", Stars = 5, CountHotelRooms = 100, CityId = 1 },
                new Hotel() { Id = 2, Name = "SunRise", Adress = "Sunny 18a", ContactNumber = "+380 68 274 1247", Description = "Cool service, 4 stars", Stars = 4, CountHotelRooms = 70, CityId = 2 },
                new Hotel() { Id = 3, Name = "MoonRise", Adress = "Moon 12a", ContactNumber = "+380 44 224 6061", Description = "Great hotel, 5 stars", Stars = 5, CountHotelRooms = 120, CityId = 3 }

            });


            modelBuilder.Entity<Position>().HasData(new[]
            {
                new Position() { Id = 1, Name = "Boss"},
                new Position() { Id = 2, Name = "Manager"},
                new Position() { Id = 3, Name = "Doorman"}

            });


            modelBuilder.Entity<Employee>().HasData(new[]
            {
                new Employee() { Id = 1, Name = "Robert", Surname = "Robertov", PhoneNumber = "+380 97 077 2533", Gmail = "roberto1237@gmil.com", Salary = 3000, HotelId = 1, PositionId = 1},
                new Employee() { Id = 2, Name = "Vika", Surname = "Vivikivna", PhoneNumber = "+380 97 707 2323", Gmail = "vika17@gmil.com", Salary = 2000, HotelId = 1, PositionId = 2},
                new Employee() { Id = 3, Name = "Danya", Surname = "Dayiilovich", PhoneNumber = "+380 97 036 2632", Gmail = "danyil32@gmil.com", Salary = 1000, HotelId = 1, PositionId = 3}

            });
        }
    }
}
