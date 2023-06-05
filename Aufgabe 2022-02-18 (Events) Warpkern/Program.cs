using Aufgabe_2022_02_18__Events__Warpkern;

Warpkern warpkern = new(250);
WarpkernKonsole warpkernKonsole = new(warpkern);

Random rtemp = new Random();

warpkern.warpkernTemperaturÄnderungsHandler += warpkernKonsole.GeänderteTemperatur;
warpkern.warpkernTemperaturÄnderungsHandler2 += warpkernKonsole.WarpkernWarnung;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine();
    Console.WriteLine("Temperaturintervall: {0, 3}", i + 1);
    int randomtemp = rtemp.Next(300, 600); ;
    warpkern.WarpkernTemperatur = randomtemp;
}

Console.ReadKey();