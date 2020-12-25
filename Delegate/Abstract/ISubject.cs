using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    public interface ISubject
    {
        void RegisterObserver(ParityChangedNotifyFunc parityChangedNotifyFunc);
        void UnregisteObserver(ParityChangedNotifyFunc parityChangedNotifyFunc);
        void NotifyObservers(Parity parity);
    }
}
