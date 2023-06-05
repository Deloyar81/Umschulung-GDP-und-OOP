
    public class Vektor
    {
        private Punkt startpunkt;
        private Punkt endpunkt;
        private double länge;

        public Vektor(Punkt punkt1, Punkt punkt2)
        {
            this.startpunkt = punkt1;
            this.endpunkt = punkt2;
        }

        public double Länge_errechnen()
        {
            return länge = Math.Sqrt(Math.Pow((endpunkt.posx - startpunkt.posx),2) + Math.Pow((endpunkt.posy - startpunkt.posy),2));
        }
    }
