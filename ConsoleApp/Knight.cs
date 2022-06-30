using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Knight : IUltimate
    {
        public string Class { get; set; }
        public Knight(string _Class) : base()
        {
            Class = _Class;
        }

        //public override void Attack()
        //{
        //    Console.WriteLine("Knight is winging sword...");
        //}

        public void UseUltimate()
        {
            Console.WriteLine($"{Class} uses \"Strong attack\"...");
        }
    }
}
