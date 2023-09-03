using data_access1.Interfaces;

namespace HotelDb.Entities
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Gmail { get; set; }
        public decimal Salary { get; set; }
        public int HotelId { get; set; }
        public int PositionId { get; set; }
        public Hotel Hotel { get; set; }
        public Position Position { get; set; }
    }
}
