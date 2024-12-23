using RabbitMQ.Client;
using System.Text;


namespace SharedLibraries
{
    public class EventBus
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;

        public EventBus(string hostName)
        {
            var factory = new ConnectionFactory() { HostName = hostName };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
        }

        public void Publish(string queueName, string message)
        {
            _channel.QueueDeclare(queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);

            var body = Encoding.UTF8.GetBytes(message);
            _channel.BasicPublish(exchange: "", routingKey: queueName, basicProperties: null, body: body);
        }
    }
}


