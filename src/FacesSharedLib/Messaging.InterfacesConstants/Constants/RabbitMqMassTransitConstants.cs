using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.InterfacesConstants.Constants
{
    public class RabbitMqMassTransitConstants
    {
        public const string RABBIT_MQ_URI = "rabbitmq://rabbitmq:/";
        public const string Username = "guest";
        public const string Password = "guest";
        public const string REGISTER_ORDER_COMMAND_QUEUE = "register.order.command";

    }
}
