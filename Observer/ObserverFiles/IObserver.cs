using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.ObserverFiles
{
    public interface IObserver
    {
        public void Update(string message);
    }
}
