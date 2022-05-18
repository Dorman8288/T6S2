using System;
using System.Collections.Generic;
using System.Text;

namespace tamrin_6_2_final
{
    class Customer : Account
    {
        string _SSN;
        public string SSN
        {
            get { return _SSN; }
            set
            {
                if (!value.isSSN() ) throw new Exception("SSN format is not correct!");
                if (DataManager.isRegisteredSSN(value)) throw new Exception("SSN is registered!");
                _SSN = value;
            }
        }
        public Customer(string name, string SSN) : base(name)
        {
            this.SSN = SSN;
        }
    }
}
