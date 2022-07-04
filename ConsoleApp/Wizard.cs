using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Wizard : Character, IUseUltimate
    {
        public Wizard(string _Name, int _Level, string _Class) : base(_Name, _Level, _Class)
        {
            Name = _Name;
            Level = _Level;
            Class = _Class;
        }

        public override void Attack()
        {
            Console.WriteLine("Wizard is spamming spell...");
        }

        public void UseUltimate()
        {
            Console.WriteLine($"{Class} uses \"Lightning strike\"...");
        }
    }
}
