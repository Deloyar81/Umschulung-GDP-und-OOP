//Variablen


//Boxer definieren
Boxer[] boxer = new Boxer[2];



//Eingabe
Console.Write("Bitte geben Sie den Namen von Boxer 1 ein: ");
boxer[0] = new Boxer(Console.ReadLine());

Console.Write("Bitte geben Sie den Namen von Boxer 2 ein: ");
boxer[1] = new Boxer(Console.ReadLine());

//Kampf

while (boxer[0].Vitalität > 0 && boxer[1].Vitalität > 0)
{
    int trefferb1 = boxer[0].Schlagen();
    if (trefferb1 > 10)
    {
        int schaden = boxer[0].Schaden(boxer[1], trefferb1);
        Console.WriteLine("Boxer {0} verursacht {1} Schaden. {2} hat noch {3} Vitalität.", boxer[0].Name, schaden, boxer[1].Name, boxer[1].Vitalität);
    };

    int trefferb2 = boxer[1].Schlagen();
    if (trefferb2 > 10)
    {
        int schaden = boxer[1].Schaden(boxer[0], trefferb2);
        Console.WriteLine("Boxer {0} verursacht {1} Schaden. {2} hat noch {3} Vitalität.", boxer[1].Name, schaden, boxer[0].Name, boxer[0].Vitalität);
    };

}

//Ausgabe

Console.ReadKey();

//Klasse Boxer
class Boxer
{
    private int vitalität;
    private string name;

    public Boxer(string name)
    {
        this.name = name;
        this.vitalität = 100;
    }

    public string Name
    { get { return name; } }

    public int Vitalität
    { get { return vitalität; } }


    public int Schlagen()
    {
        Random random = new Random();

        int treffer = random.Next(1, 21);

        if (treffer <= 10)
        {
            Console.WriteLine("{0} hat verfehlt!", this.name);
            Thread.Sleep(100);
            return treffer;
        }
        else
        {
            Console.WriteLine("{0} hat gretroffen!", this.name);
            Thread.Sleep(100);
            return treffer;
        }
    }

    public int Treffer(int schaden)
    {
        vitalität -= schaden;
        return vitalität;
    }

    public int Schaden(Boxer getroffener, int treffer)
    {
        Random random = new Random();

        int schaden = random.Next(10, 21);

        if (treffer == 20)
        {
            Console.WriteLine("POW! Kritischer Treffer! Schaden verdoppelt!");
            schaden = schaden * 2;
            getroffener.Treffer(schaden);
        }
        else if (treffer >= 11 && treffer <= 14)
        {
            Console.WriteLine("Streif-Treffer! Schaden verringert!");
            schaden = schaden / 2;
            getroffener.Treffer(schaden);
        }
        else
        {
            getroffener.Treffer(schaden);
        }

        return schaden;
    }
}