namespace MyCommerce.Models
{
    public class Customer
    {
        public int IdCustomer { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
