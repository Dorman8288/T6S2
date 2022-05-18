using System;
using System.Collections.Generic;
using System.Text;

namespace tamrin_6_2_final.source
{
    class Teacher : Account
    {
        string workPlace;
        public Teacher(string name, string workPlace) : base(name)
        {
            this.workPlace = workPlace;
        }
    }
}
