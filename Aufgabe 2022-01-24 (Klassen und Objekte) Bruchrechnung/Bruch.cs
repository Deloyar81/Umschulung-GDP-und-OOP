namespace Aufgabe_2021_06_24__Strukturen__Brüche_übergeben_und_ausrechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            string a1, a2, b1, b2;
            int a1a, a1b, b1a, b1b, b2a, b2b;

            //Eingabe der Brüche
            Console.Write("Bitte geben Sie den ersten Bruch ein: ");
            a1 = Console.ReadLine();

            //abfangen von gemischte Zahl erste Eingabe
            int indexa1 = a1.IndexOf(' ');
            if (indexa1 >= 0)
            {
                string[] parta1 = a1.Split(' ');
                a1a = Convert.ToInt32(parta1[0]);
                b1 = parta1[1];

                string[] partb1 = b1.Split('/');
                b1a = Convert.ToInt32(partb1[0]);
                b1b = Convert.ToInt32(partb1[1]);

                b1a = a1a * b1b + b1a;
            }
            else
            {
                b1 = a1;

                string[] partb1 = b1.Split('/');
                b1a = Convert.ToInt32(partb1[0]);
                b1b = Convert.ToInt32(partb1[1]);
            }

            Bruch bruch1 = new Bruch(b1a, b1b);

            Console.Write("\nBitte geben Sie den zweiten Bruch ein: ");
            a2 = Console.ReadLine();

            //abfangen von gemischte Zahl zweite Eingabe
            int indexb2 = a2.IndexOf(' ');
            if (indexb2 >= 0)
            {
                string[] parta2 = a2.Split(' ');
                a1b = Convert.ToInt32(parta2[0]);
                b2 = parta2[1];

                string[] partb2 = b2.Split('/');
                b2a = Convert.ToInt32(partb2[0]);
                b2b = Convert.ToInt32(partb2[1]);

                b2a = a1b * b2b + b2a;
            }
            else
            {
                b2 = a2;

                string[] partb2 = b2.Split('/');
                b2a = Convert.ToInt32(partb2[0]);
                b2b = Convert.ToInt32(partb2[1]);
            }

            Bruch bruch2 = new Bruch(b2a, b2b);

            //Abfangen von 0 im Nenner
            if (bruch1.Nenner == 0 || bruch2.Nenner == 0)
            {
                Console.WriteLine("Die Zahl 0 darf nicht im Nenner stehen! Bei einer Division durch 0 ist das Ergebnis nicht definiert!");
            }

            //Ausgabe der Eingabe
            Console.Clear();
            Console.WriteLine("Der erste eingegebene Bruch ist:\n");
            bruch1.AusgabeBruch();

            Console.WriteLine("\nDer zweite eingegebene Bruch ist:\n");
            bruch2.AusgabeBruch();

            //Ausgabe Eingabe in Double
            Console.WriteLine($"\nDer erste eingegebene Bruch in Double ist: \n\n{bruch1.BruchToDouble()}\n");

            Console.WriteLine($"Der zweite eingegebene Bruch in Double ist: \n\n{bruch2.BruchToDouble()}\n");

            //Ausgabe Umkehrwert
            Console.WriteLine("Der erste eingegebene Bruch als Umkehrwert:");
            bruch1.UmkehrBruch();

            Console.WriteLine("\nDer zweite eingegebene Bruch als Umkehrwert:");
            bruch2.UmkehrBruch();

            //Kürzung der Eingabe
            Console.WriteLine($"\nDer erste Bruch {bruch1.Zaehler}/{bruch1.Nenner} ist gekürzt (sofern kürzbar):");
            bruch1.KürzeBruch();

            Console.WriteLine($"\nDer zweite Bruch {bruch2.Zaehler}/{bruch2.Nenner} ist gekürzt (sofern kürzbar):");
            bruch2.KürzeBruch();

            //Addition der Eingabe
            Console.WriteLine($"\nDie Addition von {bruch1.Zaehler}/{bruch1.Nenner} + {bruch2.Zaehler}/{bruch2.Nenner} ist: ");
            AddBruch(bruch1.Zaehler, bruch1.Nenner, bruch2.Zaehler, bruch2.Nenner);

            Console.WriteLine($"\nDie Subtraktion von {bruch1.Zaehler}/{bruch1.Nenner} - {bruch2.Zaehler}/{bruch2.Nenner} ist: ");
            SubBruch(bruch1.Zaehler, bruch1.Nenner, bruch2.Zaehler, bruch2.Nenner);

            Console.WriteLine($"\nDie Multiplikation von {bruch1.Zaehler}/{bruch1.Nenner} * {bruch2.Zaehler}/{bruch2.Nenner} ist: ");
            MulBruch(bruch1.Zaehler, bruch1.Nenner, bruch2.Zaehler, bruch2.Nenner);

            Console.WriteLine($"\nDie Division von {bruch1.Zaehler}/{bruch1.Nenner} / {bruch2.Zaehler}/{bruch2.Nenner} ist: ");
            DivBruch(bruch1.Zaehler, bruch1.Nenner, bruch2.Zaehler, bruch2.Nenner);

            Console.ReadKey();
        }

        class Bruch
        {
            private readonly int zaehler;
            private readonly int nenner;


            public Bruch(int Zaehler, int Nenner)
            {
                zaehler = Zaehler;
                nenner = Nenner;
            }

            public int Zaehler { get { return zaehler; } }
            public int Nenner { get { return nenner; } }

            public void AusgabeBruch()
            {
                Console.WriteLine($"{Zaehler}/{Nenner}");
            }

            //Funktion Bruch in Double umrechnen
            public double BruchToDouble()
            {
                double a = Convert.ToDouble(Zaehler) / Convert.ToDouble(Nenner);
                return a;
            }

            //Funktion Umkehrwert nehmen
            public void UmkehrBruch()
            {
                int z = Zaehler;
                int n = Nenner;
                int n1 = n;

                n = z;
                z = n1;

                //gemischte Zahl
                if (z > n)
                {
                    int e = z % n;
                    int f = (z - e) / n;

                    //Ganzzahl
                    if (e == 0)
                    {
                        Console.WriteLine($"\n{f}");
                    }
                    //gemischte Zahl
                    else
                    {
                        Console.WriteLine($"\n{f} {e}/{n}");
                    }
                }
                //einzelne Ganzzahl
                else if (z == n)
                {
                    Console.WriteLine($"\n{z / n}");
                }
                //Bruch
                else
                {
                    Console.WriteLine($"\n{z}/{n}");
                }

                //Console.WriteLine($"{z}/{n}");
            }

            //Funktion Bruch kürzen & wenn nötig als gemischte Zahl ausgeben
            public void KürzeBruch()
            {
                int a = Zaehler;
                int b = Nenner;
                int c = a / GgT(a, b);
                int d = b / GgT(a, b);

                //gemischte Zahl
                if (c > d)
                {
                    int e = c % d;
                    int f = (c - e) / d;

                    //Ganzzahl
                    if (e == 0)
                    {
                        Console.WriteLine($"\n{f}");
                    }
                    //gemischte Zahl
                    else
                    {
                        Console.WriteLine($"\n{f} {e}/{d}");
                    }
                }
                //einzelne Ganzzahl
                else if (c == d)
                {
                    Console.WriteLine($"\n{c / d}");
                }
                //Bruch
                else
                {
                    Console.WriteLine($"\n{c}/{d}");
                }

            }

            //Funktion Größter gemeinsamer Teiler
            public int GgT(int Zaehler, int Nenner)
            {
                return Nenner != 0 ? GgT(Nenner, Zaehler % Nenner) : Zaehler;
            }
        }

        //Menue
        static void Menue()
        {

        }

        //Funktion Addition
        static void AddBruch(int za, int nb, int zc, int nd)
        {
            int ergebnisz, ergebnisn, zapuffer, nbpuffer, zcpuffer;

            zapuffer = za * nd;
            nbpuffer = nb * nd;
            zcpuffer = zc * nb;

            ergebnisz = zapuffer + zcpuffer;
            ergebnisn = nbpuffer;

            Bruch bruch3 = new Bruch(ergebnisz, ergebnisn);

            bruch3.KürzeBruch();
        }

        static void SubBruch(int za, int nb, int zc, int nd)
        {
            int ergebnisz, ergebnisn, zapuffer, nbpuffer, zcpuffer;

            zapuffer = za * nd;
            nbpuffer = nb * nd;
            zcpuffer = zc * nb;

            ergebnisz = zapuffer - zcpuffer;
            ergebnisn = nbpuffer;

            Bruch bruch3 = new Bruch(ergebnisz, ergebnisn);

            bruch3.KürzeBruch();
        }

        //Funktion Multiplikation
        static void MulBruch(int za, int nb, int zc, int nd)
        {
            int ergebnisz, ergebnisn;

            ergebnisz = za * zc;
            ergebnisn = nb * nd;

            Bruch bruch3 = new Bruch(ergebnisz, ergebnisn);

            bruch3.KürzeBruch();
        }

        //Funktion Division
        static void DivBruch(int za, int nb, int zc, int nd)
        {
            int ergebnisz, ergebnisn, zcpuffer, ndpuffer;

            zcpuffer = zc;
            ndpuffer = nd;

            zc = ndpuffer;
            nd = zcpuffer;

            ergebnisz = za * zc;
            ergebnisn = nb * nd;

            Bruch bruch3 = new Bruch(ergebnisz, ergebnisn);

            bruch3.KürzeBruch();
        }
    }
}
