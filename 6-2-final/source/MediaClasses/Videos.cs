using System;
using System.Collections.Generic;
using System.Text;

namespace tamrin_6_2_final
{
    class Videos : Media
    {
        int time;
        int numberOfCDs;
        public Videos(string name, double price, string ID, int time, int numberOfCDs) : base(name, price, ID)
        {
            this.time = time;
            this.numberOfCDs = numberOfCDs;
        }
        public override double calculatePrice()
        {
            double basePrice = base.calculatePrice();
            double multiplier = 1 + ((numberOfCDs * 3) + ((time / 60) * 5)) / 100;
            return basePrice * multiplier;
        }
        public override bool Equals(object obj)
        {
            Videos b = obj as Videos;
            if (b == null) throw new Exception("this object is not the currect type");
            return this == b && time == b.time && numberOfCDs == b.numberOfCDs;
        }
        public static bool operator ==(Videos a, Videos b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Videos a, Videos b)
        {
            return a != b;
        }
    }
}
