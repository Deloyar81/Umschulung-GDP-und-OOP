
public class KKasse
{
    private string kassenNummer;
    private string kassenName;
    private Patient patient;

    public KKasse(string kname, string knummer)
    {
        this.kassenName = kname;
        this.kassenNummer = knummer;
        

    }

    public Patient Patient { get {return patient; } }

    //static void Kassepatient()
    //{
    //    this.Patient(int patientennr, string name, string gdatum);
    //}

    public string KassenName
    { get { return kassenName; } }

    public string KassenNummer
    { get { return kassenNummer; } }
}