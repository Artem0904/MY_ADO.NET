using data_access1.Interfaces;

namespace HotelDb.Entities
{
    public class Position : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

    }
}
