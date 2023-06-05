namespace Aufgabe_2022_01_05__Verzweigungen__Widerstand_berechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            int laenge, durch;
            string mat;
            double k = 0, R, A;

            //Eingabe
            Console.Write("Bitte geben Sie die Länge des Kabels in Metern ein: ");
            laenge = int.Parse(Console.ReadLine());

            Console.Write("Bitte geben Sie den Durchmesser des Kabels in mm ein: ");
            durch = int.Parse(Console.ReadLine());

            Console.Write($"\nIn der Datenbank vorhandene Materialien: ");

            Console.WriteLine("\n\n\t (S)ilber");
            Console.WriteLine("\n\n\t (K)upfer");
            Console.WriteLine("\n\n\t (A)luminium");
            Console.WriteLine("\n\n\t (M)essing");

            Console.Write($"\n\nBitte geben Sie das Material des Kabels ein: ");
            mat = Convert.ToString(Console.ReadKey().KeyChar);

            switch (mat)
            {
                case "S":
                    k = 60.6;
                    mat = "Silber";
                    break;

                case "K":
                    k = 56.8;
                    mat = "Kupfer";
                    break;

                case "A":
                    k = 30.6;
                    mat = "Aluminium";
                    break;

                case "M":
                    k = 13.3;
                    mat = "Messing";
                    break;

                default:
                    int t = 5;
                    do
                    {
                        Console.Clear();
                        Console.Write($"Das eingegebene Material ist nicht in der Datenbank. Das Programm wird in {t} Sekunden beendet und löscht Ihre Festplatte.");
                        t--;
                        Thread.Sleep(1000);
                    } while (t > 1);
                    Console.Clear();
                    Console.Write($"Das eingegebene Material ist nicht in der Datenbank. Das Programm wird in {t} Sekunde beendet und löscht Ihre Festplatte.");
                    Thread.Sleep(1000);
                    //Environment.Exit(0);
                    return;
            }

            A = (Math.PI * durch * durch) / 4;

            R = Math.Round(laenge / (k * A), 10);

            //Ausgabe
            Console.Clear();

            Console.WriteLine($"\nDer Widerstand von {mat} ist {R}");

            Console.ReadKey();
        }
    }
}
