using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_H_Airlines
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gmail { get; set; }
        public bool IsMale { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public ICollection<Flight> Flights { get; set; }
    }
}
