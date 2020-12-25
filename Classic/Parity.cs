using System;
using System.Collections.Generic;
using System.Text;

namespace Classic
{
    public class Parity
    {
        private decimal _value;
        private string _name;

        internal Parity(string name, decimal value)
        {
            _name = name;
            _value = value;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public decimal Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}
