using Aufgabe_2022_02_16__Interface__Ninjas;

Ninja ninja1 = new Ninja("Schwert");
Ninja ninja2 = new Ninja("Shuriken");
Ninja ninja3 = new Ninja("");

Console.WriteLine("Ninja 1:");
ninja1.Angreifen("den alten Mann");
Console.WriteLine("Ninja 2:");
ninja2.Angreifen("das Kind");
Console.WriteLine("Ninja 3:");
ninja3.Angreifen("das Kind");

Console.ReadKey();