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
        public static IApplicationBuilder SetUpAmqp(this IApplicationBuilder app, ConnectionFactory connectionFactory, Action<QueueManager> queueManagerAction)
        {
            var queueManager = new QueueManager(connectionFactory);
            queueManagerAction(queueManager);
            return app;
        }

        public static IApplicationBuilder SetUpAmqp(this IApplicationBuilder app, string hostName, Action<QueueManager> queueManagerAction)
        {
            var queueManager = new QueueManager(new ConnectionFactory {HostName = hostName});
            queueManagerAction(queueManager);
            return app;
        }
    }
}
