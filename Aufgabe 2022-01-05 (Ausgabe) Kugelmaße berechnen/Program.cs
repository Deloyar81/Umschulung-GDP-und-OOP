namespace Aufgabe_2022_01_05__Ausgabe__Kugelmaße_berechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eingabe
            Console.Write("Bitte geben Sie den Durchmesser der Kugel in cm ein: ");

            //Variablen + Berechnung
            double durch = Convert.ToDouble(Console.ReadLine());

            double volumen = Math.Round(Math.PI * Math.Pow(durch, 3) / 6, 2);

            double oberfl = Math.Round(Math.PI * Math.Pow(durch, 2), 2);

            //Ausgabe
            Console.Clear();

            Console.Write($"Der eingegebene Durchmesser ist: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{durch} cm");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write($"Das daraus berechnete Volumen ist: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{volumen} cm³");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write($"Die daraus berechnete Obergläche ist: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{oberfl} cm²");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ReadKey();
        }
    }
}
