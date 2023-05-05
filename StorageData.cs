using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotal_manager
{
    public class StorageData
    {
        //Samo prva ove vrste
        public int ID;
        public int proizvodID;
        public double cijena, popust, porez;
        public int kolicina, razduzena_kolicina;
        public string naziv="GREŠKA";
        public StorageData(int proizvodID,int ID, double cijena, double popust, double porez, int kolicina)
        {
            this.proizvodID = proizvodID;
            this.ID = ID;
            this.cijena = cijena;
            this.popust = popust;
            this.porez = porez;
            this.kolicina = kolicina;
        }
        public double calc() { return Racunaj.izlaznaCijenaIzUlazne(cijena, popust, porez, kolicina); }

        public override int GetHashCode()
        {
            return (proizvodID + ":" + cijena + ":" + popust + ":" + porez).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is StorageData))
                return false;

            StorageData other = (StorageData)obj;
            return proizvodID == other.proizvodID && cijena == other.cijena && popust == other.popust && porez == other.porez;
        }

    }
}

