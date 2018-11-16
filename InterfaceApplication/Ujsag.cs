using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApplication
{
    class Ujsag : IKolcsonozheto
    {
        string cim;
        int kiadasEv;
        int KiadasHonap;

        public Ujsag(string cim, int kiadasEv, int kiadasHonap)
        {
            this.cim = cim;
            this.kiadasEv = kiadasEv;
            KiadasHonap = kiadasHonap;
        }

        public int KolcsonzesiIdo()
        {
            return 0;
        }

        public string MegjelenitendoNev()
        {
            return String.Format("{0} - {1}.{2}", cim, kiadasEv, KiadasHonap);
        }
    }
}
