using MongoDB.Driver;
using StockService.Models;

namespace StockService.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly IMongoCollection<Stock> _stocks;

        public StockRepository(IMongoDatabase database)
        {
            _stocks = database.GetCollection<Stock>("Stocks");
        }

        public async Task<Stock> GetStockByProductIdAsync(string productId)
        {
            return await _stocks.Find(s => s.ProductId == productId).FirstOrDefaultAsync();
        }

        public async Task UpdateStockAsync(string productId, int quantity)
        {
            var update = Builders<Stock>.Update.Set(s => s.Quantity, quantity);
            await _stocks.UpdateOneAsync(s => s.ProductId == productId, update);
        }
    }
}
