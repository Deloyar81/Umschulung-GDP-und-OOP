// See https://aka.ms/new-console-template for more information

using System

//Variablen
int eingabe, suche, ja = 0, nein = 0;

//Array
int[] randomarray;

//Eingabe
Console.Write("Bitte geben Sie die Größe des Array an (1-1000): ");
eingabe = int.Parse(Console.ReadLine());

Console.Write("Bitte geben Sie die zu suchende zahl ein: ");
suche = int.Parse(Console.ReadLine());

//Übergabe an Funktion
randomarray = GetRandomArray(eingabe);

//Ausgabe unsortiertes Array
Console.WriteLine("\nUnsortiertes Array: ");
PrintArray(randomarray);

//Array sortieren
BubbleSort(randomarray);

//Ausgabe sortieretes Array
Console.WriteLine("\nSortiertes Array: ");
PrintArray(randomarray);

//Suche im Heuhaufen
int ergebnis = BinarySearch(randomarray, suche);

if (ergebnis == -1)
{
    Console.WriteLine("");
}


if (ja == 1)
{
    Console.WriteLine("Die gesuchte Zahl {0} befindet sich an Position {1} des Arrays");
}
else if (nein == -1)
{
    Console.WriteLine("Die gesuchte Zahl {0} befindet sich nicht im Array");
}

Console.ReadKey();

static int[] GetRandomArray(int NumOfElements)
{
    //Zufallszahlen
    Random zahlenbereich = new Random();


    //Array erstellen
    int[] randomarray = new int[NumOfElements];

    //Array befüllen
    for (int i = 0; i < NumOfElements; i++)
    {
        randomarray[i] = zahlenbereich.Next(-100, 101);
    }

    return randomarray;
}

static void PrintArray(int[] TheArray)
{
    Console.WriteLine("\n################################################################################################\n");

    foreach (int i in TheArray)
    {
        Console.Write("| {0, 4} |", i);
    }

    Console.WriteLine("\n\n################################################################################################\n");
}

static void BubbleSort(int[] TheArray)
{
    int temp = 0;

    for (int i = 0; i < TheArray.Length; i++)
    {
        for (int z = 0; z < TheArray.Length - 1; z++)
        {
            if (TheArray[z] > TheArray[z + 1])
            {
                temp = TheArray[z + 1];
                TheArray[z + 1] = TheArray[z];
                TheArray[z] = temp;
            }
        }
    }
}

static int BinarySearch(int[] HayStack, int Needle);
{
    int erg = Array.BinarySearch(Haystack, Needle);

    //int nein = -1;
    //int counter = 0;
    //int t = 0;

    //for (int i = 0; i < HayStack.Length; i++)
    //{
    //    if (HayStack[i] == Needle)
    //    {
    //        counter++;
    //    }
    //}

    //int[] index = new int[counter];

    //for (int i = 0; i < HayStack.Length; i++)
    //{
    //    if (HayStack[i] == Needle)
    //    {
    //        index[t] = i;
    //        t++;
    //    }
    //}

    //if (counter > 0)
    //{
    //    return index[t];
    //}
    //else
    //{
    //    return nein;
    //}
}