using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access
{
    public class Sale
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int SellerId { get; set; }
        public decimal SumSale { get; set; }
        public string DateSale { get; set; }
    }
}
