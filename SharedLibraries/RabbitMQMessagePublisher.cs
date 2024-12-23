using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SharedLibraries
{
    public class RabbitMQMessagePublisher : IMessagePublisher
    {
        private readonly EventBus _eventBus;

        public RabbitMQMessagePublisher(EventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public async Task PublishAsync(string eventName, object data)
        {
            var message = JsonSerializer.Serialize(new { EventName = eventName, Data = data });
            _eventBus.Publish(eventName, message);
            await Task.CompletedTask;
        }
    }

}
