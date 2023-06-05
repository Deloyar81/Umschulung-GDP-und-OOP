//Funktion Eingabe Größe des Array
static int Eingabegr()
{
    Console.Write("Bitte geben Sie die Größe des Arrays an: ");
    int größe = int.Parse(Console.ReadLine());

    return größe;
}

//Funktion Eingabe Position im Array
static int Eingabepos()
{
    Console.Write("Bitte geben Sie die Position im Array an: ");
    int position = int.Parse(Console.ReadLine());

    return position;
}

//Funktion Array sortieren
static void Quicksort(int[] arr, int start, int ende)
{


    if (start < ende)
    {
        int pivot = Partition(arr, start, ende);

        if (pivot > 1)
        {
            Quicksort(arr, start, pivot - 1);
        }
        if (pivot + 1 < ende)
        {
            Quicksort(arr, pivot + 1, ende);
        }
    }
}

//Funktion Array Partitionieren
static int Partition(int[] array, int start, int ende)
{
    int pivot = array[start];

    while (true)
    {
        while (array[start] < pivot)
        {
            start++;
        }

        while (array[ende] > pivot)
        {
            ende--;
        }

        if (start < pivot)
        {
            if (array[start] == array[ende])
            {
                start++;
            }

            int temp = array[start];
            array[start] = array[ende];
            array[ende] = temp;
        }
        else
        {
            return ende;
        }
    }
}

//Funktion Array erstellen und befüllen
static int[] Arrayquick(int größe)
{
    int[] array = new int[größe]; //new int[] { 30, 19, 56, 98, 61, 96, 86, 66, 56, 52 };


    Random randomzahl = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomzahl.Next(1, 101);
    }

    return array;
}

//Main
//Variablen
int start = 0;

int größe = Eingabegr();

int[] array = Arrayquick(größe);

//int position = Eingabepos();

int ende = array.Length - 1;

foreach (int i in array)
{
    Console.Write(" {0} ", i);
}

//Ausgabe sortiert
Quicksort(array, start, ende);

Console.WriteLine();
Console.WriteLine("Sortiertes Array:");

foreach (int i in array)
{
    Console.Write(" {0} ", i);
}

Console.ReadKey();
