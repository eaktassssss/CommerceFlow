using StockService.Models;
using StockService.Repository;

namespace StockService.Services
{
    public class StockService : IStockService
    {
        private readonly IStockRepository _repository;

        public StockService(IStockRepository repository)
        {
            _repository = repository;
        }

        public async Task<Stock> GetStockByProductIdAsync(string productId)
        {
            return await _repository.GetStockByProductIdAsync(productId);
        }
    }

}
