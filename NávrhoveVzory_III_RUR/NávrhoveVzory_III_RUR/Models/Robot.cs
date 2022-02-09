using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NávrhoveVzory_III_RUR.Models
{
    internal class Robot
    {

        private Modul? NasazenyModul;
        private List<string> Historie = new List<string>();
        private TimeSpan CelkovyCas = TimeSpan.Zero;
        public bool ProvedCinnost(Povel povel)
        {
            if (NasazenyModul != null)
            {
                OdebratModul();
            }
            NasazenyModul = Modul.GetModul(povel._cinnost);
            NasazenyModul.Pracuj(povel._doba, povel._misto);
            CelkovyCas += povel._doba;
            Historie.Add(NasazenyModul.ToString());
            return true;
        }

        private void OdebratModul()
        {
            NasazenyModul = null;
        }

        public void VypisCinnosti()
        {
            Console.WriteLine("\nHistorie: ");
            foreach (var i in Historie)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"\nCelkovy cas: {CelkovyCas} min");
        }
    }
}
