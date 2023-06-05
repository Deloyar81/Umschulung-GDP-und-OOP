namespace Aufgabe_2022_01_06__Schleifen__Weizenkornlegende
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            int feld = 64, i = 1;
            ulong korn = 1, gesamt = 0;
            double gewicht, länge, lkw, ae;

            //Schleife (Menge berechnen)

            do
            {
                gesamt += korn;
                Console.WriteLine("Auf Feld {0, 2} liegen {1} Körner und insgesamt sind es {2} Körner auf dem Brett", i, korn, gesamt);
                korn = korn * 2;
                i++;
            } while (i <= feld);

            //Maße berechen
            gewicht = Math.Round(gesamt * 0.05 / 1000000, 2);
            lkw = Math.Ceiling(gewicht / 25);
            länge = lkw * 0.019;
            ae = länge / 149597870.7;

            Console.WriteLine("\nInsgesamt sind es {0:G} Tonnen Reiskörner.", gewicht);
            Console.WriteLine("Es werden {0} LKW benötigt", lkw);
            Console.WriteLine("Der LKW-Stau hätte (bei einer LKW-Länge von 19m) eine Länge von {0:g} Kilometern oder {1} Astronomische Einheiten", länge, ae);

            Console.ReadKey();
        }
    }
}
