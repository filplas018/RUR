using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NávrhoveVzory_III_RUR.Models.Moduly
{
    internal class ModulVrtani : Modul
    {
        public ModulVrtani()
        {

        }
        public override void Pracuj(TimeSpan? doba, string? misto)
        {
            Console.WriteLine("Vrtam");
        }
        public override string ToString()
        {
            return "Vrtani";
        }
    }
}
