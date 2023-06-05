namespace Aufgabe_2022_01_05__Schleifen__Summe_berechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Lösung 1
            ///Variablen definieren
            //int zahl, erg = 0, x;

            ////Eingabe
            //Console.Write("Geben Sie die zu berechnende Zahl ein: ");
            //zahl = int.Parse(Console.ReadLine());

            //x = zahl;
            //zahl = zahl + 1;

            ////Schleifenberechnung
            //while (zahl > 1)
            //{
            //    erg = (zahl-1 ) + erg;
            //    zahl--;
            //}

            ////Ausgabe
            //Console.WriteLine("Die Summe von 1 bis {0} ist {1}", x, erg);

            //Console.ReadKey();


            //Lösung 2

            //Variable definieren
            long erg = 0, n;

            //Eingabe
            Console.Write("Geben Sie die zu berechnende Zahl ein: ");
            n = int.Parse(Console.ReadLine());

            //Schleifenberechnung
            for (int i = 1; i <= n; i++)
            {
                erg += i;
            }

            //Ausgabe
            Console.WriteLine("{0}", erg);

            Console.ReadKey();
        }
    }
}
