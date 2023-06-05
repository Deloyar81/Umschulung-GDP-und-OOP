using Aufgabe_2022_02_25__Threads__Consumer_Producer;

class Programm
{
    static void Main()
    {
        
        Lager lager = new Lager(0);

            
        //while(true)
        //{
            Thread consumer1 = new(lager.Entnehmen);
            Thread consumer2 = new(lager.Entnehmen);
            Thread producer1 = new(lager.Produzieren);

            consumer1.Start();
            consumer2.Start();
            producer1.Start();
        //}




        Console.ReadLine();
    }
}

