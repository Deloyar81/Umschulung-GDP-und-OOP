//Aufgabe 1
static void Aufgabe1()
{
    FileStream aufgabe1 = new FileStream(@"D:\datei1.txt", FileMode.Create);

    aufgabe1.WriteByte(125);
    aufgabe1.Close();
}


//Aufgabe 2
static void Aufgabe2()
{
    FileStream lesen = new FileStream(@"D:\datei1.txt", FileMode.Open);

    Console.WriteLine(lesen.ReadByte());
    lesen.Close();
}


//Aufgabe 3
static void Aufgabe3()
{
    FileStream primwrite = new FileStream(@"D:\primzahlen.txt", FileMode.Append, FileAccess.Write);

    StreamWriter primWriter = new StreamWriter(primwrite);

    int max = 1000;

    static List<int> findPrimes(int max)
    {
        List<int> primes = new List<int>();
        bool[] numbers = new bool[max + 1];

        if (max < 2) return primes;

        for (int i = 0; i <= max; i++)
        {
            numbers[i] = true;
        }

        int p = 2;
        
        while(p * p <= max)
        {
            for(int i = p + p; i <= max; i += p)
            {
                numbers[i] = false;
            }

            int x = p + 1;

            while ( numbers[x]  == false) x++;
            p = x;
        }

        for (int i = 2; i <= max; i++)
        {
            if (numbers[i] == true) primes.Add(i);
        }

        return primes;  

    }

    List<int> primes = findPrimes(max); 

    foreach(int prime in primes)
    {
        primWriter.WriteLine("{0}",prime);
    }

    primWriter.Close();
}

//Aufgabe 4
static void Aufgabe4()
{

}

//Aufgabe 5
static void Aufgabe5()
{
    char[] count = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    int zähler = 0;

    string lesen = File.ReadAllText(@"D:\text.txt");

    int count1 = lesen.Length;
    char[] letter = lesen.ToCharArray();

    for (int i = 0; i < letter.Length; i++)
    {
        for (int z = 0;  letter[i] == count[z]; z++)
        {
            zähler++;
        }
        Console.WriteLine("{0} = {1}", count[i], zähler);
    }

    Console.WriteLine("Anzahl insgesamt: ", count1);



}

//Aufgabe 5 Alternative
static void Aufgabe5alternative()
{
    string lesen = File.ReadAllText(@"D:\text.txt");

    var counted = lesen.GroupBy(c => c).Select(g => new { g.Key, Count = g.Count() });

    foreach (var result in counted)
    {
        Console.WriteLine("{0} = {1}", result.Key, result.Count);
    }
}

//Aufgabe1();
//Aufgabe2();
//Aufgabe3();
//Aufgabe4();
Aufgabe5();
//Aufgabe5alternative();


Console.ReadLine();

