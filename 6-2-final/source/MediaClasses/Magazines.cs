using System;
using System.Collections.Generic;
using System.Text;

namespace tamrin_6_2_final
{
    class Magazines : Media
    {
        string publisher;
        int numberPages;
        public Magazines(string name, double price, string ID, int numberPages, string publisher) : base(name, price, ID)
        {
            if (numberPages < 0) throw new Exception("number of pages cant be negetive");
            this.numberPages = numberPages;
            this.publisher = publisher;
        }
        public override double calculatePrice()
        {
            double basePrice = base.calculatePrice();
            double multiplier = 1.05;
            if (1 <= numberPages && numberPages <= 20) multiplier = 1.02;
            if (21 <= numberPages && numberPages <= 50) multiplier = 1.03;
            return basePrice * multiplier;
        }
        public override bool Equals(object obj)
        {
            Magazines b = obj as Magazines;
            if (b == null) throw new Exception("this object is not the currect type");
            return name == b.name && price == b.price && ID == b.ID && publisher == b.publisher && numberPages == b.numberPages;
        }
        public static bool operator ==(Magazines a, Magazines b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Magazines a, Magazines b)
        {
            return a != b;
        }
    }
}
