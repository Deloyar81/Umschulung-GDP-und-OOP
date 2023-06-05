using System.Text.RegularExpressions;
Console.WindowWidth = 220;
Console.OutputEncoding = System.Text.Encoding.UTF8;


FileStream fileStream = new FileStream(@"D:\Aufgabenblatt 3.1c Regex.txt", FileMode.Open, FileAccess.ReadWrite);

StreamReader streamReader = new StreamReader(fileStream);

string text = streamReader.ReadToEnd();

string regex, aufgabe , eingabe = "", a1;

//Aufgabe 1
aufgabe = "4-stellige Zahl, 1. Stelle ungleich \"0\" (Bsp: 7344)";
regex = @"[1-9]\d{3}";

Aufgabe(text, aufgabe, regex);


//Aufgabe 2
aufgabe = "Wort mit 4 Zeichen (Bsp: Haus) ";
regex = @"\b[a-zA-Z]{4}\b";

Aufgabe(text, aufgabe, regex);

//Aufgabe 3
aufgabe = "Wort mit Großbuchstaben zu Beginn, das mit \"en \" endet (Bsp: Tannen) ";
regex = @"\b[A-Z]+\w*en\b";

Aufgabe(text, aufgabe, regex);

//Aufgabe 4
aufgabe = "\"Wort\", das nur aus Kleinbuchstaben besteht und keinen Selbstlaut enthält (Bsp: dkfs)";
regex = @"\b[^A-Zäöüaeiou\W\d]+\b";

Aufgabe(text, aufgabe, regex);

//Aufgabe 5
aufgabe = "Zahl (1. Stelle ungleich \"0\") mit Einheit (\" Stück \") (Bsp: 60 Stück) ";
regex = @"\b[1-9][0-9]* Stück\b";

Aufgabe(text, aufgabe, regex);

//Aufgabe 6
aufgabe = "Ziffer Strich Ziffer Strich Ziffer Strich (Bsp: 1-7-6)";
regex = @"\d-\d-\d";

Aufgabe(text, aufgabe, regex);

//Aufgabe 7
aufgabe = "Nur Buchstaben \"a \" und \"b \" enthalten (Bsp: abbababbaaa) ";
regex = @"[ab]*(ab|ba)[ab]*";

Aufgabe(text, aufgabe, regex);

//Aufgabe 8
aufgabe = "Binärzahlen (längenmäßig unbeschränkt) (Bsp: 00100101)";
regex = @"[01]+";

Aufgabe(text, aufgabe, regex);

//Aufgabe 9
aufgabe = "Zahl zwischen -750 und 750 (wenn Zahl positiv, dann kein Vorzeichen; längenmäßig nicht beschränkt) (Bsp: 411)";
regex = @"-?[0-7][0-5]{0,1}[0-9]{0,1}|-?[0-6][0-9]{0,1}[0-9]{0,1}";

Aufgabe(text, aufgabe, regex);

//Aufgabe 10
aufgabe = "Dreistellige Zahl von -750 bis 750 (wenn Zahl positiv, dann kein Vorzeichen) (Bsp: 747) ";
regex = @" -?(750|[7][0-4][0-9]|[1-6][0-9]{2})";

Aufgabe(text, aufgabe, regex);

//Aufgabe 11
aufgabe = "4-stellig; Buchstaben \"A \" an 1. Stelle gefolgt von Zahl [300;399] oder Buchstabe \"B\" zu Beginn gefolgt von Zahl [707;717;...;797] (Zahl: 1. Stelle \"7\", 2. Stelle beliebig, 3. Stelle 7) (Bsp: A380) ";
regex = @"A300|A399|B7[0-9]7";

Aufgabe(text, aufgabe, regex);

//Aufgabe 12
aufgabe = "E-Mail-Adresse (Bsp: bill_gates@googlemail.com) ";
regex = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

Aufgabe(text, aufgabe, regex);

//Aufgabe 13
aufgabe = "Internet-Adresse (Bsp: http://www.google.de/) ";
//regex = @"((https?)?|/ftp)?|(mail)?)://\w{3}([.]\w+){1,}\.[a-z]{2,3}";

Aufgabe(text, aufgabe, regex);

//Aufgabe 14
aufgabe = "Wort mit mind. 2 gleichen aufeinanderfolgenden Zeichen bzw. Buchstaben (Bsp: Schiff) ";
regex = @"\bw*(\w)\1w*\b";

Aufgabe(text, aufgabe, regex);

//Aufgabe 15
aufgabe = "Uhrzeit im Format 00:00:00 (Bsp: 16:41:33) ";
regex = @"\b([0-1][0-9]|2[0-3])(:[0-5][0-9]){2}";

Aufgabe(text, aufgabe, regex);

//Aufgabe 16
aufgabe = "Betrag in € (optional 2 Kommastellen), mit 1.000er-Trennzeichen (Bsp: 10.000,00 €) ";
regex = @"([0-9]{1,3}\.)*[0-9]{1,3},[0-9]{2}[ ]?€";

Aufgabe(text, aufgabe, regex);

//Aufgabe 17
aufgabe = "Smiley (1. Zeichen \":\" oder \"; \"); 2. Zeichen \" - \"; 3. Zeichen \"(\" oder \")\" oder \" | \") (Bsp: ;-))";
regex = @"[:;]-[)(|]";

Aufgabe(text, aufgabe, regex);


void Menu()
{
    Console.WriteLine("Geben Sie die Aufgabenbummer ein, deren Lösung angezeigt werden soll: ");
    eingabe = Console.ReadLine();
}

Console.ReadKey();

static void Aufgabe(string text, string aufgabe, string regex)
{
    Console.WriteLine();
    Console.WriteLine(aufgabe);
    Console.WriteLine();
    RegEx(text, regex);
}


static void RegEx(string text, string regex)
{
    MatchCollection m = Regex.Matches(text, regex);
        
    foreach(Match m2 in m)
    {
     
        Console.WriteLine(m2);
    }

}