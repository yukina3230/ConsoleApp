using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Models;
using static RPG.Shared.Variables;

namespace RPG.ViewModels.Servies
{
    public class CharacterCreation
    {
        Dictionary<string, Character> playerDic = new Dictionary<string, Character>();

        public void Run()
        {

        }


        private void CreateCharacter(string _Name, string _Class, string _Origin)
        {
            Console.Write("Type in character name: ");
            _Name = Console.ReadLine();
            Console.Write("Choose a class: (1: Warrior, 2: Mage, 3: Assassin, 4: Hobo --- 0: Random)");
            _Class = Console.ReadLine();
            playerDic.Add($"player{PlayerIndex}", new Assassin(_Name, _Class, _Origin));

            PlayerIndex++;
        }
    }
}



//characterList.Add(new Wizard("Aaron", 1, "Wizard"));
//characterList.Add(new Sorcerer("Alexa", 20, "Sorcerer"));
//characterList.Add(new Knight("Amir", 5, "Knight"));
//characterList.Add(new Hobo("Herb", 9, "Hobo"));
