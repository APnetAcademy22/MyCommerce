using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Entities
{
    public class Customer
    {
        int IdCustomer { get; set; }
        string Email { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        DateTime BirthDate { get; set; }
    }
}
