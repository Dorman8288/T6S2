﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tamrin_6_2_final.source
{
    class Account
    {
        string name;
        List<MediaClasses.Media> cart = new List<MediaClasses.Media>();
        public Account(string name)
        {
            this.name = name;
        }
    }
}
