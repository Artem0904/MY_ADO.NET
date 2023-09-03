using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_H_Airlines
{
    public class Airplane
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int MaxCountPass { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Flight> Flights { get; set; }
    }
}