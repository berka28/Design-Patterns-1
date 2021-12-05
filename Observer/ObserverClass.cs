using Observer.ObserverFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ObserverClass
    {
        internal static void Run()
        {

            MailBoxWatcher emailObserver = new MailBoxWatcher();
            Console.WriteLine("Observer");
            emailObserver.Update();

        }

    }
}
