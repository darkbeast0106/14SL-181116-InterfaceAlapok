using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApplication
{
    class Konyv : IKolcsonozheto
    {
        string cim;
        string szerzo;
        string isbn;

        public Konyv(string cim, string szerzo, string isbn)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.isbn = isbn;
        }

        public string MegjelenitendoNev()
        {
            return String.Format("{0}: {1}", szerzo, cim);
        }
        public int KolcsonzesiIdo()
        {
            return 30;
        }
    }
}
