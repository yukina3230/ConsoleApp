using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Models.Interfaces;

namespace RPG.Models
{
    public class Wizard : Character, IUseUltimate, ICanDoAlchemy
    {
        public Wizard(string _Name, string _Class, string _Origin) : base(_Name, _Class, _Origin)
        {
            Name = _Name;
            Class = _Class;
            Origin = _Origin;
        }

        public override void Attack()
        {
            Console.WriteLine("Wizard is spamming spell...");
        }

        public override void Walk()
        {
            Console.WriteLine("Wizard walks too slow!");
        }

        public void UseUltimate()
        {
            Console.WriteLine($"{Class} uses \"Lightning strike\"...");
        }

        public void DoAlchemy()
        {
            Console.WriteLine($"{Class} is making potion");
        }
    }
}
