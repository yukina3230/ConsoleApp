using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Knight : Character, IUltimate
    {
        public override string Class = "Knight";

        public override void Attack()
        {
            Console.WriteLine("Knight is winging sword...");
        }

        public void UseUltimate()
        {
            Console.WriteLine("Knight using \"Strong attack\"...");
        }
    }
}
