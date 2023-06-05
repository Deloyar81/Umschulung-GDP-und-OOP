using Aufgabe_2022_02_16__Interface__Flüsse;

Fluss rhein = new Fluss("Rhein");
Fluss donau = new Fluss("Donau");

Schiff rheingold = new Schiff("Rheingold");
Schiff lorelei = new Schiff("Lorelei");
Schiff xaver = new Schiff("Xaver");
Schiff franz = new Schiff("Franz");

Stadt köln = new Stadt("Köln");
Stadt düsseldorf = new Stadt("Düsseldorf");
Stadt ulm = new Stadt("Ulm");

Klärwerk strauß1 = new Klärwerk("Strauß 1");

int exit = 0, eingabe = 0;

rhein.NeueBeobachter(köln);
rhein.NeueBeobachter(düsseldorf);
rhein.NeueBeobachter(rheingold);
rhein.NeueBeobachter(lorelei);

donau.NeueBeobachter(ulm);
donau.NeueBeobachter(xaver);
donau.NeueBeobachter(franz);
donau.NeueBeobachter(strauß1);

while (exit == 0)
{
    exit = 0;

    Console.Clear();
    Console.WriteLine("Bitte prüfen Sie den Wasserstand:");
    Console.WriteLine("(1) - Prüfung des Wasserstandes");
    Console.WriteLine("(2) - Es ist Feierabend!");
    Console.WriteLine();

    eingabe = int.Parse(Console.ReadLine());

    switch (eingabe)
    {
        case 1:
            while (true)
            {
                Console.Clear();
                rhein.NeuerWasserpegel();
                donau.NeuerWasserpegel();
                Thread.Sleep(1000);
                if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }
                
            }

            break;
        case 2:
            exit = 1;
            break;
    }
}