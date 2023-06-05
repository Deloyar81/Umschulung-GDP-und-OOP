//Variablen

string vorname, nachname, name, kuerzel;

char eingabe;

int ascii;

//Aufgabe 1

//vorname = "Philipp";
//nachname = "Pick";

//name = vorname + " " + nachname;

//Console.WriteLine(name);

////Längen der Strings ausgeben
//Console.WriteLine("Der Vorname {0} besteht aus {1} Buchstaben.", vorname, vorname.Length);
//Console.WriteLine("Der Nachname {0} besteht aus {1} Buchstaben.", nachname, nachname.Length);
//Console.WriteLine("Der komplette Name {0} besteht aus {1} Buchstaben.", name, name.Length - 1);

////Strings verkürzen
//kuerzel = vorname.Remove(1, vorname.Length - 1) + "." + nachname.Remove(1, nachname.Length - 1) + ".";

//Console.WriteLine("Initialen: {0}", kuerzel);

//Aufgabe 2
//gegebenen Buchstaben in ASCII Zahl umwandeln

//Console.Write("Bitte geben Sie den zur Umwandlung bestimmten Buchstaben ein");
//eingabe = Console.ReadKey(true).KeyChar;

//ascii = Convert.ToInt32(eingabe);

//Console.WriteLine("\nDer Buchstabe {0} ist in ASCII Code die Zahl {1}", eingabe, ascii);

//Aufgabe 3
//gegebenen Text in ASCII umwandeln

//string text;

//Console.WriteLine("Bitte geben Sie den zur Umwandlung bestimmten Text ein: \n");
//text = Console.ReadLine();

//###################################################

//char[] textarray = new char[text.Length];
//int[] textascii = new int[text.Length];

//textarray = text.ToCharArray();

//for (int i = 0; i < textarray.Length; i++)
//{
//    textascii[i] = textarray[i];
//    textascii[i] = Convert.ToInt32(textascii[i]);
//}

//foreach (int z in textascii)
//{
//    Console.Write("{0} ", z);
//};

//##################################################

//Alternative

//foreach (char z in text)
//{
//    Console.Write("{0} ", (int)z);
//};

//Aufgabe 4
//Kennwortüberprüfung

static void Passwordtest(string password)
{
    int counterzahl = 0;
    int counterchar = 0;
    int countercharkl = 0;
    int counterwhite = 0;
    int countersonder = 0;
    int test;

    //Überprüfung
    for (int i = 0; i < password.Length; i++)
    {
        if (char.IsDigit(password[i]))
        {
            counterzahl++;
        }

        else if (char.IsUpper(password[i]))
        {
            counterchar++;
        }

        else if (char.IsLower(password[i]))
        {
            countercharkl++;
        }

        else if (char.IsWhiteSpace(password[i]))
        {
            counterwhite++;
        }
        else if (char.IsSymbol(password[i]))
        {
            countersonder++;
        }
        else if (char.IsPunctuation(password[i]))
        {
            countersonder++;
        }
    }

    if (password.Length >= 10 && counterzahl >= 1 && counterchar >= 1 && countercharkl >= 1 && countersonder >= 1)
    {
        test = 1;
    }
    else
    {
        test = 0;
    }

    //Ausgabe
    if (test == 1)
    {
        Console.Write("\nDas Password ist sicher");
    }
    else
    {
        Console.WriteLine("\nDas Password erfüllt die Vorgaben nicht:\n");
        if (countersonder == 0)
        {
            Console.Write("es feht mindestens ein Sonderzeichen;");
        }
        if (counterzahl == 0)
        {
            Console.Write("\nes feht mindestens eine Zahl;");
        }
        if (counterchar == 0)
        {
            Console.Write("\nes feht mindestens ein Großbuchstabe;");
        }
        if (countercharkl == 0)
        {
            Console.Write("\nes feht mindestens ein Kleinbuchstabe;");
        }
        if (password.Length < 9)
        {
            Console.Write("\nDas Passwort ist zu kurz, es fehlen {0} Zeichen", 10 - password.Length);
        }
        if (password.Length == 9)
        {
            Console.Write("\nDas Passwort ist zu kurz, es fehlt {0} Zeichen", 10 - password.Length);
        }
    }
}

Console.WriteLine("Bitte geben Sie das zu überprüfende Password mit mindestens 10 Zeichen ein.\n" +
    "Das Password muss aus mindestens 1 Großbuchstaben, einem Kleinbuchstaben, einer Zahl und einem Sonderzeichen bestehen: ");

string password = Console.ReadLine();

Passwordtest(password);






Console.ReadKey();

//Aufgabe 5
//Schreiben Sie ein Programm, das die ASCII-Tabelle ausgibt

//for (int i = 32; i <= 127; i++)
//{
//    if (i == 32)
//    {
//        Console.WriteLine("ASCII Dezimal-Zahl {0, 3} = Zeichen 'Leerzeichen'", i);
//    }
//    else if (i == 127)
//    {
//        Console.WriteLine("ASCII Dezimal-Zahl {0, 3} = Zeichen 'Löschen'", i);
//    }
//    else
//    {
//        Console.WriteLine("ASCII Dezimal-Zahl {0, 3} = Zeichen {1}", i, (char)i);
//    }
//}

//Console.ReadKey();