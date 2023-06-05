
Console.CursorVisible = false;

//Initialisierung
Homer homer = new Homer();
Marge marge = new Marge();
Bart bart = new Bart();
Lisa lisa = new Lisa();
Maggie maggie = new Maggie();


//Methoden jedes Objektes aufrufen + Ausgabe
homer.SichVorstellen();
homer.Donoutessen();
homer.Donoutessen();
homer.Donoutessen();
homer.Donoutsgegessen();

Zeile();

marge.SichVorstellen();
marge.SichKuemmern();
marge.Haushalt();

Zeile();

bart.SichVorstellen();
bart.Skateboardfahren();
bart.Skateboardfahren();
bart.Skateboardfahren();
bart.Skateboardfahren();
bart.Skateboardfahren();
bart.Skateboardgefahren();


Zeile();

lisa.SichVorstellen();
lisa.SaxophonSpielen();
lisa.SaxophonGespielt();

Zeile();

maggie.SichVorstellen();
maggie.SchnullerNuckeln();
maggie.AmSchnullerGenuckelt();

Zeile();

Console.ReadKey();


static void Zeile()
{
    Console.WriteLine("");
    Console.WriteLine("".PadLeft(totalWidth: Console.WindowWidth, '#'));
    Console.WriteLine("");
}


class Simpsons
{
    protected string nachname;
    protected string adresse;
    protected string hautfarbe;
    protected int counter;

    public Simpsons()
    {
        this.nachname = "Simpson";
        this.adresse = "Evergreen Terrace 742, Springfield";
        this.hautfarbe = "gelb";
        this.counter = 0;
    }

    protected void Ausgabe()
    {
        Console.WriteLine("Nachname: {0}", nachname);
        Console.WriteLine("Adresse: {0}", adresse);
        Console.WriteLine("Hautfarbe: {0}", hautfarbe);
    }
}

internal class Homer : Simpsons
{
    private string vorname = "Homer";

    //public Homer() : base()
    //{
    //    this.vorname = "Homer";
    //}

    public void Donoutessen()
    {
        counter ++;
    }
    public void Donoutsgegessen()
    {
        Console.WriteLine("{0} hat in seinem kurzen Leben {1} Donouts gegessen.", vorname, counter);
    }
    public void SichVorstellen()
    {
        Console.WriteLine("Vorname: {0}", vorname); ;
        Ausgabe();
    }
}

internal class Marge : Simpsons
{
    private string vorname = "Marge";

    //public Marge() : base()
    //{
    //    this.vorname = "Marge";
    //}
    public void SichKuemmern()
    {
        counter++;
    }
    public void Haushalt()
    {
        Console.WriteLine("{0} hat sich {1} mal um den Haushalt gekümmert.", vorname, counter);
    }

    public void SichVorstellen()
    {
        Console.WriteLine("Vorname: {0}", vorname);
        Ausgabe();
    }
}

internal class Bart : Simpsons
{
    private string vorname = "Bart";

    //public Bart() : base()
    //{
    //    this.vorname = "Bart";
    //}

    public void SichVorstellen()
    {
        Console.WriteLine("Vorname: {0}", vorname);
        Ausgabe();
    }

    public void Skateboardfahren()
    {
        counter++;
    }
    public void Skateboardgefahren()
    {
        Console.WriteLine("{0} ist {1} mal mit dem skateboard gefahren.", vorname, counter);
    }
}

internal class Maggie : Simpsons
{
    private string vorname = "Maggie";

    //public Maggie() : base()
    //{
    //    this.vorname = "Maggie";
    //}

    public void SichVorstellen()
    {
        Console.WriteLine("Vorname: {0}", vorname);
        Ausgabe();
    }
    public void SchnullerNuckeln()
    {
        counter++;
    }
    public void AmSchnullerGenuckelt()
    {
        Console.WriteLine("{0} hat  {1} mal am Schnuller genuckelt.", vorname, counter);
    }
}

internal class Lisa : Simpsons
{
    private string vorname = "Lisa";

    //public Lisa() : base()
    //{
    //    this.vorname = "Lisa";
    //}
    public void SaxophonSpielen()
    {
        counter++;
    }

    public void SichVorstellen()
    {
        Console.WriteLine("Vorname: {0}", vorname);
        Ausgabe();
    }
    public void SaxophonGespielt()
    {
        Console.WriteLine("{0} hat {1} mal Saxophon gespielt.", vorname, counter);
    }

}


