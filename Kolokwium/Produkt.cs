using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Produkt
    {
        public string cena;
        public string nazwa;
        public bool nowy;
        public int count;


        public Produkt(string cena, string nazwa, bool nowy, int count)
        {
            this.cena = cena;
            this.nazwa = nazwa;
            this.nowy = nowy;
            this.count = count;
        }

    }
}
