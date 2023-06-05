using Aufgabe_2022_02_02__Polymorphie__Haustiere;

Haustier[] haustier = new Haustier[6];

Vogel vogel1 = new Vogel("vogel1", 2000, true);
Vogel vogel2 = new Vogel("vogel2", 2000, false);

haustier[0] = vogel1;
haustier[1] = vogel2;

Main();

Console.ReadKey();

void Main()
{
    AnlegenHaustier();
    Ausgeben();


}

void AnlegenHaustier()
{
    haustier[0] = new Vogel("vogel1", 2000, true);
    haustier[1] = new Vogel("vogel2", 2000, false);

    haustier[2] = new Katze("Katze1", 2000, haustier[0] as Vogel);
    haustier[3] = new Katze("Katze2", 2000, (Vogel)haustier[1]);

    haustier[4] = new Hund("Hund1", 2000, "Dalmatiner");
    haustier[5] = new Hund("Hund2", 2000, "Dackel");
}

void SetNeuerLieblingsvogel()
{

}

void Ausgeben()
{
    double kosten = 0;


    foreach (Haustier tier in haustier)
    {
        Console.WriteLine("");
        if (tier.GetType().Name == "Katze")
        {
            Console.WriteLine(tier.GetType().Name);
            Console.WriteLine((Katze)tier.GetBeschreibung());
        }
        Console.WriteLine(tier.GetType().Name);
        Console.WriteLine(tier.GetBeschreibung());
        kosten += tier.JahreskostenTierarzt;
    }
    Console.WriteLine("\n\nGesamte Tierarztkosten im Jahr: {0}", kosten);

}