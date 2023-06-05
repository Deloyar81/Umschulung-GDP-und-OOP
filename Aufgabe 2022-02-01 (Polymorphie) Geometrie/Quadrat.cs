    class Quadrat : GeometrieObjekt
    {
        private double seitenlaenge;


        public Quadrat(double seitenlaenge)
        {
            this.seitenlaenge = seitenlaenge;
        }

        public override void Ausgabe()
        {
            Console.WriteLine("Quadratumfang: {0}", BerechneUmfang());
            Console.WriteLine("Quadratfläche: {0}", BerechneFlaeche());
        }

        protected override double BerechneUmfang()
        {
            double umfang = 4 * seitenlaenge;
            return umfang;
        }

        protected override double BerechneFlaeche()
        {
            double flaeche = Math.Pow(seitenlaenge, 2);
            return flaeche;
        }
    }

