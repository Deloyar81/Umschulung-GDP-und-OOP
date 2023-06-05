int exit = 0;
int count = 0;
//Initialisierung der Anzeige von Volumes
DriveInfo[] drives = DriveInfo.GetDrives();
int drivecount = 1;

//Ausgabe der Volumes
foreach (DriveInfo drive in drives)
{
    Console.WriteLine("{0,2} - {1}", drivecount, drive);
    drivecount++;
}
drivecount = 0; //Counter für Numerierung wird zurückgesetzt

//Laufwerk auswahl:
Console.WriteLine("Laufwerk wählen: ");
int drivechoice = int.Parse(Console.ReadLine());
string path = Convert.ToString(drives[drivechoice - 1]);

//Working Directory basierend auf laufwerkwahl:
Directory.SetCurrentDirectory(path);
string wd = Directory.GetCurrentDirectory();
string[] folder = Directory.GetDirectories(wd);
string[] files = Directory.GetFiles(wd);
while (exit == 0) //Beginn der Programmschleife
{
    Console.Clear();
    wd = Directory.GetCurrentDirectory();
    folder = Directory.GetDirectories(wd);
    files = Directory.GetFiles(wd);
    count = 1;
    Console.WriteLine(wd);
}
//Ausgabe der Ordner und Dateien mit eigener Numerierung und zurück-Option
Console.WriteLine("Ordner:");
Console.WriteLine("  0 - Zurück ");

foreach (string ausg in folder)
{
    Console.WriteLine("{0,3} - {1}", count, ausg);
    count++;
}
Console.WriteLine("Dateien:");
count = 1;
foreach (string ausg in files)
{
    Console.WriteLine("{0,3} - {1}", count, ausg);
    count++;
}
//Menü
Console.WriteLine("\t---Optionen---\n " +
    "\td - Ordner wechseln\n" +
    "\tf - Info zu Datei\n" +
    "\tl - Laufwerk wählen\n" +
    "\te - Ende");
//Switchcase für Menüpunkte
char choice = Console.ReadKey(true).KeyChar;
switch (choice)
{
    case 'd':
        //Case für Ordnerwahl
        Console.WriteLine("Ordnernummer eingeben:");
        int pathchange = int.Parse(Console.ReadLine()); //Zahl basierend auf der in der Ordnerausgabe angezeigten Nummerierung

        if (Directory.Exists(folder[pathchange - 1]) == true)
        {
            if (pathchange == 0) //Option für zurück in der Ordnerstruktur
            {
                //Variablen für die Navigation in den Ordnern
                string current = Directory.GetCurrentDirectory();
                char[] currarr = current.ToCharArray();
                string back = "";

                //Anweisung den Pfad für die "Zurück" Option zu erstellen
                for (int i = currarr.Length - 1; currarr[i] != '\\'; i--)
                {
                    currarr[i] = ' ';
                }
                foreach (char l in currarr)
                {
                    back = string.Concat(back, l);
                }
                Directory.SetCurrentDirectory(back);
                break;
            }
            else
            {
                //Änderung des Working Directorys basierend auf oben getätigter Angabe
                Directory.SetCurrentDirectory(folder[pathchange - 1]);
                break;
            }
        }
        else break;
    case 'f':
        //Case für Infos zu Dateien
        Console.WriteLine("Dateinummer angeben:");
        int filechange = int.Parse(Console.ReadLine()); //Zahl basierend auf der in der Dateiausgabe angezeigten Nummerierung
        if (Directory.Exists(files[filechange - 1]) == false && File.Exists(files[filechange - 1]) == true)
        {
            //Erstellung von verschiedenen Ausgabestrings basierend auf der gewählten Datei
            FileInfo fileprint = new FileInfo(files[filechange - 1]);
            string fname = Convert.ToString(fileprint.FullName);
            string fpath = Convert.ToString(fileprint.DirectoryName);
            string fext = Convert.ToString(fileprint.Extension);
            string flastwritten = Convert.ToString(fileprint.LastWriteTime);
            string fcreation = Convert.ToString(fileprint.CreationTime);
            //Ausgabe der Strings
            Console.WriteLine("Name: {0}" +
                "\nDateiendung: {1}" +
                "\nPfad: {2}" +
                "\nErstellung: {3}" +
                "\nZuletzt bearbeitet: {4}", fname, fext, fpath, flastwritten, fcreation);
            Console.ReadKey();
        }
        break;
    case 'l':
        //Option zum Wechsel des Laufwerks:
        drives = DriveInfo.GetDrives();
        drivecount = 1;
        foreach (DriveInfo drive in drives)
        {
            Console.WriteLine("{0,2} - {1}", drivecount, drive);
            drivecount++;
        }
        drivecount = 0;
        Console.WriteLine("Laufwerk wählen: ");
        drivechoice = int.Parse(Console.ReadLine());
        path = Convert.ToString(drives[drivechoice - 1]);
        Directory.SetCurrentDirectory(path);
        break;
    case 'e':
        //Programm ende
        Console.WriteLine("Programm beendet!");
        exit = 1;
        break;
}

Console.ReadKey();
