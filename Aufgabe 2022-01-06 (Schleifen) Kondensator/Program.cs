namespace Aufgabe_2022_01_06__Schleifen__Kondensator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            int spannung, widerstand, t = 0;
            double prozent = 0.99, d = 0, kapazität;

            //Abfrage
            Console.Write("Bitte geben Sie die SPannung (S) in Volt ein: ");
            spannung = int.Parse(Console.ReadLine());

            Console.Write("Bitte geben Sie den Widerstand (R) in Ohm ein: ");
            widerstand = int.Parse(Console.ReadLine());

            Console.Write("Bitte geben Sie die Kapazität (C) in mikroFarad ein: ");
            kapazität = double.Parse(Console.ReadLine());

            //Schleife
            while (d < prozent * spannung)
            {
                d = spannung * (1 - Math.Pow(Math.E, -t / (widerstand * kapazität)));
                t++;
            }

            //Logarythmus

            //d = spannung * (1 -;

            //Ausgabe
            Console.WriteLine("\nDer Kondensator ist nach {0} Mikrosekunden bei {1} Prozent Ladung und zu {2} Volt geladen.", t, prozent * 100, d);

            Console.ReadKey();
        }
    }
}
