static void LaufwerkDings(DriveInfo Laufwerk)
{
    string pfad = Navigator(Convert.ToString(Laufwerk));
    while (true)
    {
        pfad = Navigator(pfad);
        if (pfad == null)
        {
            return;
        }
    }
}
static void Dateinfo(string[] Dateien)
{
    Console.Clear();
    foreach (string datei in Dateien)
    {
        Console.WriteLine(datei);
        Console.WriteLine("Erstellt: " + File.GetCreationTime(datei));
        Console.WriteLine("zuletzt geändert: " + File.GetLastWriteTime(datei));
    }
    Console.ReadKey();
}
static string Navigator(string laufwerk)
{
    Console.Clear();
    Directory.SetCurrentDirectory(Convert.ToString(laufwerk));
    string pfad = Directory.GetCurrentDirectory();
    string[] Ordner = Directory.GetDirectories(pfad);
    int count = 1;
    foreach (string ord in Ordner)
    {
        Console.WriteLine(count + "\t" + ord);
        count++;
    }
    Console.WriteLine("Dateien enthalten: \n");
    Console.WriteLine("Möchten Sie Infos zu enthaltenen Dateien ? (Y/N)");
    char wahl = char.ToLower(Console.ReadKey().KeyChar);
    switch (wahl)
    {
        case 'y':
            string[] Dateien = Directory.GetFiles(pfad);
            Dateinfo(Dateien);
            return pfad;
        case 'n':
            Console.Clear();
            count = 1;
            foreach (string ord in Ordner)
            {
                Console.WriteLine(count + "\t" + ord);
                count++;
            }
            Console.WriteLine((count + 1) + "Zurück");
            Console.WriteLine((count + 2) + " Beenden");
            break;
        default:
            Console.WriteLine("Ungültige Auswahl");
            break;
    }
    Console.WriteLine("\nAuswahl: ");
    int auswahl = int.Parse(Console.ReadLine());
    if (auswahl == count + 1)
    {
        int index = pfad.LastIndexOf('\\');
        string pfadzurück = pfad.Remove(index);
        return pfadzurück + "\\";
    }
    if (auswahl == count + 2)
    {
        string ende = null;
        Console.Clear();
        Console.WriteLine("Wird Beendet");
        return ende;
    }
    string neuerpfad = Ordner[auswahl - 1];
    return neuerpfad;
}
static void Main(string[] args)
{
    //Aufgabe Navigator
    DriveInfo[] Laufwerke = DriveInfo.GetDrives();
    Console.WriteLine("Laufwerke:");
    int laufwerkCount = 1;
    foreach (DriveInfo drive in Laufwerke)
    {
        Console.WriteLine(laufwerkCount + ": " + drive);
        laufwerkCount++;
    }
    Console.Write("\n\nWähle Laufwerk: ");
    int laufwerkauswahl = int.Parse(Console.ReadLine());
    switch (laufwerkauswahl)
    {
        case 1:
            LaufwerkDings(Laufwerke[0]);
            break;
        case 2:
            LaufwerkDings(Laufwerke[1]);
            break;
        default:
            Console.WriteLine("Laufwerk Existiert nicht!");
            break;
    }
    Console.ReadKey();
}