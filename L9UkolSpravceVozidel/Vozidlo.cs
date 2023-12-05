using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9UkolSpravceVozidel
{
    public class Vozidlo
    {
        public string TypVozidla;
        public string RokVyroby;
        public string Barva;

        public Vozidlo(string typVozidla, string rokVyroby, string barva)
        {
            TypVozidla = typVozidla;
            RokVyroby = rokVyroby;
            Barva = barva;
        }
    }
}
