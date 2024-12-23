using StockService.Models;

namespace StockService.Repository
{
    public interface IStockRepository
    {
        Task<Stock> GetStockByProductIdAsync(string productId);
        Task UpdateStockAsync(string productId, int quantity);
    }
}
