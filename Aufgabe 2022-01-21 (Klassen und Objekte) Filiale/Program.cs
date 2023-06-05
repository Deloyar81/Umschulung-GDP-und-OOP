//Variablen
int counter = 0, i = 0;



//Filiale[] filiale = new Filiale[0];
string[] filialenanzahl = new string[0];

Eingabe(counter, filialenanzahl, i);

static void Eingabe(int counter, string[] filialenanzahl, int i)
{
    //Prime Array vergrößern
    Array.Resize(ref filialenanzahl, filialenanzahl.Length + 1);

    //Datensatz anlegen
    Console.Write("Bitte geben Sie den Namen der Filiale ein: ");
    string eingabe = Console.ReadLine();
    filialenanzahl[counter] = eingabe;

    //Weitere Datensätze?
    Console.WriteLine("");
    Console.WriteLine("Möchten Sie einen weiteren Datensatz anlegen? J/N: ");
    char weiter = Char.ToLower(Console.ReadKey(true).KeyChar);
    Console.WriteLine("");

    switch (weiter)
    {
        case 'j':
            counter++;
            Eingabe(counter, filialenanzahl, i);
            break;
        case 'n':
            break;
        default:
            break;
    }

    //Bildschirm säubern
    Console.Clear();

    //Filiale-Array erstellen
    Filiale[] filiale = new Filiale[filialenanzahl.Length];

    //Objekt-Array befüllen
    for (int d = 0; d < filialenanzahl.Length; d++)
    {

        filiale[d] = new Filiale(filialenanzahl[d]);

    }
    Menu(filiale, i);

}

//Menu
static void Menu(Filiale[] filiale, int i)
{
    int eingabe = 0;

    //Auswahl Menu
    while (true)
    {
        Console.Clear();
        Console.Write("\n\nWas möchten Sie tun?" +
                        "\n\n" +
                        "\n(1) - Filiale wechseln" +
                        "\n(2) - Infortmationen über die aktive Filiale" +
                        "\n(3) - Einkaufen" +
                        "\n(4) - Verkaufen" +
                        "\n(5) - Programm beenden");

        eingabe = (int)Console.ReadKey(true).KeyChar - 48;
        Console.Clear();

        switch (eingabe)
        {
            case 1:
                Console.WriteLine("Welche Filiale möchten Sie sich anschauen?\n");

                for (int z = 0; z < filiale.Length; z++)
                {
                    Console.WriteLine("{0} - {1}", z + 1, filiale[z].Name);
                }

                i = (int)Console.ReadKey(true).KeyChar - 49;


                for (int j = 0; j < filiale.Length; j++)
                {
                    if (i == j)
                    {
                        i = j;
                        filiale[j].Ausgabe();
                    }
                }
                break;

            case 2:
                filiale[i].Ausgabe();
                break;

            case 3:
                filiale[i].Einkauf();
                break;

            case 4:
                filiale[i].Verkauf();
                break;

            case 5:

                return;
        }
    }
    Thread.Sleep(2000);
}


//Klasse Filiale definieren
public class Filiale
{
    private string name;
    private int warenbestand;
    private double kasse;

    public Filiale(string name)
    {
        this.name = name;
        this.warenbestand = 100;
        this.kasse = 500.00;
    }

    public string Name
    {
        get { return name; }
        //set { name = Console.ReadLine() ; }
    }

    public int Warenbestand
    {
        get { return warenbestand; }
    }

    public double Kasse
    {
        get { return kasse; }
    }

    public void Ausgabe()
    {
        Console.WriteLine("\n\nFiliale: {0}" +
                            "\n\nDer aktuelle Warenbestand: {1}" +
                            "\nGeld in der Kasse: {2}€", this.name, this.warenbestand, this.kasse);
        Console.ReadLine();
    }

    public void Verkauf()
    {
        if (warenbestand > 0)
        {
            kasse = kasse + 20;
            warenbestand--;
        }
        else
        {
            Console.WriteLine("Der aktuelle Warenbestand ist {0}, von daher kann nichts verkauft werden.", warenbestand);
        }
        Ausgabe();
    }

    public void Einkauf()
    {
        if (kasse >= 10)
        {
            kasse = kasse - 10;
            warenbestand++;
        }
        else
        {
            Console.WriteLine("Der aktuelle KAsseninhalt ist {0}, von daher kann nichts gekauft werden.", kasse);
        }
        Ausgabe();
    }
}

