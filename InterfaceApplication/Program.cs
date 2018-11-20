using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Dvd d1 = new Dvd("Avatar", 150);
            Dvd d2 = new Dvd("Deadpool", 90);
            Dvd d3 = new Dvd("Gyűrűk Ura", 120);
            /*
             * Dvd-k példányosítása. Fontos, hogy az objektum a memória egy külön részén jön létre.
             * A kódban csak hivatkozunk arra a memória részre.
             * Ha két hivatkozásunk is mutat arra az objektumpéldányra az attól még 1 példányra fog mutatni
             * épp ezért ha módosítást hajtunk végre az egyik hivatkozással és utána a másikkal kérjük le az adatot
             * akkor abban is látni fogjuk a módosítást.
             */
            Dvd d4 = d3;
            d4.Cim = "Gyűrűk Ura: A király visszatér";

            var katalogus = new List<IKolcsonozheto>();
            /*
             * Interface típussal is létre tudunk hozni listát. Ekkor az összes olyan típúsú objektumot bele tudjuk rakni,
             * ami megvalósítja az adott interfacet.
             * A lista elemeken így meg tudjuk hívni az interfaceben felvett metódusokat.
             */
            katalogus.Add(d1);
            katalogus.Add(d2);
            katalogus.Add(d3);
            katalogus.Add(new Konyv("Bánk bán", "Katona József", "ISBN 15-48984-5156-5"));
            katalogus.Add(new Ujsag("A tudás fája", 2008, 12));

            foreach (var item in katalogus)
            {
                Console.WriteLine(item.MegjelenitendoNev() + " // " + item.KolcsonzesiIdo());
                /*
                 * Mivel tudjuk, hogy a lista elemei megvalósítják a IKolcsonozheto interfacet
                 * így annak a metódusait fel tudjuk használni
                 */
            }

            var dvdk = new List<Dvd>();
            /*
             * Dvd típúsú lista -> csak dvd-ket lehet bele pakolni.
             */
            dvdk.Add(d1);
            dvdk.Add(d2);
            dvdk.Add(d3);
            /*
             * Ugyan azt az objektumot több listába is be tudjuk pakolni.
             * Ha a listában lévő hivatkozással változtatunk rajta, az az objektumon is változtat ->
             * A másik listában is megtörténik a változás.
             */
            dvdk[1].Cim = "Deadpool 2";

            foreach (var item in katalogus)
            {
                Console.WriteLine(item.MegjelenitendoNev() + " // " + item.KolcsonzesiIdo());
            }
            dvdk.Sort();
            /*
             * Mivel a Dvd osztály megvalósítja az IComparable interfacet, és a listát dvdkből hoztuk létre
             * így meg tudjuk hívni a beépített rendező függvényt.
             */
            foreach (var item in dvdk)
            {
                Console.WriteLine(item.Cim);
            }

            Console.ReadLine();
        }
    }
}
