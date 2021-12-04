using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.MessageTypes
{
    internal class Facebook : IFacebook
    {
        public void Send()
        {
            Console.WriteLine("This is the message");
        }
    }
}
