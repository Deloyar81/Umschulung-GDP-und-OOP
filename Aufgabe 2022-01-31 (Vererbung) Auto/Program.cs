using Aufgabe_2022_01_31__Vererbung__Auto;

//Listen definieren
List<Auto> auto = new List<Auto>();
List<Pickup> pickup = new List<Pickup>();

//Variablen
string kennzeichen;
int exitmain = 0, exitauto = 0, sitzplaetze, eingabeauto;

Menu();

//Eingabe
void Eingabeauto()
{
    while (exitauto == 0)
    {
        Console.Clear();
        Console.WriteLine("(1) - Neuwagen eingeben (inkls. Sitzplätze & Kennzeichen)");
        Console.WriteLine("(2) - Neuwagen eingeben (inkls. Kennzeichen)");
        Console.WriteLine("(3) - Neuwagen eingeben (inkls. Sitzplätze)");
        Console.WriteLine("(4) - Gebrauchten (Kennzeichen DOO-M3) eingeben");



        Console.WriteLine("(5) - Exit");

        Console.Write("\n\nAuswahl: ");

        eingabeauto = Convert.ToInt32(Console.ReadLine());

        switch (eingabeauto)
        {
            case 1:
                Console.WriteLine("Bitte geben Sie das Kennzeichen ein: ");
                kennzeichen = Console.ReadLine();
                Console.WriteLine("Bitte geben Sie die Anzahl der Sitzplätze ein: ");
                sitzplaetze = Convert.ToInt32(Console.ReadLine());

                auto.Add(new Auto(kennzeichen, sitzplaetze));
                break;
            case 2:
                Console.WriteLine("Bitte geben Sie das Kennzeichen ein: ");
                kennzeichen = Console.ReadLine();

                auto.Add(new Auto(kennzeichen));
                break;
            case 3:
                Console.WriteLine("Bitte geben Sie die Anzahl der Sitzplätze ein: ");
                sitzplaetze = Convert.ToInt32(Console.ReadLine());

                auto.Add(new Auto(sitzplaetze));
                break;
            case 4:
                auto.Add(new Auto());
                break;
            case 5:
                exitauto = 1;
                break;
        }
    }
}

void EingabePickUp()
{
    while (exitauto == 0)
    {
        Console.Clear();
        Console.WriteLine("(1) - Neuwagen eingeben (inkls. Sitzplätze & Kennzeichen)");
        Console.WriteLine("(2) - Neuwagen eingeben (inkls. Kennzeichen)");
        Console.WriteLine("(3) - Neuwagen eingeben (inkls. Sitzplätze)");
        Console.WriteLine("(4) - Gebrauchten (Kennzeichen DOO-M3) eingeben");



        Console.WriteLine("(5) - Exit");

        Console.Write("\n\nAuswahl: ");

        eingabeauto = Convert.ToInt32(Console.ReadLine());

        switch (eingabeauto)
        {
            case 1:
                Console.WriteLine("Bitte geben Sie das Kennzeichen ein: ");
                kennzeichen = Console.ReadLine();
                Console.WriteLine("Bitte geben Sie die Anzahl der Sitzplätze ein: ");
                sitzplaetze = Convert.ToInt32(Console.ReadLine());

                auto.Add(new Auto(kennzeichen, sitzplaetze));
                break;
            case 2:
                Console.WriteLine("Bitte geben Sie das Kennzeichen ein: ");
                kennzeichen = Console.ReadLine();

                auto.Add(new Auto(kennzeichen));
                break;
            case 3:
                Console.WriteLine("Bitte geben Sie die Anzahl der Sitzplätze ein: ");
                sitzplaetze = Convert.ToInt32(Console.ReadLine());

                auto.Add(new Auto(sitzplaetze));
                break;
            case 4:
                auto.Add(new Auto());
                break;
            case 5:
                exitauto = 1;
                break;
        }
    }
}

//Menu
void Menu()
{


    //Hauptmenu
    while (exitmain == 0)
    {


        Console.WriteLine("(1) - Auto eingeben");
        Console.WriteLine("(2) - PickUp eingeben");
        Console.WriteLine("(3) - Auto ausgeben");
        Console.WriteLine("(4) - PickUp ausgeben");



        Console.WriteLine("(5) - Exit");

        Console.Write("\n\nAuswahl: ");

        int eingabemain = Convert.ToInt32(Console.ReadLine());

        switch (eingabemain)
        {
            case 1:

                //Untermenu
                Eingabeauto();

                break;
            case 2:
                EingabePickUp();
                break;
            case 3:
                foreach(Auto fahrzeug in auto)
                {
                    Console.WriteLine(fahrzeug.ToString());
                }
                Console.ReadKey();
                break;

            case 4:
                foreach (Pickup fahrzeug in pickup)
                {
                    fahrzeug.ToString();
                }
                Console.ReadKey();
                break;
            case 5:
                exitmain = 1;
                break;


        }
    }
}