namespace Aufgabe_2022_01_05__Verzweigungen__Zahlenbereich
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            int zahl;
            char art;

            //Verzweigung Art der Lösung
            Console.Write("(u)nd oder (o)der-Lösung: ");
            art = Console.ReadKey().KeyChar;
            art = char.ToLower(art);

            switch (art)
            {
                case 'u':
                    Console.Write("Bitte geben Sie eine Zahl zwischen 10 und 100 ein: ");
                    zahl = Console.ReadKey().KeyChar;

                    if (zahl > 10 && zahl < 100)
                    {
                        Console.WriteLine("richtig");
                    }
                    else
                    {
                        Console.WriteLine("falsch");
                    }

                    break;
                case 'o':
                    Console.Write("Bitte geben Sie eine Zahl zwischen 10 und 100 ein: ");
                    zahl = Console.ReadKey().KeyChar;

                    if (zahl < 100 || zahl > 10)
                    {
                        Console.WriteLine("richtig");
                    }
                    else
                    {
                        Console.WriteLine("falsch");
                    }
                    break;
            }

        }
    }
}
