using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9UkolSpravceVozidel
{
    public class Motocykl : Vozidlo
    {
        public string TypMotocyklu;
        public int PocetKol;

        public Motocykl(string typVozidla, string rokVyroby, string barva, string typMotocyklu, int pocetKol) : base(typVozidla, rokVyroby, barva)
        {
            TypMotocyklu = typMotocyklu;
            PocetKol = pocetKol;

        }
    }
}
