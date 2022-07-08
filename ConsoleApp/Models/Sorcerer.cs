using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Models.Interfaces;

namespace RPG.Models
{
    public class Sorcerer : Character, IUseUltimate
    {
        public Sorcerer(string _Name, string _Class, string _Origin) : base(_Name, _Class, _Origin)
        {
            Name = _Name;
            Class = _Class;
            Origin = _Origin;
        }

        public override void Attack()
        {
            Console.WriteLine("Sorcerer is swinging her staff");
        }

        public void UseUltimate()
        {
            Console.WriteLine("Sorcerer is using \"Fireball\"");
        }
    }
}
