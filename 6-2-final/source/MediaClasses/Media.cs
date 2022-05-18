using System;
using System.Collections.Generic;
using System.Text;

namespace tamrin_6_2_final.source.MediaClasses
{
    class Media
    {
        string name;
        double price;
        string ID;
        public Media(string name, double price, string ID)
        {
            this.name = name;
            this.price = price;
            this.ID = ID;
        }
        public virtual double calculatePrice()
        {
            return price;
        }
    }
}
