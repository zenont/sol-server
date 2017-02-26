using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using RabbitMQ.Client;

namespace Sol.AMQP.Abstractions.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder SetUpAMQP(this IApplicationBuilder app, ConnectionFactory connectionFactory, Action<QueueManager> queueManagerAction)
        {
            var queueManager = new QueueManager(connectionFactory);
            queueManagerAction(queueManager);
            return app;
        }

        public static IApplicationBuilder DeclareQueue(this IApplicationBuilder app,
            ConnectionFactory connectionFactory,
            string queue,
            bool durable = false,
            bool exclusive = false,
            bool autoDelete = false,
            IDictionary<string, object> arguments = null)
        {
            using (IConnection connection = connectionFactory.CreateConnection())
            using (IModel channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue,
                    durable,
                    exclusive,
                    autoDelete,
                    arguments);
            }

            return app;
        }

        public static IApplicationBuilder DeclareQueue(this IApplicationBuilder app, 
            string hostName, 
            string queue, 
            bool durable = false,
            bool exclusive = false,
            bool autoDelete = false,
            IDictionary<string, object> arguments = null)
        {
            ConnectionFactory factory = new ConnectionFactory { HostName = hostName };
            return app.DeclareQueue(factory, queue, durable, exclusive, autoDelete, arguments);
        }

        public static IApplicationBuilder ConsumeQueue(this IApplicationBuilder app,
            ConnectionFactory connectionFactory,
            string queue,
            bool durable = false,
            bool exclusive = false,
            bool autoDelete = false,
            IDictionary<string, object> arguments = null)
        {
            app = app.DeclareQueue(connectionFactory, queue, durable, exclusive, autoDelete, arguments);



            return app;
        }
    }
}
