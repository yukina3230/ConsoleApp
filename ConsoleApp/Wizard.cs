﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Wizard : Character, IUltimate
    {
        public override string Class = "Wizard";

        public override void Attack()
        {
            Console.WriteLine("Wizard is spamming spell...");
        }

        public void UseUltimate()
        {
            Console.WriteLine("Wizard using \"Lightning strike\"...");
        }
    }
}