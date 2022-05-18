using System;
using System.Collections.Generic;
using System.Text;

namespace tamrin_6_2_final.source.MediaClasses
{
    class Book : Media
    {
        string author;
        string publisher;
        public Book(string name, double price, string ID, string author, string publisher) : base(name, price, ID)
        {
            this.author = author;
            this.publisher = publisher;
        }
        public override double calculatePrice()
        {
            return 1.1 * base.calculatePrice();
        }
    }
}
