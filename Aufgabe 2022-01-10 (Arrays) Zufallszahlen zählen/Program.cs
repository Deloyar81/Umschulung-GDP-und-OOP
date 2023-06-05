// See https://aka.ms/new-console-template for more information

//Variablen
int counter;

//Arrray erstellen und befüllen
int[] array = new int[5000];

Random random = new Random();

for (int j = 0; j < array.Length; j++)
{
    array[j] = random.Next(1, 10);
}

//Array 9mal durchlaufen
for (int j = 1; j <= 9; j++)
{
    counter = 0;
    //Array nach Zahl j (1-9) durchsuchen und zählen
    for (int d = 0; d < array.Length; d++)
    {
        if (array[d] == j)
        {
            counter++;
        }
    }
    //Ausgabe pro Durchlauf
    Console.WriteLine("Häufigkeit von {0} ist {1}", j, counter);
}
Console.ReadKey();