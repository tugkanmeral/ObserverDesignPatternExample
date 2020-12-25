using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    public class Bank : ISubject
    {
        ParityChangedNotifyFunc parityChangedNotifyFunc = null;

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

        public void RegisterObserver(ParityChangedNotifyFunc parityChangedNotifyFunc)
        {
            this.parityChangedNotifyFunc += parityChangedNotifyFunc;

            if (Parity != null)
                NotifyObservers(Parity);
        }

        public void UnregisteObserver(ParityChangedNotifyFunc parityChangedNotifyFunc)
        {
            this.parityChangedNotifyFunc -= parityChangedNotifyFunc;
        }

        public void NotifyObservers(Parity parity)
        {
            if (parityChangedNotifyFunc != null)
                parityChangedNotifyFunc.Invoke(parity);
        }

        public void ChangeParityValue(decimal newValue)
        {
            Parity = new Parity(this.Parity.Name, newValue);
        }
    }
}
