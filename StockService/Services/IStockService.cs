using StockService.Models;

namespace StockService.Services
{
    public interface IStockService
    {
        Task<Stock> GetStockByProductIdAsync(string productId);
    }

}
