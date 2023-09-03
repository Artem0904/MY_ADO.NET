using data_access1.Interfaces;

namespace HotelDb.Entities
{
    public class Visitor : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public int HotelRoomId { get; set; }
        public HotelRoom HotelRoom { get; set; }

    }
}
