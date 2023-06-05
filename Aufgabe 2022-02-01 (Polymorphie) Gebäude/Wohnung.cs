
internal class Wohnung : Gebaeude
{
    private int zimmer;


    public Wohnung(int flaeche, string adresse, int zimmer ) : base(flaeche, adresse)
    {
        this.zimmer = zimmer;
    }

    public Wohnung(int flaeche, string adresse) : base(flaeche, adresse)
    {
        this.zimmer = 5;
    }

    public int Zimmer
    { get { return zimmer; } set { zimmer = value; } }

    public override int Get_miete()
    {
        return miete;
    }

    public override void Set_miete()
    {
        miete = Flaeche * 10;
    }
}

