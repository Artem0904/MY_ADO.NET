using data_access1.Interfaces;

namespace HotelDb.Entities
{
    public class Country : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; } = new HashSet<City>();
    }
}
