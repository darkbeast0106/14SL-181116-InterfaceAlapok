using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApplication
{
    class Dvd : IKolcsonozheto
    {
        string cim;
        int hossz; //perc

        public string Cim
        {
            get
            {
                return cim;
            }

            set
            {
                cim = value;
            }
        }

        public int Hossz
        {
            get
            {
                return hossz;
            }

            set
            {
                hossz = value;
            }
        }

        public Dvd(string cim, int hossz)
        {
            this.cim = cim;
            this.hossz = hossz;
        }

        public string MegjelenitendoNev()
        {
            return String.Format("{0}", cim);
        }
        public int KolcsonzesiIdo()
        {
            return 14;
        }
    }
}
