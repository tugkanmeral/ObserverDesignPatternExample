using System;
using System.Collections.Generic;
using System.Text;

namespace Classic
{
    public interface ISubject
    {
        List<IObserver> ObserverCollection { get; set; }
        void RegisterObserver(IObserver subscriber);
        void UnregisterObserver(IObserver subscriber);
        void NotifyObservers(Parity parity);
    }
}
