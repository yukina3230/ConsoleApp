using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Models.Interfaces;

namespace RPG.Models
{
    public class Assassin : Character, IUseUltimate, INightVision
    {
        public Assassin(string _Name, string _Class, string _Origin) : base(_Name, _Class, _Origin)
        {
            Name = _Name;
            Class = _Class;
            Origin = _Origin;
        }

        public override void Attack()
        {
            Console.WriteLine("Assassin is throwing daggers...");
        }

        public override void Walk()
        {
            Console.WriteLine("Wizard walks fast!");
        }

        public void UseUltimate()
        {
            Console.WriteLine($"{Class} uses \"Critikal strike\"...");
        }

        public void NightVision()
        {
            Console.WriteLine($"{Class} actives \"Night Vision\"...");
        }
    }
}
