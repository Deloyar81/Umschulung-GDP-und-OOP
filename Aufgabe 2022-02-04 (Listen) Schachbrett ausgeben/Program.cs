//zweidimensinale Liste initialisieren
List<List<string>> Reihe = new List<List<string>>();

//Consolenausgabe anpassen
Console.SetWindowSize(70,20);

//ASCII 1, 2, 3...
int reihe = 49;

//Felder belegen
//Reihe hochzählen
for (int z = 1; z <= 8; z++)
{
    List<string> Zeile = new List<string>();

    //ASCII A, B, C...
    int zeile = 65;

    //Zeilennummern hochzählen, mit Reihe verknüpfen und Listen befüllen
    for (int i = 1; i <= 8; i++)
    {
        string stringzeile = Convert.ToString((char)zeile);
        string stringreihe = Convert.ToString((char)reihe);
        string feld = stringzeile + stringreihe;
        Zeile.Add(feld);
        zeile++;
    }
    Reihe.Add(Zeile);
    reihe++;
}

//Ausgabe
foreach (var list in Reihe)
{
    foreach (var element in list)
    {
        Console.Write(element + "\t");
    }
    Console.WriteLine();
}

Console.ReadLine();
