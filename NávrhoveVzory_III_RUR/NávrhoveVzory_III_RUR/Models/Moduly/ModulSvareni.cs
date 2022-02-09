using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NávrhoveVzory_III_RUR.Models.Moduly
{
    internal class ModulSvareni : Modul
    {
        public ModulSvareni()
        {

        }
        public override void Pracuj(TimeSpan? doba, string? misto)
        {
            Console.WriteLine("Svarim");
        }
        public override string ToString()
        {
            return "Obycejny svareni";
        }
    }
}
