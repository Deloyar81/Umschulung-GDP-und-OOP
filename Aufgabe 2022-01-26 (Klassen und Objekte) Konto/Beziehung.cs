//Variablen
int counter = 0;
int i = 0;

//Person erstellen
Person[] person = new Person[counter];

Menu(i);

//Array vergrößern
static Person[] Vergroessernperson(Person[] person)
{
    Array.Resize(ref person, person.Length + 1);
    return person;
}

static Adresse[] Vergroessernadresse(Adresse[] adresse)
{
    Array.Resize(ref adresse, adresse.Length + 1);
    return adresse;
}


void Menu(int i)
{
    //Ausbruchsvariable
    int exit = 0;

    while (exit == 0)
    {
        Console.Clear();

        //Menuausgabe
        Console.WriteLine("( 1) - Person anlegen");
        Console.WriteLine("( 2) - Adresse eingeben/aktualisieren");
        Console.WriteLine("( 3) - Kontodaten eingeben/aktualisieren");
        Console.WriteLine("( 4) - Name ausgeben");
        Console.WriteLine("( 5) - Alter ausgeben");
        Console.WriteLine("( 6) - Adresse ausgeben");
        Console.WriteLine("( 7) - Personaldaten komplett ausgeben");
        Console.WriteLine("( 8) - Nachname ändern");
        Console.WriteLine("( 9) - Konto Einzahlung");
        Console.WriteLine("(10) - Konto Auszahlung");
        Console.WriteLine("(11) - Konto auflösen");
        Console.WriteLine("(12) - Programm beenden");

        Console.Write("\n\nAuswahl: ");

        int auswahl = Convert.ToInt32(Console.ReadLine());


        switch (auswahl)
        {
            case 1:
                Console.Clear();
                person = Vergroessernperson(person);
                person[person.Length - 1] = new Person(counter);

                Adresse a1 = new Adresse(counter);
                person[i].adresse = a1;

                person[i].Kontoanlegen();

                //Personalnummer erhöhen
                counter++;
                break;

            case 2:
                Console.Clear();
                a1 = new Adresse(counter);
                person[i].adresse = a1;

                break;

            case 3:
                Console.Clear();
                person[i].Kontoanlegen();

                break;

            case 4:
                Console.Clear();
                Console.WriteLine(person[i].Vname() + " " + person[i].Nname());
                Thread.Sleep(3000);
                break;
            case 5:
                Console.Clear();
                Console.WriteLine(person[i].Alter());
                Thread.Sleep(3000);
                break;

            case 6:
                Console.Clear();
                person[i].adresse.Ausgabe();
                Thread.Sleep(3000);
                break;

            case 7:
                Console.Clear();

                if(person[i].adresse != null && person[i].öffentlkonto != null)
                {
                    person[i].Ausgabe();
                    person[i].adresse.Ausgabe();
                    person[i].öffentlkonto.Ausgabekonto();
                }
                else if (person[i].adresse == null)
                {
                    person[i].Ausgabe();
                    person[i].öffentlkonto.Ausgabekonto();
                }
                else if(person[i].öffentlkonto == null)
                {
                    person[i].Ausgabe();
                    person[i].adresse.Ausgabe();
                }
                
                Thread.Sleep(3000);
                break;

            case 8:
                Console.Clear();
                person[i].Nnamechange();
                break;

            case 9:
                Console.Clear();
                if (person[i].öffentlkonto != null)
                {
                    person[i].öffentlkonto.Einzahlen();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sie müssen erst ein Konto eröffnen!");
                    Thread.Sleep(3000);
                }
                break;

            case 10:
                Console.Clear();
                if (person[i].öffentlkonto != null)
                {
                    person[i].öffentlkonto.Auszahlen();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sie müssen erst ein Konto eröffnen!");
                    Thread.Sleep(3000);
                }
                break;

            case 11:
                Console.Clear();
                if (person[i].öffentlkonto != null)
                {
                    person[i].öffentlkonto.Auflösenkonto();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sie müssen erst ein Konto eröffnen!");
                    Thread.Sleep(3000);
                }
                break;

            case 12:
                exit = 1;
                break;
        }
    }
}

class Person
{
    private string nachname;
    private string vorname;
    private string alter;
    private int persnummer;

    public Person(int counter)
    {
        Console.WriteLine("Bitte geben Sie den Nachnamen, Vornamen und das Alter mit einem Komma getrennt an:\n");

        String[] teile = Console.ReadLine().Split(',');

        this.nachname = teile[0].Trim();
        this.vorname = teile[1].Trim();
        this.alter = teile[2].Trim();
        this.persnummer = counter;
    }

