static int Eingabe()
{
    Console.Write("Bitte geben sie die maximale Tiefe des Pascalschen Dreieckes an (der Wert muss ziwschen 3 - 12 liegen): ");
    int eingabe = int.Parse(Console.ReadLine());

    if (eingabe < 3 || eingabe > 12)
    {
        Console.Write("Zahlen sind schwierig, hm? Versuchen Sie es nochmal - diesmal aber wirklich eine Zahl zwischen 3 und 12!");
        Thread.Sleep(3000);
        Console.Clear();
        Eingabe();
        return eingabe;
    }
    else
    {
        Console.Clear();
        return eingabe;
    }
}

static int pDreieck(int zeile, int spalte)
{
    if (spalte == 0 || zeile == spalte)
    {
        return 1;
    }
    else
    {
        return pDreieck(zeile - 1, spalte - 1) + pDreieck(zeile - 1, spalte);
    }
}

//Main Block

//Variable
int zeile, screenWidth = 100;

zeile = Eingabe();

for (int i = 0; i <= zeile; i++)
{
    for (int z = 0; z < screenWidth; z++)
    {
        Console.SetCursorPosition(screenWidth / 2 - i * 3, i);
    }

    for (int j = 0; j <= i; j++)
    {
        Console.Write("{0, -3}   ", pDreieck(i, j));
    }

    Console.WriteLine();
}
Console.ReadKey();

//for (int row = 1; row <= height; row++)
//{
//    Console.SetCursorPosition(screenWidth / 2 - row * 3, row);
//}