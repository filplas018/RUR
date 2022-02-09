using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NávrhoveVzory_III_RUR.Models
{
    internal static class Ovladac
    {
        public static void PredejPovel(Robot robot, Povel povel)
        {
            robot.ProvedCinnost(povel);
        }
    }
}
//prepravka, servant