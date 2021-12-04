using Strategy.MessageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Message
{
    internal class Message : IMessage
    {
        public IMessageTypes MessageTypes { get; set; }

        public void Send()
        {
            MessageTypes.Send();
        }
    }
}
