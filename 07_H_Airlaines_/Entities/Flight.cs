using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_H_Airlines
{
    public class Flight
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime ArivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int AirplaneId { get; set; }
        public Airplane Airplane { get; set; }
        public int CityArivalId { get; set; }
        public City ArivalCity { get; set; }
        public int CityDepartureId { get; set; }
        public City DepartureCity { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}
