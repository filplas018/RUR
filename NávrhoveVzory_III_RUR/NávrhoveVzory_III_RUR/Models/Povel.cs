using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NávrhoveVzory_III_RUR.Models
{
    internal class Povel
    {


        public Aktivita _cinnost { get; set; }
        public TimeSpan _doba { get; set; }
        public string _misto { get; set; }
        public Povel(Aktivita cinnost, string misto, TimeSpan doba)
        {
            _cinnost = cinnost;
            _doba = doba;
            _misto = misto;
        }
    }
}
