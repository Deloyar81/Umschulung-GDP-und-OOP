using Aufgabe_2022_02_03__Vererbung__Tiere;

Baummarder baummarder1 = new Baummarder(500);
Baummarder baummarder2 = new Baummarder(300);

Eichhoernchen eichhoernchen1 = new Eichhoernchen(500);
Eichhoernchen eichhoernchen2 = new Eichhoernchen(400);

Uhu uhu1 = new Uhu(2500);
Uhu uhu2 = new Uhu(4500);

Main();

void Main()
{
    baummarder1.Eat(uhu2);
    Ausgabe(baummarder1);

    Console.WriteLine();

    Ausgabe(uhu1);

    Console.WriteLine();

    uhu1.Eat(baummarder2);
    
    Console.WriteLine();

    Ausgabe(baummarder2);
    Ausgabe(uhu1);

    uhu1.Verdauen();

    Console.WriteLine();

    uhu1.Fliegen();
    Ausgabe(uhu1);

    Console.ReadLine();
}

void Ausgabe(Tier tier)
{
    //Console.WriteLine();
    Console.WriteLine("Name: {0}", tier.GetType().Name);
    Console.WriteLine("Aktuelles Gewicht: {0}", tier.GetAktuellesGewicht);
    Console.WriteLine("Lebendigkeits-Status: {0}", tier.GetIsAlive);
}