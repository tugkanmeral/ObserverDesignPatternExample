using System;
using System.Collections.Generic;

namespace DotNet
{
    internal class Unsubscriber<T> : IDisposable
    {
        private List<IObserver<Parity>> observers;
        private IObserver<Parity> observer;

        public Unsubscriber(List<IObserver<Parity>> observers, IObserver<Parity> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        public void Dispose()
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }
    }
}