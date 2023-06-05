using Aufgabe_2022_02_16__Interface__Wasserbüffel;

Wasserbüffel wasserbüffelhirte = new Wasserbüffel();
Straße straßenwacht = new Straße();
Fluss ruhr = new Fluss();
Wanderweg wanderwegverein = new Wanderweg();

int exit = 0, eingabe = 0;

ruhr.NeueBeobachter(wanderwegverein);
ruhr.NeueBeobachter(straßenwacht);
ruhr.NeueBeobachter(wasserbüffelhirte);


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
            Console.Clear();
            ruhr.NeuerWasserpegel();
            Thread.Sleep(5000);
            break;
        case 2:
            exit = 1;
            break;
    }
}
