namespace Aufgabe_2022_01_05__Ausgabe__Eierfrage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            int eier, kinder, erg, rest;

            //Eingabe
            Console.Write("Bitte geben Sie die Anzahl der Geburtstagskinder ein: ");
            kinder = int.Parse(Console.ReadLine());

            Console.Write("\nBitte geben Sie die Anzahl der Eier ein: ");
            eier = int.Parse(Console.ReadLine());

            //Berechnung
            erg = eier / kinder;

            rest = eier % kinder;

            //Ausgabe
            //Verzweigung Einzahl/Mehrzahl Eier/Ergebnis

            if (erg > 1 && rest > 1)
            {
                Console.WriteLine("\nJedes Kind bekommt {0} Eier und es bleiben {1} Eier übrig.", erg, rest);
            }
            else if (erg == 1 && rest > 1)
            {
                Console.WriteLine("\nJedes Kind bekommt {0} Eier und es bleibt {1} Ei übrig.", erg, rest);
            }
            else if (erg > 1 && rest == 1)
            {
                Console.WriteLine("\nJedes Kind bekommt {0} Ei und es bleiben {1} Eier übrig.", erg, rest);
            }
            else
            {
                Console.WriteLine("\nJedes Kind bekommt {0} Ei und es bleibt {1} Ei übrig.", erg, rest);
            }

            Console.ReadKey();
        }
    }
}
