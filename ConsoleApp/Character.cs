using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class Character
    {
        public abstract string Class { get; set; }

        public void Walk()
        {
            Console.WriteLine("Walking...");
        }

        public abstract void Attack();
    }
}
