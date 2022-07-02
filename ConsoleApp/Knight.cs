using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Knight : Character
    {
        //public override void Attack()
        //{
        //    Console.WriteLine("Knight is winging sword...");
        //}

        public void UseUltimate()
        {
            Console.WriteLine($"{Class} uses \"Strong attack\"...");
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
