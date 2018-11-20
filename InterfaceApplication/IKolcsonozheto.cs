using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApplication
{
    interface IKolcsonozheto
        /*
         * Egy olyan felület amely a Kölcsönözhető tárgyakhoz társít műveleteket.
         * C#-os megszokás, hogy az interfacek neve elé I betűt írunk.
         */
    {
        string MegjelenitendoNev();
        int KolcsonzesiIdo();
        /*
         * Az interfacek csak metódusokat tartalmaznak (lehet eljárás (void), és függvény is).
         * Ezeket a metódusokat nem definiáljuk, csak felsoroljuk.
         * Definiálása abban az osztályban történik amelyik az interfacet implementálja.
         * Ha egy osztály implementálja az interfacet akkor az összes metódusát meg kell valósítani.
         */
    }
}
