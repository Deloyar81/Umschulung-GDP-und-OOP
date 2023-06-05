// See https://aka.ms/new-console-template for more information

using Snake;

//Variablen
int gameover = 0;
int score = 0;

//Consolengröße
int consoleleft = 0, consoletop = 0, consoleright = 160, consolebottom = 46;

//Spielfeldgröße
int spielfeldleft = consoleleft + 10, spielfeldtop = consoletop + 10, spielfeldright = consoleright - 10, spielfeldbottom = consolebottom - 10;

//Spielfeld generieren
Console.CursorVisible = false;
Spielfeld();


//snake initialisieren
Schlange snake = new Schlange(spielfeldright/2, spielfeldbottom/2);

snake.Startposition(spielfeldleft, spielfeldtop);
snake.Score();

//Bite initlialisieren
Bite bite = new Bite(spielfeldleft, spielfeldtop, spielfeldleft +1 , spielfeldright - 1, spielfeldtop + 1, spielfeldbottom - 1);

Console.ReadKey();

//Window
void Spielfeld()
{
    //Variablen
   

    Console.SetWindowSize(consoleright, consolebottom);
    Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);

    //Spielfeldbegrenzung
    for (int i = 0; i <= spielfeldright - 10; i++)
    {
        Console.SetCursorPosition(spielfeldleft + i, spielfeldtop);
        Console.Write("X");
        Console.SetCursorPosition(spielfeldleft + i, spielfeldbottom);
        Console.Write("X");
    }

    for (int i = 0; i <= spielfeldbottom - 10; i++)
    {
        Console.SetCursorPosition(spielfeldleft, spielfeldtop + i);
        Console.Write("X");
        Console.SetCursorPosition(spielfeldright, spielfeldtop + i);
        Console.Write("X");
    }        
}

