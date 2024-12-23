using MongoDB.Driver;
using PaymentService.Models;

namespace PaymentService.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly IMongoCollection<Payment> _payments;

        public PaymentRepository(IMongoDatabase database)
        {
            _payments = database.GetCollection<Payment>("Payments");
        }

        public async Task AddAsync(Payment payment)
        {
            await _payments.InsertOneAsync(payment);
        }

        public async Task<Payment> GetByOrderIdAsync(string orderId)
        {
            return await _payments.Find(p => p.OrderId == orderId).FirstOrDefaultAsync();
        }
    }

}
