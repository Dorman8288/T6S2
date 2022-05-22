using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace tamrin_6_2_final
{
    public class Teacher : Account
    {
        public string workPlace;
        public Teacher(string name, string workPlace) : base(name)
        {
            this.workPlace = workPlace;
        }
        public static bool operator ==(Teacher a, Teacher b)
        {
            return a.name == b.name && a.workPlace == b.workPlace;
        }
        public static bool operator !=(Teacher a, Teacher b)
        {
            return a != b;
        }
        public override string info()
        {
            return base.info() + $"workplace {workPlace}\n";
        }
    } 
}
