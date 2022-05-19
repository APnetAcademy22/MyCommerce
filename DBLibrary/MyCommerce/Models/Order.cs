namespace MyCommerce.Models
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
