using System;
using System.Collections.Generic;
using System.Text;

namespace tamrin_6_2_final.source.MediaClasses
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
    }
}
