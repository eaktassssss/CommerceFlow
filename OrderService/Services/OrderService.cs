using OrderService.Models;
using OrderService.Repositories;
using SharedLibraries;


namespace OrderService.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;
        private readonly IMessagePublisher _messagePublisher;

        public OrderService(IOrderRepository repository, IMessagePublisher messagePublisher)
        {
            _repository = repository;
            _messagePublisher = messagePublisher;
        }

        public async Task<Order> CreateOrderAsync(Order order)
        {
            order.Status = "Created";
            order.CreatedAt = DateTime.UtcNow;

            await _repository.AddAsync(order);

            await _messagePublisher.PublishAsync("OrderCreated", new { order.Id, order.Items });
            return order;
        }

        public async Task<Order> GetOrderByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }

}
