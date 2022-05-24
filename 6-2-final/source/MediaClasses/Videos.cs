using System;
using System.Collections.Generic;
using System.Text;

namespace tamrin_6_2_final
{
    public class Videos : Media
    {
        int time;
        int numberOfCDs;
        public Videos(string name, double price, string ID, int time, int numberOfCDs) : base(name, price, ID)
        {
            if (time < 0) throw new Exception("time cant be negetive");
            if (numberOfCDs < 0) throw new Exception("number of cds cant be negetive");
            this.time = time;
            this.numberOfCDs = numberOfCDs;
        }
        public Videos() : base()
        {
            time = 0;
            numberOfCDs = 0;
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
            if (b == null) return false;
            return name == b.name && price == b.price && ID == b.ID && time == b.time && numberOfCDs == b.numberOfCDs;
        }
        public override string info()
        {
            return base.info() + $"Author: {time}\nPublisher: {numberOfCDs}\n";
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
