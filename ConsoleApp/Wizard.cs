using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    [Test(Name = "Alan", Level = 1)]
    public class Wizard : Character
    {
        //public override void Attack()
        //{
        //    Console.WriteLine("Wizard is spamming spell...");
        //}

        public void UseUltimate()
        {
            Console.WriteLine($"{Class} uses \"Lightning strike\"...");
        }
    }
}
