using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_16__Interface__Flüsse
{
    internal class Fluss
    {
        private string name;
        private double wasserstand;
        private static Random random = new Random();

        List<IBeobachter> listeBeobachter = new List<IBeobachter>();

        public Fluss(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }

        public void NeuerWasserpegel()
        {
            wasserstand = (double)random.Next(100, 11991);
            Console.WriteLine("{0} - aktueller Wasserpegel: {1} cm", name, wasserstand);

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
