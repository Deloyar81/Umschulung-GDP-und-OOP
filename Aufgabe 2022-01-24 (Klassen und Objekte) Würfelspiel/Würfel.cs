//Variablen
int counter = 0, i = 0;

//Filiale[] filiale = new Filiale[0];
string[] spieleranzahl = new string[0];

//Eingabe
//Eingabe(counter, spieleranzahl, i);

Player[] spieler = new Player[2];

Console.Write("Bitte geben Sie Spieler 1 ein: ");
spieler[0] = new Player(Console.ReadLine());

Console.Write("Bitte geben Sie Spieler 2 ein: ");
spieler[1] = new Player(Console.ReadLine());

for (i = 0; i < spieler.Length; i++)
{
    spieler[i].Gamble();
    Console.WriteLine("");
    Console.WriteLine("Spieler: {0} hat die Gesamt-Punktzahl: {1}\n", spieler[i].Name, spieler[i].GetScore());
    Console.WriteLine("");
}

if (spieler[0].GetScore() > spieler[1].GetScore())
{
    Console.WriteLine("{0} ist Sieger!", spieler[0].Name);
}
else if (spieler[0].GetScore() < spieler[1].GetScore())
{
    Console.WriteLine("{0} ist Sieger!", spieler[1].Name);
}
else
{
    Console.WriteLine("Unentschieden! {0} hat genau soviele Punkte wie {1}.", spieler[0].Name, spieler[1].Name);
}

Console.ReadKey();

static void Eingabe(int counter, string[] spieleranzahl, int i)
{
    //Prime Array vergrößern
    Array.Resize(ref spieleranzahl, spieleranzahl.Length + 1);

    //Datensatz anlegen
    Console.Write("Bitte geben Sie den Namen des Spielers ein: ");
    string eingabe = Console.ReadLine();
    spieleranzahl[counter] = eingabe;

    //Weitere Datensätze?
    Console.WriteLine("");
    Console.WriteLine("Möchten Sie einen weiteren Spieler eingeben? J/N: ");
    char weiter = Char.ToLower(Console.ReadKey(true).KeyChar);
    Console.WriteLine("");

    switch (weiter)
    {
        case 'j':
            counter++;
            Eingabe(counter, spieleranzahl, i);
            break;
        case 'n':
            break;
        default:
            break;
    }

    //Bildschirm säubern
    Console.Clear();
    Console.WriteLine("Spieleranzahl {0}", spieleranzahl.Length);
    //Spieler-Array erstellen
    Player[] player = new Player[spieleranzahl.Length];

    //Objekt-Array befüllen
    for (int d = 0; d < spieleranzahl.Length; d++)
    {

        player[d] = new Player(spieleranzahl[d]);
        player[d].Gamble();


    }
    Console.ReadKey();
    Console.WriteLine("{0}", player[1]);

    for (i = 0; i < spieleranzahl.Length; i++)
    {
        Console.WriteLine("Spieler: {0} hat folgende Gesamt-Punktzahl: {1}", player[i].Name, player[i].GetScore());
    }


}


//Klasse
class Player
{
    private int score;
    private string name;

    public Player(string name)
    {
        this.name = name;
    }

    public string Name
    { get { return name; } }

    public void Gamble()
    {
        int wurf, erg = 0;

        Random random = new Random();

        Console.WriteLine();
        Console.WriteLine("Spieler {0} hat folgende Würfe:", name);
        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            wurf = random.Next(1, 7);
            Console.Write("| {0} ", wurf);

            erg += wurf;

            score = erg;
        }
        Console.WriteLine();
    }

    public int GetScore()
    {
        return score;
    }
}
