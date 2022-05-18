using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace tamrin_6_2_final.source
{
    static class Extensions
    {
        public static bool isSSN(this string SSN)
        {
            if (SSN.Length != 10) return false;
            if (Regex.IsMatch(SSN, @"\d{10}")) return false;
            int a, b, c;
            a = int.Parse(SSN[9].ToString());
            b = 0;
            for(int i = 0; i < SSN.Length - 1; i++)
            {
                b += int.Parse(SSN[i].ToString()) * (10 - i);
            }
            c = b % 11;
            if (c == 0 && a == c) return true;
            if (c == 1 && a == 1) return true;
            if (c > 1 && a == Math.Abs(c - 11)) return true;
            return false;
        }
    }
}
