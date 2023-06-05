//Main
Eingabe();
Console.ReadKey();

//Funktion Eingabe
static void Eingabe()
{
    //Variablen
    string name, rasse;
    int jahr, hoecker;

    //Eingabe

    Console.Write("Wieviele Kamele möchten Sie in die Datenbank eingeben: ");
    int i = int.Parse(Console.ReadLine());

    //Random Funktion
    Random random = new Random();

    //Struktur erstellen
    Kamel[] kamel = new Kamel[i];

    //Struktur befüllen
    for (int z = 0; z < i; z++)
    {
        Console.Write("Bitte geben Sie den Namen des Kamels ein: ");
        name = Console.ReadLine();
        jahr = random.Next(1960, 2023);
        hoecker = random.Next(0, 3);

        //Rasse bestimmen
        if (hoecker == 0)
        {
            rasse = "Lama";
        }
        else if (hoecker == 1)
        {
            rasse = "Dromedar";
        }
        else
        {
            rasse = "Kamel";
        }

        kamel[z] = new Kamel(name, jahr, hoecker, rasse);
    }

    //Ausgabe
    Console.Clear();
    for (int z = 0; z < i; z++)
    {
        Ausgabe(kamel[z]);
    }
    Console.WriteLine("".PadLeft(20, '#'));

}

//Funktion Ausgabe
static void Ausgabe(Kamel kamel)
{
    Console.WriteLine("".PadLeft(20, '#'));
    Console.WriteLine();
    Console.WriteLine("Name: {0}", kamel.Name);
    Console.WriteLine("Jahrgang: {0}", kamel.Jahrgang);
    Console.WriteLine("Höckeranzahl: {0}", kamel.Hoeckeranzahl);
    Console.WriteLine("Rasse: {0}", kamel.Rasse);
    Console.WriteLine();
}

//Struktur
struct Kamel
{
    private readonly string name;
    private readonly int jahrgang;
    private readonly int hoeckeranzahl;
    private readonly string rasse;

    public Kamel(string _name, int _jahrgang, int _hoeckeranzahl, string _rasse)
    {
        name = _name;
        jahrgang = _jahrgang;
        hoeckeranzahl = _hoeckeranzahl;
        rasse = _rasse;
    }

    public string Name { get { return name; } }
    public int Jahrgang { get { return jahrgang; } }
    public int Hoeckeranzahl { get { return hoeckeranzahl; } }
    public string Rasse { get { return rasse; } }
}