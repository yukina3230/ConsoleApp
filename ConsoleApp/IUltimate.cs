﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    interface IUseUltimate
    {
        void UseUltimate(string _Class)
        {
            Console.WriteLine($"{_Class} is using an \"Ultimate\"");
        }
    }
}
