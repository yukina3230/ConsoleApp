using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Knight : Character, IUseUltimate
    {
        public Knight(string _Name, int _Level, string _Class) : base(_Name, _Level, _Class)
        {
            Name = _Name;
            Level = _Level;
            Class = _Class;
        }

        public override void Attack()
        {
            Console.WriteLine("Knight is winging sword...");
        }

        public void UseUltimate()
        {
            Console.WriteLine($"{Class} uses \"Strong attack\"...");
        }
    }
}
