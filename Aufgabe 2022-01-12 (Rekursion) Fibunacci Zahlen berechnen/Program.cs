// See https://aka.ms/new-console-template for more information

static ulong FiBo(ulong eingabe, ulong b, ulong c, ulong counter)
{

    if (eingabe == 0)
    {
        return b;
    }
    else
    {
        ulong a;
        ulong z;
        Console.WriteLine("Platz {0, 3} ist die Fibunacci-Zahl {1, 8}", counter, b);

        a = b + c;
        b = c;
        c = a;

        return FiBo(eingabe - 1, b, c, counter + 1);
    }
}

//Variablen
ulong eingabe, a, b = 0, c = 1, counter = 1;

//Eingabe
Console.WriteLine("Bitte geben Sie die Begrenzung ein: ");
eingabe = ulong.Parse(Console.ReadLine());

FiBo(eingabe, b, c, counter);



////Berechnung

//for (int i = 0; i < eingabe; i++)
//{
//    a = b + c;
//    b = c;
//    c = a;

//    Console.WriteLine("Platz {0} ist die Fibunacci-Zahl {1}", i, a);
//}

Console.ReadKey();