    public Adresse adresse;
    //{ get { return default; }; set  }

    public Konto öffentlkonto;

    public void Nnamechange()
    {
        Console.WriteLine("\nBitte geben Sie den neuen Nachnamen an: ");
        this.nachname = Console.ReadLine();
    }
    public string Nname()
    {

        return this.nachname;
    }

    public string Vname()
    {
        return this.vorname;
    }

    public string Alter()
    {
        return this.alter;
    }

    public int Persnummer()
    {
        return this.persnummer;
    }

    public void Ausgabe()
    {
        Console.Clear();
        Console.WriteLine("\nPersonaldaten von Personalnummer: {0}", Persnummer());
        Console.WriteLine("\nNachname: {0}", Nname());
        Console.WriteLine("Vorname: {0}", Vname());
        Console.WriteLine("Alter: {0}", Alter());

    }

    public void Kontoanlegen()
    {
        if (Convert.ToInt32(Alter()) >= 16)
        {
            Konto k1 = new Konto();

        }
        else
        {
            Console.Clear();
            Console.WriteLine("Sie müssen das gesetzliche Mindestalter für das Eröffnen eines Kontos erreichen.");
            Console.WriteLine("Wir freuen uns, Sie in {0} Jaren wieder bei uns begrüßen zu dürfen.", 16 - Convert.ToInt32(Alter()));
            Thread.Sleep(5000);
        }

    }
}

class Konto
{
    private int guthaben;
    private int knummer;
    private int abgang;
    private int eingang;

    public Konto()
    {
        Console.Write("Ihr aktueller Kontostand beträgt: ");
        this.guthaben = Convert.ToInt32(Console.ReadLine());

        Console.Write("Die Kontonummer lautet: ");
        this.knummer = Convert.ToInt32(Console.ReadLine());
    }

    public void Einzahlen()
    {
        Console.WriteLine("Wieviel möchten Sie einzahlen?\n");
        eingang = Convert.ToInt32(Console.ReadLine());

        this.guthaben += eingang;
    }

    public void Auszahlen()
    {
        Console.WriteLine("Wieviel möchten Sie abheben?\n");
        abgang = Convert.ToInt32(Console.ReadLine());

        if (guthaben > abgang)
        {
            this.guthaben -= abgang;
            Console.WriteLine("Sie haben {0} abgehoben. Ihr aktueller Kontostand beträgt: {1}", abgang, guthaben);
        }
        else
        {
            Console.WriteLine("Sie haben nicht genug Deckung (Kontostand: {0}, um diesen Betrag ({1}) abzuheben. Bitte zahlen Sie Geld ein.", guthaben, abgang);
        }
    }

    public void Ausgabekonto()
    {
        Console.WriteLine("\nKontodaten:");
        Console.WriteLine("Der Kontostand des Kontos {0} beträgt: {1}", knummer, guthaben);
    }

    public int Auflösenkonto()
    {
        if (this.guthaben > 5)
        {
            Console.WriteLine("Das Konto wurde aufgelöst.");
            return guthaben - 5;
        }
        else
        {
            Console.WriteLine("Sie haben nicht genug Deckung, um die Bearbeitungsgebühr zu zahlen. Bitte zahlen Sie Geld ein.");
            return guthaben;

        }
    }
}

public class Adresse
{
    private string straße;
    private string hausnummer;
    private string plz;
    private string ort;

    public Adresse(int counter)
    {
        Console.WriteLine("\nBitte geben Sie die Straße, die Hausnummer, die PLZ und den Ort mit einem Komma getrennt an:\n");

        String[] teile = Console.ReadLine().Split(',');

        this.straße = teile[0].Trim();
        this.hausnummer = teile[1].Trim();
        this.plz = teile[2].Trim();
        this.ort = teile[3].Trim();
    }

    public string Straße
    {
        get
        {
            return this.straße;
        }
        set
        {
            this.straße = Console.ReadLine();
        }
    }

    public void Ausgabe()
    {
        Console.WriteLine("\nAdressdaten:");
        Console.WriteLine("Straße: {0}", Straße);
        Console.WriteLine("Hausnummer: {0}", hausnummer);
        Console.WriteLine("PLZ: {0}", plz);
        Console.WriteLine("Ort: {0}", ort);
    }
}
