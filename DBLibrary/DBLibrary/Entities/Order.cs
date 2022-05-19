using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Entities
{
    public class Order
    {
        public int IdOrder { get; set; }
        public int IdCustomer { get; set; }
        public string C8 { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}
