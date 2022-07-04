using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    interface IUseUltimate
    {
        void UseUltimate()
        {
            Console.WriteLine($"Character is using an \"Ultimate\"");
        }
    }
}
