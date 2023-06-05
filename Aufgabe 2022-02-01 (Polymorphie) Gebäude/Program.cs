//Variablen
string adressebüro, adressewohn;
int bürofläche, wohnfläche;

//Eingabe
Console.Write("Bitte geben Sie die Fläche der Büroräume an: ");
bürofläche = Convert.ToInt32(Console.ReadLine());
Console.Write("Bitte geben Sie die Adresse der Büroräume an: ");
adressebüro = Console.ReadLine();

Console.Write("Bitte geben Sie die Fläche der Wohnräume an: ");
wohnfläche = Convert.ToInt32(Console.ReadLine());
Console.Write("Bitte geben Sie die Adresse der Wohnräume an: ");
adressewohn = Console.ReadLine();

//Objekte erstellen
Buero buero = new Buero(bürofläche, adressebüro);
Wohnung wohnung = new Wohnung(wohnfläche, adressewohn);

//Miete berechnen
buero.Set_miete();
wohnung.Set_miete();

//Ausgabe
Console.WriteLine("Die Miete der Büroräume in {0} beträgt: {1}", buero.Adresse, buero.Get_miete());
Console.WriteLine("Die Miete der Wohnräume in {0} beträgt: {1}", wohnung.Adresse, wohnung.Get_miete());

Console.ReadKey();