// See https://aka.ms/new-console-template for more information

//Variablen
int countersonder, counterchar, counterzahl, counterupper, check = 0, count = 0;

Random random = new Random();

//Array erstellen
char[] password = new char[8];
char[] pool = new char[93];

//pool befüllen
for (int i = 0; i < 93; i++)
{
    int d = 33 + i;
    pool[i] = (char)d;
}

do
{
    counterchar = 0;
    counterzahl = 0;
    countersonder = 0;
    counterupper = 0;

    //Schleife
    for (int i = 0; i < password.Length; i++)
    {
        int zahl = random.Next(0, 93);
        password[i] = pool[(char)zahl];

        if (char.IsLetter(password[i]) && char.IsUpper(password[i]))
        {
            counterchar++;
            counterupper++;
        }
        else if (char.IsDigit(password[i]))
        {
            counterzahl++;
        }
        else if (char.IsLetter(password[i]) && char.IsLower(password[i]))
        {
            counterchar++;
        }
        else
        {
            countersonder++;
        }

        if (counterchar == 5 && countersonder == 1 && counterzahl == 2 && counterupper >= 1)
        {
            check = 1;
        }
    }

    //Ausgabe Counter
    Console.Clear();
    count++;
    Console.WriteLine("Für die Passwortgenerierung wurden {0} Iterationen des Durchlaufes benötigt", count);
    Thread.Sleep(10);
} while (check != 1);

//Ausgabe Password
string passw = new string(password);
Console.WriteLine("");
Console.WriteLine("Das Password mit mindestens 1 Großbuchstaben, 5 Buchstaben insgesamt, 2 Zahlen und 1 Sonderzeichen lautet: \n");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(passw);
Console.ReadKey();
