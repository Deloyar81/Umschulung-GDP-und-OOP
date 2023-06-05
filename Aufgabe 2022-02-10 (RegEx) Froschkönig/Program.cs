using System.Text.RegularExpressions;

FileStream fileStream = new FileStream(@"C:\Users\deloy\OneDrive - IT-Akademie Dr. Heuer GmbH\Klassenraum\Grundlagen der Programmierung\18-Regex\Froschkönig Unix Zeilenumbrüche.txt", FileMode.Open, FileAccess.ReadWrite);
StreamReader streamReader = new StreamReader(fileStream);

List<string> lines = new List<string>();

while(!streamReader.EndOfStream)
{
    lines.Add(streamReader.ReadLine());
}

//Original - Text
Console.WriteLine("Original - Text: \n");

int zeilennummer = 0;
string regex;

foreach (string line in lines)
{
    zeilennummer++;
    Console.Write("Zeile {0, 3}: ", zeilennummer);
    Console.WriteLine(line);
}




Console.WriteLine();
ConsoleGreen();
Console.WriteLine("Alle Zeilen mit einem Umlaut: \n");
Console.ResetColor();

regex = @"[ÄÖÜäöü]";
RegEx(lines,regex);

Console.WriteLine();
ConsoleGreen();
Console.WriteLine("Alle Zeilen in denen das Wort „der“ alleine steht: \n");
Console.ResetColor();

regex = @"\bder\b";
RegEx(lines, regex);

Console.WriteLine();
ConsoleGreen();
Console.WriteLine("Alle Zeilen die mit einem großen Buchstaben beginnen: \n");
Console.ResetColor();

regex = @"^[A-Z]";
RegEx(lines, regex);

Console.WriteLine();
ConsoleGreen();
Console.WriteLine("Alle Zeilen, in denen das Wort Frosch oder Froschkönig vorkommt: \n");
Console.ResetColor();

regex = @"\bFrosch\b|\bFroschkönig\b";
RegEx(lines, regex);

Console.WriteLine();
ConsoleGreen();
Console.WriteLine("Alle Zeilen mit einem . (Punkt) am Ende der Zeile: \n");
Console.ResetColor();

regex = @"\.$";
RegEx(lines, regex);

Console.WriteLine();
ConsoleGreen();
Console.WriteLine("Alle Zeilen die mit einer Leerzeichen beginnen: \n");
Console.ResetColor();

regex = @"^ ";
RegEx(lines, regex);

Console.WriteLine();
ConsoleGreen();
Console.WriteLine("Alle Zeilen die einen Punkt, Komma, Ausrufezeichen, etc. enthalten: \n");
Console.ResetColor();

regex = @"[.,!?;:]";
RegEx(lines, regex);


Console.ReadKey();

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