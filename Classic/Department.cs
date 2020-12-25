using System;
using System.Collections.Generic;
using System.Text;

namespace Classic
{
    public class Department : IObserver
    {
        private string name;

        public Department(string name)
        {
            this.name = name;
        }

        public void Update(Parity parity)
        {
            Console.WriteLine($"{name}:\t Kur bilgisi alındı. {parity.Name} = {parity.Value} ");
        }
    }
}
