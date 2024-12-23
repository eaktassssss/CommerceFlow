using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShippingService.Models;
using ShippingService.Services;

namespace ShippingService.Controllers
{
    [ApiController]
    [Route("api/shipping")]
    public class ShippingController : ControllerBase
    {
        private readonly IShippingService _shippingService;

        public ShippingController(IShippingService shippingService)
        {
            _shippingService = shippingService;
        }

        [HttpPost]
        public async Task<IActionResult> ScheduleDelivery([FromBody] Shipment shipment)
        {
            var result = await _shippingService.ScheduleDeliveryAsync(shipment);
            return Ok(result);
        }
    }

}
