namespace Aufgabe_2022_01_07__Arrays__Befüllen_mit_Zahlen_bis_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array erstellen
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] array3 = new int[10];

            Random zahl = new Random();

            //befüllen 10 absteigend
            for (int i = array1.Length - 1; i >= 0; i--)
            {
                array1[array1.Length - 1 - i] = i + 1;
            }

            //befüllen 10 aufsteigend
            for (int i = array2.Length - 1; i >= 0; i--)
            {
                array2[array2.Length - 1 - i] = array2.Length - i;
            }

            //befüllen 10 random
            for (int i = array3.Length - 1; i >= 0; i--)
            {
                int random = zahl.Next(1, 11);
                array3[i] = random;
            }

            //Ausgabe
            Console.WriteLine("Befüllen mit 10 absteigend\n");

            foreach (int i in array1)
            {
                Console.Write("|{0}| ", i);
            }

            Console.WriteLine("\n\nBefüllen mit 10 aufsteigend\n");

            foreach (int i in array2)
            {
                Console.Write("|{0}| ", i);
            }

            Console.WriteLine("\n\nBefüllen mit 10 random\n");

            foreach (int i in array3)
            {
                Console.Write("|{0}| ", i);
            }

            Console.ReadKey();
        }
    }
}
