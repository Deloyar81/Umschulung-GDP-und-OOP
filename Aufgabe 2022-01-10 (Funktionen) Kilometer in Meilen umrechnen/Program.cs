// See https://aka.ms/new-console-template for more information

//Variablen
string name;
int kilometer;

//Funktion
static void Hallo(string kopie_name)
{
    Console.WriteLine("Hallo {0}!", kopie_name);
    return;
}

static void Kilometer(int kopie_kilometer)
{
    double meile = kopie_kilometer * 1.609344;
    Console.WriteLine("{0} Kiloemter sind {1} Meilen", kopie_kilometer, meile);
}

static double Kilometerreturn(int kopie_kilometer)
{
    double meile = kopie_kilometer * 1.609344;

    return meile;
}

//Aufgabe 1
static void Aufgabe1()
{
    Console.Write("Bitte geben Sie ihren Namen ein: ");
    name = Console.ReadLine();

    Hallo(name);
}

//Aufgabe 2
static void Aufgabe2()
{
    Console.Write("Bitte geben Sie eine Kilometerzahl ein: ");
    kilometer = int.Parse(Console.ReadLine());

    Kilometer(kilometer);
}


//Aufgabe 2return
static void Aufgabe2return()
{
    Console.Write("Bitte geben Sie eine Kilometerzahl ein: ");
    kilometer = int.Parse(Console.ReadLine());

    Kilometerreturn(kilometer);

    Console.WriteLine(meile);
}

Aufgabe1();
Aufgabe2();
Aufgabe2return();


Console.ReadKey();