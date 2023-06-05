namespace Aufgabe_2022_01_07__Arrays__Array_random_befüllen_und_summieren
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            int size, erg = 0, kzahl, gzahl;
            double mitt = 0;

            //Eingabe
            Console.Write("Bitte geben Sie die Größe des Arrays an: ");
            size = int.Parse(Console.ReadLine());

            //Array erstellen
            int[] array = new int[size];

            Random zahl = new Random();

            //Array befüllen und summieren
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int z = zahl.Next(1, 10);
                array[i] = z;
            }

            foreach (int i in array)
            {
                erg += i;
            }

            //Ausgabe
            //Summe
            Console.WriteLine("");

            foreach (int i in array)
            {
                Console.Write("|{0}| ", i);
            }

            Console.Write("\n\nDie Summe der Werte des Arrays ist: {0}", erg);

            //Mittelwert
            mitt = (double)erg / array.Length;
            Console.Write("\n\nDer Mittelwert aller Werte des Arrays ist: {0}", mitt);

            //Kleinste Zahl
            Array.Sort(array);
            kzahl = array[0];
            Console.Write("\n\nDer kleinste Wert aller Werte des Arrays ist: {0}", kzahl);

            int kbuffer = 100;
            foreach (int z in array)
            {
                if (z < kbuffer)
                {
                    kzahl = z;
                    kbuffer = z;
                }
            }
            Console.Write("\n\nDer kleinste Wert aller Werte des Arrays ist: {0}", kzahl);

            //größte Zahl
            Array.Sort(array);
            gzahl = array[array.Length - 1];
            Console.Write("\n\nDer größte Wert aller Werte des Arrays ist: {0}", gzahl);

            int gbuffer = 0;
            foreach (int z in array)
            {
                if (z > gbuffer)
                {
                    gzahl = z;
                    gbuffer = z;
                }
            }
            Console.Write("\n\nDer größte Wert aller Werte des Arrays ist: {0}", gzahl);

            Console.ReadKey();
        }
    }
}
