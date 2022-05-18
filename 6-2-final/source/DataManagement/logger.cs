using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace tamrin_6_2_final.source.DataManagement
{
    class logger
    {
        static StreamReader MediaReader = new StreamReader("Media.txt");
        static StreamWriter MediaWriter = new StreamWriter("Media.txt", true);
        static StreamReader AccountReader = new StreamReader("Account.txt");
        static StreamWriter AccountWriter = new StreamWriter("Account.txt", true);
        public void addMedia(MediaClasses.Media input)
        {
            MediaWriter.WriteLine();
            MediaWriter.WriteLine();
            MediaWriter.WriteLine();
            MediaWriter.WriteLine();
        }

    }
}
