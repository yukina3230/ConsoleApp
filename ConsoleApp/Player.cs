using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Player
    {
        public void DoingStuff(IEnumerable<Character> players)
        {
            foreach (var player in players)
            {
                player.Walk();
                player.Attack();
            }

            foreach (var player in players.OfType<IUltimate>())
            {
                player.UseUltimate();
            }
        }
    }
}
