using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Models.Interfaces;

namespace RPG.Models
{
    public class Knight : Character, IUseUltimate
    {
        public Knight(string _Name, string _Class, string _Origin) : base(_Name, _Class, _Origin)
        {
            Name = _Name;
            Class = _Class;
            Origin = _Origin;
        }

        public override void Attack()
        {
            Console.WriteLine("Knight is winging sword...");
        }

        public void UseUltimate()
        {
            Console.WriteLine($"{Class} uses \"Strong attack\"...");
        }
    }
}
