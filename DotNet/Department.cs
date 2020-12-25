using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet
{
    public class Department : IObserver<Parity>
    {
        private string name;
        private IDisposable cancellation;

        public Department(string name)
        {
            this.name = name;
        }

        public virtual void RegisterObserver(Bank provider)
        {
            cancellation = provider.Subscribe(this);
        }

        public virtual void UnregisterObserver()
        {
            cancellation.Dispose();
        }

        public virtual void OnCompleted() 
        {
            Console.WriteLine("Bildirimler tamamlandı. Service bir daha bildirim gerçekleştirmeyecek.");
        }

        public virtual void OnError(Exception e)
        {
            Console.WriteLine($"Bir hata oluştu. Hata: {e.Message}");
        }

        public virtual void OnNext(Parity parity)
        {
            Console.WriteLine($"{name}:\t Kur bilgisi alındı. {parity.Name} = {parity.Value} ");
        }
    }
}