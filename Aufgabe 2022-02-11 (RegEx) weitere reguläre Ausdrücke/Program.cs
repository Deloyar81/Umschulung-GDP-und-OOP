using System.Text.RegularExpressions;
Console.WindowWidth = 220;
Console.OutputEncoding = System.Text.Encoding.UTF8;

FileStream fileStream = new FileStream(@"D:\Froschkönig Unix Zeilenumbrüche.txt", FileMode.Open, FileAccess.ReadWrite);
StreamReader streamReader = new StreamReader(fileStream);

List<string> lines = new List<string>();

int zeilennummer = 0;
string regex1, regex2, regex3, regex4, regex5, regex6, eingabe1, eingabe2, eingabe3, eingabe4, eingabe5, eingabe6;

while (!streamReader.EndOfStream)
{
    lines.Add(streamReader.ReadLine());
}

foreach (string line in lines)
{
    zeilennummer++;
    Console.Write("Zeile {0, 3}: ", zeilennummer);
    Console.WriteLine(line);
}



eingabe1 = "Alle Zeilen in den ein Wort mit ß am Ende des Wortes steht (daß, saß, heiß, usw.). Geben Sie die Zeilennummern mit aus.";
regex1 = @"\b\w+ß\b";

eingabe2 = "Die Anzahl der leeren Zeilen im Dokument. Hinweis: Eine leere Zeile ist eine Zeile, bei der am Zeilenanfang das Zeilenende steht.";
regex2 = @"^$";

eingabe3 = "Alle Zeilen bei denen am Anfang der Zeile ein Wort mit genau 3 Buchstaben steht (und, der, sie, usw.). Es sollen Große und Kleine Wörter ausgeben werden.";
regex3 = @"^[\a-zA-ZÄÖÜäöü}{3}\b";

eingabe4 = "Alle Zeilen die einen Artikel enthalten (der, die, das).";
regex4 = @"\b[D|d](er|ie|as)\b";

eingabe5 = "Überprüfen sie IP-Adressen auf ihre Gültigkeit.";
regex5 = @"\b(1?[0-9]{1,2})(\.1?[0-9]{1,2}){3}|(2*[0-4][0-9])(\.2*[0-4][0-9]){3}|((25)*[0-5])(\.(25)*[0-5]){3}\b";

eingabe6 =   "\nSchreiben Sie einen Ausdruck, der überprüft, ob eine Log-Zeile dem Standard-Log Format des Apache-Servers entspricht. Eine Zeile kann z.B. so aussehen:" +
            "\n192.168.1.1 - - [01 / Apr / 2001:08:33:48 + 0200] \"GET / test.php4 HTTP / 1.0\" 200 3286" +
            "\nDie Bedeutung der Felder ist hier nicht wichtig, kann aber trotzdem interessant sein: Als erstes steht die IP-Adresse bzw. der Rechnername, von dem die Anfrage kam. Die nächsten beiden Felder sind der Username, beide Felder müssen aber nicht existieren. In den eckigen Klammern steht das genaue Datum mit Zeit und Zeitzone. In den Anführungszeichen steht die angeforderte Datei mit der Methode (kann auch POST sein) und dem Protokoll (kann auch HTTP/1.1 sein). Als vorletztes wird der Status angegeben (200 ist OK) und das letzte Feld sagt, wie viel Daten bei diesem Aufruf übertragen wurden.";
regex6 = //@"\b(1?[0-9]{1,2})(\.1?[0-9]{1,2}){3}|(2*[0-4][0-9])(\.2*[0-4][0-9]){3}|((25)*[0-5])(\.(25)*[0-5]){3} (([\w-]){1,} )?\[([0-3][0-1])|[0-2][0-9] \/ [A-Za-z]{3} \/ -?[0-9]+:([0-1][0-9]|2[0-3])(:[0-5][0-9]){2} + [0-9]{4}\] ""(GET) | (POST) \/ [\w.] + (HTTP \/ (1.0))|(HTTP \/ (1.1))"" [0-9]{ 3} [0-9]?$";

//IP-Adresse, username
//@"\b(1?[0-9]{1,2})(\.1?[0-9]{1,2}){3}|(2*[0-4][0-9])(\.2*[0-4][0-9]){3}|((25)*[0-5])(\.(25)*[0-5]){3} (([\w-]){1,} )? ";
//Datum, Uhrzeit, Zeitzone
//@"\[([0-3][0-1])|[0-2][0-9] \/ [A-Za-z]{3} \/ -?[0-9]+:([0-1][0-9]|2[0-3])(:[0-5][0-9]){2} + [0-9]{4}\]";
//Datei, Methode
//@"""(GET)|(POST) \/ [\w.]+ (HTTP \/ (1.0))|(HTTP \/ (1.1))\""";
//Status
//@" [0-9]{3} ";
//Übertragungsgröße
//@"[0-9]?";



Überschrift(eingabe6);
RegEx(lines, regex6);


Console.ReadKey();
fileStream.Close();

static void Überschrift(string eingabe)
{
    Console.WriteLine();
    ConsoleGreen();
    Console.WriteLine(eingabe);
    Console.ResetColor();
}

static void ConsoleGreen()
{
    Console.ForegroundColor = ConsoleColor.Green;
}

static void RegEx(List<string> lines, string regex)
{
    int zeilennummer = 0;
    int i = 0;
    foreach (string line in lines)
    {
        zeilennummer++;
        if (Regex.IsMatch(line, regex))
        {
            i++;
            string ersatz = regex;
            Console.Write("Zeile {0, 3}: ", zeilennummer);

            Console.WriteLine(line);
        }
    }
    Console.WriteLine("Gesamt: {0} Zeilen", i);
}