using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    public interface IObserver
    {
        void Update(Parity parity);
    }
}
