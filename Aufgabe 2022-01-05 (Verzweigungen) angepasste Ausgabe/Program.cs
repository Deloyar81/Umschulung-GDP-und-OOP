namespace Aufgabe_2022_01_05__Verzweigungen__angepasste_Ausgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eingabe
            Console.Write("Antworten Sie mit Ja (j oder J) oder Nein (n oder N): ");
            char eingabe = Console.ReadKey().KeyChar;
            eingabe = char.ToLower(eingabe);

            Console.Clear();

            //Verzweigung und Ausgabe
            if (eingabe == 'j')
            {
                Console.WriteLine("Sie haben mit 'Ja' geantwortet");
            }
            else if (eingabe == 'n')
            {
                Console.WriteLine("Sie haben mit 'Nein' geantwortet");
            }
            else
            {
                Console.WriteLine("Sie haben eine falsche Eingabe gemacht");
            }

            Console.ReadKey();
        }
    }
}
