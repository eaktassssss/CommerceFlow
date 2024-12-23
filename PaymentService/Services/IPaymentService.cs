using PaymentService.Models;

namespace PaymentService.Services
{
    public interface IPaymentService
    {
        Task<string> ProcessPaymentAsync(Payment payment);
    }

}
