using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockService.Services;

namespace StockService.Controllers
{
    [ApiController]
    [Route("api/stocks")]
    public class StockController : ControllerBase
    {
        private readonly IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> CheckStock(string productId)
        {
            var stock = await _stockService.GetStockByProductIdAsync(productId);
            if (stock == null) return NotFound();
            return Ok(stock);
        }

    }
}
