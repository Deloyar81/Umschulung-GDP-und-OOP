//Funktion Array erstellen und befüllen
static int[] Array(int größe)
{
    int[] array = new int[größe];

    for (int i = 0; array.Length - 1 > i; i++)
    {
        array[i] = i + 1;
    }
    return array;
}

//Funktion Gesuchte Zahl abfragen
static int Eingabe()
{
    Console.Write("\nBitte geben Sie die zu suchende Zahl (zwischen 1 - 100) an: \n");
    int x = int.Parse(Console.ReadLine());

    return x;
}

//Rekursive Berechnung der Zahl
static void Suche(int x, int zahl, int counter, int start, int ende)
{
    if (x == zahl)
    {
        Console.WriteLine("Die vom mir geratene Zahl {0} ist die gesucht Zahl {1}! Ich habe Gewonnen! Ich habe {2} Versuche benötigt.", x, zahl, counter);
    }
    else if (x < zahl)
    {
        Console.WriteLine("Die vom mir geratene Zahl {0} ist kleiner als die gesuchte Zahl! Ich habe bisher {1} Versuche benötigt.", x, counter);
        start = x;
        x = (start + ende) / 2;
        counter++;

        Suche(x, zahl, counter, start, ende);
    }
    else if (x > zahl)
    {
        Console.WriteLine("Die vom mir geratene Zahl {0} ist größer als die gesuchte Zahl! Ich habe bisher {1} Versuche benötigt.", x, counter);
        ende = x;
        x = (start + ende) / 2;
        counter++;

        Suche(x, zahl, counter, start, ende);
    }
}

//Main
//Variablen
int x, start, counter = 1;

//Array erstellen
Array(100);

//Startzahl berechnen
Random cpu = new Random();
start = cpu.Next(1, 101);

//Rekursive Abfrage
int zahl = Eingabe();
Suche(start, zahl, counter, 1, 100);

//Ausgabe
//Console.WriteLine("{0}", ergebnis);

Console.ReadKey();