using System;
using System.Collections.Generic;
using System.Text;

namespace Classic
{
    public delegate void NotifyFunc();
    public class Bank : ISubject
    {
        public List<IObserver> ObserverCollection { get; set; }

        private Parity parity = new Parity("USD/TRY", 7.68M);
        public Parity Parity
        {
            get
            {
                return parity;
            }
            private set
            {
                parity = value;
                NotifyObservers(value);
            }
        }

        public Bank()
        {
            ObserverCollection = new List<IObserver>();
        }

        public void NotifyObservers(Parity parity)
        {
            ObserverCollection.ForEach(sub =>
            {
                sub.Update(parity);
            });
        }

        public void RegisterObserver(IObserver subscriber)
        {
            ObserverCollection.Add(subscriber);

            if (Parity != null)
                NotifyObservers(Parity);
        }

        public void UnregisterObserver(IObserver subscriber)
        {
            ObserverCollection.Remove(subscriber);
        }

        public void ChangeParityValue(decimal newValue)
        {
            this.Parity = new Parity(this.Parity.Name, newValue);
        }
    }
}
