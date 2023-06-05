namespace Aufgabe_2022_01_05__Verzweigungen__Zahl_gerade_oder_ungerade
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl;
            do
            {
                Console.Write("Bitte geben Sie eine Zahl im Bereich 1-100 ein: ");
                zahl = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (zahl < 1 || zahl > 100);

            if (zahl % 2 == 0)
            {
                Console.WriteLine($"Die eingegebene Zahl ({zahl}) ist gerade.");
            }
            else
            {
                Console.WriteLine($"Die eingegebene Zahl ({zahl}) ist ungerade.");
            }

            Console.ReadKey();
        }
    }
}
