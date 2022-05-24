using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
namespace tamrin_6_2_final
{
   public class Account
    {
        public int additionalDiscount = 0;
        public string name { get; set; }
        public List<Media> cart = new List<Media>();
        public Account(string name)
        {
            this.name = name;
        }
        public Account()
        {
            name = "";
        }
        public void AddToCart(Media item)
        {
            if (cart.Count < 20)
                cart.Add(item);
            else throw new Exception("cart is full");
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
            try
            {
                return a.name == b.name;
            }catch(NullReferenceException)
            {
                if (a is null && b is null) return true;
                else return false;
            }      
        }
        public static bool operator !=(Account a, Account b)
        {
            return a != b;
        }
        public virtual string info()
        {
            return $"Name: {name}\n";
        }
        public List<string> getCartNames()
        {
            List<string> ans = new List<string>();
            foreach(var media in cart)
            {
                ans.Add(media.name);
            }
            return ans;
        }
        public void removeFromCart(string name)
        {
            cart.RemoveAll(x => x.name == name);
        }
        public double CheckOut()
        {
            double total = 0;
            foreach(var item in cart)
            {
                total += item.calculatePrice();
            }
            double discount = 0;
            if (this is Student) discount = 20;
            if (this is Teacher && cart.Count > 3) discount = 15;
            if (this is Customer && cart.Count > 5) discount = 5;
            return total * (1 + ((discount + additionalDiscount) / 100));
        }
        public int generateChance()
        {
            int[] temp = { 0, 2, 3, 5, 7, 10, 15, 25, 30 };
            Random generator = new Random();
            additionalDiscount = temp[generator.Next(0, 8)];
            return additionalDiscount;
        }
    }
}
