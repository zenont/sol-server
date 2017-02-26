using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Sol.AMQP.Abstractions
{
    public class QueueManager : IDisposable
    {
        public QueueManager(IConnectionFactory connectionFactory)
        {
            Connection = connectionFactory.CreateConnection();
            Channel = Connection.CreateModel();
        }

        public IConnection Connection { get; }

        public IModel Channel { get; }

        public void Declare(string queue,
            bool durable = false,
            bool exclusive = false,
            bool autoDelete = false,
            IDictionary<string, object> arguments = null)
        {
            Channel.QueueDeclare(queue,
                durable,
                exclusive,
                autoDelete,
                arguments);
        }

        public void Receive(string queue,
            Action<object, BasicDeliverEventArgs> receiverAction,
            bool noAck = true)
        {
            var consumer = new EventingBasicConsumer(Channel);
            consumer.Received += (model, ea) =>
            {
                receiverAction(model, ea);
            };
            Channel.BasicConsume(queue,
                                 noAck,
                                 consumer);
        }

        public void Dispose()
        {
            Channel.Dispose();
            Connection.Dispose();
        }
    }
}
