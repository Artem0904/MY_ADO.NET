using data_access1.Interfaces;

namespace HotelDb.Entities
{
    public class Hotel : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string ContactNumber { get; set; }
        public string Description { get; set; }
        public int Stars { get; set; }
        public int CountHotelRooms { get; set; }
        public int CityId { get; set; }
        public City City { set; get; }
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
        public ICollection<HotelRoom> HotelRooms { get; set; } = new HashSet<HotelRoom>();

    }
}
