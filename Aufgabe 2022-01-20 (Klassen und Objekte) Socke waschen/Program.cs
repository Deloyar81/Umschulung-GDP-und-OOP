namespace Aufgabe_2022_01_20__Klassen_und_Objekte__Socke
{
    class Program
    {
        static void Main()
        {
            string farbe = "";

            Socke socke1 = new Socke(farbe);

            socke1.farbe = "braun";
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Was möchten Sie tun?");
                Console.WriteLine("(1) - Socke waschen");
                Console.WriteLine("(2) - Socke trocknen");
                Console.WriteLine("(3) - Zustand der Socke");
                Console.WriteLine("(4) - Programm beenden");

                int eingabe = Console.ReadKey(true).KeyChar;
                Console.Clear();
                switch (eingabe)
                {
                    case '1':
                        socke1.Wasche();
                        Console.ReadKey();
                        break;
                    case '2':
                        socke1.Trockne();
                        Console.ReadKey();
                        break;
                    case '3':
                        socke1.Ausgabe();
                        Console.ReadKey();
                        break;
                    case '4':
                        return;
                }
            }
            Console.ReadKey();




        }
    }
}










