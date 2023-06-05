
    class Kreis : GeometrieObjekt
    {
        private double radius;

        public Kreis(double radius)
        {
            this.radius = radius;
        }


        protected override double BerechneFlaeche()
        {
            double kreisumfang = 2 * Math.PI * radius;
            return kreisumfang;
        }

        protected override double BerechneUmfang()
        {
            double kreisflaeche = Math.PI * Math.Pow(radius, 2);
            return kreisflaeche;

            return Math.PI* Math.Pow(radius, 2);
    }

        public override void Ausgabe()
        {
            Console.WriteLine("Kreisumfang: {0}", BerechneUmfang());
            Console.WriteLine("Kreisfläche: {0}", BerechneFlaeche());
        }
    }

