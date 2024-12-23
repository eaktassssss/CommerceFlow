using ShippingService.Models;

namespace ShippingService.Services
{
    public class ShippingService : IShippingService
    {
        public async Task<string> ScheduleDeliveryAsync(Shipment shipment)
        {
            shipment.ScheduledAt = DateTime.UtcNow;
            // Teslimat planlama mantığı
            return await Task.FromResult("Scheduled");
        }
    }

}
