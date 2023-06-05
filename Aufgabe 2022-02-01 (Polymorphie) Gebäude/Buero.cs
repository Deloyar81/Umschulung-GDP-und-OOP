internal class Buero : Gebaeude
{
    private int bueroraeume;
    public Buero(int flaeche, string adresse, int buroraeume) : base(flaeche, adresse)
    {
        this.bueroraeume = buroraeume;
    }

    public Buero(int flaeche, string adresse) : base(flaeche, adresse)
    {
        this.bueroraeume = 5;
    }

    public int Bueroraeume
    { get { return this.bueroraeume; } set { this.bueroraeume = value; } }

    public override int Get_miete()
    {
        return miete;
    }

    public override void Set_miete()
    {
        miete = flaeche * 20 + Bueroraeume * 30;

    }
}

