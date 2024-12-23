namespace PaymentService.Models
{
    public class Payment
    {
        public string OrderId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; } // Pending, Completed, Failed
    }

}
