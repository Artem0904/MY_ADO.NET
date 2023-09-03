using data_access1.Repositories;
using HotelDb.Data;
using HotelDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Repositories
{
    public interface IUoW
    {
        Repository<City> CityRepo { get; }
        Repository<Country> CountryRepo { get; }
        Repository<Employee> EmployeeRepo { get; }
        Repository<Hotel> HotelRepo { get; }
        Repository<HotelRoom> HotelRoomRepo { get; }
        Repository<Position> PositionRepo { get; }
        Repository<Visitor> VisitorRepo { get; }
        

        void Save();
    }
    public class UnitOfWork : IUoW, IDisposable
    {
        private static HotelDbContext context = new HotelDbContext();
        private Repository<City> cityRepo;
        private Repository<Country> countryRepo;
        private Repository<Employee> employeeRepo;
        private Repository<Hotel> hotelRepo;
        private Repository<HotelRoom> hotelRoomRepo;
        private Repository<Position> positionRepo;
        private Repository<Visitor> visitorRepo;


        public Repository<City> CityRepo
        {
            get
            {
                if (this.cityRepo == null)
                {
                    this.cityRepo = new Repository<City>(context);
                }
                return cityRepo;
            }
        }

        public Repository<Country> CountryRepo
        {
            get
            {

                if (this.countryRepo == null)
                {
                    this.countryRepo = new Repository<Country>(context);
                }
                return countryRepo;
            }
        }

        public Repository<Employee> EmployeeRepo
        {
            get
            {

                if (this.employeeRepo == null)
                {
                    this.employeeRepo = new Repository<Employee>(context);
                }
                return employeeRepo;
            }
        }

        public Repository<Hotel> HotelRepo
        {
            get
            {

                if (this.hotelRepo == null)
                {
                    this.hotelRepo = new Repository<Hotel>(context);
                }
                return hotelRepo;
            }
        }
        public Repository<HotelRoom> HotelRoomRepo
        {
            get
            {

                if (this.hotelRoomRepo == null)
                {
                    this.hotelRoomRepo = new Repository<HotelRoom>(context);
                }
                return hotelRoomRepo;
            }
        }
        public Repository<Position> PositionRepo
        {
            get
            {

                if (this.positionRepo == null)
                {
                    this.positionRepo = new Repository<Position>(context);
                }
                return positionRepo;
            }
        }
        public Repository<Visitor> VisitorRepo
        {
            get
            {

                if (this.visitorRepo == null)
                {
                    this.visitorRepo = new Repository<Visitor>(context);
                }
                return visitorRepo;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
