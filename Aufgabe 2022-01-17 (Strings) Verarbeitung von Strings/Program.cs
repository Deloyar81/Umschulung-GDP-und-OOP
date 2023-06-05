static void Aufgabe1()
{
    Console.WriteLine("Bitte geben Sie den zu verarbeitenden Text ein: ");
    string eingabe = Console.ReadLine();

    char[] zeichen = eingabe.ToCharArray();
    char[] ausgabe = eingabe.ToCharArray();


    for (int i = 0; i < eingabe.Length; i++)
    {
        ausgabe[eingabe.Length - 1 - i] = zeichen[i];
    }

    string ergebnis = new string(ausgabe);
    Console.WriteLine("{0}", ergebnis);

    Console.ReadKey();
}

static void Aufgabe2()
{
    //Verschlüsselung
    static void Verschlüsselung(string eingabe)
    {
        char[] ausgabe = eingabe.ToCharArray();

        for (int i = 0; i < eingabe.Length;)
        {
            char temp = eingabe[i];
            ausgabe[i] = eingabe[i + 1];
            ausgabe[i + 1] = temp;
            i = i + 2;
        }

        if (eingabe.Length % 2 != 0)
        {

        }

        string ergebnis = new string(ausgabe);

        Console.WriteLine("{0}", ergebnis);
    }

    //eingabe
    Console.WriteLine("Bitte geben Sie den zu verschlüsselnden Text ein: ");
    Verschlüsselung(Console.ReadLine());

    Console.ReadKey();
}

static void Aufgabe3()
{
    //Variablen
    string eingabe;
    int gleich = 0, name = 0;

    //Eingabe
    Console.WriteLine("Eingabe 'Name=Wert': ");
    eingabe = Console.ReadLine();

    //Überprüfung
    for (int i = 0; i < eingabe.Length; i++)
    {
        if (eingabe[i] == '=')
        {
            gleich++;
        }
        if (eingabe[0] == '=')
        {
            name++;
        }
    }

    //Fehlerausgabe
    if (name == 1 && gleich == 1)
    {
        Console.WriteLine("Bitte geben Sie den Namen ein.");
    }
    if (gleich > 1)
    {
        Console.WriteLine("Die Eingabe darf nur ein '=' beinhalten.");
    }

    string[] teile = eingabe.Split('=');

    foreach (char x in teile[1])
    {
        if (!char.IsDigit(x))
        {
            Console.WriteLine("Der Wert darf nur aus Zahlen bestehen.");
            Console.ReadKey();
            return;
        }
    }

    //Ausgabe
    Console.WriteLine("Länge des Strings: {0}", eingabe.Length);
    Console.WriteLine("Name: {0}", teile[0]);
    Console.WriteLine("Wert: {0}", teile[1]);

    Console.ReadKey();
}

static void Aufgabe4()
{
    //Binärumwandlung
    static void Eingabe()
    {
        Console.Write("Bitte geben Sie die positive Dezinalzahl an, die umgewandelt werden soll: ");
        int eingabe = int.Parse(Console.ReadLine());

        Umwandlung(eingabe);
    }

    static void Umwandlung(int eingabe)
    {
        //Variablen
        int x = 1, zahl = eingabe;
        string binär = "";

        //Umwandlung

        do
        {
            x = zahl % 2;
            zahl = zahl / 2;
            binär = x + binär;
        } while (zahl != 0);

        Console.Clear();
        Console.WriteLine("Die Dezimalzahl {0} ist in Binärschreibweise {1}", eingabe, binär);
    }

    Eingabe();
    Console.ReadKey();
}

//Aufgabe1();

//Aufgabe2();

//Aufgabe3();

Aufgabe4();