using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models
{
    public class Hobo : Character
    {
        public string Class { get; set; }
        public Hobo(string _Name, string _Class, string _Origin) : base(_Name, _Class, _Origin)
        {
            Name = _Name;
            Class = _Class;
            Origin = _Origin;
        }

        public override void Attack()
        {
            Console.WriteLine("Just a naked fuck with a stick...");
        }
    }
}
