using Observer.ObserverFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Observer.SubjectFiles
{
    internal class MailBox : IMailBox
    {
        public List<IObserver> Observers { get; set; }

        public MailBox()
        {
            Observers = new List<IObserver>();
        }

        public void notifyObservers(string message)
        {
            foreach (var observer in Observers)
            {
                observer.Update(message);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void UnRegisterObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void CreateTimer()
        {
            var timer = new System.Timers.Timer(5000); 
            timer.Elapsed += HandleTimerElapsed;

            timer.AutoReset = true;

            timer.Enabled = true;

            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.ReadLine();

        }

        public void HandleTimerElapsed(object sender, ElapsedEventArgs e)
        {
            string message = "You have new email";
            notifyObservers(message);
        }
    }
}
