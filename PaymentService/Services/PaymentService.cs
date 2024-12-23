using PaymentService.Models;
using PaymentService.Repositories;

namespace PaymentService.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _repository;

        public PaymentService(IPaymentRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> ProcessPaymentAsync(Payment payment)
        {
            payment.Status = "Completed";
            await _repository.AddAsync(payment);
            return payment.Status;
        }
    }

}
