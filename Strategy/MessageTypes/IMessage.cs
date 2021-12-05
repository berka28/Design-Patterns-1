using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.MessageTypes
{
    public interface IMessage
    {
        public void SendMessage(string message);
    }
}
