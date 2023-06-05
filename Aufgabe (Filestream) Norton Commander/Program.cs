DriveInfo[] laufwerk = DriveInfo.GetDrives();


Menu();
Drive();


Console.ReadKey();

//Eingabe
static int Eingabe()
{
    return Convert.ToInt32(Console.ReadLine());
}

//Menu
static void Menu()
{
    Console.WriteLine("Norton Commander Filesystems inc");
    Console.WriteLine("".PadLeft(40, '_'));
    Console.WriteLine();
}

//Ausgabe Laufwerke
void Drive()
{
    int counter = 1;

    Console.WriteLine("({0}) \\...", counter++);
    foreach (DriveInfo drive in laufwerk)
    {
        Console.WriteLine("({0}) {1}", counter++, drive);
    }
}