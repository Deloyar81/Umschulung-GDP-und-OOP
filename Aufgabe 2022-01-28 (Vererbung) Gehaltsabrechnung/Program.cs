using Aufgabe_2022_01_28__Vererbung__Gehaltsabrechnung;



double alter = 0;

//Praktikant praktikant = new Praktikant();
//Angestellte angestellte = new Angestellte();

List<Praktikant> Praktikanten = new List<Praktikant>();
List<extMitarbeiter> extMitarbeiter = new List<extMitarbeiter>();
List<Angestellte> Angestellte = new List<Angestellte>();

Menu();


void Menu()
{
    int exitM = 0;
    

    while (exitM == 0)
    {
        Console.WriteLine("(1) - Mitarbeiter anlegen");
        Console.WriteLine("(2) - Projekt anlegen");
        Console.WriteLine("(3) - Abteilung anlegen");
        Console.WriteLine("(4) - Tarifgruppe anlegen");
        Console.WriteLine("(5) - Exit");

        Console.Write("\n\nAuswahl: ");

        int eingabe = Convert.ToInt32(Console.ReadLine());

        switch (eingabe)
        {
            case 1:
                Console.Clear();

                int exitMit = 0;

                while (exitMit == 0)
                {
                    Console.Clear();
                    Console.WriteLine("(1) - externen Mitarbeiter anlegen");
                    Console.WriteLine("(2) - Angestellten anlegen");
                    Console.WriteLine("(3) - Praktikanten anlegen");
                    Console.WriteLine("(4) - externen Mitarbeiter anzeigen");
                    Console.WriteLine("(5) - Angestellten anzeigen");
                    Console.WriteLine("(6) - Praktikanten anzeigen");

                    Console.WriteLine("(7) - Exit");

                    Console.Write("\n\nAuswahl: ");

                    int eingabeMit = Convert.ToInt32(Console.ReadLine());

                    switch (eingabeMit)
                    {
                        //extMitarbeiter anlegen
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Bitte geben Sie den Nachnamen ein: ");
                            string nachname = Console.ReadLine();
                            Console.WriteLine("Bitte geben Sie den Vornamen ein:");
                            string vorname = Console.ReadLine();
                            Console.WriteLine("Bitte geben Sie die Anzahl der Projektstunden des externen Mitarbeiters ein: ");
                            int anzahlstd = Convert.ToInt32(Console.ReadLine());

                            extMitarbeiter.Add(new extMitarbeiter(vorname, nachname, anzahlstd));

                            break;
                        
                        //Angestellter anlegen
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Bitte geben Sie den Nachnamen ein: ");
                            nachname = Console.ReadLine();
                            Console.WriteLine("Bitte geben Sie den Vornamen ein:");
                            vorname = Console.ReadLine();
                            Console.WriteLine("Bitte geben Sie das Alter des Abgestellten ein: ");
                            int alter = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Bitte geben Sie die Tarifgruppe des Angestellten ein (A / B / C / D): ");
                            string tarifgruppe = Console.ReadLine();

                            Angestellte.Add(new Angestellte(vorname, nachname, alter, tarifgruppe));

                            break;

                        //Praktikant anlegen
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Bitte geben Sie den Nachnamen ein: ");
                            nachname = Console.ReadLine();
                            Console.WriteLine("Bitte geben Sie den Vornamen ein:");
                            vorname = Console.ReadLine();
                            Console.WriteLine("Bitte geben Sie die Abteilung des Praktikanten ein (Entwicklung / Produktion / Vertrieb): ");
                            string abteilung =Console.ReadLine();

                            Praktikanten.Add(new Praktikant(vorname, nachname, abteilung));

                            break;

                        //Ausgabe extMitarbeiter
                        case 4:
                            Console.Clear();
                            foreach(extMitarbeiter mitarbeiter in extMitarbeiter)
                            {
                                Console.WriteLine("Vorname: {0}", mitarbeiter.Vorname);
                                Console.WriteLine("Nachname: {0}", mitarbeiter.Nachname);
                                Console.WriteLine("Gehalt: {0}", mitarbeiter.GehaltExtMitarbeiter());
                            }
                            Thread.Sleep(3000);
                            break;

                        //Ausgabe Angestellter
                        case 5:
                            Console.Clear();
                            foreach (Angestellte angestellte in Angestellte)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Vorname: {0}", angestellte.Vorname);
                                Console.WriteLine("Nachname: {0}", angestellte.Nachname);
                                Console.WriteLine("Gehalt: {0}", angestellte.GehaltAngestellter());
                                Console.WriteLine("");

                            }
                            Thread.Sleep(3000);
                            break;

                        //Ausgabe Praktikant
                        case 6:
                            Console.Clear();
                            foreach (Praktikant praktikant in Praktikanten)
                            {
                                Console.WriteLine("Vorname: {0}", praktikant.Vorname);
                                Console.WriteLine("Nachname: {0}", praktikant.Nachname);
                                Console.WriteLine("Gehalt: {0}", praktikant.GehaltPraktikant());
                            }
                            Thread.Sleep(3000);
                            break;
                        case 7:
                            exitMit = 1;
                            break;
                    }
                }
                break;

            case 2:
                Console.Clear();

                break;

            case 3:
                Console.Clear();

                break;

            case 4:
                Console.Clear();

                break;

            case 5:
                exitM = 1;
                break;
        }
    }
}

//Hauptklasse
public abstract class Mitarbeiter
{
    protected string vorname;
    protected string nachname;
    protected double gehalt;

    public Mitarbeiter(string vorname, string nachname)
    {
        this.vorname = vorname;
        this.nachname = nachname;
    }

    public string Vorname
    { get { return vorname; } }

    public string Nachname
    { get { return nachname; } }

    public string Gehalt
    { get { return Gehalt; } }
}

//Subklasse Ebene 1
public class Projekt : Mitarbeiter
{
    protected int gehaltprojektstd = 75;
    protected string projektname = "Daedalus";

    public Projekt(string vorname, string nachname, int anzahlstd) : base(vorname, nachname)
    {


    }

}

//Subklasse Ebene 2
public class extMitarbeiter : Projekt
{
    protected int anzahlprojektstd;
     

    public extMitarbeiter(string vorname, string nachname, int anzahlstd) : base(vorname, nachname, anzahlstd)
    {
        this.anzahlprojektstd = anzahlstd;
    }

    public double GehaltExtMitarbeiter()
    {
        return  gehalt = anzahlprojektstd * gehaltprojektstd;
    }
}


public class Angestellte : Tarif
{
    protected int alter;

    public Angestellte(string vorname, string nachname, int alter, string tarif) : base(vorname, nachname, tarif)
    {
        this.alter = alter;
    }

    public double GehaltAngestellter()
    {
        return gehalt = grundgehalt * (1 + ((alter - 25) / 100));
    }
}

public class Praktikant : Abteilungen
{ 

    public Praktikant(string vorname, string nachname, string tarif) : base(vorname, nachname, tarif)
    {
    }

    public double GehaltPraktikant()
    {

       return gehalt = grundgehalt;
    }
}