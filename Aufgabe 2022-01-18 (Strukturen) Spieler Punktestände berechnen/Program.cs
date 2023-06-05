//Array
static void spielerarray(int eingabe)
{
    //Array erstellen
    string[] namearray = new string[10];

    Gambler[] gambler = new Gambler[eingabe];

    //random zahl
    Random zahl = new Random();


    int i = zahl.Next(1, 11);

    //Namen-Array befüllen
    namearray[0] = "Adam Andler";
    namearray[1] = "Gerhard Gröder";
    namearray[2] = "Ammelie Auser";
    namearray[3] = "Winfried Wotto";
    namearray[4] = "Marl Mey";
    namearray[5] = "Sabine Schröder";
    namearray[6] = "Erhard Emser";
    namearray[7] = "Manuela Meier";
    namearray[8] = "Lieselotte Lang";
    namearray[9] = "Theodor Tarf";

    //Struktur befüllen
    for (int j = 0; j < eingabe; j++)
    {
        int punkte = zahl.Next(1, 101);
        gambler[j] = new Gambler(namearray[j], punkte);
    }

    //Bubblesort
    int sort;

    do
    {
        sort = 0;

        for (int j = 0; j < eingabe; j++)
        {
            for (int k = 0; k < eingabe - 1; k++)
            {
                if (gambler[k].Punkte < gambler[k + 1].Punkte)
                {
                    Gambler buffer = gambler[k];
                    gambler[k] = gambler[k + 1];
                    gambler[k + 1] = buffer;
                }
            }
            sort = 1;
        }
    } while (sort != 1);

    //Ausgabe
    foreach (Gambler x in gambler)
    {
        Console.WriteLine($"+" + "".PadRight(51, '-') + "+");
        Console.WriteLine("| Name: {0} | Punkte: {1, 2} |", x.Name.PadRight(30, ' '), x.Punkte);
    }
    Console.WriteLine($"+" + "".PadRight(51, '-') + "+");

    Console.ReadKey();
}

//Eingabe
Console.Write("Wieviele Spieler nehmen teil (maximal 10): ");
int eingabe = int.Parse(Console.ReadLine());

spielerarray(eingabe);

//Struktur Gambler
struct Gambler
{
    private readonly string pname;
    private readonly int punktestand;

    public Gambler(string name, int punkte)
    {
        pname = name;
        punktestand = punkte;
    }

    public string Name { get { return pname; } }
    public int Punkte { get { return punktestand; } }

}