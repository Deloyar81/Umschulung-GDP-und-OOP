using Aufgabe_2022_02_17__Interface__Movable;



MovablePoint p1 = new (1, 10);
MovablePoint p2 = new (6, 5);
MovableRect movableRect = new(p1, p2);

movableRect.MoveRight();
movableRect.MoveRight();
movableRect.MoveRight();

Console.WriteLine(movableRect);

movableRect.MoveUp();
movableRect.MoveUp();
movableRect.MoveUp();

Console.WriteLine(movableRect);

movableRect.MoveLeft();
movableRect.MoveLeft();

Console.WriteLine(movableRect);

Console.ReadKey();