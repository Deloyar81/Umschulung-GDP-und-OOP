FileStream eingabe = File.Open("D:\\Datei.txt", FileMode.Open, FileAccess.Read);
FileStream ausgabe = new FileStream("D:\\Dateikonvertiert.txt", FileMode.Append, FileAccess.Write);

StreamReader sr = new StreamReader(eingabe);
StreamWriter sw = new StreamWriter(ausgabe);

string textdatei = sr.ReadToEnd();

Console.Write(textdatei);

Console.ReadKey();

foreach(char c in textdatei)
{
    if(c == 'ä')
    {
        sw.Write('a');
        sw.Write('e');
    }
    else if(c == 'ö')
    {
        sw.Write('o');
        sw.Write('e');
    }
    else if (c == 'ü')
    {
        sw.Write('u');
        sw.Write('e');
    }
    else
    {
        sw.Write(c);
    }
}
eingabe.Close();
ausgabe.Close();
