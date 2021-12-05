using Observer.SubjectFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.ObserverFiles
{
    public class MailBoxWatcher
    {
        MailBox Email = new MailBox();

        public void Update()
        {
            Email.CreateTimer();
        }
    }
}
