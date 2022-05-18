using System;
using System.Collections.Generic;
using System.Text;

namespace tamrin_6_2_final.source
{
    class Account
    {
        public string name;
        public List<MediaClasses.Media> cart = new List<MediaClasses.Media>();
        public Account(string name)
        {
            this.name = name;
        }
        public void AddToCart(MediaClasses.Media item)
        {
            cart.Add(item);
        }
        public void removeFromCart(MediaClasses.Media item)
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
    }
}
