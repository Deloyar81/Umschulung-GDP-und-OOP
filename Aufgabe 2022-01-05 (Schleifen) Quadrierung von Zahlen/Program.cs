namespace Aufgabe_2022_01_05__Schleifen__Quadrierung_von_Zahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, zahl;

            while (i <= 10)
            {
                zahl = Convert.ToInt32(Math.Pow(i, 2));
                Console.WriteLine("Das Quadrat von {0, 2} ist {1, 3}", i, zahl);
                i++;
            }
            Console.ReadKey();
        }
    }
}
