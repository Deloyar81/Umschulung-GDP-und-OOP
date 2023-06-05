//Menu nicht rekursiv aufrufen

//




Person[] array = new Person[0];
int i = 1;
Menue(i);
static Person[] Erhoehung(Person[] array)
{
    Array.Resize(ref array, array.Length + 1);
    return array;
}
void Menue(int i)
{
    int exit = 0;
    while (exit == 0)
    {
        Console.WriteLine("\n1 - Neue Person erstellen.");
        Console.WriteLine("2 - Person wechseln.");
        Console.WriteLine("3 - Nachname ändern.");
        Console.WriteLine("4 - Name und Alter ausgeben.");
        Console.WriteLine("5 - Adresse ändern.");
        Console.WriteLine("6 - Adresse ausgeben.");
        Console.WriteLine("7 - Konto Einzahlung.");
        Console.WriteLine("8 - Konto Auszahlung.");
        Console.WriteLine("9 - Konto Ausgabe.");
        Console.WriteLine("10 - Konto Auflösen.");
        Console.WriteLine("11 - Beenden.\n");
        int eingabe = int.Parse(Console.ReadLine());
        switch (eingabe)
        {
            case 1:
                array = Erhoehung(array);
                Console.WriteLine("Vorname eingeben: ");
                string eingabevorname = Console.ReadLine();
                Console.WriteLine("Nachname eingeben: ");
                string eingabenachname = Console.ReadLine();
                Console.WriteLine("Alter eingeben: ");
                int eingabealter = Convert.ToInt32(Console.ReadLine());
                array[array.Length - 1] = new Person(eingabevorname, eingabenachname, eingabealter);
                break;
            case 2:
                for (int j = 0; j < array.Length; j++)
                {
                    Console.WriteLine($"{j + 1} - {array[j].Nachname} auswählen.");
                }
                i = int.Parse(Console.ReadLine());
                break;
            case 3:
                array[i - 1].Nachname_Eingabe();
                break;
            case 4:
                array[i - 1].Person_Ausgabe();
                break;
            case 5:
                array[i - 1].Adresse_Eingabe();
                break;
            case 6:
                array[i - 1].Adresse_Ausgabe();
                break;
            case 7:
                array[i - 1].Konto_Einzahlen();
                break;
            case 8:
                array[i - 1].Konto_Auszahlen();
                break;
            case 9:
                array[i - 1].Konto_Ausgabe();
                break;
            case 10:
                array[i - 1].Konto_Ausgabe();
                break;
            case 11:
                exit = 1;
                return;
        }
    }
}
public class Person
{
    private string vorname;
    private string nachname;
    private int alter;
    private Adresse adresse = new Adresse();
    private Konto konto = new Konto();
    public Person(string vorname, string nachname, int alter)
    {
        this.nachname = nachname;
        this.vorname = vorname;
        this.alter = alter;
    }
    public string Vorname { get { return vorname; } set { vorname = value; } }
    public string Nachname { get { return nachname; } set { nachname = value; } }
    public int Alter { get { return alter; } set { alter = value; } }
    public Adresse PersonAdresse { get { return adresse; } set { adresse = value; } }
    public Konto PersonKonto { get { return konto; } set { konto = value; } }
    public void Nachname_Eingabe()
    {
        Console.Write($"Neuen Nachnamen für {this.Vorname} {this.Nachname} eingeben: ");
        this.nachname = Console.ReadLine();
    }
    public void Adresse_Eingabe()
    {
        Console.Write($"Strasse von Herr {this.Nachname}: ");
        adresse.Strasse = Console.ReadLine();
        Console.Write($"Hausnummer von {adresse.Strasse}: ");
        adresse.Hausnummer = Convert.ToInt32(Console.ReadLine());
        Console.Write($"PLZ von {adresse.Strasse} {adresse.Hausnummer}: ");
        adresse.Plz = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Zugehöriger Ort zu {adresse.Plz}: ");
        adresse.Ort = Console.ReadLine();
    }
    public void Person_Ausgabe()
    {
        Console.WriteLine($"{this.Vorname} {this.Nachname} ist {this.Alter} Jahre alt");
    }
    public void Adresse_Ausgabe()
    {
        Console.WriteLine($"Herr {this.Nachname} wohnt in der " +
    $"{adresse.Strasse} {adresse.Hausnummer} bei {adresse.Plz} {adresse.Ort}.");
    }
    public void Konto_Alterspruefung()
    {
        if (this.Alter >= 16)
            konto.Aktiv = true;
        else konto.Aktiv = false;
    }
    public void Konto_Einzahlen()
    {
        Konto_Alterspruefung();
        if (konto.Aktiv == true)
        {
            Console.Write($"Wieviel bei Herr {this.Nachname} einzahlen? ");
            konto.Guthaben += Convert.ToInt32(Console.ReadLine());
        }
        else Console.WriteLine($"Herr {this.Nachname} scheiterte an der Alterspruefung.");
    }
    public void Konto_Auszahlen()
    {
        Konto_Alterspruefung();
        Console.Write($"Wieviel bei Herr {this.Nachname} auszahlen? ");
        int auszahlen = Convert.ToInt32(Console.ReadLine());
        if (konto.Guthaben >= auszahlen && konto.Aktiv == true)
        {
            konto.Guthaben -= auszahlen;
        }
        if (konto.Guthaben < auszahlen && konto.Aktiv == true)
        {
            Console.WriteLine($"Auszahlung übersteigt Deckung.");
        }
        else Console.WriteLine($"Herr {this.Nachname} scheiterte an der Alterspruefung.");
    }
    public void Konto_Ausgabe()
    {
        Konto_Alterspruefung();
        if (konto.Aktiv == true)
        {
            Console.WriteLine($"Herr {this.Nachname} Kontostand beträgt {konto.Guthaben}");
        }
        else
        {
            Console.WriteLine($"Herr {this.Nachname} scheiterte an der Alterspruefung.");
        }
    }
    public void Konto_Aufloesen()
    {
        Konto_Alterspruefung();
        if (konto.Guthaben > 5 && konto.Aktiv == true)
        {
            konto.Guthaben -= 5;
            float rest = konto.Guthaben;
            konto.Guthaben = 0;
            Console.WriteLine($"Es waren {rest} im Konto bei der Auflösung.");
        }
        if (konto.Guthaben < 5 && konto.Aktiv == true)
        {
            Console.WriteLine("Nicht genug Deckung.");
        }
        else
        {
            Console.WriteLine($"Herr {this.Nachname} scheiterte an der Alterspruefung.");
        }
    }
    public class Adresse
    {
        private string strasse;
        private int hausnummer;
        private int plz;
        private string ort;
        public string Strasse { get { return strasse; } set { strasse = value; } }
        public int Hausnummer { get { return hausnummer; } set { hausnummer = value; } }
        public int Plz { get { return plz; } set { plz = value; } }
        public string Ort { get { return ort; } set { ort = value; } }
    }
    public class Konto
    {
        private float guthaben;
        private int kontonummer;
        private bool aktiv;
        public float Guthaben { get { return guthaben; } set { guthaben = value; } }
        public int Kontonummer { get { return kontonummer; } set { kontonummer = value; } }
        public bool Aktiv { get { return aktiv; } set { aktiv = value; } }
    }