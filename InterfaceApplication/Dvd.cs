using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApplication
{
    class Dvd : IKolcsonozheto, IComparable<Dvd>
        /*
         * Az interfacek implementálása : után vesszővel kell felsorolni az összes interfacet amit implementálunk.
         * Ha egy ősosztályból származtatunk akkor azt kell a kettőspont után írni először, majd ugyan úgy vesszővel
         * elválasztva kell az implementált interfaceket felsorolni
         */
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
        /*
         * Az IKolcsonozeto Interface két művelete. Minden implementáló osztályban másképp definiálhatjuk.
         */

        public int CompareTo(Dvd other)
            /*
             * Az IComparable interface CompareTo metódusa.
             * Ha a példány amit összegasonlítunk (this) kisebb a másiknál (other) akkor negatív,
             * Ha nagyobb akkor pozitív értéket ad vissza (nem feltétlenül -1 vagy +1).
             * Ha a kettő megyegyezik akkor 0-t.
             */
        {
            return this.hossz.CompareTo(other.hossz);
            /*
             * Ha olyan dolgok alapján akarunk összehasonlítani amik megvalósítják az IComparable-t
             * akkor arra fel tudjuk használni az adott osztályra vonatkozó CompareTo-t
             * (beépített osztályok legtöbbje összehasonlítható)
             * Fontos, hogy így a rendezésünk csak az alap szempont szerint rendez.
             */

            return this.hossz - other.hossz; // Elérhetetlen kód mert az előző sorban már visszatérünk valamivel.
            /*
             * Ha számokat akarunk összehasonlítani akkor egy egyszerű kivonással is megtehetjük,
             * mivel meg fog felelni a feltételnek, hogy pozitív, ha nagyobb
             * negatív, ha kisebb és 0 ha egyenlő.
             */
            
            if (this.hossz > other.hossz)
            {
                return 1;
            }
            else if (this.hossz < other.hossz)
            {
                return -1;
            }
            else
            {
                if (this.cim.CompareTo(other.cim) > 0)
                {
                    /*
                     * String esetén, ha betűrendben később van akkor nagyobb
                     */
                    return 1;
                }
                else if (this.cim.CompareTo(other.cim) > 0)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            /*
             * Ha egyszerre több szempont alapján szeretnénk rendezni (pl. azonos hosszúságú filmeket betűrendben.),
             * vagy ha nem elég az egyszerű típusok összehasonlításával definiálnunk az objektum két példányának
             * összehasonlítását akkor a definíció alapján (ha nagyobb -> +, ha kisebb -> -, ha egyenlő -> 0)
             * egy többágú elágazással kell megírnunk az összehasonlítást.
             */
        }
    }
}
