// See https://aka.ms/new-console-template for more information

double posx = 0, posy = 0;
Punkt startpunkt = new Punkt(posx, posy);
Punkt endpunkt = new Punkt(posx, posy);

Menu();
Console.ReadKey();

//Menu
void Menu()
{
    //Ausbruchsvariable
    int exit = 0;

    while (exit == 0)
    {
        Console.Clear();

        //Menuausgabe
        Console.WriteLine("( 1) - Startpunkt einer Geraden eingeben");
        Console.WriteLine("( 2) - Endpunkt einer Geraden eingeben");
        Console.WriteLine("( 3) - Länge einer durch Start- und Endpunkt definierten Geraden berechnen");
        Console.WriteLine("( 4) - Kreis Berechnungen");
        Console.WriteLine("( 5) - Programm beenden");

        Console.Write("\n\nAuswahl: ");

        int auswahl = Convert.ToInt32(Console.ReadLine());


        switch (auswahl)
        {
            case 1:
                Console.Clear();
                Eingabestart();
                Console.ReadKey();
                break;
            case 2:
                Console.Clear();
                Eingabeende();
                Console.ReadKey();
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Die Länge der Geraden beträgt: {0}", Vektor());
                Console.ReadKey();
                break;
            case 4:
                Console.Clear();
                //if(Eingabestart() == null || Eingabeende() == null)
                //{
                Kreis(Vektor());
                    Console.ReadKey();
                //}
                //else
                //{
                    
                //}
                break;
            case 5:
                exit = 1;
                break;
        }

    }
}
//Eingabe
static Punkt Eingabestart()
{
    Console.Write("Bitte geben Sie die Koordinaten des Start-Punktes mit Komma getrennt ein: ");
    string[] teil1 = Console.ReadLine().Split(',');

    teil1[0] = teil1[0].Trim();
    teil1[1] = teil1[1].Trim();

    double posx = Convert.ToDouble(teil1[0]);
    double posy = Convert.ToDouble(teil1[1]);

    Punkt startpunkt = new Punkt(posx, posy);

    return startpunkt;
}

static Punkt Eingabeende()
{

    Console.Write("Bitte geben Sie die Koordinaten des End-Puntes mit Komma getrennt ein: ");
    string[] teil2 = Console.ReadLine().Split(',');

    teil2[0] = teil2[0].Trim();
    teil2[1] = teil2[1].Trim();

    double posx = Convert.ToDouble(teil2[0]);
    double posy = Convert.ToDouble(teil2[1]);

    Punkt endpunkt = new Punkt(posx, posy);

    return endpunkt;
}

//Vektor berechnen
static double Vektor()
{ 
    Vektor vektor = new Vektor(Eingabestart(), Eingabeende());

    //Radius/Länge berechnen
    double länge = vektor.Länge_errechnen();

    return länge;
}




//Kreis
static void Kreis(double länge)
{
    Console.Write("Bitte geben Sie die Koordinaten des Mittelpunktes mit Komma getrennt ein: ");
    string[] teil3 = Console.ReadLine().Split(',');

    teil3[0] = teil3[0].Trim();
    teil3[1] = teil3[1].Trim();

    double posx = Convert.ToDouble(teil3[0]);
    double posy = Convert.ToDouble(teil3[1]);

    Punkt mittelpunkt = new Punkt(posx, posy);

    Kreis kreis = new Kreis(länge, mittelpunkt);


    Console.WriteLine("Der Kreisumfang beträgt: {0}", kreis.Umfang());
    Console.WriteLine("Die Kreisfläche beträgt: {0}", kreis.Inhalt());
    Console.ReadKey();
}


