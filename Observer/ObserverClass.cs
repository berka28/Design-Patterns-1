using Observer.ObserverFiles;
using Observer.SubjectFiles;
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
            MailBox Email = new MailBox();

            MailBoxWatcher emailObserver = new MailBoxWatcher();
            Email.RegisterObserver(emailObserver);
            Email.CreateTimer();
            Console.WriteLine("Observer");

        }

    }
}
