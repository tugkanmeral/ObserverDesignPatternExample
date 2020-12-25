using System;
using System.Collections.Generic;
using System.Text;

namespace Classic
{
    public interface IObserver
    {
        public void Update(Parity parity);
    }
}
