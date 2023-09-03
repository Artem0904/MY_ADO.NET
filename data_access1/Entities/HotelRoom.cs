using data_access1.Interfaces;

namespace HotelDb.Entities
{
    public class HotelRoom : IEntity
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public bool IsVip { get; set; }
        public int CountVisitors { get; set; }
        public decimal PriceForDay { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public ICollection<Visitor> Visitors { get; set; } = new HashSet<Visitor>();
    }
}
