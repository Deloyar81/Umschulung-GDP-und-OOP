using Aufgabe_2022_02_15__Interface__Fliegen;

Biene biene = new Biene();
Fledermaus fledermaus = new Fledermaus();
Singvogel singvogel = new Singvogel();

IFliegen[] f1 = new IFliegen[3] { biene, fledermaus, singvogel };
ISingen[] s1 = new ISingen[1] { singvogel };

biene.Fliegen();
fledermaus.Fliegen();
singvogel.Fliegen();
singvogel.Singen();

Console.WriteLine();

foreach (IFliegen f in f1)
{
    Console.WriteLine(f.GetType().Name);
    f.Fliegen();
    Console.WriteLine();
}

Console.WriteLine();

foreach(ISingen s in s1)
{
    Console.WriteLine(s.GetType().Name);
    s.Singen();
    Console.WriteLine();
}

Console.ReadKey();