using summon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summon.Utils
{
    public static class Method
    {

        public static void RarityDisplay(Unit unit)
        {
            if (unit.Rarity == "3")
            {
                Console.WriteLine($"{unit.Name} ***");

            }
            if (unit.Rarity == "4")
            {
                Console.WriteLine($"{unit.Name} ****");

            }
            if (unit.Rarity == "5")
            {
                Console.WriteLine($"{unit.Name} *****");

            }
        }
    }
}
