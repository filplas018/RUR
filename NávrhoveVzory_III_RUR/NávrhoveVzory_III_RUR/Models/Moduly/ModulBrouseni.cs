using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NávrhoveVzory_III_RUR.Models.Moduly
{
    internal class ModulBrouseni : Modul
    {
        public ModulBrouseni()
        {

        }
        public override void Pracuj(TimeSpan? doba, string? misto)
        {
            Console.WriteLine("Nuzky, noze, brousim!");
        }
        public override string ToString()
        {
            return "Brouseni";
        }
    }
}
