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
        public override bool Equals(object obj)
        {
            Book b = obj as Book;
            if (b == null) throw new Exception("this object is not the currect type");
            return this == b && publisher == b.publisher && author == b.author;
        }
        public static bool operator ==(Book a, Book b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Book a, Book b)
        {
            return a != b;
        }
    }
}
