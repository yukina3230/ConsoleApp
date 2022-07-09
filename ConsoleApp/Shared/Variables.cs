using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Shared
{
    public static class Variables
    {
        public static int PlayerIndex = 1;
        public static int MaxLevel = 15;

        public static void PrintMaxLevel()
        {
            Console.WriteLine($"MaxLevel: {MaxLevel}");
        }
    }
}
