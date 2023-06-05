
public class Punkt
{
    private global::System.Double PosX;
    private global::System.Double PosY;

    public Punkt(double posx, double posy)
    {
        this.PosX = posx;
        this.PosY = posy;
    }

    public double posx
    {
        get { return this.PosX; }
    }

    public double posy
    {
        get { return this.PosY; }
    }
}
