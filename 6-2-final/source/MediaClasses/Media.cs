using System;
using System.Collections.Generic;
using System.Text;

namespace tamrin_6_2_final
{
    public class Media
    {
        public string name { get; set; }
        double _price;
        string _ID;
        public double price
        {
            get { return _price; }
            set
            {
                if (value < 0) throw new Exception("media price cant be negetive");
                _price = value;
            }
        }
        public string ID
        {
            get { return _ID; }
            set 
            {
                if (DataManager.isRegisteredID(value)) throw new Exception("this ID is registered");
                _ID = value;
            }
        }
        public Media(string name, double price, string ID)
        {
            this.name = name;
            this.price = price;
            this.ID = ID;
        }
        public Media()
        {
            name = "";
            price = 0;
            ID = "null";
        }
        public virtual string info()
        {
            return $"Name: {name}\nPrice: {price}\nID: {ID}\n";
        }
        public virtual double calculatePrice()
        {
            return price;
        }
        public override bool Equals(object obj)
        {
            Media b = obj as Media;
            if (b == null) return false;
            return  name == b.name && price == b.price && ID == b.ID;
        }
        public static bool operator ==(Media a, Media b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Media a, Media b)
        {
            return a != b;
        }
    }
}
