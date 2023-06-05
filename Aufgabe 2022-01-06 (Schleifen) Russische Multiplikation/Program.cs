namespace Aufgabe_2022_01_06__Schleifen__Russische_Multiplikation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            decimal zahl1, z1;
            int zahl2, z2, erg = 0;

            //Eingabe
            Console.Write("Bitte geben Sie die erste Zahl (größer als 0) ein: ");
            zahl1 = int.Parse(Console.ReadLine());

            Console.Write("Bitte geben Sie die zweite Zahl (größer als 0) ein: ");
            zahl2 = int.Parse(Console.ReadLine());

            z1 = zahl1;
            z2 = zahl2;

            //Fehler abfangen
            if (zahl1 <= 0 || zahl2 <= 0)
            {
                Console.WriteLine("Die Zahlen müssen größer 0 sein!");
                Thread.Sleep(1000);
                return;
            }
            else
            {
                ////Schleife
                //do
                //{
                //    if (zahl1 % 2 == 0)
                //    {
                //        Console.Write("\n         | {0, 3} || ", zahl1);
                //        Console.ForegroundColor = ConsoleColor.Red;
                //        Console.Write("{0, 3}", zahl2);
                //        Console.ForegroundColor = ConsoleColor.Gray;
                //        Console.WriteLine(" |");
                //    }

                //    if (zahl1 % 2 == 1)
                //    {
                //        erg += zahl2;
                //        Console.Write("         | {0, 3} || ", zahl1);
                //        Console.ForegroundColor = ConsoleColor.Green;
                //        Console.Write("{0, 3}", zahl2);
                //        Console.ForegroundColor = ConsoleColor.Gray;
                //        Console.WriteLine(" |");
                //    }



                //    zahl1 = Math.Floor(zahl1 / 2);
                //    zahl2 = zahl2 * 2;
                //} while (zahl1 >= 1);

                //Schleife
                for (; zahl1 >= 1;)
                {
                    if (zahl1 % 2 == 0)
                    {
                        Console.Write("\n         | {0, 3} || ", zahl1);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0, 3}", zahl2);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" |");
                    }

                    if (zahl1 % 2 == 1)
                    {
                        erg += zahl2;
                        Console.Write("         | {0, 3} || ", zahl1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0, 3}", zahl2);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" |");
                    }



                    zahl1 = Math.Floor(zahl1 / 2);
                    zahl2 = zahl2 * 2;
                }
            }

            Console.WriteLine("\nErgebnis |     || {0, 3} |", erg);

            //Ausgabe
            Console.WriteLine("\nDas Ergebnis von {0} * {1} ist {2}.", z1, z2, erg);

            Console.ReadKey();
        }
    }
}