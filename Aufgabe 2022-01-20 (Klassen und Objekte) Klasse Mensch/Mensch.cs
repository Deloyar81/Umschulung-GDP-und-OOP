Mensch mensch1 = new Mensch();

while (true)
{
    Console.Clear();

    Console.WriteLine("Was möchten Sie tun?");
    Console.WriteLine("(1) - Person anlegen");
    Console.WriteLine("(2) - Person vorstellen");
    Console.WriteLine("(3) - Geburtstag feiern");
    Console.WriteLine("(4) - Programm beenden");

    int eingabe = Console.ReadKey(true).KeyChar;
    Console.Clear();
    switch (eingabe)
    {
        case '1':
            mensch1.Anlegen();
            break;
        case '2':
            Console.WriteLine("Mein Name ist {0}, ich bin {1} Jahre alt.", mensch1.Vorstellen(), mensch1.Alter());
            Thread.Sleep(3000);
            break;
        case '3':
            Console.WriteLine("Ich bin jetzt {0} Jahre alt!", mensch1.Geburtstag());
            Thread.Sleep(3000);
            break;
        case '4':
            return;
    }
}

public class Mensch
{
    private int alter;
    private string vorname;
    private string nachname;

    public Mensch()
    {
        alter = 0;
    }

    public void Anlegen()
    {
        Console.WriteLine("Wie ist der Vorname?\n");
        vorname = Console.ReadLine();
        Console.WriteLine("\nWie ist der Nachame?\n");
        nachname = Console.ReadLine();

        Console.WriteLine("\nWie ist das Alter?\n");
        alter = Convert.ToInt32(Console.ReadLine());
    }

    public string Vorstellen()
    {
        string name = vorname + " " + nachname;
        return name;
    }

    public int Geburtstag()
    {
        alter++;
        return alter;
    }

    public int Alter()
    {
        return alter;
    }
}
