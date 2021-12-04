using Strategy.MessageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Message
{

    internal interface IMessage
    {
        IMessageTypes MessageTypes { get; set; }

        void Send();
    }
}
