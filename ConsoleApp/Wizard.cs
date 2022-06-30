using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Wizard : IUltimate
    {
        public string Class { get; set; }
        public Wizard(string _Class) : base()
        {
            Class = _Class;
        }

        //public override void Attack()
        //{
        //    Console.WriteLine("Wizard is spamming spell...");
        //}

        public void UseUltimate()
        {
            Console.WriteLine($"{Class} uses \"Lightning strike\"...");
        }
    }
}
