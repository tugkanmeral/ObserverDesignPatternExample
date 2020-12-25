using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    public class Parity
    {
        private decimal value;
        private string name;

        public Parity(string name, decimal value)
        {
            this.name = name;
            this.value = value;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public decimal Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
    }
}
