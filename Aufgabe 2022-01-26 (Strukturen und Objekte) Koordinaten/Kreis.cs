
public class Kreis
{
    private double radius;
    private Punkt mittelpunkt;

public Kreis(double länge, Punkt mittelpunkt)
    {
        this.radius = länge;
        this.mittelpunkt = mittelpunkt;
    }

    public double Umfang()
    {
        double Umfang = 2 * Math.PI * this.radius;
        return Umfang;
    }

    public double Inhalt()
    {
        double inhalt = Math.PI * Math.Pow(this.radius, 2);
        return inhalt;            
    }
}
