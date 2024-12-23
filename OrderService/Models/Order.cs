namespace OrderService.Models
{
    public class Order
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public List<OrderItem> Items { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
