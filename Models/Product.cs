namespace NorthwindMVC.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInstock { get; set; }
        public string CategoryName { get; set; }
        public string Supplier { get; set; }
   
    }
}
