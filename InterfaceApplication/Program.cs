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

            var katalogus = new List<IKolcsonozheto>();
            katalogus.Add(d1);
            katalogus.Add(d2);
            katalogus.Add(d3);
            katalogus.Add(new Konyv("Bánk bán", "Katona József", "ISBN 15-48984-5156-5"));
            katalogus.Add(new Ujsag("A tudás fája", 2008, 12));

            foreach (var item in katalogus)
            {
                Console.WriteLine(item.MegjelenitendoNev() + " // " + item.KolcsonzesiIdo());
            }

            var dvdk = new List<Dvd>();
            dvdk.Add(d1);
            dvdk.Add(d2);
            dvdk.Add(d3);

            dvdk[1].Cim = "Deadpool 2";

            foreach (var item in katalogus)
            {
                Console.WriteLine(item.MegjelenitendoNev() + " // " + item.KolcsonzesiIdo());
            }
            dvdk.Sort();
            foreach (var item in dvdk)
            {
                Console.WriteLine(item.Cim);
            }

            Console.ReadLine();
        }
    }
}
