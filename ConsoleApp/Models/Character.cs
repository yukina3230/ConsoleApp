using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models
{
    public abstract class Character
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Origin { get; set; }

        protected Character(string _Name, string _Class, string _Origin) { }

        public abstract void Attack();

        public virtual void Walk()
        {
            Console.WriteLine($"{Class} is walking...");
        }

    }
}
