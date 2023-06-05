namespace Aufgabe_2022_01_07__Arrays__Zahlen_miteinander_vertauschen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            int size;


            //Eingabe
            Console.Write("Bitte geben Sie die Größe des Arrays an: ");
            size = int.Parse(Console.ReadLine());

            //Array erstellen
            int[] array = new int[size];

            Random zahl = new Random();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                int z = zahl.Next(1, 10);
                array[i] = z;
            }


            //Ausgabe normales array

            Console.WriteLine("normales Array");
            foreach (int i in array)
            {
                Console.Write("|{0}| ", i);
            }

            //tausch
            for (int i = 0; i < array.Length / 2; i++)
            {
                int buffer1 = array[i];
                int buffer2 = array[array.Length - 1 - i];
                array[i] = buffer2;
                array[array.Length - 1 - i] = buffer1;
            }

            //Ausgabe normales array
            Console.WriteLine("\n\ngetauschtes Array");
            foreach (int i in array)
            {
                Console.Write("|{0}| ", i);
            }

            Console.ReadKey();
        }
    }
}
