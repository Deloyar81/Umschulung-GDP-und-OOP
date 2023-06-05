
abstract class Gebaeude
{
    protected int flaeche;
    protected int miete;
    protected string adresse;



    public Gebaeude(int flaeche, string adresse)
    {
        this.flaeche = flaeche;
        this.adresse = adresse;
    }

    public int Flaeche
    { get { return flaeche; } set { flaeche = value; } }

    public string Adresse
    { get { return adresse; } set { adresse = value; } }

    public abstract void Set_miete();
    public abstract int Get_miete();
        

}

