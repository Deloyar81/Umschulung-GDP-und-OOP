namespace Aufgabe_2022_01_05__Ausgabe__Widerstand_berechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            double widerstandr, induktivität, frequenz, widerstandz;

            //Eingabe           
            Console.Write("Bitte geben Sie den Ohm'schen Widerstand (R) ein: ");
            widerstandr = double.Parse(Console.ReadLine());

            Console.Write("\nBitte geben Sie die Induktivität (L) ein: ");
            induktivität = double.Parse(Console.ReadLine());

            Console.Write("\nBitte geben Sie die Frequenz (F) ein: ");
            frequenz = double.Parse(Console.ReadLine());

            //Berechnung
            widerstandz = Math.Round(Math.Sqrt(Math.Pow(widerstandr, 2) + Math.Pow((2 * Math.PI * frequenz * induktivität), 2)), 2);

            //Ausgabe
            Console.WriteLine("\nDer Widerstand (Z) bei einer Frequenz (F) von {0} Hertz, einem Ohm'schen Widerstand (R) von {1} Ohm und einer Induktivität (L) von {2} Henry ist: {3} Ohm", frequenz, widerstandr, induktivität, widerstandz);

            Console.ReadKey();
        }
    }
}
