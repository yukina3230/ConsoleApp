using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Hobo : Character
    {
        public override string Class = "Hobo";

        public override void Attack()
        {
            Console.WriteLine("Naked fuck with a stick...");
        }
    }
}
