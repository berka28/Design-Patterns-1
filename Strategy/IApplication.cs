using Strategy.Message;
using Strategy.MessageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal interface IApplication
    {
        IMessage Message  { get; set; }

        IMessageTypes Email { get; set; }

        IMessageTypes Facebook { get; set; }

        IMessageTypes SMS { get; set; }

        void Run();
    }
}
