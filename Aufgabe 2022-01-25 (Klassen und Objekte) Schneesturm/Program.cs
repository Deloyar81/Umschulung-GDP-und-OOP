

Console.CursorVisible = false;
Console.SetWindowSize(80, 25);

Random random = new Random();
int i;
int posx = 0;


Schneeflocke[] schneeflocke = new Schneeflocke[180];



for (i = 0; i < schneeflocke.Length; i++)
{
    posx = random.Next(0, 80);
    schneeflocke[i] = new Schneeflocke(posx);
}

int z = 0;
while (true)
{

    while (schneeflocke[posx].Posy != 0)
    {
        Thread.Sleep(100);
        posx++;
        if (posx >= 80)
            posx = 0;
    }
    schneeflocke[posx].Position();

    for (int j = 0; j < 80; j++)
    {
        if (schneeflocke[j].Posy != 0)
            schneeflocke[j].Position();
    }
}


Console.ReadKey();
class Wind
{

}

class Schneeflocke
{
    private int posx;
    private int posy;

    public Schneeflocke(int posx)
    {
        this.posx = posx;
        this.posy = 0;
    }

    public int Posx { get { return posx; } set { posx = value; } }
    public int Posy { get { return posy; } set { posy = value; } }

    public int Position()
    {

        Console.SetCursorPosition(posx, posy);
        Console.Write("*");

        Console.SetCursorPosition(posx, posy);
        Console.Write(" ");
        posy++;

        return posy;
    }
}

//do
//{
//    while (!Console.KeyAvailable)
//    {
//        //Making a copy of this list .ToList() as its changed in move and the compiler complains about that
//        foreach (Flyer F in Flyer.AllMy.ToList())
//        {
//            F.Move();
//        }
//        Thread.Sleep(5);



//        // Hom many objects in list 2
//        Console.SetCursorPosition(0, 27);
//        Console.Write("Count: {0}", Flyer.AllMy.Count);
//    }



//} while (Console.ReadKey(true).Key != ConsoleKey.Escape);