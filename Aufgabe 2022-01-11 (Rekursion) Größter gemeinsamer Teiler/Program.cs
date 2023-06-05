//Funktion Teiler berechnen
static int ggTeiler(int zahl1, int zahl2)
{
    //if (zahl1 % zahl2 == 0)
    //{
    //    return zahl2;
    //}
    //else
    //{
    if (zahl1 > zahl2)
    {
        return zahl2 == 0 ? zahl1 : ggTeiler(zahl2, zahl1 % zahl2);
    }
    else
    {
        return zahl1 == 0 ? zahl2 : ggTeiler(zahl1, zahl2 % zahl1);
    }
    //}
}

static void Header()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("#########################################################");
    Console.WriteLine("#       Suche nach dem größten gemeinsamen Teiler       #");
    Console.WriteLine("#########################################################");
    Console.ForegroundColor = ConsoleColor.DarkCyan;
}

//Main

//Variablen
int zahl1, zahl2, ggT;

Header();

Console.Write("\nBitte geben Sie die erste Zahl ein: ");
zahl1 = int.Parse(Console.ReadLine());

Console.Write("Bitte geben Sie die zweite Zahl ein: ");
zahl2 = int.Parse(Console.ReadLine());

ggT = ggTeiler(zahl1, zahl2);

//Ausgabe
Console.Clear();

Header();

Console.WriteLine("\nDer größte gemeinsame Teiler von {0} und {1} = {2}", zahl1, zahl2, ggT);
Console.ReadKey();

public sealed class Colors
{

}