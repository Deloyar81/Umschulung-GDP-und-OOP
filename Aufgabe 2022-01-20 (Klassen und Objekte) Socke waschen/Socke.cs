namespace Aufgabe_2022_01_20__Klassen_und_Objekte__Socke
{
    public class Socke
    {
        public string farbe;
        private bool trocken;
        private bool dreckig;

        public Socke(string farbe)
        {
            this.farbe = farbe;
        }

        public void Trockne()
        {
            trocken = true;
        }

        public bool IstTrocken()
        {
            return trocken;
        }

        public void Wasche()
        {
            trocken = false;
        }

        public void Ausgabe()
        {
            string zustand;
            if (trocken == true)
            {
                zustand = "trocken";
            }
            else
            {
                zustand = "nass";
            }

            Console.WriteLine("Die Socke mit der Farbe {0} ist {1}", farbe, zustand);
        }

        public void Stinkt()
        {
            if (dreckig == true)
            {

            }
        }
    }
}