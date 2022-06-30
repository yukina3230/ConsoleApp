using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class Character
    {
        public virtual string Class { get; set; }

        public Character(string _Class)
        {
            Class = _Class;
        }

        public void Walk()
        {
            Console.WriteLine($"{Class} is walking...");
        }

        public abstract void Attack();
    }
}
