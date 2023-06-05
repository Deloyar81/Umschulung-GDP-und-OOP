public class Patient
{
    private int patientenNr;
    private string patientenname;
    private string adresse;
    private string gdatum;
    private bool versKarte;
    private KKasse kkasse;

    public Patient(int patientennr, string name, string gdatum, KKasse KKasse)
    {
        this.patientenname = name;
        this.versKarte = true;
        this.kkasse = KKasse;
        this.patientenNr = patientennr;  
        this.gdatum = gdatum;
        this.adresse = "";
    }

    public Patient(int patientennr, string name, string gdatum)
    {
        this.patientenname = name;
        this.versKarte = true;
        this.patientenNr = patientennr;
        this.gdatum = gdatum;
        this.adresse = "";
    }

    public void setKrankenkasse(KKasse kasse)
    {
        this.kkasse = kasse;
    }

    public void Patientauslesen()
    {
        Console.WriteLine("Patienten-Nr.: {0}", PatientenNr);
        Console.WriteLine("Name: {0}", PatientenName);
        Console.WriteLine("Geburtsdatum: {0}", Gdatum);
        Console.WriteLine("Krankenkasse: {0}", Kkasse.KassenName);
        Console.WriteLine("");
    }

    public KKasse Kkasse { get { return this.kkasse; } }


    public string PatientenName
    { get { return this.patientenname; } }

    public string Adresse
    { get { return this.adresse; } }

    public bool VersKarte
    { get { return this.versKarte; } }

    public string Gdatum
    { get { return this.gdatum; } }

    public int PatientenNr
    { get { return this.patientenNr; } }
}