using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;

namespace tamrin_6_2_final
{
    public class Seller : Account
    {
        public string password { get; set; }
        public string lastTimeChanged = "";
        public Seller(string name, string password = "MyShop1234$") : base(name)
        {
            if (!isInEmailFormat(name)) throw new Exception("this username is not an email");
            this.password = password;
        }
        bool isInEmailFormat(string input)
        {
            return Regex.IsMatch(input, @"^.+@.+\..+$");
        }
        public void changePassword(string oldPass, string newPass)
        {
            if (oldPass != password) throw new Exception("password dosent match");
            if(lastTimeChanged != "")
            MessageBox.Show($"Last time changed {lastTimeChanged}", "state", MessageBoxButton.OK, MessageBoxImage.Information);
            lastTimeChanged = DateTime.Now.ToString();
            password = newPass;
        }
        public static bool operator ==(Seller a, Seller b)
        {
            return a.name == b.name && a.password == b.password;
        }
        public static bool operator !=(Seller a, Seller b)
        {
            return a != b;
        }
        public override string info()
        {
            return base.info() + $"password {password}\n";
        }
    }
}
