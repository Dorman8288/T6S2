using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace tamrin_6_2_final.source
{
    class Seller : Account
    {
        string _password;
        string password;
        public Seller(string name, string password = "MyShop1234$") : base(name)
        {
            if (!isInEmailFormat(name)) throw new Exception("this username is not an email");
            this.password = password;
        }
        bool isInEmailFormat(string input)
        {
            return Regex.IsMatch(input, @"^.+@.+\..+$");
        }
        
    }
}
