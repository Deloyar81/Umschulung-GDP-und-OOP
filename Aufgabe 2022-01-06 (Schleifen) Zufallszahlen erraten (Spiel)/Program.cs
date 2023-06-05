namespace Aufgabe_2022_01_06__Schleifen__Zufallszahlen_erraten__Spiel_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable für Programmende

            char eingabe;

            //Programmdurchlauf

            do
            {
                {
                    //Variablen

                    int z, zahl, counter = 1, limit, ende = 0;

                    //Randomisieren

                    Random zufall = new Random();
                    zahl = zufall.Next(1, 101);

                    //Ausgabe von Abfrage

                    Console.Write("Lege die Schwierigkeit des Spieles fest! Wieviele Versuche möchtest du haben? \n\n");
                    limit = int.Parse(Console.ReadLine());

                    Console.Clear();

                    Console.Write("Eine Stimme aus der Dunkelheit fragt: Wollen wir ein Spiel spielen?\n\n");

                    Console.Write($"Ich denke mir eine Zahl zwischen 1 und 100 aus und du musst sie erraten.\n\nWähle richtig und du darfst leben... du hast {limit} Versuche!\n\n");
                    Console.Write($"Nenne mir deine Zahl!\n\n");
                    z = int.Parse(Console.ReadLine());

                    //Spiel

                    while (z != zahl)
                    {
                        Console.Clear();

                        //Game over bei erreichen der Limitgrenze -> siehe Zeile 93
                        if (limit - counter > 0)
                        {
                            //Zahl kleiner/größer Verzweigung

                            if (z < zahl)
                            {
                                //Einzahl/Mehrzahl Verzweigung

                                if (limit - counter == 1)
                                {
                                    Console.WriteLine($"{z} ist die falsche Zahl. Das war Versuch {counter}. \n\n{z} ist kleiner als die gesuchte Zahl! Du hast noch {limit - counter} Versuch!");
                                }
                                else
                                {
                                    Console.WriteLine($"{z} ist die falsche Zahl. Das war Versuch {counter}. \n\n{z} ist kleiner als die gesuchte Zahl! Du hast noch {limit - counter} Versuche!");
                                }
                            }
                            else if (z > zahl)
                            {
                                //Einzahl/Mehrzahl Verzweigung

                                if (limit - counter == 1)
                                {
                                    Console.WriteLine($"{z} ist die falsche Zahl. Das war Versuch {counter}. \n\n{z} ist größer als die gesuchte Zahl! Du hast noch {limit - counter} Versuch!");
                                }
                                else
                                {
                                    Console.WriteLine($"{z} ist die falsche Zahl. Das war Versuch {counter}. \n\n{z} ist größer als die gesuchte Zahl! Du hast noch {limit - counter} Versuche!");
                                }
                            }
                            counter++;

                            Console.WriteLine($"\nGebe eine neue Zahl ein. Bedenke den Hinweis!\n\n");
                            z = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            ende = 1;
                            break;
                        }
                    };

                    //Game Over bei Limitgrenze
                    if (ende == 1)
                    {
                        Console.Write("Game Over!\n\nDu wirst hier nicht mehr rauskommen...\n\nOder...\n");
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine($"Herzlichen Glückwunsch, {z} ist die gesuchte Zahl.");
                        Console.WriteLine($"\nDu hast {counter} Versuche benötigt.");
                    }
                }

                Console.Write($"\n\nWillst du noch ein Spiel wagen (J/N)? ");
                eingabe = Console.ReadKey(true).KeyChar;

                Console.Clear();

            } while (eingabe == 'j');
        }
    }
}
