using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Statics
{
    public static class GlobalProperty
    {
        public static int PlayerIndex = 1;
        public static int MaxLevel = 15;

        public static void PrintMaxLevel()
        {
            Console.WriteLine($"MaxLevel: {MaxLevel}");
        }
    }
}
