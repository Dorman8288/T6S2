using System;
using System.Collections.Generic;
using System.Text;

namespace tamrin_6_2_final
{
    public class Book : Media
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
            if (b is null) return false;
            return name == b.name && price == b.price && ID == b.ID && publisher == b.publisher && author == b.author;
        }
        public override string info()
        {
            return base.info() + $"Author: {author}\nPublisher: {publisher}\n";
        }
        public static bool operator ==(Book a, Book b)
        {
            if ((object)b == null && (object)a == null) return true;
            return a.Equals(b);
        }
        public static bool operator !=(Book a, Book b)
        {
            return a != b;
        }
    }
}
