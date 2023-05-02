using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Gotal_manager
{
    internal class Racunaj
    {
        public static double izlaznaCijenaIzUlazne(double ulaznaCijena, double DodanPopust, double DodanPorez, int kolicina=1)
        {
            return Math.Round(
                ((ulaznaCijena - (ulaznaCijena * DodanPopust))+//Cijena s popustom
                ((ulaznaCijena - (ulaznaCijena * DodanPopust)) * (DodanPorez / (1 - DodanPorez))))//Cijena s popustom i na to porez
                * kolicina //Sve pomožemo s količinom
                , 2);
        }
    }
}
