using System;

namespace NorthwindMVC.Models
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public decimal ShippingFee { get; set; }
    }
}
