﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Cat : Animal
    {
        public void CatInfo()
        {
            AnimalInfo();
            Console.WriteLine("Cat..........");
        }
    }
}
