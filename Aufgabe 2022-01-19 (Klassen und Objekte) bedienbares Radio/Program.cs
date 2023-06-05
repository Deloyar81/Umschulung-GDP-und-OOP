//Main
Menu();


//Funktion Textausgabe in Console zentrieren
static void CenterText(string text)
{
    int winWidth = (Console.WindowWidth / 2);
    Console.WriteLine(String.Format("{0," + winWidth + "}", text));
    return;
}

//Funktion Menu
static void Menu()
{
    int ende = 0, eingabe, lstärke;
    string text;

    Radio radio1 = new Radio();

    while (true)
    {
        Console.WriteLine("Sie haben ein wunderschönes neues Radio mit unglaublich vielen Funktionen erstanden!");
        Console.WriteLine();

        //Farbe abängig vom Zustand
        if (radio1.IstAn() == false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        Console.WriteLine(radio1.RadioInfo());

        //durchlaufende Radiostation
        Console.CursorVisible = false;

        Console.Write("");
        Console.WriteLine("+-----------------------------------------------------------------------------------+\n");

        Console.ForegroundColor = ConsoleColor.Gray;

        Console.WriteLine();
        Console.WriteLine("Sie haben folgende Funktionen zur Auswahl:\n");
        Console.WriteLine("(1) - Radio einschalten");
        Console.WriteLine("(2) - Radio ausschalten");
        Console.WriteLine("(3) - Lautstärke erhöhen");
        Console.WriteLine("(4) - Lautstärke vermindern");
        Console.WriteLine("(5) - Frequenz einstellen");
        Console.WriteLine("(6) - Radio umtauschen");

        //Auswahl
        eingabe = Console.ReadKey(true).KeyChar;

        switch (eingabe)
        {
            case '1':
                radio1.Einschalten();
                Console.ReadKey();
                break;
            case '2':
                radio1.Ausschalten();
                break;
            case '3':
                Console.WriteLine("\nUm wieviel Prozent möchten Sie Ihre Lautstärke erhöhen?");
                lstärke = int.Parse(Console.ReadLine());
                for (int i = 0; i < lstärke; i++)
                {
                    radio1.Lauter();
                }
                Console.WriteLine("\nDie Lautstärke ist jetzt auf {0} Prozent eingestellt.", radio1.Lautstaerke());
                Thread.Sleep(4000);
                break;
            case '4':
                Console.WriteLine("\nUm wieviel Prozent möchten Sie Ihre Lautstärke vermindern?");
                lstärke = int.Parse(Console.ReadLine());
                for (int i = 0; i < lstärke; i++)
                {
                    radio1.Leiser();
                }
                Console.WriteLine("\nDie Lautstärke ist jetzt auf {0} Prozent eingestellt.", radio1.Lautstaerke());
                Thread.Sleep(4000);
                break;
            case '5':
                radio1.Frequenz();
                Thread.Sleep(4000);
                break;
            case '6':
                return;
            default:
                break;
        }

        Console.WriteLine("\n");

        Console.Clear();

    }
}

//Klasse radio
class Radio
{
    //Attribute
    private const int lautmax = 100;
    private const int lautmin = 0;
    private int lautstaerke;
    private bool eingeschaltet;
    private string frequenz;

    //Konstruktor
    public Radio()
    {
        lautstaerke = lautmin;
        eingeschaltet = false;
        frequenz = "00,0";
    }

    //Methoden
    public int Lautstaerke()
    {
        return lautstaerke;
    }

    public void Lauter()
    {
        if (lautstaerke < 100)
        {
            lautstaerke++;
        }
    }

    public void Leiser()
    {
        if (lautstaerke > 0)
        {
            lautstaerke--;
        }
    }

    public void Einschalten()
    {
        if (eingeschaltet == false)
        {
            eingeschaltet = true;
            Console.WriteLine("\nDas Radio ist eigeschaltet");
            Console.ReadKey();
            Thread.Sleep(5000);
        }
    }

    public void Ausschalten()
    {
        if (eingeschaltet == true)
        {
            eingeschaltet = false;
            Console.WriteLine("\nDas Radio ist ausgeschaltet");
            Thread.Sleep(500);
        }
    }

    public bool IstAn()
    {
        return eingeschaltet;
    }

    public string RadioInfo()
    {
        string radioinfo1 = "+-----------------------------------------------------------------------------------+\n";
        string radioinfo2 = "| Zustand des Radios:                                                               |\n";
        string radioinfo3 = "|                                                                                   |\n";
        string radioinfo4 = $"| Radio an:";
        string radioinfo5 = $" {IstAn(),5}                                                                   |\n";
        string radioinfo6 = $"| eingestellte Frequenz/Sender: {Kanal(),4} MHz / {Sender(Kanal()),21}                    |\n";
        string radioinfo7 = $"| eingestellte Lautstärke: {Lautstaerke(),3}%                                                     |\n";
        string radioinfo8 = "+-----------------------------------------------------------------------------------+\n";

        string radioinfo = radioinfo1 + radioinfo2 + radioinfo3 + radioinfo4 + radioinfo5 + radioinfo6 + radioinfo7 + radioinfo8;

        return radioinfo;
    }

    public string Kanal()
    {
        return frequenz;
    }

    public string Sender(string frequenz)
    {
        string station = string.Empty;

        //Array Radiosender
        string[,] sender = { { "87,6", "87,7", "98,5", "87,7", "", "" },
                             {"WDR 1 Live", "WDR 5", "Radio Bochum", "WDR 4", "", "" } };

        //Suche nach Sender
        for (int i = 0; i < sender.Length / 2 - 1; i++)
        {
            if (Kanal() == sender[0, i])
            {
                station = sender[1, i];
            }

        }

        if (station.Length == 0)
        {
            station = "Kein Sender gefunden!";
        }

        //Ausgabe
        return station;
    }

    public void Frequenz()
    {
        //Auswahl
        Console.Clear();
        Console.WriteLine("Wie wollen Sie die Frequenz einstellen?\n");
        Console.WriteLine("1 - per Hand\n");
        Console.WriteLine("2 - automatisch\n");

        int wahl = Console.ReadKey(true).KeyChar;

        if (wahl == '1')

        {
            Console.WriteLine($"\nDie Frequenz ist aktuell auf {frequenz} MHz eingestellt\n");
            Console.Write($"\nBitte geben Sie die neue Frequenz ein: ");
            frequenz = Console.ReadLine();

            Console.WriteLine($"\nDie Frequenz ist jetzt auf {frequenz} MHz eingestellt");
        }
        else
        {
            Console.Clear();
            Console.Write("Automatische Frequenzsuche läuft...");
            Console.CursorVisible = false;

            //"Animation" der Frequenz-Suche
            for (int i = 0; i < 50; i++)
            {
                Console.SetCursorPosition(i, 2);

                if (Console.CursorLeft <= 16)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (Console.CursorLeft <= 35)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (Console.CursorLeft <= 50)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.Write("-");
                Thread.Sleep(50);
                Console.SetCursorPosition(i, 2);
                Console.Write("\\");
                Thread.Sleep(50);
                Console.SetCursorPosition(i, 2);
                Console.Write("|");
                Thread.Sleep(50);
                Console.SetCursorPosition(i, 2);
                Console.Write("/");
                Thread.Sleep(50);

                Console.SetCursorPosition(25, 2);
                Console.Write(" {0, 2}% ", i * 2);
                Thread.Sleep(50);

            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.CursorVisible = true;
            Console.Clear();

            //Ausgabe
            Console.WriteLine("Die beste lokale Frequenz ist eingestellt:");
            frequenz = "98,5";
            Console.WriteLine("\n{0}: {1} MHz", Sender(frequenz), frequenz);

            Console.WriteLine($"\nDie Frequenz ist jetzt auf {frequenz} MHz eingestellt");
        }
    }
}