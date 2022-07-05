using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Class { get; set; }

        protected Character(string _Name, int _Level, string _Class) { }

        public abstract void Attack();

        public virtual void Walk()
        {
            Console.WriteLine($"{Class} is walking...");
        }

    }
}
