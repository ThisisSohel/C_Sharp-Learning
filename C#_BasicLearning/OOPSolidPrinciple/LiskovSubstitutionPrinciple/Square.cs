﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Square : Rectangle
    {
        public override double Area()
        {
            return Width * Height;
        }
    }
}
