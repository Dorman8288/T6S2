using System;
using System.Collections.Generic;
using System.Text;

namespace tamrin_6_2_final
{
   public class Account
    {
        public string name { get; set; }
        public List<Media> cart = new List<Media>();
        public Account(string name)
        {
            this.name = name;
            DataManager.AddAccount(this);
        }
        public Account()
        {
            name = "";
            DataManager.AddAccount(this);
        }
        public void AddToCart(Media item)
        {
            cart.Add(item);
        }
        public void removeFromCart(Media item)
        {
            foreach(var media in cart)
            {
                if(media == item)
                {
                    cart.Remove(media);
                }
            }
            throw new Exception("not found");
        }
        public static bool operator ==(Account a, Account b)
        {
            return a.name == b.name;
        }
        public static bool operator !=(Account a, Account b)
        {
            return a != b;
        }
    }
}
