using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNet
{
    public class Bank : IObservable<Parity>
    {
        private List<IObserver<Parity>> clients;
        private Parity parity = new Parity("USD/TRY", 7.68M);

        public Bank()
        {
            clients = new List<IObserver<Parity>>();
        }

        public IDisposable Subscribe(IObserver<Parity> client)
        {
            if (!clients.Contains(client))
            {
                clients.Add(client);
                client.OnNext(parity);
            }
            return new Unsubscriber<Parity>(clients, client);
        }

        public void ChangeParityValue(decimal newValue)
        {
            parity.Value = newValue;

            foreach (var client in clients)
            {
                try
                {
                    client.OnNext(parity);
                }
                catch (Exception ex)
                {
                    client.OnError(ex);
                }
            }
        }

        public void CloseNotificationService()
        {
            foreach (var client in clients)
                client.OnCompleted();

            clients.Clear();
        }
    }
}
