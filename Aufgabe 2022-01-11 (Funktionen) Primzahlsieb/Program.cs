
//Variablen
int eingabe;


//Eingabe
Header();

Console.Write("\nBitte geben Sie das Ende des Primzahlsiebes an: ");
eingabe = int.Parse(Console.ReadLine());

int[] zbereich = Zahlenbereich(eingabe);

Ausgabe(zbereich);

int[] primary = Primzahlsieb(zbereich);

Ausgabe(primary);

Console.ReadKey();

//Funktion Sieb
static int[] Primzahlsieb(int[] zbereich)
{
    int[] primary = zbereich;
    for (int i = 1; i < zbereich.Length; i++)
    {
        if (zbereich[i] == 0)
        {

        }
        else if (zbereich[i] % i + 1 == 0)
        {
            primary[i] = 0;
        }

    }

    return primary;
}

//Funktion Array erstellen
static int[] Zahlenbereich(int eingabe)
{
    //Definieren
    int[] arrayzahlenbereich = new int[eingabe];


    //befüllen
    for (int i = 0; i < arrayzahlenbereich.Length; i++)
    {
        arrayzahlenbereich[i] = i + 1;
    }

    return arrayzahlenbereich;
}

//Funktion Ausgabe
static void Ausgabe(int[] zbereich)
{
    foreach (int i in zbereich)
    {
        Console.Write(" | {0} |", i);
    }
}


//Funktion Header
static void Header()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("##########################################################");
    Console.WriteLine("#                      Primzahlsieb                      #");
    Console.WriteLine("##########################################################");
    Console.ForegroundColor = ConsoleColor.DarkCyan;
}
