namespace SOLID.Shared.Models
{
    public class OrderItem
    {
        public string Identifier { get; set; }
        public string SKU { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
