using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NávrhoveVzory_III_RUR.Models.Moduly
{
    internal class ModulRezani : Modul
    {
        public ModulRezani()
        {

        }
        public override void Pracuj(TimeSpan? doba, string? misto)
        {
            Console.WriteLine("Rezu rezu drivi");
        }
        public override string ToString()
        {
            return "Rezani";
        }
    }
}
