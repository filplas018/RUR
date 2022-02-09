using NávrhoveVzory_III_RUR.Models.Moduly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NávrhoveVzory_III_RUR.Models
{
    internal class Modul
    {
        
        
        public Modul()
        {
            
        }
        public static Modul GetModul(Aktivita aktivita)
        {
            switch (aktivita)
            {
                case Aktivita.VRTANI:
                    return new ModulVrtani();

                case Aktivita.BROUSENI:
                    return new ModulBrouseni();

                case Aktivita.SVAROVANI:
                    return new ModulSvareni();

                case Aktivita.REZANI:
                    return new ModulRezani();
                default:
                    return null;
            }
        }
        public virtual void Pracuj(TimeSpan? doba, string? misto)
        {
            Console.WriteLine("Musis mit modul");
        }
        public override string ToString()
        {
            return "Obycejny modul";
        }
    }
}
