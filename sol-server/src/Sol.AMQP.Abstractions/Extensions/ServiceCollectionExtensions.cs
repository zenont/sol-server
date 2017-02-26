using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;

namespace Sol.AMQP.Abstractions.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAmqp(this IServiceCollection services, 
            IConnectionFactory connectionFactory, 
            Action<QueueManager> queueManagerAction)
        {
            var queueManager = new QueueManager(connectionFactory);
            queueManagerAction(queueManager);
            return services;
        }

        public static IServiceCollection AddAmqp(this IServiceCollection services, string hostName, Action<QueueManager> queueManagerAction)
        {
            var queueManager = new QueueManager(new ConnectionFactory { HostName = hostName });
            queueManagerAction(queueManager);
            return services;
        }
    }
}
