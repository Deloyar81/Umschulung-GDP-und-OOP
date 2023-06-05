// See https://aka.ms/new-console-template for more information
//Überschrift
Console.WriteLine("Lottogenerator 2022");
Console.WriteLine("");

//VAriablen
int i = 1;

//Array
int[] lotto = new int[49];
Random zahl = new Random();

//Array befüllen
for (i = 1; i <= 49; i++)
{
    lotto[i - 1] = i;
}

//Zahlen picken
for (int j = 6; j >= 1; j--)
{
    i = zahl.Next(0, 49);
    while (lotto[i] == 0)
    {
        i = zahl.Next(0, 49);
    }

    //Ausgabe
    Console.WriteLine(lotto[i]);
    lotto[i] = 0;
}

Console.ReadKey();
