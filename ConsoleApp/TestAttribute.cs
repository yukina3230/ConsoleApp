using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class TestAttribute : Attribute
    {
        public string Name { get; set; }
        public int Level { get; set; }
    }
}
