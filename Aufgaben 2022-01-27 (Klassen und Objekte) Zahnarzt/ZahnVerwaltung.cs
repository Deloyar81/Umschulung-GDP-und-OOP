

KKasse kkasse1 = new KKasse("IKK", "1");
KKasse kkasse2 = new KKasse("DAK", "2");
KKasse kkasse3 = new KKasse("BKK", "3");

Patient patient1 = new Patient(1, "Albert", "05.12.1981", kkasse1);
Patient patient2 = new Patient(2, "Bernf", "05.12.2000", kkasse2);

Menu();
Console.ReadKey();

void Menu()
{
    int exit = 0;


    while (exit == 0)
    {
        Console.WriteLine("(1) - Patient anlegen");
        Console.WriteLine("(2) - Krankenkasse anlegen");
        Console.WriteLine("(3) - Datenausgabe");
        Console.WriteLine("(4) - ");
        Console.WriteLine("(5) - Exit");

        Console.Write("\n\nAuswahl: ");

        int eingabe = Convert.ToInt32(Console.ReadLine());




        switch (eingabe)
        {
            case 1:
                Console.WriteLine("Name des Patienten: ");

                break;
            case 2:
                
                break;

            case 3:
                Console.Clear();
                patient1.Patientauslesen();
                patient2.Patientauslesen();

                break;

            case 4:

                break;

            case 5:
                exit = 1;
                break;
        }
    }
}


