using System;
using System.Collections.Generic;
using System.Text;

namespace tamrin_6_2_final.source
{
    class Customer : Account
    {
        string _SSN;
        string SSN
        {
            get { return _SSN; }
            set
            {
                if (!value.isSSN()) throw new Exception("SSN format is not correct!");
                _SSN = value;
            }
        }
        public Customer(string name, string SSN) : base(name)
        {
            this.SSN = SSN;
            
        }
    }
}
