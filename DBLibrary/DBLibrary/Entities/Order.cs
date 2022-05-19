using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Entities
{
    public class Order
    {
        int IdOrder { get; set; }
        int IdCustomer { get; set; }
        string C8 { get; set; }
        DateTime Date { get; set; }
        decimal Price { get; set; }
    }
}
