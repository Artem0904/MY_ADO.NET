using System.ComponentModel.DataAnnotations;

namespace _07_H_Airlines
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Airplane> Airplanes { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}