namespace Aufgabe_2022_01_05__Ausgabe__Benzinverbrauch_errechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Benzinverbrauch auf 100 Kilometer ******\n");
            Console.Write("Bitte geben Sie den Benzinverbrauch in Litern an: ");

            double liter = double.Parse(Console.ReadLine());

            Console.Write("\nBitte geben Sie die zurückgelegte Strecke in Kilometern an: ");

            double strecke = double.Parse(Console.ReadLine());

            double verbrauch = liter / strecke * 100;

            Console.Clear();

            Console.Write($"Der Verbrauch auf 100 Kilometern beträgt: {verbrauch} Liter.\n\n" +
                $"Schaffen Sie sich endlich einen Elektrowagen an!");

            Console.ReadKey();
        }
    }
}
