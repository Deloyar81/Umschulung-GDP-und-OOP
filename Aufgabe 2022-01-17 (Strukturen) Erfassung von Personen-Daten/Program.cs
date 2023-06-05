string[] daten = new string[0];
Eingabe(0, daten);


//Eingabe
static void Eingabe(int counter, string[] daten)
{
    //Datensatz-Array erweitern
    Array.Resize(ref daten, daten.Length + 1);

    //Console.WriteLine("Wie viele Datensätze möchten Sie eingeben");
    Console.WriteLine("Bitte geben Sie den Vornamen, Nachnamen, Steuersatz und das Bruttogehalt ein (per Komma getrennt): ");
    string eingabe = Console.ReadLine();
    daten[counter] = eingabe;

    //Weitere Datensätze?
    Console.WriteLine("");
    Console.WriteLine("Möchten Sie einen weiteren Datensatz eingeben? J/N: ");
    char weiter = Console.ReadKey(true).KeyChar;
    Console.WriteLine("");

    switch (weiter)
    {
        case 'j':
        case 'J':
            counter++;
            Eingabe(counter, daten);
            break;
        case 'n':
        case 'N':
            break;
        default:
            break;
    }

    //Bildschirm säubern
    Console.Clear();

    //Übergabe der Daten
    for (int i = 0; i < daten.Length; i++)
    {
        //Split
        string[] teile = daten[i].Split(',');

        //Leerzeichen entfernen
        teile[0] = teile[0].Trim();
        teile[1] = teile[1].Trim();
        teile[2] = teile[2].Trim();
        teile[3] = teile[3].Trim();

        //PersDatensatz(teile[0], teile[1], teile[2], teile[3]);

        //nötige Konvertierung
        double ssatz = Convert.ToDouble(teile[2]);
        double brutto = Convert.ToDouble(teile[3]);

        //Struktur befüllen


        Personendaten[] pers = new Personendaten[daten.Length];
        pers[i] = new Personendaten(teile[0], teile[1], ssatz, brutto);
    }
    Console.ReadKey();
}

//Weiterverarbeitung des Datensatzes in ein Array und Ausgabe
static void PersDatensatz(string vorname, string nachname, string steuersatz, string bruttogehalt)
{
    //nötige Konvertierung
    double ssatz = Convert.ToDouble(steuersatz);
    double brutto = Convert.ToDouble(bruttogehalt);

    //Struktur befüllen
    Personendaten alledaten = new Personendaten(vorname, nachname, ssatz, brutto);

    //Ausgabe des Datensatzes
    {
        string a = "";

        alledaten.AusgabeDatensatz();
        Console.WriteLine("Nettogehalt: {0}", alledaten.Nettogehalt());
        Console.WriteLine();
        Console.WriteLine(a.PadLeft(20, '#'));
        Console.WriteLine();
    }
}


//Struktur
struct Personendaten
{
    private readonly string vorname;
    private readonly string nachname;
    private readonly double steuersatz;
    private readonly double bruttogehalt;

    public Personendaten(string vname, string nname, double ssatz, double brutto)
    {
        vorname = vname;
        nachname = nname;
        steuersatz = ssatz;
        bruttogehalt = brutto;
    }

    public string Vorname { get { return vorname; } }
    public string Nachname { get { return nachname; } }
    public double Steuersatz { get { return steuersatz; } }
    public double Bruttogehalt { get { return bruttogehalt; } }

    //Ausgabeerstellung
    public void AusgabeDatensatz()
    {
        Console.WriteLine("Name: {0} {1}", vorname, nachname);
        Console.WriteLine("Steuersatz: {0}%", steuersatz);
        Console.WriteLine("Bruttogehalt: {0}", bruttogehalt);
    }

    public double Nettogehalt()
    {
        double netto = bruttogehalt - (bruttogehalt * steuersatz / 100);
        return netto;
    }
}