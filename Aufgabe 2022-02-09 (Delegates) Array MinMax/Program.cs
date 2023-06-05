using Aufgabe_2022_02_09__Delegates__Array_MinMax;

//Array erstellen
int[] vs = new int[10];

//Array random befüllen
Random random = new Random();
for (int i = 0; i < vs.Length; i++)
{
    vs[i] = random.Next(1, 101);
}

//Delegat Objekt initialisieren
Vergleich vergleich = new Vergleich();

//Methoden auf Delegate legen
VergleichsDelegate min;
VergleichsDelegate max;

min = new VergleichsDelegate(vergleich.IstKleiner);
max = new VergleichsDelegate(vergleich.IstGroesser);

//Ausgabe des Arrays
for (int i = 0;i < vs.Length;i++)
{
    Console.WriteLine("Index {0, 2}: {1, 3}", i, vs[i]);
}

//Ausgabe und Übergabe an die Delegaten
Console.Write("\nIndex der kleinsten Zahl im Array: "); 
Console.WriteLine(Limit(min, vs));
Console.Write("Index der größten Zahl im Array: ");
Console.WriteLine(Limit(max, vs));

Console.ReadKey();

//Methode zum Vergleichen von jeweils 2 Zahlen im Array
static int Limit(VergleichsDelegate vergleich, int[] array)
{
    //Alternative 1:

    //int index = 0;
    //for (int j = 0; j < array.Length - 1; j++)
    //{
    //    for (int i = 0; i < array.Length - 1; i++)
    //    {
    //        if (vergleich(array[i], array[a]) == true)
    //        {
    //            index = i;
    //        }
    //    }
    //}

    //########################################################################

    //Alternative 2:

    int x = array[0];
    int counter = 0, index = 0;

    foreach(int zahl in array)
    {
        if(vergleich(zahl, x) == true)
        {
            x = zahl;
            index = counter;
        }
        counter++;
    }

    //########################################################################

    return index;
}
