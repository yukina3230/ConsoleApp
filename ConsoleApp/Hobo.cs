using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Hobo : Character
    {
        public string Class { get; set; }
        public Hobo(string _Class) : base()
        {
            Class = _Class;
        }

        public override void Attack()
        {
            Console.WriteLine("Just a naked fuck with a stick...");
        }
    }
}
