using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Sorcerer : Character, IUseUltimate
    {
        public Sorcerer(string _Name, int _Level, string _Class) : base(_Name, _Level, _Class)
        {
            Name = _Name;
            Level = _Level;
            Class = _Class;
        }

        public override void Attack()
        {
            Console.WriteLine("Sorcerer is swinging her staff");
        }

        public void UseUltimate()
        {
            Console.WriteLine("Sorcerer is using \"Fireball\"");
        }
    }
}
