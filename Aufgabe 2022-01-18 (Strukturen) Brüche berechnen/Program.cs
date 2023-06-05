//Eingabe
static void Eingabe()
{
    string b1, b2;

    Console.WriteLine("Bitte geben Sie zwei Brüche in folgendem Format ein, die Sie verrechnen möchten: 'X x/x' oder 'x/x'");
    Console.WriteLine("Der erste Bruch: ");
    b1 = Console.ReadLine();
    Console.WriteLine("Der zweite Bruch: ");
    b2 = Console.ReadLine();
}

//Menu
static void Menu()
{
    Console.WriteLine($"+" + "".PadRight(80, '-') + "+");
    Console.WriteLine("|".PadRight(10, ' ') + "Was möchten Sie mit den Brüchen tun?" + "|".PadLeft(36, ' '));
    Console.WriteLine($"+" + "".PadRight(80, '-') + "+");
    Console.WriteLine("|".PadRight(10, ' ') + "(1) Alles. Gib mir alles!" + "|".PadLeft(47, ' '));
    Console.WriteLine($"+" + "".PadRight(80, '-') + "+");
    Console.WriteLine("|".PadRight(10, ' ') + "(2) Den Umkehrwert der eingegebenen Brüche berechnen." + "|".PadLeft(19, ' '));
    Console.WriteLine($"+" + "".PadRight(80, '-') + "+");
    Console.WriteLine("|".PadRight(10, ' ') + "(3) Die beiden Brüche kürzen." + "|".PadLeft(43, ' '));
    Console.WriteLine($"+" + "".PadRight(80, '-') + "+");
    Console.WriteLine("|".PadRight(10, ' ') + "(4) Die beiden Brüche addieren." + "|".PadLeft(41, ' '));
    Console.WriteLine($"+" + "".PadRight(80, '-') + "+");
    Console.WriteLine("|".PadRight(10, ' ') + "(5) Die beiden Brüche subtrahieren." + "|".PadLeft(37, ' '));
    Console.WriteLine($"+" + "".PadRight(80, '-') + "+");
    Console.WriteLine("|".PadRight(10, ' ') + "(6) Die beiden Brüche multiplizieren." + "|".PadLeft(35, ' '));
    Console.WriteLine($"+" + "".PadRight(80, '-') + "+");
    Console.WriteLine("|".PadRight(10, ' ') + "(7) Die beiden Brüche dividieren." + "|".PadLeft(39, ' '));
    Console.WriteLine($"+" + "".PadRight(80, '-') + "+");
    Console.WriteLine("|".PadRight(10, ' ') + "(8) Programm beenden." + "|".PadLeft(51, ' '));
    Console.WriteLine($"+" + "".PadRight(80, '-') + "+");

    int menu = int.Parse(Console.ReadLine());

    switch (menu)
    {
        case 1:

            break;
        case 2:

            break;
        case 3:

            break;
        case 4:

            break;
        case 5:

            break;

        case 6:

            break;
        case 7:

            break;
        case 8:
            return;
    }
}

//Ausgabe
static void AusgabeBruch()
{

}

//Konvertierung in Double
static void BruchToDouble()
{

}

//Umkehrbruch
static void UmkehrBruch()
{

}

//Bruch kürzen
static void KürzeBruch()
{

}

//Bruch addieren
static void AddBruch()
{

}

//Bruch subtrahieren
static void SubBruch()
{

}

//Bruch multiplizieren
static void MulBruch()
{

}

//Bruch dividieren
static void DivBruch()
{

}

//Main
Menu();
Console.ReadKey();

//Struktur
struct Bruch
{
    private readonly int zaehler;
    private readonly int nenner;

    public Bruch(int Zaehler, int Nenner)
    {
        zaehler = Zaehler;
        nenner = Nenner;
    }
}

