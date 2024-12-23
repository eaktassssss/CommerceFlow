namespace ShippingService.Models
{
    public class Shipment
    {
        public string OrderId { get; set; }
        public string Address { get; set; }
        public DateTime ScheduledAt { get; set; }
    }

}
