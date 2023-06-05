namespace Aufgabe_2022_01_05__Verzweigungen__Rabatte
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            int stück;
            double preis, gesamt;

            //Eingabe
            Console.Write("Bitte geben Sie die Stückzahl ein: ");
            stück = int.Parse(Console.ReadLine());

            Console.Write("Bitte geben Sie den Stückpreis ein: ");
            preis = double.Parse(Console.ReadLine());

            gesamt = stück * preis;

            if (stück > 10 && stück < 50)
            {
                gesamt = gesamt * 0.95;
            }
            else if (stück > 50)
            {
                gesamt = gesamt * 0.90;
            }

            Console.WriteLine($"Der Gesamtpreis beträgt {Math.Round(gesamt, 2)} Euro.");

            Console.ReadKey();
        }
    }
}
