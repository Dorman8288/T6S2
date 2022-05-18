using System;
using System.Collections.Generic;
using System.Text;

namespace tamrin_6_2_final
{
    class Teacher : Account
    {
        public string workPlace;
        public Teacher(string name, string workPlace) : base(name)
        {
            this.workPlace = workPlace;
        }
    }
}
