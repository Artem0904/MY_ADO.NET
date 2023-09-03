using data_access1.Interfaces;

namespace HotelDb.Entities
{
    public class City : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Hotel> Hotels { get; set; } = new HashSet<Hotel>();

    }
}
