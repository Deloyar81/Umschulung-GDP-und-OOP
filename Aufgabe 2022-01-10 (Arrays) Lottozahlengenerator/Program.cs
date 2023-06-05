// See https://aka.ms/new-console-template for more information

//Variablen
int t = 0;

//Überschrift
Console.WriteLine("Lottogenerator 2022");
Console.WriteLine("");

//Array
int[] lotto = new int[6];

Random zahl = new Random();

//Schleife
for (int i = 5; i >= 0;)
{
    lotto[i] = zahl.Next(1, 49);
    int zahl1 = lotto[i];

    do
    {

        for (int j = i - 1; j >= 0; j--)
        {
            if (lotto[j] == lotto[i])
            {
                t++;
            };
        }

    } while (t != 0);
    i--;

}
//Ausgabe

foreach (int d in lotto)
{
    Console.WriteLine("{0}", d);
}
Console.ReadKey();
