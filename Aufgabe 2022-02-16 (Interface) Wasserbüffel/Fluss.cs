using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_16__Interface__Wasserbüffel
{
    internal class Fluss
    {
        private double wasserstand;
        private static Random random = new Random();

        List<IBeobachter> listeBeobachter = new List<IBeobachter>();

        public void NeuerWasserpegel()
        {
            wasserstand = (double)random.Next(0, 101) / 10;
            Console.WriteLine("aktueller Wasserpegel: {0:F} Meter", wasserstand);

            for (int i = 0; i < listeBeobachter.Count; i++)
            {
                listeBeobachter[i].WasserpegelÄnderung(wasserstand);
            }
        }

        public void NeueBeobachter(IBeobachter beobachter)
        {
            listeBeobachter.Add(beobachter);
        }
     


    }
}
