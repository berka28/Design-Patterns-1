using Strategy.MessageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class MessageHandler : IMessageHandler
    {
        public IMessage Message { get; set; }

        public void SendMessage(string message)
        {
            Message.SendMessage(message);
        }
    }
}
