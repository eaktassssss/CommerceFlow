using ShippingService.Models;

namespace ShippingService.Services
{
    public interface IShippingService
    {
        Task<string> ScheduleDeliveryAsync(Shipment shipment);
    }

}
