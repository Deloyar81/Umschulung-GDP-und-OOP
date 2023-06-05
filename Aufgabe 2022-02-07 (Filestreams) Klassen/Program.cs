DriveInfo[] laufwerk = DriveInfo.GetDrives();

Navigator();

Console.ReadKey();

void Navigator()
{
    Menu();
    Drive();

    Console.Write("\nAuswahl: ");
    Dir(Eingabe());




}

int Eingabe()
{
    //int eingabe = (int)Console.ReadKey(true).KeyChar - 48;
    string eingabe = Console.ReadLine();

    int ausgabe = Convert.ToInt32(eingabe);
    return ausgabe;
}

static void Menu()
{
    Console.WriteLine("Norton Commander Filesystems inc");
    Console.WriteLine("".PadLeft(40, '_'));
    Console.WriteLine();
}

void Drive()
{
    int counter = 1;

    Console.WriteLine("({0}) \\...", counter++);
    foreach (DriveInfo drive in laufwerk)
    {
        Console.WriteLine("({0}) {1}", counter++, drive);
    }
}

void Dir(int eingabe)
{
    Console.Clear();
    int counter = 1;

    if (eingabe == 1)
    {
        return;
    }
    else
    {
        Console.Clear();
        string[] dir = Directory.GetDirectories(Convert.ToString(laufwerk[eingabe - 2]));

        Console.WriteLine("({0, 2})  :\\...", counter++);
        foreach (string dirName in dir)
        {
            Console.WriteLine("({0, 2}) {1}", counter++, dirName);
            string[] files = Directory.GetFiles(dir[Eingabe() - 2]);
            Console.WriteLine(" :\\...");
            foreach (string file in files)
            {
                Console.WriteLine("\t" + file);
            }

        }

        Datei(dir);
    }


}

void Datei(string[] dir)
{
    string[] files = Directory.GetFiles(dir[Eingabe() - 2]);
    Console.WriteLine(" :\\...");
    foreach (string file in files)
    {
        Console.WriteLine("\t" + file);
    }
}