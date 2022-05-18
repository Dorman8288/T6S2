using System;
using System.Collections.Generic;
using System.Text;

namespace tamrin_6_2_final.source.MediaClasses
{
    class Library
    {
        List<Media> stock;
        public void addMedia(Media input)
        {
            stock.Add(input);
        }
        public void deleteMedia(Media input)
        {
            stock.Remove(input);
        }
    }
}
