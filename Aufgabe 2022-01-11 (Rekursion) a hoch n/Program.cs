//Funktion Potenz
static int Potenz(int basis, int exponent)
{

    // Bedingung
    /* 
       int erg;

       if (exponent == 0)
        {
            return 1;
        }
        else
        {
            erg = basis * Potenz(basis, exponent - 1);
            return erg;
        }*/

    // das Ganze mit ternärem Opoerator
    return exponent == 0 ? 1 : basis * Potenz(basis, exponent - 1);
}

//Funktion Header
static void Header()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("#########################################################");
    Console.WriteLine("#                 einfache Potenzierung                 #");
    Console.WriteLine("#########################################################");
    Console.ForegroundColor = ConsoleColor.Red;
}

int basis, exponent, erg;

//Main
do
{
    Header();

    Console.Write("\n\nBitte geben Sie die Basis ein: ");
    basis = int.Parse(Console.ReadLine());

    Console.Write("\nBitte geben Sie den Exponenten ein: ");
    exponent = int.Parse(Console.ReadLine());

    if (basis == 0)
    {
        Console.WriteLine("\nDas Ergebnis von Basis {0} mit Exponent {1} = 0", basis, exponent);
        Console.WriteLine("Bitte beschränken Sie sich bei der Eingabe auf Werte > 0");
        Thread.Sleep(4000);
    }
    if (exponent == 0)
    {
        Console.WriteLine("\nDas Ergebnis von Basis {0} mit Exponent {1} = 1", basis, exponent);
        Console.WriteLine("\nAber bitte beschränken Sie sich bei der Eingabe auf Werte > 0");
        Thread.Sleep(4000);
    }
    Console.Clear();
} while (basis == 0 || exponent == 0);

erg = Potenz(basis, exponent);

if (erg == 1)
{
    Header();
    Console.WriteLine("\nDas Ergebnis von Basis {0} mit Exponent {1} = {3}", basis, exponent, erg);
}
else
{
    Header();
    Console.WriteLine("\nDas Ergebnis von Basis {0} mit Exponent {1} = {2}", basis, exponent, erg);
}
Console.ReadKey();