using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotificationService.Models;

namespace NotificationService.Controllers
{
    [ApiController]
    [Route("api/notifications")]
    public class NotificationController : ControllerBase
    {
        [HttpPost]
        public IActionResult SendNotification([FromBody] Notification notification)
        {
            Console.WriteLine($"Bildirim gönderildi: {notification.Message}");
            return Ok("Notification Sent");
        }
    }
}
