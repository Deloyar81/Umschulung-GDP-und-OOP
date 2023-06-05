namespace Aufgabe_2022_01_05__Verzweigungen__Aktien_erwerben
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            double dauer;
            char kündigung;

            //Eingabe
            Console.Write("Bitte geben Sie die Dauer des Arbeitsverhältnisses an: ");
            dauer = Convert.ToDouble(Console.ReadLine());

            Console.Write("Wurde das Arbeitsverhältnis gekündigt (j/n): ");
            kündigung = char.Parse(Console.ReadLine());

            //Verzweigung

            switch (kündigung)
            {
                case 'j':
                    Console.WriteLine("Sie können keine Aktien erwerben.");
                    break;

                case 'n':

                    if (dauer > 10)
                    {
                        Console.WriteLine("Sie können 20 Aktien erwerben.");
                    }
                    else if (dauer > 2)
                    {
                        Console.WriteLine("Sie können 10 Aktien erwerben.");
                    }
                    else
                    {
                        Console.WriteLine("Sie können keine Aktien erwerben.");
                    }
                    break;

                default:
                    Console.WriteLine("Sie haben eine falsche Eingabe getätigt!");
                    break;
            }


            Console.ReadKey();


        }
    }
}
