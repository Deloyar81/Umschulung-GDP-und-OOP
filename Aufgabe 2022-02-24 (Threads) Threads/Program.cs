Object lockObject = new();

Thread thread1 = new(Ausgabe1);
Thread thread2 = new (Ausgabe2);
Thread thread3 = new(ZahlenAusgebenGelb);
Thread thread4 = new(ZahlenAusgebenGrün);

thread3.Start();


thread4.Start();


thread1.Start();
thread1.Join();
//thread1.Abort(); veraltet

thread2.Start("Welt");
thread2.Join();


void ZahlenAusgebenGrün()
{
    int zahl = 0;
    lock (lockObject)
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" " + zahl++);
            Console.ResetColor();
            if (zahl > 10) { break; }
        }
        Thread.Sleep(2000);
    }
}

void ZahlenAusgebenGelb()
{
    int zahl = 0;
    lock (lockObject)
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" " + zahl++);
            Console.ResetColor();
            if (zahl > 10) { break; }
        }
        Thread.Sleep(2000);

    }
}

void Ausgabe1()
{
    lock (lockObject)
    {
        Thread.BeginCriticalRegion();
        Console.WriteLine("Methode 1");
        Thread.EndCriticalRegion();
        Console.WriteLine("bla");
        Thread.Sleep(2000);
        Console.WriteLine("blub");
    }


}

void Ausgabe2(object ea)
{
    Console.WriteLine("Methode 2");
    Console.WriteLine("Hallo " + ea);
    Thread.Sleep(300);
}

Console.WriteLine("Es geht weiter...");

static void ThreadMethode()
{
    try
    {
        Console.WriteLine("Abruch");
    }
    catch (ThreadAbortException ex)
    {

    }
}

Console.ReadLine();